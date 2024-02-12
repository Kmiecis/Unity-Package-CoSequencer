using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Common.Coroutines.Segments
{
    [Serializable]
    public abstract class OutlineSegment<T> : TimedSegment
    {
        public Outline outline;
        public T target;
    }
    
    [SegmentMenu("EffectColor", SegmentPath.Outline, SegmentGroup.UI)]
    public sealed class OutlineEffectColorSegment : OutlineSegment<Color>
    {
        public OutlineEffectColorSegment()
            => target = Color.white;

        public override IEnumerator GetSequence()
            => outline.CoEffectColor(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("EffectFade", SegmentPath.Outline, SegmentGroup.UI)]
    public sealed class OutlineEffectFadeSegment : OutlineSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);
        
        public override IEnumerator GetSequence()
            => outline.CoEffectFade(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("EffectGradient", SegmentPath.Outline, SegmentGroup.UI)]
    public sealed class OutlineEffectGradientSegment : OutlineSegment<Gradient>
    {
        public override IEnumerator GetSequence()
            => outline.CoEffectGradient(target, duration, easer.Evaluate);
    }
}