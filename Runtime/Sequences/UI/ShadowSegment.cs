using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Common.Coroutines.Segments
{
    [Serializable]
    public abstract class ShadowSegment<T> : Segment
    {
        public Shadow shadow;
        public T target;
    }

    [Serializable]
    public abstract class ShadowTimedSegment<T> : TimedSegment
    {
        public Shadow shadow;
        public T target;
    }

    [Serializable]
    public abstract class ShadowBetweenSegment<T> : TimedSegment
    {
        public Shadow shadow;
        public T start;
        public T target;
    }

    #region EffectColor
    [SegmentMenu("Towards", SegmentPath.ShadowEffectColor, SegmentGroup.UI)]
    public sealed class ShadowEffectColorSegment : ShadowTimedSegment<Color>
    {
        public ShadowEffectColorSegment()
            => target = Color.white;

        public override IEnumerator Build()
            => shadow.CoEffectColor(target, duration, easer.Evaluate);
    }

    [SegmentMenu("Set", SegmentPath.ShadowEffectColor, SegmentGroup.UI)]
    public sealed class ShadowEffectColorSetSegment : ShadowSegment<Color>
    {
        public ShadowEffectColorSetSegment()
            => target = Color.white;

        public override IEnumerator Build()
            => shadow.CoEffectColor(target);
    }

    [SegmentMenu("Between", SegmentPath.ShadowEffectColor, SegmentGroup.UI)]
    public sealed class ShadowEffectColorBetweenSegment : ShadowBetweenSegment<Color>
    {
        public ShadowEffectColorBetweenSegment()
        {
            start = Color.white;
            target = Color.white;
        }

        public override IEnumerator Build()
            => shadow.CoEffectColor(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region EffectFade
    [SegmentMenu("Towards", SegmentPath.ShadowEffectFade, SegmentGroup.UI)]
    public sealed class ShadowEffectFadeSegment : ShadowTimedSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator Build()
            => shadow.CoEffectFade(target, duration, easer.Evaluate);
    }

    [SegmentMenu("Set", SegmentPath.ShadowEffectFade, SegmentGroup.UI)]
    public sealed class ShadowEffectFadeSetSegment : ShadowSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator Build()
            => shadow.CoEffectFade(target);
    }

    [SegmentMenu("Between", SegmentPath.ShadowEffectFade, SegmentGroup.UI)]
    public sealed class ShadowEffectFadeBetweenSegment : ShadowBetweenSegment<float>
    {
        public override void OnValidate()
        {
            start = Mathf.Clamp(start, 0.0f, 1.0f);
            target = Mathf.Clamp(target, 0.0f, 1.0f);
        }

        public override IEnumerator Build()
            => shadow.CoEffectFade(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region EffectGradient
    [SegmentMenu("Effect Gradient", SegmentPath.Shadow, SegmentGroup.UI)]
    public sealed class ShadowEffectGradientSegment : ShadowTimedSegment<Gradient>
    {
        public override IEnumerator Build()
            => shadow.CoEffectGradient(target, duration, easer.Evaluate);
    }
    #endregion
}