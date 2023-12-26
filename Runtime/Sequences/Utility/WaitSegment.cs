using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines
{
    [Serializable]
    [SegmentMenu("Utility", "WaitTime")]
    public class WaitTimeSegment : Segment
    {
        [SerializeField] private float _duration;

        public override IEnumerator CoExecute()
            => UCoroutine.YieldTime(_duration);
    }

    [Serializable]
    [SegmentMenu("Utility", "WaitRealtime")]
    public class WaitRealtimeSegment : Segment
    {
        [SerializeField] private float _duration;

        public override IEnumerator CoExecute()
            => UCoroutine.YieldRealtime(_duration);
    }

    [Serializable]
    [SegmentMenu("Utility", "WaitFrames")]
    public class WaitFramesSegment : Segment
    {
        [SerializeField] private int _frames;

        public override IEnumerator CoExecute()
            => UCoroutine.YieldFrames(_frames);
    }
}