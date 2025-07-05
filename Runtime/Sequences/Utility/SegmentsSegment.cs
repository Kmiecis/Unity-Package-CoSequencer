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

        public abstract override IEnumerator Build();

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

    [Serializable]
    [SegmentMenu("Sequence", SegmentPath.Utility, SegmentGroup.Utility)]
    public class SequenceSegment : SegmentsSegment
    {
        public override IEnumerator Build()
        {
            var prev = (ILink)_segments[0];
            for (int i = 1; i < _segments.Count; ++i)
            {
                var next = _segments[i];
                if (next is IDecorator decorator)
                {
                    prev = new DecoratorLink(prev, decorator);
                }
                else
                {
                    prev = new ThenLink(prev, next);
                }
            }
            return prev.Build();
        }
    }

    [Serializable]
    [SegmentMenu("Parallel", SegmentPath.Utility, SegmentGroup.Utility)]
    public class ParallelSegment : SegmentsSegment
    {
        public override IEnumerator Build()
        {
            var prev = (ILink)_segments[0];
            for (int i = 1; i < _segments.Count; ++i)
            {
                var next = _segments[i];
                if (next is IDecorator decorator)
                {
                    prev = new DecoratorLink(prev, decorator);
                }
                else
                {
                    prev = new WithLink(prev, next);
                }
            }
            return prev.Build();
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