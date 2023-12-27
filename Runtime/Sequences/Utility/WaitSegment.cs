using System;
using System.Collections;

namespace Common.Coroutines.Segments
{
    [Serializable]
    [SegmentMenu("Utility", "WaitTime")]
    public class WaitTimeSegment : Segment
    {
        public float duration;

        public override IEnumerator CoExecute()
            => UCoroutine.YieldTime(duration);
    }

    [Serializable]
    [SegmentMenu("Utility", "WaitRealtime")]
    public class WaitRealtimeSegment : Segment
    {
        public float duration;

        public override IEnumerator CoExecute()
            => UCoroutine.YieldRealtime(duration);
    }

    [Serializable]
    [SegmentMenu("Utility", "WaitFrames")]
    public class WaitFramesSegment : Segment
    {
        public int frames;

        public override IEnumerator CoExecute()
            => UCoroutine.YieldFrames(frames);
    }
}