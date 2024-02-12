using System;
using System.Collections;
using UnityEngine.Events;

namespace Common.Coroutines.Segments
{
    [Serializable]
    [SegmentMenu("Event", SegmentPath.Utility, SegmentGroup.Utility)]
    public class EventSegment : Segment
    {
        public UnityEvent action;

        public override IEnumerator GetSequence()
            => UCoroutine.Yield(action);
    }
}