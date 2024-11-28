using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines.Segments
{
    #region Color
    [Serializable]
    [SegmentMenu("Set", SegmentPath.TrailRendererStartColor, SegmentGroup.Core)]
    public sealed class TrailRendererStartColorSetSegment : SetSegment<TrailRenderer, Color>
    {
        public TrailRendererStartColorSetSegment()
            => target = Color.white;

        public override IEnumerator Build()
            => component.CoStartColor(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.TrailRendererStartColor, SegmentGroup.Core)]
    public sealed class TrailRendererStartColorSegment : TowardsSegment<TrailRenderer, Color>
    {
        public TrailRendererStartColorSegment()
            => target = Color.white;

        public override IEnumerator Build()
            => component.CoStartColor(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.TrailRendererStartColor, SegmentGroup.Core)]
    public sealed class TrailRendererStartColorBetweenSegment : BetweenSegment<TrailRenderer, Color>
    {
        public TrailRendererStartColorBetweenSegment()
        {
            start = Color.white;
            target = Color.white;
        }

        public override IEnumerator Build()
            => component.CoStartColor(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Set", SegmentPath.TrailRendererEndColor, SegmentGroup.Core)]
    public sealed class TrailRendererEndColorSetSegment : SetSegment<TrailRenderer, Color>
    {
        public TrailRendererEndColorSetSegment()
            => target = Color.white;

        public override IEnumerator Build()
            => component.CoEndColor(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.TrailRendererEndColor, SegmentGroup.Core)]
    public sealed class TrailRendererEndColorSegment : TowardsSegment<TrailRenderer, Color>
    {
        public TrailRendererEndColorSegment()
            => target = Color.white;

        public override IEnumerator Build()
            => component.CoEndColor(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.TrailRendererEndColor, SegmentGroup.Core)]
    public sealed class TrailRendererEndColorBetweenSegment : BetweenSegment<TrailRenderer, Color>
    {
        public TrailRendererEndColorBetweenSegment()
        {
            start = Color.white;
            target = Color.white;
        }

        public override IEnumerator Build()
            => component.CoEndColor(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region Fade
    [Serializable]
    [SegmentMenu("Set", SegmentPath.TrailRendererStartFade, SegmentGroup.Core)]
    public sealed class TrailRendererStartFadeSetSegment : SetSegment<TrailRenderer, float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator Build()
            => component.CoStartFade(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.TrailRendererStartFade, SegmentGroup.Core)]
    public sealed class TrailRendererStartFadeSegment : TowardsSegment<TrailRenderer, float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator Build()
            => component.CoStartFade(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.TrailRendererStartFade, SegmentGroup.Core)]
    public sealed class TrailRendererStartFadeBetweenSegment : BetweenSegment<TrailRenderer, float>
    {
        public override void OnValidate()
        {
            start = Mathf.Clamp(start, 0.0f, 1.0f);
            target = Mathf.Clamp(target, 0.0f, 1.0f);
        }

        public override IEnumerator Build()
            => component.CoStartFade(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Set", SegmentPath.TrailRendererEndFade, SegmentGroup.Core)]
    public sealed class TrailRendererEndFadeSetSegment : SetSegment<TrailRenderer, float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator Build()
            => component.CoEndFade(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.TrailRendererEndFade, SegmentGroup.Core)]
    public sealed class TrailRendererEndFadeSegment : TowardsSegment<TrailRenderer, float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator Build()
            => component.CoEndFade(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.TrailRendererEndFade, SegmentGroup.Core)]
    public sealed class TrailRendererEndFadeBetweenSegment : BetweenSegment<TrailRenderer, float>
    {
        public override void OnValidate()
        {
            start = Mathf.Clamp(start, 0.0f, 1.0f);
            target = Mathf.Clamp(target, 0.0f, 1.0f);
        }

        public override IEnumerator Build()
            => component.CoEndFade(target, duration, easer.Evaluate);
    }
    #endregion

    #region Time
    [Serializable]
    [SegmentMenu("Set", SegmentPath.TrailRendererTime, SegmentGroup.Core)]
    public sealed class TrailRendererTimeSetSegment : SetSegment<TrailRenderer, float>
    {
        public override IEnumerator Build()
            => component.CoTime(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.TrailRendererTime, SegmentGroup.Core)]
    public sealed class TrailRendererTimeSegment : TowardsSegment<TrailRenderer, float>
    {
        public override IEnumerator Build()
            => component.CoTime(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.TrailRendererTime, SegmentGroup.Core)]
    public sealed class TrailRendererTimeBetweenSegment : BetweenSegment<TrailRenderer, float>
    {
        public override IEnumerator Build()
            => component.CoTime(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region Width
    [Serializable]
    [SegmentMenu("Set", SegmentPath.TrailRendererStartWidth, SegmentGroup.Core)]
    public sealed class TrailRendererStartWidthSetSegment : SetSegment<TrailRenderer, float>
    {
        public override IEnumerator Build()
            => component.CoStartWidth(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.TrailRendererStartWidth, SegmentGroup.Core)]
    public sealed class TrailRendererStartWidthSegment : TowardsSegment<TrailRenderer, float>
    {
        public override IEnumerator Build()
            => component.CoStartWidth(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.TrailRendererStartWidth, SegmentGroup.Core)]
    public sealed class TrailRendererStartWidthBetweenSegment : BetweenSegment<TrailRenderer, float>
    {
        public override IEnumerator Build()
            => component.CoStartWidth(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Set", SegmentPath.TrailRendererEndWidth, SegmentGroup.Core)]
    public sealed class TrailRendererEndWidthSetSegment : SetSegment<TrailRenderer, float>
    {
        public override IEnumerator Build()
            => component.CoEndWidth(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.TrailRendererEndWidth, SegmentGroup.Core)]
    public sealed class TrailRendererEndWidthSegment : TowardsSegment<TrailRenderer, float>
    {
        public override IEnumerator Build()
            => component.CoEndWidth(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.TrailRendererEndWidth, SegmentGroup.Core)]
    public sealed class TrailRendererEndWidthBetweenSegment : BetweenSegment<TrailRenderer, float>
    {
        public override IEnumerator Build()
            => component.CoEndWidth(start, target, duration, easer.Evaluate);
    }
    #endregion
}