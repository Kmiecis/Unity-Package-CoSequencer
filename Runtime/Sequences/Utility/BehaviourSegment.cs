using System;
using System.Collections;

namespace Common.Coroutines.Segments
{
    [Serializable]
    [SegmentMenu("Behaviour", SegmentPath.Utility, SegmentGroup.Utility)]
    public class BehaviourSegment : Segment
    {
        public SegmentBehaviour behaviour;

        public override IEnumerator GetSequence()
            => behaviour.GetSequence();
    }
}