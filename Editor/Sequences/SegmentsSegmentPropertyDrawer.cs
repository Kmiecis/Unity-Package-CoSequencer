using Common.Coroutines;
using System.Linq;
using System.Reflection;
using System;
using UnityEditor;
using UnityEngine;

namespace CommonEditor.Coroutines
{
    [CustomPropertyDrawer(typeof(SegmentsSegment), true)]
    public class SegmentsSegmentPropertyDrawer : PropertyDrawer
    {
        private readonly Type SubclassType = typeof(Segment);

        private SegmentsSegment _target;
        private int _count;

        private void ShowAddMenu()
        {
            var menu = new GenericMenu();

            var added = 0;

            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            for (int i = 0; i < assemblies.Length; ++i)
            {
                var assembly = assemblies[i];

                var types = assembly.FindTypes(t => t.IsSubclassOf(SubclassType) && !t.IsAbstract);

                if (types.Any())
                {
                    if (added > 0)
                    {
                        menu.AddSeparator(string.Empty);
                    }
                    added += 1;
                }

                foreach (var type in types)
                {
                    var attribute = type.GetCustomAttribute<SegmentMenuAttribute>();
                    var menuPath = attribute.GetMenuPathOrDefault("Custom");
                    var fileName = attribute.GetFileNameOrDefault(type.Name);

                    var path = $"{menuPath}/{fileName}";

                    menu.AddItem(new GUIContent(path), false, OnMenuAdd, type);
                }
            }

            menu.ShowAsContext();
        }

        private void OnMenuAdd(object type)
        {
            var instance = (Segment)Activator.CreateInstance((Type)type);

            _target.AddSegment(instance);

            _count = _target.SegmentCount;
        }

        private void CheckSequenceChange()
        {
            var current = _target.SegmentCount;
            if (current > _count)
            {
                _target.RemoveLastSegment();

                ShowAddMenu();
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