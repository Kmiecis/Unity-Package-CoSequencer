using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines.Segments
{
    [Serializable]
    public abstract class LightSegment<T> : Segment
    {
        public Light light;
        public T target;
    }

    [Serializable]
    public abstract class LightTimedSegment<T> : TimedSegment
    {
        public Light light;
        public T target;
    }

    [Serializable]
    public abstract class LightBetweenSegment<T> : TimedSegment
    {
        public Light light;
        public T start;
        public T target;
    }

    #region Color
    [SegmentMenu("Towards", SegmentPath.LightColor, SegmentGroup.Core)]
    public sealed class LightColorSegment : LightTimedSegment<Color>
    {
        public LightColorSegment()
            => target = Color.white;

        public override IEnumerator Build()
            => light.CoColor(target, duration, easer.Evaluate);
    }

    [SegmentMenu("Set", SegmentPath.LightColor, SegmentGroup.Core)]
    public sealed class LightColorSetSegment : LightSegment<Color>
    {
        public LightColorSetSegment()
            => target = Color.white;

        public override IEnumerator Build()
            => light.CoColor(target);
    }

    [SegmentMenu("Between", SegmentPath.LightColor, SegmentGroup.Core)]
    public sealed class LightColorBetweenSegment : LightBetweenSegment<Color>
    {
        public LightColorBetweenSegment()
        {
            start = Color.white;
            target = Color.white;
        }

        public override IEnumerator Build()
            => light.CoColor(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region Intensity
    [SegmentMenu("Towards", SegmentPath.LightIntensity, SegmentGroup.Core)]
    public sealed class LightIntensitySegment : LightTimedSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Max(target, 0.0f);

        public override IEnumerator Build()
            => light.CoIntensity(target, duration, easer.Evaluate);
    }

    [SegmentMenu("Set", SegmentPath.LightIntensity, SegmentGroup.Core)]
    public sealed class LightIntensitySetSegment : LightSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Max(target, 0.0f);

        public override IEnumerator Build()
            => light.CoIntensity(target);
    }

    [SegmentMenu("Between", SegmentPath.LightIntensity, SegmentGroup.Core)]
    public sealed class LightIntensityBetweenSegment : LightBetweenSegment<float>
    {
        public override void OnValidate()
        {
            start = Mathf.Max(start, 0.0f);
            target = Mathf.Max(target, 0.0f);
        }

        public override IEnumerator Build()
            => light.CoIntensity(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region Range
    [SegmentMenu("Towards", SegmentPath.LightRange, SegmentGroup.Core)]
    public sealed class LightRangeSegment : LightTimedSegment<float>
    {
        public override IEnumerator Build()
            => light.CoRange(target, duration, easer.Evaluate);
    }

    [SegmentMenu("Set", SegmentPath.LightRange, SegmentGroup.Core)]
    public sealed class LightRangeSetSegment : LightSegment<float>
    {
        public override IEnumerator Build()
            => light.CoRange(target);
    }

    [SegmentMenu("Between", SegmentPath.LightRange, SegmentGroup.Core)]
    public sealed class LightRangeBetweenSegment : LightBetweenSegment<float>
    {
        public override IEnumerator Build()
            => light.CoRange(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region ShadowStrength
    [SegmentMenu("Towards", SegmentPath.LightShadowStrength, SegmentGroup.Core)]
    public sealed class LightShadowStrengthSegment : LightTimedSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator Build()
            => light.CoShadowStrength(target, duration, easer.Evaluate);
    }

    [SegmentMenu("Set", SegmentPath.LightShadowStrength, SegmentGroup.Core)]
    public sealed class LightShadowStrengthSetSegment : LightSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator Build()
            => light.CoShadowStrength(target);
    }

    [SegmentMenu("Between", SegmentPath.LightShadowStrength, SegmentGroup.Core)]
    public sealed class LightShadowStrengthBetweenSegment : LightBetweenSegment<float>
    {
        public override void OnValidate()
        {
            start = Mathf.Clamp(start, 0.0f, 1.0f);
            target = Mathf.Clamp(target, 0.0f, 1.0f);
        }

        public override IEnumerator Build()
            => light.CoShadowStrength(start, target, duration, easer.Evaluate);
    }
    #endregion
}