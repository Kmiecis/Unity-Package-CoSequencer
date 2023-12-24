using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Common.Coroutines
{
    [Serializable]
    public abstract class OutlineSegment<T> : TimedSegment
    {
        [SerializeField] protected Outline _outline;
        [SerializeField] protected T _target;
    }
    
    [SegmentMenu(nameof(Outline), "EffectColor")]
    public sealed class OutlineEffectColorSegment : OutlineSegment<Color>
    {
        public override IEnumerator CoExecute()
            => _outline.CoEffectColor(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Outline), "EffectFade")]
    public sealed class OutlineEffectFadeSegment : OutlineSegment<float>
    {
        public override void OnValidate()
            => _target = Mathf.Clamp(_target, 0.0f, 1.0f);
        
        public override IEnumerator CoExecute()
            => _outline.CoEffectFade(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Outline), "EffectGradient")]
    public sealed class OutlineEffectGradientSegment : OutlineSegment<Gradient>
    {
        public override IEnumerator CoExecute()
            => _outline.CoEffectGradient(_target, _duration, _easer.Evaluate);
    }
}