using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines
{
    [Serializable]
    public abstract class LightSegment<T> : TimedSegment
    {
        [SerializeField] protected Light _light;
        [SerializeField] protected T _target;
    }
    
    [SegmentMenu(nameof(Light), "Color")]
    public sealed class LightColorSegment : LightSegment<Color>
    {
        public override void OnAdded()
            => _target = Color.white;

        public override IEnumerator CoExecute()
            => _light.CoColor(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Light), "Intensity")]
    public sealed class LightIntensitySegment : LightSegment<float>
    {
        public override void OnValidate()
            => _target = Mathf.Max(_target, 0.0f);

        public override IEnumerator CoExecute()
            => _light.CoIntensity(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Light), "Range")]
    public sealed class LightRangeSegment : LightSegment<float>
    {
        public override IEnumerator CoExecute()
            => _light.CoRange(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Light), "ShadowStrength")]
    public sealed class LightShadowStrengthSegment : LightSegment<float>
    {
        public override void OnValidate()
            => _target = Mathf.Clamp(_target, 0.0f, 1.0f);

        public override IEnumerator CoExecute()
            => _light.CoShadowStrength(_target, _duration, _easer.Evaluate);
    }
}