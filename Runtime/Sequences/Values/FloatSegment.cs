using System;
using System.Collections;

namespace Common.Coroutines.Segments
{
    [Serializable]
    [SegmentMenu("Float", SegmentPath.Value, SegmentGroup.Value)]
    public class FloatSegment : ConsumerSegment<float>
    {
        public override IEnumerator Build()
            => Yield.Value(start, target, Yield.Time(duration, easer.Evaluate)).Into(consumer);
    }
}