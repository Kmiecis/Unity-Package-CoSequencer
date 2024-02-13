using UnityEditor;
using UnityEngine;

namespace CommonEditor.Coroutines
{
    internal static class UEditorGUI
    {
        public const float SpaceHeight = 2.0f;
        public const float IndentWidth = 10.0f;

        public static void UnfoldedLabelField(ref Rect position, GUIContent label, GUIStyle style)
        {
            position.x -= IndentWidth;
            position.width += IndentWidth;
            position.height = EditorGUIUtility.singleLineHeight;

            EditorGUI.LabelField(position, label, style);

            position.y += position.height + SpaceHeight;
        }

        public static void UnfoldedPropertyField(ref Rect position, SerializedProperty property)
        {
            foreach (var child in property.GetChildren())
            {
                position.height = EditorGUI.GetPropertyHeight(child, true);

                EditorGUI.PropertyField(position, child, true);

                position.y += position.height + SpaceHeight;
            }
        }

        public static float GetUnfoldedLabelHeight(GUIContent label)
        {
            return EditorGUIUtility.singleLineHeight + SpaceHeight;
        }

        public static float GetUnfoldedPropertyHeight(SerializedProperty property)
        {
            var result = 0.0f;
            foreach (var child in property.GetChildren())
            {
                result += EditorGUI.GetPropertyHeight(child, true) + SpaceHeight;
            }
            return result;
        }
    }
}