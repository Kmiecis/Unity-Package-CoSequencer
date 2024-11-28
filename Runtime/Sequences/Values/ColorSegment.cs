using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines.Segments
{
    [Serializable]
    [SegmentMenu("Color", SegmentPath.Value, SegmentGroup.Value)]
    public class ColorSegment : ConsumerSegment<Color>
    {
        public override IEnumerator Build()
            => Yield.Value(start, target, Yield.Time(duration, easer.Evaluate)).Into(consumer);
    }
}