using System.Collections;
using UnityEngine;

namespace Common.Coroutines
{
    public abstract class SegmentBehaviour : MonoBehaviour, ISegment
    {
        private Coroutine _coroutine;

        public abstract IEnumerator Build();

        public Coroutine Play(MonoBehaviour target)
        {
            return Build().Start(target);
        }

        public void Play()
        {
            _coroutine = Play(this);
        }

        public void Stop()
        {
            UCoroutine.SafeStop(ref _coroutine, this);
        }

        public virtual void OnValidate()
        {
        }

        private void OnEnable()
        {
            Play();
        }

        private void OnDisable()
        {
            Stop();
        }

#if UNITY_EDITOR
        private void Reset()
        {
            enabled = false;
        }
#endif

        [ContextMenu("Play")]
        private void PlayFromContext()
        {
            if (Application.isPlaying)
            {
                StartCoroutine(Build());
            }
#if UNITY_EDITOR
            else
            {
                EditorCoroutines.StartCoroutine(Build());
            }
#endif
        }
    }
}