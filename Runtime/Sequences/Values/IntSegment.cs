using System;
using System.Collections;

namespace Common.Coroutines.Segments
{
    [Serializable]
    [SegmentMenu("Int", SegmentPath.Value, SegmentGroup.Value)]
    public class IntSegment : ConsumerSegment<int>
    {
        public override IEnumerator Build()
            => Yield.Value(start, target, Yield.Time(duration, easer.Evaluate)).Into(consumer);
    }
}