using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Common.Coroutines
{
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
            foreach (var segment in GetSegments())
            {
                var coroutine = segment.CoExecute();
                while (coroutine.MoveNext())
                {
                    yield return coroutine.Current;
                }
            }
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