using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines
{
    [Serializable]
    [SegmentMenu("Utility", "Behaviour")]
    public class BehaviourSegment : Segment
    {
        [SerializeField] private SegmentBehaviour _behaviour;

        public override IEnumerator CoExecute()
            => _behaviour.CoExecute();
    }
}