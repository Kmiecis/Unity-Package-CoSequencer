using Common.Coroutines.Segments;
using System.Collections;
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

        private IList GetList(SerializedProperty property)
        {
            return (IList)property.GetValue();
        }

        private SegmentsMenu GetMenu(SerializedProperty property)
        {
            var list = GetList(property);
            if (!_menus.TryGetValue(list, out var menu))
            {
                _menus[list] = menu = new SegmentsMenu(list);
            }
            return menu;
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.PropertyField(position, property, label, true);

            GetMenu(property).OnGUI();
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return EditorGUI.GetPropertyHeight(property, label, true);
        }
    }
}