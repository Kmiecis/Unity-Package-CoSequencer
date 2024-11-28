using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Common.Coroutines.Segments
{
    #region FontSize
    [Serializable]
    [SegmentMenu("Set", SegmentPath.TextFontSize, SegmentGroup.UI)]
    public sealed class TextFontSizeSetSegment : SetSegment<Text, int>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0, 300);

        public override IEnumerator Build()
            => component.CoFontSize(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.TextFontSize, SegmentGroup.UI)]
    public sealed class TextFontSizeSegment : TowardsSegment<Text, int>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0, 300);

        public override IEnumerator Build()
            => component.CoFontSize(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.TextFontSize, SegmentGroup.UI)]
    public sealed class TextFontSizeBetweenSegment : BetweenSegment<Text, int>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0, 300);

        public override IEnumerator Build()
            => component.CoFontSize(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region Text
    [Serializable]
    [SegmentMenu("Set", SegmentPath.TextText, SegmentGroup.UI)]
    public sealed class TextTextSetSegment : SetSegment<Text, string>
    {
        public override IEnumerator Build()
            => component.CoText(target);
    }

    [Serializable]
    [SegmentMenu("Unwind", SegmentPath.TextText, SegmentGroup.UI)]
    public sealed class TextTextSegment : TowardsSegment<Text, string>
    {
        public override IEnumerator Build()
            => component.CoText(target, duration, easer.Evaluate);
    }
    #endregion

    #region Graphic
    [Serializable]
    [SegmentMenu("Set", SegmentPath.TextColor, SegmentGroup.UI)]
    public sealed class TextColorSetSegment : TowardsSegment<Text, Color>
    {
        public TextColorSetSegment()
            => target = Color.white;

        public override IEnumerator Build()
            => component.CoColor(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.TextColor, SegmentGroup.UI)]
    public sealed class TextColorSegment : TowardsSegment<Text, Color>
    {
        public TextColorSegment()
            => target = Color.white;

        public override IEnumerator Build()
            => component.CoColor(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.TextColor, SegmentGroup.UI)]
    public sealed class TextColorBetweenSegment : BetweenSegment<Text, Color>
    {
        public TextColorBetweenSegment()
        {
            start = Color.white;
            target = Color.white;
        }

        public override IEnumerator Build()
            => component.CoColor(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Set", SegmentPath.TextFade, SegmentGroup.UI)]
    public sealed class TextFadeSetSegment : TowardsSegment<Text, float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator Build()
            => component.CoFade(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.TextFade, SegmentGroup.UI)]
    public sealed class TextFadeSegment : TowardsSegment<Text, float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator Build()
            => component.CoFade(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.TextFade, SegmentGroup.UI)]
    public sealed class TextFadeBetweenSegment : BetweenSegment<Text, float>
    {
        public override void OnValidate()
        {
            start = Mathf.Clamp(start, 0.0f, 1.0f);
            target = Mathf.Clamp(target, 0.0f, 1.0f);
        }

        public override IEnumerator Build()
            => component.CoFade(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Gradient", SegmentPath.Text, SegmentGroup.UI)]
    public sealed class TextGradientSegment : TowardsSegment<Text, Gradient>
    {
        public override IEnumerator Build()
            => component.CoGradient(target, duration, easer.Evaluate);
    }
    #endregion
}