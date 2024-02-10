using Common.Coroutines;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace CommonEditor.Coroutines
{
    public class SegmentsMenu
    {
        private class EntryData
        {
            public string menuPath;
            public string fileName;
            public Type type;
        }

        private readonly IList _list;
        private readonly Type _type;

        private int _count;

        public SegmentsMenu(IList list)
        {
            _list = list;
            _type = list.GetType().GetGenericArguments()[0];

            _count = list.Count;
        }

        public void OnGUI()
        {
            var current = _list.Count;
            if (current > _count)
            {
                var last = _list[_list.Count - 1];

                if (last == null)
                {
                    _list.RemoveAt(_list.Count - 1);

                    ShowAddMenu();
                }
                else
                {
                    var added = FindDuplicate();

                    if (added != null)
                    {
                        Replace(added);
                    }
                }
            }
            else
            {
                _count = current;
            }
        }

        private bool IsValidType(Type type)
        {
            return (
                type.HasInterface(_type) &&
                !type.IsInterface &&
                !type.IsAbstract &&
                !type.IsSubclassOf(typeof(MonoBehaviour))
            );
        }

        private void ShowAddMenu()
        {
            var menu = new GenericMenu();

            var map = new Dictionary<int, List<EntryData>>();

            var types = AppDomain.CurrentDomain.FindTypes(IsValidType);
            foreach (var type in types)
            {
                var attribute = type.GetCustomAttribute<SegmentMenuAttribute>();

                var menuPath = attribute.GetMenuPathOrDefault();
                var fileName = attribute.GetFileNameOrDefault(type.Name);
                var group = attribute.GetGroupOrDefault();

                var data = new EntryData
                {
                    menuPath = menuPath,
                    fileName = fileName,
                    type = type
                };

                if (!map.TryGetValue(group, out var target))
                {
                    map[group] = target = new List<EntryData>();
                }
                target.Add(data);
            }

            var added = 0;

            var mapped = map.OrderBy(kv => kv.Key);
            foreach (var kv in mapped)
            {
                if (added > 0)
                {
                    menu.AddSeparator(string.Empty);
                }
                added += 1;

                foreach (var data in kv.Value)
                {
                    var path = $"{data.menuPath}/{data.fileName}";

                    menu.AddItem(new GUIContent(path), false, OnMenuAdd, data.type);
                }
            }

            menu.ShowAsContext();
        }

        private void OnMenuAdd(object type)
        {
            var instance = CreateObjectOfType((Type)type);

            _list.Add(instance);

            _count = _list.Count;
        }

        private void Replace(object item)
        {
            var index = _list.IndexOf(item);
            _list.RemoveAt(index);

            var replace = CreateObjectOfType(item.GetType());
            _list.Insert(index, replace);
            _count = _list.Count;

            EditorUtility.CopySerializedManagedFieldsOnly(item, replace);
        }

        private object CreateObjectOfType(Type type)
        {
            return Activator.CreateInstance(type);
        }

        private object FindDuplicate()
        {
            var previous = (object)null;
            foreach (var child in _list)
            {
                if (Equals(previous, child))
                {
                    return child;
                }
                previous = child;
            }
            return previous;
        }
    }
}