using Common.Coroutines.Segments;
using UnityEditor;
using UnityEngine;

namespace CommonEditor.Coroutines.Segments
{
    [CustomPropertyDrawer(typeof(SegmentsSegment), true)]
    public class SegmentsSegmentPropertyDrawer : PropertyDrawer
    {
        private SegmentsMenu _menu;

        private void EnsureMenu(SerializedProperty property)
        {
            if (_menu == null)
            {
                var segments = (SegmentsSegment)property.managedReferenceValue;
                _menu = new SegmentsMenu(segments);
            }
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EnsureMenu(property);

            EditorGUI.PropertyField(position, property, label, true);

            _menu.OnGUI();
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return EditorGUI.GetPropertyHeight(property, label);
        }
    }
}