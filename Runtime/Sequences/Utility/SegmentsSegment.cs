using System.Collections.Generic;
using System;
using UnityEngine;
using System.Collections;

namespace Common.Coroutines
{
    [Serializable]
    public abstract class SegmentsSegment : Segment
    {
        [SerializeReference]
        protected List<Segment> _segments;

        public abstract override IEnumerator CoExecute();

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

        public void RemoveSegmentAt(int index)
        {
            _segments.RemoveAt(index);
        }

        public void RemoveLastSegment()
        {
            RemoveSegmentAt(_segments.Count - 1);
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

        public void Execute(MonoBehaviour target)
        {
            CoExecute().Start(target);
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

    [SegmentMenu("Utility", "Sequence")]
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

    [SegmentMenu("Utility", "Parallel")]
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