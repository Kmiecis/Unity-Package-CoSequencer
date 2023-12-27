using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines.Segments
{
    [Serializable]
    public abstract class LightSegment<T> : TimedSegment
    {
        public Light light;
        public T target;
    }
    
    [SegmentMenu(nameof(Light), "Color")]
    public sealed class LightColorSegment : LightSegment<Color>
    {
        public override void OnAdded()
            => target = Color.white;

        public override IEnumerator CoExecute()
            => light.CoColor(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Light), "Intensity")]
    public sealed class LightIntensitySegment : LightSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Max(target, 0.0f);

        public override IEnumerator CoExecute()
            => light.CoIntensity(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Light), "Range")]
    public sealed class LightRangeSegment : LightSegment<float>
    {
        public override IEnumerator CoExecute()
            => light.CoRange(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Light), "ShadowStrength")]
    public sealed class LightShadowStrengthSegment : LightSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator CoExecute()
            => light.CoShadowStrength(target, duration, easer.Evaluate);
    }
}