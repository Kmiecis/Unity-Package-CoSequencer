using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines.Segments
{
    public abstract class LineRendererSegment<T> : Segment
    {
        public LineRenderer renderer;
        public T target;
    }

    public abstract class LineRendererTimedSegment<T> : TimedSegment
    {
        public LineRenderer renderer;
        public T target;
    }

    public abstract class LineRendererBetweenSegment<T> : TimedSegment
    {
        public LineRenderer renderer;
        public T start;
        public T target;
    }

    #region Color
    [Serializable]
    [SegmentMenu("Towards", SegmentPath.LineRendererStartColor, SegmentGroup.Core)]
    public sealed class LineRendererStartColorSegment : LineRendererTimedSegment<Color>
    {
        public LineRendererStartColorSegment()
            => target = Color.white;

        public override IEnumerator Build()
            => renderer.CoStartColor(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Set", SegmentPath.LineRendererStartColor, SegmentGroup.Core)]
    public sealed class LineRendererStartColorSetSegment : LineRendererSegment<Color>
    {
        public LineRendererStartColorSetSegment()
            => target = Color.white;

        public override IEnumerator Build()
            => renderer.CoStartColor(target);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.LineRendererStartColor, SegmentGroup.Core)]
    public sealed class LineRendererStartColorBetweenSegment : LineRendererBetweenSegment<Color>
    {
        public LineRendererStartColorBetweenSegment()
        {
            start = Color.white;
            target = Color.white;
        }

        public override IEnumerator Build()
            => renderer.CoStartColor(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.LineRendererEndColor, SegmentGroup.Core)]
    public sealed class LineRendererEndColorSegment : LineRendererTimedSegment<Color>
    {
        public LineRendererEndColorSegment()
            => target = Color.white;

        public override IEnumerator Build()
            => renderer.CoEndColor(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Set", SegmentPath.LineRendererEndColor, SegmentGroup.Core)]
    public sealed class LineRendererEndColorSetSegment : LineRendererSegment<Color>
    {
        public LineRendererEndColorSetSegment()
            => target = Color.white;

        public override IEnumerator Build()
            => renderer.CoEndColor(target);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.LineRendererEndColor, SegmentGroup.Core)]
    public sealed class LineRendererEndColorBetweenSegment : LineRendererBetweenSegment<Color>
    {
        public LineRendererEndColorBetweenSegment()
        {
            start = Color.white;
            target = Color.white;
        }

        public override IEnumerator Build()
            => renderer.CoEndColor(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region Fade
    [Serializable]
    [SegmentMenu("Towards", SegmentPath.LineRendererStartFade, SegmentGroup.Core)]
    public sealed class LineRendererStartFadeSegment : LineRendererTimedSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator Build()
            => renderer.CoStartFade(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Set", SegmentPath.LineRendererStartFade, SegmentGroup.Core)]
    public sealed class LineRendererStartFadeSetSegment : LineRendererSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator Build()
            => renderer.CoStartFade(target);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.LineRendererStartFade, SegmentGroup.Core)]
    public sealed class LineRendererStartFadeBetweenSegment : LineRendererBetweenSegment<float>
    {
        public override void OnValidate()
        {
            start = Mathf.Clamp(start, 0.0f, 1.0f);
            target = Mathf.Clamp(target, 0.0f, 1.0f);
        }

        public override IEnumerator Build()
            => renderer.CoStartFade(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.LineRendererEndFade, SegmentGroup.Core)]
    public sealed class LineRendererEndFadeSegment : LineRendererTimedSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator Build()
            => renderer.CoEndFade(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Set", SegmentPath.LineRendererEndFade, SegmentGroup.Core)]
    public sealed class LineRendererEndFadeSetSegment : LineRendererSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator Build()
            => renderer.CoEndFade(target);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.LineRendererEndFade, SegmentGroup.Core)]
    public sealed class LineRendererEndFadeBetweenSegment : LineRendererBetweenSegment<float>
    {
        public override void OnValidate()
        {
            start = Mathf.Clamp(start, 0.0f, 1.0f);
            target = Mathf.Clamp(target, 0.0f, 1.0f);
        }

        public override IEnumerator Build()
            => renderer.CoEndFade(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region Width
    [Serializable]
    [SegmentMenu("Towards", SegmentPath.LineRendererStartWidth, SegmentGroup.Core)]
    public sealed class LineRendererStartWidthSegment : LineRendererTimedSegment<float>
    {
        public override IEnumerator Build()
            => renderer.CoStartWidth(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Set", SegmentPath.LineRendererStartWidth, SegmentGroup.Core)]
    public sealed class LineRendererStartWidthSetSegment : LineRendererSegment<float>
    {
        public override IEnumerator Build()
            => renderer.CoStartWidth(target);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.LineRendererStartWidth, SegmentGroup.Core)]
    public sealed class LineRendererStartWidthBetweenSegment : LineRendererBetweenSegment<float>
    {
        public override IEnumerator Build()
            => renderer.CoStartWidth(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.LineRendererEndWidth, SegmentGroup.Core)]
    public sealed class LineRendererEndWidthSegment : LineRendererTimedSegment<float>
    {
        public override IEnumerator Build()
            => renderer.CoEndWidth(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Set", SegmentPath.LineRendererEndWidth, SegmentGroup.Core)]
    public sealed class LineRendererEndWidthSetSegment : LineRendererSegment<float>
    {
        public override IEnumerator Build()
            => renderer.CoEndWidth(target);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.LineRendererEndWidth, SegmentGroup.Core)]
    public sealed class LineRendererEndWidthBetweenSegment : LineRendererBetweenSegment<float>
    {
        public override IEnumerator Build()
            => renderer.CoEndWidth(start, target, duration, easer.Evaluate);
    }
    #endregion
}