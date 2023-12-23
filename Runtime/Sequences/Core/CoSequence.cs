using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Common.Coroutines
{
    [AddComponentMenu(nameof(Common) + "/" + nameof(Coroutines) + "/" + nameof(CoSequence))]
    public class CoSequence : MonoBehaviour
    {
        [SerializeReference]
        private List<Segment> _segments;

        public CoSequence()
        {
            _segments = new List<Segment>();
        }

        public int SegmentCount
            => _segments.Count;

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

        public void Execute()
        {
            Execute(this);
        }

        public IEnumerator CoExecute()
        {
            var providers = new Func<IEnumerator>[_segments.Count];
            for (int i = 0; i < _segments.Count; ++i)
            {
                providers[i] = _segments[i].CoExecute;
            }
            return UCoroutine.YieldSequentially(providers);
        }

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
    }
}