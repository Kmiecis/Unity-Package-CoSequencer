using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Common.Coroutines
{
    [Serializable]
    public abstract class ShadowSegment<T> : TimedSegment
    {
        [SerializeField] protected Shadow _outline;
        [SerializeField] protected T _target;
    }
    
    [SegmentMenu(nameof(Shadow), "EffectColor")]
    public sealed class ShadowEffectColorSegment : ShadowSegment<Color>
    {
        public override IEnumerator CoExecute()
            => _outline.CoEffectColor(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Shadow), "EffectFade")]
    public sealed class ShadowEffectFadeSegment : ShadowSegment<float>
    {
        public override void OnValidate()
            => _target = Mathf.Clamp(_target, 0.0f, 1.0f);

        public override IEnumerator CoExecute()
            => _outline.CoEffectFade(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Shadow), "EffectGradient")]
    public sealed class ShadowEffectGradientSegment : ShadowSegment<Gradient>
    {
        public override IEnumerator CoExecute()
            => _outline.CoEffectGradient(_target, _duration, _easer.Evaluate);
    }
}