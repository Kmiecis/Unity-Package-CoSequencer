using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Common.Coroutines
{
    [AddComponentMenu(nameof(Common) + "/" + nameof(Coroutines) + "/" + nameof(CoSequence))]
    public class CoSequence : SegmentBehaviour
    {
        [SerializeReference]
        protected List<ISegment> _segments;

        public CoSequence()
        {
            _segments = new List<ISegment>();
        }

        public IEnumerable<ISegment> GetSegments()
        {
            return _segments;
        }

        public Coroutine Execute()
        {
            return Execute(this);
        }

        public Coroutine Execute(MonoBehaviour target)
        {
            return CoExecute().Start(target);
        }

        public override IEnumerator CoExecute()
        {
            var coroutines = new IEnumerator[_segments.Count];
            for (int i = 0; i < _segments.Count; ++i)
            {
                coroutines[i] = _segments[i].CoExecute();
            }
            return UCoroutine.YieldInSequence(coroutines);
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
        public static IEnumerable<T> GetSegments<T>(this CoSequence self)
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