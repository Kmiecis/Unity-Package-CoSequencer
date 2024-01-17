using Common.Coroutines;
using UnityEditor;

namespace CommonEditor.Coroutines
{
    [CanEditMultipleObjects]
    [CustomEditor(typeof(CoSequence))]
    public class CoSequenceEditor : Editor
    {
        private SegmentsMenu _menu;
        
        private void OnEnable()
        {
            var sequence = (CoSequence)target;
            _menu = new SegmentsMenu(sequence);
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            _menu.OnGUI();
        }
    }
}