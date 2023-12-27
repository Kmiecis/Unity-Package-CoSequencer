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
    
    [SegmentMenu(nameof(Shadow), "EffectColor")]
    public sealed class ShadowEffectColorSegment : ShadowSegment<Color>
    {
        public override void OnAdded()
            => target = Color.white;

        public override IEnumerator CoExecute()
            => outline.CoEffectColor(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Shadow), "EffectFade")]
    public sealed class ShadowEffectFadeSegment : ShadowSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator CoExecute()
            => outline.CoEffectFade(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Shadow), "EffectGradient")]
    public sealed class ShadowEffectGradientSegment : ShadowSegment<Gradient>
    {
        public override IEnumerator CoExecute()
            => outline.CoEffectGradient(target, duration, easer.Evaluate);
    }
}