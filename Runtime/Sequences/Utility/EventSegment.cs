using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Common.Coroutines
{
    [Serializable]
    [SegmentMenu("Utility", "Event")]
    public class EventSegment : Segment
    {
        [SerializeField] private UnityEvent _action;

        public override IEnumerator CoExecute()
            => UCoroutine.Yield(_action);
    }
}