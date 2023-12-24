using System;
using UnityEngine;

namespace Common.Coroutines
{
    [Serializable]
    public abstract class TimedSegment : Segment
    {
        [SerializeField] protected AnimationCurve _easer = AnimationCurve.EaseInOut(0.0f, 0.0f, 1.0f, 1.0f);
        [SerializeField] protected float _duration = 1.0f;
    }
}