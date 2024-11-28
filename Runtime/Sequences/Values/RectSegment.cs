using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines.Segments
{
    [Serializable]
    [SegmentMenu("Rect", SegmentPath.Value, SegmentGroup.Value)]
    public class RectSegment : ConsumerSegment<Rect>
    {
        public override IEnumerator Build()
            => Yield.Value(start, target, Yield.Time(duration, easer.Evaluate)).Into(consumer);
    }
}