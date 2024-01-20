using Common.Coroutines;
using System.Collections.Generic;
using System.Reflection;
using System;
using UnityEditor;
using UnityEngine;
using System.Linq;

namespace CommonEditor.Coroutines
{
    public class SegmentsMenu
    {
        private class SegmentData
        {
            public string menuPath;
            public string fileName;
            public Type type;
        }

        private readonly Type SubclassType = typeof(Segment);

        private readonly ISegments _target;
        private int _count;

        public SegmentsMenu(ISegments target)
        {
            _target = target;
            _count = target.SegmentCount;
        }

        public void OnGUI()
        {
            var current = _target.SegmentCount;
            if (current > _count)
            {
                var last = _target.GetLastSegment();

                if (last == null)
                {
                    _target.RemoveLastSegment();

                    ShowAddMenu();
                }
                else
                {
                    var added = FindDuplicateSegment();

                    if (added != null)
                    {
                        ReplaceSegment(added);
                    }
                }
            }
            else
            {
                _count = current;
            }
        }

        private bool IsValidSegmentType(Type type)
        {
            return (
                type.IsSubclassOf(SubclassType) &&
                !type.IsAbstract
            );
        }

        private void ShowAddMenu()
        {
            var menu = new GenericMenu();

            var map = new Dictionary<int, List<SegmentData>>();

            var types = AppDomain.CurrentDomain.FindTypes(IsValidSegmentType);
            foreach (var type in types)
            {
                var attribute = type.GetCustomAttribute<SegmentMenuAttribute>();

                var menuPath = attribute.GetMenuPathOrDefault(SegmentPath.Custom);
                var fileName = attribute.GetFileNameOrDefault(type.Name);
                var group = attribute.GetGroupOrDefault(SegmentGroup.Custom);

                var data = new SegmentData
                {
                    menuPath = menuPath,
                    fileName = fileName,
                    type = type
                };

                if (!map.TryGetValue(group, out var target))
                {
                    map[group] = target = new List<SegmentData>();
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
            var instance = CreateSegmentOfType((Type)type);

            _target.AddSegment(instance);
            _count = _target.SegmentCount;
        }

        private void ReplaceSegment(ISegment segment)
        {
            var index = _target.IndexOf(segment);
            _target.RemoveSegmentAt(index);

            var replace = CreateSegmentOfType(segment.GetType());
            _target.AddSegmentAt(index, replace);
            _count = _target.SegmentCount;

            EditorUtility.CopySerializedManagedFieldsOnly(segment, replace);
        }

        private ISegment CreateSegmentOfType(Type type)
        {
            return (ISegment)Activator.CreateInstance(type);
        }

        private ISegment FindDuplicateSegment()
        {
            var previous = (ISegment)null;
            foreach (var segment in _target.GetSegments())
            {
                if (previous == segment)
                {
                    return segment;
                }
                previous = segment;
            }
            return null;
        }
    }
}