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
    
    [SegmentMenu("Color", SegmentPath.Light, SegmentGroup.Core)]
    public sealed class LightColorSegment : LightSegment<Color>
    {
        public LightColorSegment()
            => target = Color.white;

        public override IEnumerator GetSequence()
            => light.CoColor(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("Intensity", SegmentPath.Light, SegmentGroup.Core)]
    public sealed class LightIntensitySegment : LightSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Max(target, 0.0f);

        public override IEnumerator GetSequence()
            => light.CoIntensity(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("Range", SegmentPath.Light, SegmentGroup.Core)]
    public sealed class LightRangeSegment : LightSegment<float>
    {
        public override IEnumerator GetSequence()
            => light.CoRange(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("ShadowStrength", SegmentPath.Light, SegmentGroup.Core)]
    public sealed class LightShadowStrengthSegment : LightSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator GetSequence()
            => light.CoShadowStrength(target, duration, easer.Evaluate);
    }
}