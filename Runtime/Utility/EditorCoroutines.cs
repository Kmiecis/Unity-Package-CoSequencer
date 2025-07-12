using System.Collections;
using System.Collections.Generic;

namespace Common.Coroutines
{
    public static class EditorCoroutines
    {
        private static List<EditorCoroutine> _coroutines;

        static EditorCoroutines()
        {
            _coroutines = new List<EditorCoroutine>();
        }

        public static void StartCoroutine(IEnumerator coroutine)
        {
            var ecoroutine = new EditorCoroutine(coroutine);

            _coroutines.Add(ecoroutine);

            if (_coroutines.Count == 1)
            {
                EditorAppendUpdate();

                EditorQueueUpdate();
            }
        }

#if UNITY_EDITOR
        [UnityEditor.MenuItem("Window/Coroutines/Stop Editor Coroutines", false)]
#endif
        public static void StopAllCoroutines()
        {
            _coroutines.Clear();

            EditorRemoveUpdate();
        }

        private static void Update()
        {
            for (int i = _coroutines.Count - 1; i > -1; --i)
            {
                var coroutine = _coroutines[i];
                if (!coroutine.MoveNext())
                {
                    _coroutines.RemoveAt(i);
                }
            }

            if (_coroutines.Count > 0)
            {
                EditorQueueUpdate();
            }
            else
            {
                EditorRemoveUpdate();
            }
        }

        private static void EditorAppendUpdate()
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.update += Update;
#endif
        }

        private static void EditorRemoveUpdate()
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.update -= Update;
#endif
        }

        private static void EditorQueueUpdate()
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.QueuePlayerLoopUpdate();
#endif
        }
    }
}
