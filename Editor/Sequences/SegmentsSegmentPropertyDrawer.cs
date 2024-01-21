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
        private Dictionary<long, SegmentsMenu> _menus;

        public SegmentsSegmentPropertyDrawer()
        {
            _menus = new Dictionary<long, SegmentsMenu>();
        }

        private void EnsureMenu(SerializedProperty property)
        {
            var key = property.managedReferenceId;
            if (!_menus.ContainsKey(key))
            {
                var value = property.managedReferenceValue;
                _menus[key] = new SegmentsMenu((SegmentsSegment)value);
            }
        }

        private SegmentsMenu GetMenu(SerializedProperty property)
        {
            var key = property.managedReferenceId;
            return _menus[key];
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