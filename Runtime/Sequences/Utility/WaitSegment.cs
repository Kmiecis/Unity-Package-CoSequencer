using System;
using System.Collections;

namespace Common.Coroutines.Segments
{
    [Serializable]
    [SegmentMenu("Time", SegmentPath.Wait, SegmentGroup.Utility)]
    public class WaitTimeSegment : Segment
    {
        public float duration;

        public override IEnumerator GetSequence()
            => UCoroutine.YieldTime(duration);
    }

    [Serializable]
    [SegmentMenu("Realtime", SegmentPath.Wait, SegmentGroup.Utility)]
    public class WaitRealtimeSegment : Segment
    {
        public float duration;

        public override IEnumerator GetSequence()
            => UCoroutine.YieldRealtime(duration);
    }

    [Serializable]
    [SegmentMenu("Frames", SegmentPath.Wait, SegmentGroup.Utility)]
    public class WaitFramesSegment : Segment
    {
        public int frames;

        public override IEnumerator GetSequence()
            => UCoroutine.YieldFrames(frames);
    }
}