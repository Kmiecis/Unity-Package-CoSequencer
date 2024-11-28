using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines.Segments
{
    [Serializable]
    [SegmentMenu("Vector3", SegmentPath.Value, SegmentGroup.Value)]
    public class Vector3Segment : ConsumerSegment<Vector3>
    {
        public override IEnumerator Build()
            => Yield.Value(start, target, Yield.Time(duration, easer.Evaluate)).Into(consumer);
    }
}