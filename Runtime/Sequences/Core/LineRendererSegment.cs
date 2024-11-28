using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines.Segments
{
    #region Color
    [Serializable]
    [SegmentMenu("Set", SegmentPath.LineRendererStartColor, SegmentGroup.Core)]
    public sealed class LineRendererStartColorSetSegment : SetSegment<LineRenderer, Color>
    {
        public LineRendererStartColorSetSegment()
            => target = Color.white;

        public override IEnumerator Build()
            => component.CoStartColor(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.LineRendererStartColor, SegmentGroup.Core)]
    public sealed class LineRendererStartColorSegment : TowardsSegment<LineRenderer, Color>
    {
        public LineRendererStartColorSegment()
            => target = Color.white;

        public override IEnumerator Build()
            => component.CoStartColor(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.LineRendererStartColor, SegmentGroup.Core)]
    public sealed class LineRendererStartColorBetweenSegment : BetweenSegment<LineRenderer, Color>
    {
        public LineRendererStartColorBetweenSegment()
        {
            start = Color.white;
            target = Color.white;
        }

        public override IEnumerator Build()
            => component.CoStartColor(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Set", SegmentPath.LineRendererEndColor, SegmentGroup.Core)]
    public sealed class LineRendererEndColorSetSegment : SetSegment<LineRenderer, Color>
    {
        public LineRendererEndColorSetSegment()
            => target = Color.white;

        public override IEnumerator Build()
            => component.CoEndColor(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.LineRendererEndColor, SegmentGroup.Core)]
    public sealed class LineRendererEndColorSegment : TowardsSegment<LineRenderer, Color>
    {
        public LineRendererEndColorSegment()
            => target = Color.white;

        public override IEnumerator Build()
            => component.CoEndColor(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.LineRendererEndColor, SegmentGroup.Core)]
    public sealed class LineRendererEndColorBetweenSegment : BetweenSegment<LineRenderer, Color>
    {
        public LineRendererEndColorBetweenSegment()
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
    [SegmentMenu("Set", SegmentPath.LineRendererStartFade, SegmentGroup.Core)]
    public sealed class LineRendererStartFadeSetSegment : SetSegment<LineRenderer, float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator Build()
            => component.CoStartFade(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.LineRendererStartFade, SegmentGroup.Core)]
    public sealed class LineRendererStartFadeSegment : TowardsSegment<LineRenderer, float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator Build()
            => component.CoStartFade(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.LineRendererStartFade, SegmentGroup.Core)]
    public sealed class LineRendererStartFadeBetweenSegment : BetweenSegment<LineRenderer, float>
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
    [SegmentMenu("Set", SegmentPath.LineRendererEndFade, SegmentGroup.Core)]
    public sealed class LineRendererEndFadeSetSegment : SetSegment<LineRenderer, float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator Build()
            => component.CoEndFade(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.LineRendererEndFade, SegmentGroup.Core)]
    public sealed class LineRendererEndFadeSegment : TowardsSegment<LineRenderer, float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator Build()
            => component.CoEndFade(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.LineRendererEndFade, SegmentGroup.Core)]
    public sealed class LineRendererEndFadeBetweenSegment : BetweenSegment<LineRenderer, float>
    {
        public override void OnValidate()
        {
            start = Mathf.Clamp(start, 0.0f, 1.0f);
            target = Mathf.Clamp(target, 0.0f, 1.0f);
        }

        public override IEnumerator Build()
            => component.CoEndFade(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region Width
    [Serializable]
    [SegmentMenu("Set", SegmentPath.LineRendererStartWidth, SegmentGroup.Core)]
    public sealed class LineRendererStartWidthSetSegment : SetSegment<LineRenderer, float>
    {
        public override IEnumerator Build()
            => component.CoStartWidth(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.LineRendererStartWidth, SegmentGroup.Core)]
    public sealed class LineRendererStartWidthSegment : TowardsSegment<LineRenderer, float>
    {
        public override IEnumerator Build()
            => component.CoStartWidth(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.LineRendererStartWidth, SegmentGroup.Core)]
    public sealed class LineRendererStartWidthBetweenSegment : BetweenSegment<LineRenderer, float>
    {
        public override IEnumerator Build()
            => component.CoStartWidth(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Set", SegmentPath.LineRendererEndWidth, SegmentGroup.Core)]
    public sealed class LineRendererEndWidthSetSegment : SetSegment<LineRenderer, float>
    {
        public override IEnumerator Build()
            => component.CoEndWidth(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.LineRendererEndWidth, SegmentGroup.Core)]
    public sealed class LineRendererEndWidthSegment : TowardsSegment<LineRenderer, float>
    {
        public override IEnumerator Build()
            => component.CoEndWidth(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.LineRendererEndWidth, SegmentGroup.Core)]
    public sealed class LineRendererEndWidthBetweenSegment : BetweenSegment<LineRenderer, float>
    {
        public override IEnumerator Build()
            => component.CoEndWidth(start, target, duration, easer.Evaluate);
    }
    #endregion
}