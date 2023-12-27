using System;
using System.Collections;
using UnityEngine.Events;

namespace Common.Coroutines.Segments
{
    [Serializable]
    [SegmentMenu("Utility", "Event")]
    public class EventSegment : Segment
    {
        public UnityEvent action;

        public override IEnumerator CoExecute()
            => UCoroutine.Yield(action);
    }
}