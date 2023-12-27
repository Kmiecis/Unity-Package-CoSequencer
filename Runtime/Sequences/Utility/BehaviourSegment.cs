using System;
using System.Collections;

namespace Common.Coroutines.Segments
{
    [Serializable]
    [SegmentMenu("Utility", "Behaviour")]
    public class BehaviourSegment : Segment
    {
        public SegmentBehaviour behaviour;

        public override IEnumerator CoExecute()
            => behaviour.CoExecute();
    }
}