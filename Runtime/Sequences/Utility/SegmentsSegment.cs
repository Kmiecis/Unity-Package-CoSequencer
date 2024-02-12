using System.Collections.Generic;
using System;
using UnityEngine;
using System.Collections;

namespace Common.Coroutines.Segments
{
    [Serializable]
    public abstract class SegmentsSegment : Segment
    {
        [SerializeReference]
        protected List<ISegment> _segments;

        public SegmentsSegment()
        {
            _segments = new List<ISegment>();
        }

        public IEnumerable<ISegment> GetSegments()
        {
            return _segments;
        }

        public abstract override IEnumerator GetSequence();

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

    [SegmentMenu("Sequence", SegmentPath.Utility, SegmentGroup.Utility)]
    public class SequenceSegment : SegmentsSegment
    {
        public override IEnumerator GetSequence()
        {
            var providers = new IEnumerator[_segments.Count];
            for (int i = 0; i < _segments.Count; ++i)
            {
                providers[i] = _segments[i].GetSequence();
            }
            return UCoroutine.YieldInSequence(providers);
        }
    }

    [SegmentMenu("Parallel", SegmentPath.Utility, SegmentGroup.Utility)]
    public class ParallelSegment : SegmentsSegment
    {
        public override IEnumerator GetSequence()
        {
            var providers = new IEnumerator[_segments.Count];
            for (int i = 0; i < _segments.Count; ++i)
            {
                providers[i] = _segments[i].GetSequence();
            }
            return UCoroutine.YieldInParallel(providers);
        }
    }

    public static class SegmentsSegmentExtensions
    {
        public static IEnumerable<T> GetSegments<T>(this SegmentsSegment self)
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