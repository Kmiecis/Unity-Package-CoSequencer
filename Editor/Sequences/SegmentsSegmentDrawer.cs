using Common.Coroutines.Segments;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace CommonEditor.Coroutines.Segments
{
    [CanEditMultipleObjects]
    [CustomPropertyDrawer(typeof(SegmentsSegment), true)]
    public class SegmentsSegmentDrawer : PropertyDrawer
    {
        private readonly Dictionary<object, SegmentsMenu> _menus;

        public SegmentsSegmentDrawer()
        {
            _menus = new Dictionary<object, SegmentsMenu>();
        }

        private IList GetList(SerializedProperty property)
        {
            var subproperty = property.FindPropertyRelative("_segments");
            return (IList)subproperty.GetValue();
        }

        private SegmentsMenu GetMenu(SerializedProperty property)
        {
            if (!_menus.TryGetValue(property.propertyPath, out var menu))
            {
                var list = GetList(property);
                _menus[property.propertyPath] = menu = new SegmentsMenu(list);
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