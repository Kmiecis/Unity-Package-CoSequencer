using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Common.Coroutines
{
    [AddComponentMenu(nameof(Common) + "/" + nameof(Coroutines) + "/" + nameof(CoSequence))]
    public class CoSequence : SegmentBehaviour, ISegments
    {
        [SerializeReference]
        protected List<ISegment> _segments;

        public int SegmentCount
            => _segments.Count;

        public CoSequence()
        {
            _segments = new List<ISegment>();
        }

        public void AddSegment(ISegment item)
        {
            _segments.Add(item);

            item.OnAdded();
        }

        public void AddSegmentAt(int index, ISegment item)
        {
            _segments.Insert(index, item);

            item.OnAdded();
        }

        public bool RemoveSegment(ISegment item)
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

        public ISegment GetSegmentAt(int index)
        {
            return _segments[index];
        }

        public ISegment GetLastSegment()
        {
            return GetSegmentAt(SegmentCount - 1);
        }

        public int IndexOf(ISegment item)
        {
            return _segments.IndexOf(item);
        }

        public IEnumerable<ISegment> GetSegments()
        {
            return _segments;
        }

        public IEnumerable<T> GetSegments<T>()
            where T : ISegment
        {
            foreach (var segment in GetSegments())
            {
                if (segment is T item)
                {
                    yield return item;
                }
            }
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
}