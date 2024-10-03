using System;
using System.Collections;

namespace Common.Coroutines.Segments
{
    [Serializable]
    [SegmentMenu("Time", SegmentPath.Wait, SegmentGroup.Utility)]
    public class WaitTimeSegment : Segment
    {
        public float duration = 1.0f;

        public override IEnumerator Build()
            => Yield.Time(duration);
    }

    [Serializable]
    [SegmentMenu("Realtime", SegmentPath.Wait, SegmentGroup.Utility)]
    public class WaitRealtimeSegment : Segment
    {
        public float duration = 1.0f;

        public override IEnumerator Build()
            => Yield.Realtime(duration);
    }

    [Serializable]
    [SegmentMenu("Frames", SegmentPath.Wait, SegmentGroup.Utility)]
    public class WaitFramesSegment : Segment
    {
        public int frames = 1;

        public override IEnumerator Build()
            => Yield.Frames(frames);
    }
}