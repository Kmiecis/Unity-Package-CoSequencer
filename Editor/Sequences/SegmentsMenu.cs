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
    internal class SegmentsMenu
    {
        private class EntryData : IComparable<EntryData>
        {
            public string path;
            public int group;
            public Type type;

            public int CompareTo(EntryData other)
                => this.group - other.group;
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
                var obsolete = type.GetCustomAttribute<ObsoleteAttribute>();
                if (obsolete != null)
                    continue;

                var attribute = type.GetCustomAttribute<SegmentMenuAttribute>();

                var menuPath = attribute.GetMenuPathOrDefault();
                var fileName = attribute.GetFileNameOrDefault(type.Name);
                var group = attribute.GetGroupOrDefault();
                
                var data = new EntryData
                {
                    path = $"{menuPath}/{fileName}",
                    group = group,
                    type = type
                };

                var order = group / 1000;
                if (!map.TryGetValue(order, out var target))
                {
                    map[order] = target = new List<EntryData>();
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

                var entries = kv.Value;
                entries.StableSort();

                foreach (var entry in entries)
                {
                    menu.AddItem(new GUIContent(entry.path), false, OnMenuAdd, entry.type);
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