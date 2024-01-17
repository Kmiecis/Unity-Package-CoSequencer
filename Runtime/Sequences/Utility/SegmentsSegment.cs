using System.Collections.Generic;
using System;
using UnityEngine;
using System.Collections;

namespace Common.Coroutines.Segments
{
    [Serializable]
    public abstract class SegmentsSegment : Segment, ISegments
    {
        [SerializeReference]
        protected List<Segment> _segments;

        public int SegmentCount
            => _segments.Count;

        public SegmentsSegment()
        {
            _segments = new List<Segment>();
        }

        public void AddSegment(Segment item)
        {
            _segments.Add(item);

            item.OnAdded();
        }

        public void AddSegmentAt(int index, Segment item)
        {
            _segments.Insert(index, item);

            item.OnAdded();
        }

        public void RemoveSegmentAt(int index)
        {
            _segments.RemoveAt(index);
        }

        public void RemoveLastSegment()
        {
            RemoveSegmentAt(_segments.Count - 1);
        }

        public Segment GetSegmentAt(int index)
        {
            return _segments[index];
        }

        public Segment GetLastSegment()
        {
            return GetSegmentAt(SegmentCount - 1);
        }

        public int IndexOf(Segment item)
        {
            return _segments.IndexOf(item);
        }

        public IEnumerable<Segment> GetSegments()
        {
            return _segments;
        }

        public IEnumerable<T> GetSegments<T>()
            where T : Segment
        {
            foreach (var segment in GetSegments())
            {
                if (segment is T item)
                {
                    yield return item;
                }
            }
        }

        public abstract override IEnumerator CoExecute();

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
        public override IEnumerator CoExecute()
        {
            var providers = new IEnumerator[_segments.Count];
            for (int i = 0; i < _segments.Count; ++i)
            {
                providers[i] = _segments[i].CoExecute();
            }
            return UCoroutine.YieldInSequence(providers);
        }
    }

    [SegmentMenu("Parallel", SegmentPath.Utility, SegmentGroup.Utility)]
    public class ParallelSegment : SegmentsSegment
    {
        public override IEnumerator CoExecute()
        {
            var providers = new IEnumerator[_segments.Count];
            for (int i = 0; i < _segments.Count; ++i)
            {
                providers[i] = _segments[i].CoExecute();
            }
            return UCoroutine.YieldInParallel(providers);
        }
    }
}