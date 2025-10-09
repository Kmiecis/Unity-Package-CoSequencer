using Common.Coroutines;
using UnityEditor;
using UnityEngine;

namespace CommonEditor.Coroutines
{
    [CanEditMultipleObjects]
    [CustomEditor(typeof(SegmentBehaviour))]
    public class SegmentBehaviourEditor : Editor
    {
        private SegmentBehaviour Script
            => (SegmentBehaviour)target;

        private bool _updating;

        public override void OnInspectorGUI()
        {
            TriggerEditorUpdate();

            if (GUILayout.Button("Play"))
            {
                if (Application.isPlaying)
                {
                    Script.StartCoroutine(Script.Build());
                }
                else
                {
                    EditorCoroutines.StartCoroutine(Script.Build());
                }
            }

            base.OnInspectorGUI();
        }

        private void TriggerEditorUpdate()
        {
            if (!_updating)
            {
                EditorApplication.update += EditorApplication.QueuePlayerLoopUpdate;

                EditorApplication.QueuePlayerLoopUpdate();

                _updating = true;
            }
        }

        private void ClearEditorUpdate()
        {
            EditorApplication.update -= EditorApplication.QueuePlayerLoopUpdate;

            _updating = false;
        }

        private void OnDisable()
        {
            ClearEditorUpdate();
        }
    }
}