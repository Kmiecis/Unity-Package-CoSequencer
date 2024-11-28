using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Common.Coroutines.Segments
{
    #region Shadow
    [Serializable]
    [SegmentMenu("Set", SegmentPath.OutlineEffectColor, SegmentGroup.UI)]
    public sealed class OutlineEffectColorSetSegment : SetSegment<Outline, Color>
    {
        public OutlineEffectColorSetSegment()
            => target = Color.white;

        public override IEnumerator Build()
            => component.CoEffectColor(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.OutlineEffectColor, SegmentGroup.UI)]
    public sealed class OutlineEffectColorSegment : TowardsSegment<Outline, Color>
    {
        public OutlineEffectColorSegment()
            => target = Color.white;

        public override IEnumerator Build()
            => component.CoEffectColor(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.OutlineEffectColor, SegmentGroup.UI)]
    public sealed class OutlineEffectColorBetweenSegment : BetweenSegment<Outline, Color>
    {
        public OutlineEffectColorBetweenSegment()
        {
            start = Color.white;
            target = Color.white;
        }

        public override IEnumerator Build()
            => component.CoEffectColor(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Set", SegmentPath.OutlineEffectFade, SegmentGroup.UI)]
    public sealed class OutlineEffectFadeSetSegment : SetSegment<Outline, float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator Build()
            => component.CoEffectFade(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.OutlineEffectFade, SegmentGroup.UI)]
    public sealed class OutlineEffectFadeSegment : TowardsSegment<Outline, float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator Build()
            => component.CoEffectFade(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.OutlineEffectFade, SegmentGroup.UI)]
    public sealed class OutlineEffectFadeBetweenSegment : BetweenSegment<Outline, float>
    {
        public override void OnValidate()
        {
            start = Mathf.Clamp(start, 0.0f, 1.0f);
            target = Mathf.Clamp(target, 0.0f, 1.0f);
        }

        public override IEnumerator Build()
            => component.CoEffectFade(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Effect Gradient", SegmentPath.Outline, SegmentGroup.UI)]
    public sealed class OutlineEffectGradientSegment : TowardsSegment<Outline, Gradient>
    {
        public override IEnumerator Build()
            => component.CoEffectGradient(target, duration, easer.Evaluate);
    }
    #endregion
}