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
    
    [SegmentMenu(nameof(Outline), "EffectColor")]
    public sealed class OutlineEffectColorSegment : OutlineSegment<Color>
    {
        public override void OnAdded()
            => target = Color.white;

        public override IEnumerator CoExecute()
            => outline.CoEffectColor(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Outline), "EffectFade")]
    public sealed class OutlineEffectFadeSegment : OutlineSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);
        
        public override IEnumerator CoExecute()
            => outline.CoEffectFade(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Outline), "EffectGradient")]
    public sealed class OutlineEffectGradientSegment : OutlineSegment<Gradient>
    {
        public override IEnumerator CoExecute()
            => outline.CoEffectGradient(target, duration, easer.Evaluate);
    }
}