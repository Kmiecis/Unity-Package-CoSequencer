using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Common.Coroutines.Segments
{
    #region EffectColor
    [Serializable]
    [SegmentMenu("Set", SegmentPath.ShadowEffectColor, SegmentGroup.UI)]
    public sealed class ShadowEffectColorSetSegment : SetSegment<Shadow, Color>
    {
        public ShadowEffectColorSetSegment()
            => target = Color.white;

        public override IEnumerator Build()
            => component.CoEffectColor(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.ShadowEffectColor, SegmentGroup.UI)]
    public sealed class ShadowEffectColorSegment : TowardsSegment<Shadow, Color>
    {
        public ShadowEffectColorSegment()
            => target = Color.white;

        public override IEnumerator Build()
            => component.CoEffectColor(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.ShadowEffectColor, SegmentGroup.UI)]
    public sealed class ShadowEffectColorBetweenSegment : BetweenSegment<Shadow, Color>
    {
        public ShadowEffectColorBetweenSegment()
        {
            start = Color.white;
            target = Color.white;
        }

        public override IEnumerator Build()
            => component.CoEffectColor(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region EffectFade
    [Serializable]
    [SegmentMenu("Set", SegmentPath.ShadowEffectFade, SegmentGroup.UI)]
    public sealed class ShadowEffectFadeSetSegment : SetSegment<Shadow, float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator Build()
            => component.CoEffectFade(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.ShadowEffectFade, SegmentGroup.UI)]
    public sealed class ShadowEffectFadeSegment : TowardsSegment<Shadow, float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator Build()
            => component.CoEffectFade(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.ShadowEffectFade, SegmentGroup.UI)]
    public sealed class ShadowEffectFadeBetweenSegment : BetweenSegment<Shadow, float>
    {
        public override void OnValidate()
        {
            start = Mathf.Clamp(start, 0.0f, 1.0f);
            target = Mathf.Clamp(target, 0.0f, 1.0f);
        }

        public override IEnumerator Build()
            => component.CoEffectFade(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region EffectGradient
    [Serializable]
    [SegmentMenu("Effect Gradient", SegmentPath.Shadow, SegmentGroup.UI)]
    public sealed class ShadowEffectGradientSegment : TowardsSegment<Shadow, Gradient>
    {
        public override IEnumerator Build()
            => component.CoEffectGradient(target, duration, easer.Evaluate);
    }
    #endregion
}