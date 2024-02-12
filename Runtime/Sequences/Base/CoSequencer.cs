using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Common.Coroutines
{
    [AddComponentMenu(nameof(Common) + "/" + nameof(Coroutines) + "/" + nameof(CoSequencer))]
    public class CoSequencer : SegmentBehaviour
    {
        [SerializeField]
        private bool _playOnStart;
        [SerializeReference]
        protected List<ISegment> _segments;

        private Coroutine _coroutine;

        public CoSequencer()
        {
            _segments = new List<ISegment>();
        }

        public IEnumerable<ISegment> GetSegments()
        {
            return _segments;
        }

        public override IEnumerator GetSequence()
        {
            var coroutines = new IEnumerator[_segments.Count];
            for (int i = 0; i < _segments.Count; ++i)
            {
                coroutines[i] = _segments[i].GetSequence();
            }
            return UCoroutine.YieldInSequence(coroutines);
        }

        public Coroutine Play(MonoBehaviour target)
        {
            return GetSequence().Start(target);
        }

        public void Play()
        {
            _coroutine = Play(this);
        }

        public void Stop()
        {
            UCoroutine.SafeStop(ref _coroutine, this);
        }

        private void Start()
        {
            if (_playOnStart)
            {
                Play();
            }
        }

        public override void OnValidate()
        {
            foreach (var segment in GetSegments())
            {
                if (segment != null)
                {
                    segment.OnValidate();
                }
            }
        }
    }

    public static class CoSequenceExtensions
    {
        public static IEnumerable<T> GetSegments<T>(this CoSequencer self)
            where T : ISegment
        {
            foreach (var segment in self.GetSegments())
            {
                if (segment is T item)
                {
                    yield return item;
                }
            }
        }
    }
}