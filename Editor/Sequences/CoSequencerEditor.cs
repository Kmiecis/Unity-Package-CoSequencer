using Common.Coroutines;
using System.Collections;
using UnityEditor;
using UnityEngine;

namespace CommonEditor.Coroutines
{
    [CanEditMultipleObjects]
    [CustomEditor(typeof(CoSequencer))]
    public class CoSequencerEditor : SegmentBehaviourEditor
    {
        private SegmentsMenu _menu;

        private IList GetList()
        {
            var property = serializedObject.FindProperty("_segments");
            return (IList)property.GetValue();
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            _menu.OnGUI();
        }

        private void OnEnable()
        {
            var list = GetList();
            _menu = new SegmentsMenu(list);
        }
    }

    [CustomPropertyDrawer(typeof(CoSequencer))]
    public class CoSequencerDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.PropertyField(position, property, label, false);
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return EditorGUI.GetPropertyHeight(property, false);
        }
    }
}