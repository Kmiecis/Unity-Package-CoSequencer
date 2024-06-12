using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines.Segments
{
    [Serializable]
    public abstract class TrailRendererSegment<T> : Segment
    {
        public TrailRenderer renderer;
        public T target;
    }

    [Serializable]
    public abstract class TrailRendererTimedSegment<T> : TimedSegment
    {
        public TrailRenderer renderer;
        public T target;
    }

    [Serializable]
    public abstract class TrailRendererBetweenSegment<T> : TimedSegment
    {
        public TrailRenderer renderer;
        public T start;
        public T target;
    }

    #region Color
    [SegmentMenu("Towards", SegmentPath.TrailRendererStartColor, SegmentGroup.Core)]
    public sealed class TrailRendererStartColorSegment : TrailRendererTimedSegment<Color>
    {
        public TrailRendererStartColorSegment()
            => target = Color.white;

        public override IEnumerator Build()
            => renderer.CoStartColor(target, duration, easer.Evaluate);
    }

    [SegmentMenu("Set", SegmentPath.TrailRendererStartColor, SegmentGroup.Core)]
    public sealed class TrailRendererStartColorSetSegment : TrailRendererSegment<Color>
    {
        public TrailRendererStartColorSetSegment()
            => target = Color.white;

        public override IEnumerator Build()
            => renderer.CoStartColor(target);
    }

    [SegmentMenu("Between", SegmentPath.TrailRendererStartColor, SegmentGroup.Core)]
    public sealed class TrailRendererStartColorBetweenSegment : TrailRendererBetweenSegment<Color>
    {
        public TrailRendererStartColorBetweenSegment()
        {
            start = Color.white;
            target = Color.white;
        }

        public override IEnumerator Build()
            => renderer.CoStartColor(start, target, duration, easer.Evaluate);
    }

    [SegmentMenu("Towards", SegmentPath.TrailRendererEndColor, SegmentGroup.Core)]
    public sealed class TrailRendererEndColorSegment : TrailRendererTimedSegment<Color>
    {
        public TrailRendererEndColorSegment()
            => target = Color.white;

        public override IEnumerator Build()
            => renderer.CoEndColor(target, duration, easer.Evaluate);
    }

    [SegmentMenu("Set", SegmentPath.TrailRendererEndColor, SegmentGroup.Core)]
    public sealed class TrailRendererEndColorSetSegment : TrailRendererSegment<Color>
    {
        public TrailRendererEndColorSetSegment()
            => target = Color.white;

        public override IEnumerator Build()
            => renderer.CoEndColor(target);
    }

    [SegmentMenu("Between", SegmentPath.TrailRendererEndColor, SegmentGroup.Core)]
    public sealed class TrailRendererEndColorBetweenSegment : TrailRendererBetweenSegment<Color>
    {
        public TrailRendererEndColorBetweenSegment()
        {
            start = Color.white;
            target = Color.white;
        }

        public override IEnumerator Build()
            => renderer.CoEndColor(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region Fade
    [SegmentMenu("Towards", SegmentPath.TrailRendererStartFade, SegmentGroup.Core)]
    public sealed class TrailRendererStartFadeSegment : TrailRendererTimedSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator Build()
            => renderer.CoStartFade(target, duration, easer.Evaluate);
    }

    [SegmentMenu("Set", SegmentPath.TrailRendererStartFade, SegmentGroup.Core)]
    public sealed class TrailRendererStartFadeSetSegment : TrailRendererSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator Build()
            => renderer.CoStartFade(target);
    }

    [SegmentMenu("Between", SegmentPath.TrailRendererStartFade, SegmentGroup.Core)]
    public sealed class TrailRendererStartFadeBetweenSegment : TrailRendererBetweenSegment<float>
    {
        public override void OnValidate()
        {
            start = Mathf.Clamp(start, 0.0f, 1.0f);
            target = Mathf.Clamp(target, 0.0f, 1.0f);
        }

        public override IEnumerator Build()
            => renderer.CoStartFade(start, target, duration, easer.Evaluate);
    }

    [SegmentMenu("Towards", SegmentPath.TrailRendererEndFade, SegmentGroup.Core)]
    public sealed class TrailRendererEndFadeSegment : TrailRendererTimedSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator Build()
            => renderer.CoEndFade(target, duration, easer.Evaluate);
    }

    [SegmentMenu("Set", SegmentPath.TrailRendererEndFade, SegmentGroup.Core)]
    public sealed class TrailRendererEndFadeSetSegment : TrailRendererSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator Build()
            => renderer.CoEndFade(target);
    }

    [SegmentMenu("Between", SegmentPath.TrailRendererEndFade, SegmentGroup.Core)]
    public sealed class TrailRendererEndFadeBetweenSegment : TrailRendererBetweenSegment<float>
    {
        public override void OnValidate()
        {
            start = Mathf.Clamp(start, 0.0f, 1.0f);
            target = Mathf.Clamp(target, 0.0f, 1.0f);
        }

        public override IEnumerator Build()
            => renderer.CoEndFade(target, duration, easer.Evaluate);
    }
    #endregion

    #region Time
    [SegmentMenu("Towards", SegmentPath.TrailRendererTime, SegmentGroup.Core)]
    public sealed class TrailRendererTimeSegment : TrailRendererTimedSegment<float>
    {
        public override IEnumerator Build()
            => renderer.CoTime(target, duration, easer.Evaluate);
    }

    [SegmentMenu("Set", SegmentPath.TrailRendererTime, SegmentGroup.Core)]
    public sealed class TrailRendererTimeSetSegment : TrailRendererSegment<float>
    {
        public override IEnumerator Build()
            => renderer.CoTime(target);
    }

    [SegmentMenu("Between", SegmentPath.TrailRendererTime, SegmentGroup.Core)]
    public sealed class TrailRendererTimeBetweenSegment : TrailRendererBetweenSegment<float>
    {
        public override IEnumerator Build()
            => renderer.CoTime(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region Width
    [SegmentMenu("Towards", SegmentPath.TrailRendererStartWidth, SegmentGroup.Core)]
    public sealed class TrailRendererStartWidthSegment : TrailRendererTimedSegment<float>
    {
        public override IEnumerator Build()
            => renderer.CoStartWidth(target, duration, easer.Evaluate);
    }

    [SegmentMenu("Set", SegmentPath.TrailRendererStartWidth, SegmentGroup.Core)]
    public sealed class TrailRendererStartWidthSetSegment : TrailRendererSegment<float>
    {
        public override IEnumerator Build()
            => renderer.CoStartWidth(target);
    }

    [SegmentMenu("Between", SegmentPath.TrailRendererStartWidth, SegmentGroup.Core)]
    public sealed class TrailRendererStartWidthBetweenSegment : TrailRendererBetweenSegment<float>
    {
        public override IEnumerator Build()
            => renderer.CoStartWidth(start, target, duration, easer.Evaluate);
    }

    [SegmentMenu("Towards", SegmentPath.TrailRendererEndWidth, SegmentGroup.Core)]
    public sealed class TrailRendererEndWidthSegment : TrailRendererTimedSegment<float>
    {
        public override IEnumerator Build()
            => renderer.CoEndWidth(target, duration, easer.Evaluate);
    }

    [SegmentMenu("Set", SegmentPath.TrailRendererEndWidth, SegmentGroup.Core)]
    public sealed class TrailRendererEndWidthSetSegment : TrailRendererSegment<float>
    {
        public override IEnumerator Build()
            => renderer.CoEndWidth(target);
    }

    [SegmentMenu("Between", SegmentPath.TrailRendererEndWidth, SegmentGroup.Core)]
    public sealed class TrailRendererEndWidthBetweenSegment : TrailRendererBetweenSegment<float>
    {
        public override IEnumerator Build()
            => renderer.CoEndWidth(start, target, duration, easer.Evaluate);
    }
    #endregion
}