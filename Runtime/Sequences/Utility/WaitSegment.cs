using System;
using System.Collections;

namespace Common.Coroutines.Segments
{
    [Serializable]
    [SegmentMenu("WaitTime", SegmentPath.Utility, SegmentGroup.Utility)]
    public class WaitTimeSegment : Segment
    {
        public float duration;

        public override IEnumerator CoExecute()
            => UCoroutine.YieldTime(duration);
    }

    [Serializable]
    [SegmentMenu("WaitRealtime", SegmentPath.Utility, SegmentGroup.Utility)]
    public class WaitRealtimeSegment : Segment
    {
        public float duration;

        public override IEnumerator CoExecute()
            => UCoroutine.YieldRealtime(duration);
    }

    [Serializable]
    [SegmentMenu("WaitFrames", SegmentPath.Utility, SegmentGroup.Utility)]
    public class WaitFramesSegment : Segment
    {
        public int frames;

        public override IEnumerator CoExecute()
            => UCoroutine.YieldFrames(frames);
    }
}