using System;
using System.Collections;

namespace Common.Coroutines.Segments
{
    [Serializable]
    public abstract class TimeSegment : TimedSegment
    {
        public float target;
    }

    [SegmentMenu("Scale", SegmentPath.Time, SegmentGroup.Utility)]
    public class TimeScaleSegment : TimeSegment
    {
        public override IEnumerator Build()
            => UCoroutine.CoTimeScale(target, duration, easer.Evaluate);
    }
}