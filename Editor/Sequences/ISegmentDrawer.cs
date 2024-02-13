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
            UEditorGUI.UnfoldedLabelField(ref position, label, EditorStyles.boldLabel);
            UEditorGUI.UnfoldedPropertyField(ref position, property);
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return (
                UEditorGUI.GetUnfoldedLabelHeight(label) +
                UEditorGUI.GetUnfoldedPropertyHeight(property)
            );
        }
    }
}