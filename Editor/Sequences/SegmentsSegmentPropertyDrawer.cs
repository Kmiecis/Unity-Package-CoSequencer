using Common.Coroutines.Segments;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace CommonEditor.Coroutines.Segments
{
    [CanEditMultipleObjects]
    [CustomPropertyDrawer(typeof(SegmentsSegment), true)]
    public class SegmentsSegmentPropertyDrawer : PropertyDrawer
    {
        private readonly Dictionary<object, SegmentsMenu> _menus;

        public SegmentsSegmentPropertyDrawer()
        {
            _menus = new Dictionary<object, SegmentsMenu>();
        }

        private SegmentsSegment GetValue(SerializedProperty property)
        {
            return (SegmentsSegment)property.GetValue();
        }

        private void EnsureMenu(SerializedProperty property)
        {
            var value = GetValue(property);
            if (!_menus.ContainsKey(value))
            {
                _menus[value] = new SegmentsMenu(value);
            }
        }

        private SegmentsMenu GetMenu(SerializedProperty property)
        {
            var value = GetValue(property);
            return _menus[value];
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EnsureMenu(property);

            EditorGUI.PropertyField(position, property, label, true);

            GetMenu(property).OnGUI();
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return EditorGUI.GetPropertyHeight(property, label, true);
        }
    }
}