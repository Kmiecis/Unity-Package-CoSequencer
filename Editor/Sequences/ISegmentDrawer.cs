using Common.Coroutines;
using UnityEditor;
using UnityEngine;

namespace CommonEditor.Coroutines
{
    [CustomPropertyDrawer(typeof(ISegment), true)]
    public class ISegmentDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            if (property.IsInArray())
            {
                UEditorGUI.UnfoldedLabelField(ref position, label, EditorStyles.boldLabel);
                UEditorGUI.UnfoldedPropertyField(ref position, property);
            }
            else
            {
                EditorGUI.PropertyField(position, property, label, true);
            }
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            if (property.IsInArray())
            {
                return (
                    UEditorGUI.GetUnfoldedLabelHeight(label) +
                    UEditorGUI.GetUnfoldedPropertyHeight(property)
                );
            }
            else
            {
                return EditorGUI.GetPropertyHeight(property, true);
            }
        }
    }
}