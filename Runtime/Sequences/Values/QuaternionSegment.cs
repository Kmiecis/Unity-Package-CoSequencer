using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines.Segments
{
    [Serializable]
    [SegmentMenu("Quaternion", SegmentPath.Value, SegmentGroup.Value)]
    public class QuaternionSegment : ConsumerSegment<Quaternion>
    {
        public override IEnumerator Build()
            => Yield.Value(start, target, Yield.Time(duration, easer.Evaluate)).Into(consumer);
    }
}