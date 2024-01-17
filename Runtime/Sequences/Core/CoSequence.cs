using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Common.Coroutines
{
    [AddComponentMenu(nameof(Common) + "/" + nameof(Coroutines) + "/" + nameof(CoSequence))]
    public class CoSequence : SegmentBehaviour, ISegments
    {
        [SerializeReference]
        protected List<Segment> _segments;

        public int SegmentCount
            => _segments.Count;

        public CoSequence()
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

        public bool RemoveSegment(Segment item)
        {
            return _segments.Remove(item);
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

        public void Execute()
        {
            Execute(this);
        }

        public void Execute(MonoBehaviour target)
        {
            CoExecute().Start(target);
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

#if UNITY_EDITOR
        private void OnValidate()
        {
            foreach (var segment in GetSegments())
            {
                if (segment != null)
                {
                    segment.OnValidate();
                }
            }
        }
#endif
    }
}