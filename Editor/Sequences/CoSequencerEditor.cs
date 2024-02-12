using Common.Coroutines;
using System.Collections;
using UnityEditor;

namespace CommonEditor.Coroutines
{
    [CanEditMultipleObjects]
    [CustomEditor(typeof(CoSequencer))]
    public class CoSequencerEditor : Editor
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
}