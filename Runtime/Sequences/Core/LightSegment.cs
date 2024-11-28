using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines.Segments
{
    #region Color
    [Serializable]
    [SegmentMenu("Set", SegmentPath.LightColor, SegmentGroup.Core)]
    public sealed class LightColorSetSegment : SetSegment<Light, Color>
    {
        public LightColorSetSegment()
            => target = Color.white;

        public override IEnumerator Build()
            => component.CoColor(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.LightColor, SegmentGroup.Core)]
    public sealed class LightColorSegment : TowardsSegment<Light, Color>
    {
        public LightColorSegment()
            => target = Color.white;

        public override IEnumerator Build()
            => component.CoColor(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.LightColor, SegmentGroup.Core)]
    public sealed class LightColorBetweenSegment : BetweenSegment<Light, Color>
    {
        public LightColorBetweenSegment()
        {
            start = Color.white;
            target = Color.white;
        }

        public override IEnumerator Build()
            => component.CoColor(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region Intensity
    [Serializable]
    [SegmentMenu("Set", SegmentPath.LightIntensity, SegmentGroup.Core)]
    public sealed class LightIntensitySetSegment : SetSegment<Light, float>
    {
        public override void OnValidate()
            => target = Mathf.Max(target, 0.0f);

        public override IEnumerator Build()
            => component.CoIntensity(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.LightIntensity, SegmentGroup.Core)]
    public sealed class LightIntensitySegment : TowardsSegment<Light, float>
    {
        public override void OnValidate()
            => target = Mathf.Max(target, 0.0f);

        public override IEnumerator Build()
            => component.CoIntensity(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.LightIntensity, SegmentGroup.Core)]
    public sealed class LightIntensityBetweenSegment : BetweenSegment<Light, float>
    {
        public override void OnValidate()
        {
            start = Mathf.Max(start, 0.0f);
            target = Mathf.Max(target, 0.0f);
        }

        public override IEnumerator Build()
            => component.CoIntensity(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region Range
    [Serializable]
    [SegmentMenu("Set", SegmentPath.LightRange, SegmentGroup.Core)]
    public sealed class LightRangeSetSegment : SetSegment<Light, float>
    {
        public override IEnumerator Build()
            => component.CoRange(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.LightRange, SegmentGroup.Core)]
    public sealed class LightRangeSegment : TowardsSegment<Light, float>
    {
        public override IEnumerator Build()
            => component.CoRange(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.LightRange, SegmentGroup.Core)]
    public sealed class LightRangeBetweenSegment : BetweenSegment<Light, float>
    {
        public override IEnumerator Build()
            => component.CoRange(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region ShadowStrength
    [Serializable]
    [SegmentMenu("Set", SegmentPath.LightShadowStrength, SegmentGroup.Core)]
    public sealed class LightShadowStrengthSetSegment : SetSegment<Light, float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator Build()
            => component.CoShadowStrength(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.LightShadowStrength, SegmentGroup.Core)]
    public sealed class LightShadowStrengthSegment : TowardsSegment<Light, float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator Build()
            => component.CoShadowStrength(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.LightShadowStrength, SegmentGroup.Core)]
    public sealed class LightShadowStrengthBetweenSegment : BetweenSegment<Light, float>
    {
        public override void OnValidate()
        {
            start = Mathf.Clamp(start, 0.0f, 1.0f);
            target = Mathf.Clamp(target, 0.0f, 1.0f);
        }

        public override IEnumerator Build()
            => component.CoShadowStrength(start, target, duration, easer.Evaluate);
    }
    #endregion
}