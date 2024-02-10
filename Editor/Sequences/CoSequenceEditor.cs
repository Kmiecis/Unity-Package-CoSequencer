using Common.Coroutines;
using System.Collections;
using UnityEditor;

namespace CommonEditor.Coroutines
{
    [CanEditMultipleObjects]
    [CustomEditor(typeof(CoSequence))]
    public class CoSequenceEditor : Editor
    {
        private SegmentsMenu _menu;

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            _menu.OnGUI();
        }

        private void OnEnable()
        {
            var segmentsProperty = serializedObject.FindProperty("_segments");
            var list = (IList)segmentsProperty.GetValue();

            _menu = new SegmentsMenu(list);
        }
    }
}