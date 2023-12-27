using System;
using UnityEngine;

namespace Common.Coroutines.Segments
{
    [Serializable]
    public abstract class TimedSegment : Segment
    {
        public AnimationCurve easer = AnimationCurve.EaseInOut(0.0f, 0.0f, 1.0f, 1.0f);
        public float duration = 1.0f;
    }
}