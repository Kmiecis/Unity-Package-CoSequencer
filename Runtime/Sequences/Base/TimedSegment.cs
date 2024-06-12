using System;
using UnityEngine;

namespace Common.Coroutines.Segments
{
    [Serializable]
    public abstract class TimedSegment : Segment
    {
        public float duration = 1.0f;
        public AnimationCurve easer = UAnimationCurve.EaseInOutNormalized();
    }
}