using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Common.Coroutines.Segments
{
    [Serializable]
    public abstract class ShadowSegment<T> : TimedSegment
    {
        public Shadow outline;
        public T target;
    }
    
    [SegmentMenu("EffectColor", SegmentPath.Shadow, SegmentGroup.UI)]
    public sealed class ShadowEffectColorSegment : ShadowSegment<Color>
    {
        public ShadowEffectColorSegment()
            => target = Color.white;

        public override IEnumerator GetSequence()
            => outline.CoEffectColor(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("EffectFade", SegmentPath.Shadow, SegmentGroup.UI)]
    public sealed class ShadowEffectFadeSegment : ShadowSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator GetSequence()
            => outline.CoEffectFade(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("EffectGradient", SegmentPath.Shadow, SegmentGroup.UI)]
    public sealed class ShadowEffectGradientSegment : ShadowSegment<Gradient>
    {
        public override IEnumerator GetSequence()
            => outline.CoEffectGradient(target, duration, easer.Evaluate);
    }
}