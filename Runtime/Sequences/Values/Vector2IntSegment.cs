using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines.Segments
{
    [Serializable]
    [SegmentMenu("Vector2Int", SegmentPath.Value, SegmentGroup.Value)]
    public class Vector2IntSegment : ConsumerSegment<Vector2Int>
    {
        public override IEnumerator Build()
            => Yield.Value(start, target, Yield.Time(duration, easer.Evaluate)).Into(consumer);
    }
}