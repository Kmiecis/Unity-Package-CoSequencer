using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines.Segments
{
    [Serializable]
    [SegmentMenu("Vector3Int", SegmentPath.Value, SegmentGroup.Value)]
    public class Vector3IntSegment : ConsumerSegment<Vector3Int>
    {
        public override IEnumerator Build()
            => Yield.Value(start, target, Yield.Time(duration, easer.Evaluate)).Into(consumer);
    }
}