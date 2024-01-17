using Common.Coroutines;
using Common.Coroutines.Segments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace CommonEditor.Coroutines.Segments
{
    [CustomPropertyDrawer(typeof(SegmentsSegment), true)]
    public class SegmentsSegmentPropertyDrawer : PropertyDrawer
    {
        private class SegmentData
        {
            public string menuPath;
            public string fileName;
            public Type type;
        }

        private readonly Type SubclassType = typeof(Segment);

        private SegmentsSegment _target;
        private int _count;

        private void ShowAddMenu()
        {
            var menu = new GenericMenu();

            var added = 0;

            var map = new Dictionary<int, List<SegmentData>>();

            var types = AppDomain.CurrentDomain.FindTypes(t => t.IsSubclassOf(SubclassType) && !t.IsAbstract);
            foreach (var type in types)
            {
                var attribute = type.GetCustomAttribute<SegmentMenuAttribute>();

                var group = attribute.group;
                var menuPath = attribute.GetMenuPathOrDefault(SegmentPath.Custom);
                var fileName = attribute.GetFileNameOrDefault(type.Name);

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

        private void ReplaceSegment(Segment segment)
        {
            var index = _target.IndexOf(segment);
            _target.RemoveSegmentAt(index);

            var replace = CreateSegmentOfType(segment.GetType());
            _target.AddSegmentAt(index, replace);
            _count = _target.SegmentCount;

            EditorUtility.CopySerializedManagedFieldsOnly(segment, replace);
        }

        private Segment CreateSegmentOfType(Type type)
        {
            return (Segment)Activator.CreateInstance(type);
        }

        private Segment FindDuplicate()
        {
            var previous = (Segment)null;
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

        private void CheckSequenceChange()
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
                    var added = FindDuplicate();

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

        private void CheckInitialValues(SerializedProperty property)
        {
            if (_target == null)
            {
                _target = (SegmentsSegment)property.managedReferenceValue;
                _count = _target.SegmentCount;
            }
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            CheckInitialValues(property);

            EditorGUI.PropertyField(position, property, label, true);

            CheckSequenceChange();
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return EditorGUI.GetPropertyHeight(property, label);
        }
    }
}