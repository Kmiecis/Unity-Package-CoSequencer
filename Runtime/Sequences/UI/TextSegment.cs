using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Common.Coroutines.Segments
{
    [Serializable]
    public abstract class TextSegment<T> : Segment
    {
        public Text text;
        public T target;
    }

    [Serializable]
    public abstract class TextTimedSegment<T> : TimedSegment
    {
        public Text text;
        public T target;
    }

    [Serializable]
    public abstract class TextBetweenSegment<T> : TimedSegment
    {
        public Text text;
        public T start;
        public T target;
    }

    #region FontSize
    [SegmentMenu("Towards", SegmentPath.TextFontSize, SegmentGroup.UI)]
    public sealed class TextFontSizeSegment : TextTimedSegment<int>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0, 300);

        public override IEnumerator Build()
            => text.CoFontSize(target, duration, easer.Evaluate);
    }

    [SegmentMenu("Set", SegmentPath.TextFontSize, SegmentGroup.UI)]
    public sealed class TextFontSizeSetSegment : TextSegment<int>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0, 300);

        public override IEnumerator Build()
            => text.CoFontSize(target);
    }

    [SegmentMenu("Between", SegmentPath.TextFontSize, SegmentGroup.UI)]
    public sealed class TextFontSizeBetweenSegment : TextBetweenSegment<int>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0, 300);

        public override IEnumerator Build()
            => text.CoFontSize(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region Text
    [SegmentMenu("Unwind", SegmentPath.TextText, SegmentGroup.UI)]
    public sealed class TextTextSegment : TextTimedSegment<string>
    {
        public override IEnumerator Build()
            => text.CoText(target, duration, easer.Evaluate);
    }

    [SegmentMenu("Set", SegmentPath.TextText, SegmentGroup.UI)]
    public sealed class TextTextSetSegment : TextSegment<string>
    {
        public override IEnumerator Build()
            => text.CoText(target);
    }
    #endregion

    #region Graphic
    [SegmentMenu("Towards", SegmentPath.TextColor, SegmentGroup.UI)]
    public sealed class TextColorSegment : TextTimedSegment<Color>
    {
        public TextColorSegment()
            => target = Color.white;

        public override IEnumerator Build()
            => text.CoColor(target, duration, easer.Evaluate);
    }

    [SegmentMenu("Set", SegmentPath.TextColor, SegmentGroup.UI)]
    public sealed class TextColorSetSegment : TextTimedSegment<Color>
    {
        public TextColorSetSegment()
            => target = Color.white;

        public override IEnumerator Build()
            => text.CoColor(target);
    }

    [SegmentMenu("Between", SegmentPath.TextColor, SegmentGroup.UI)]
    public sealed class TextColorBetweenSegment : TextBetweenSegment<Color>
    {
        public TextColorBetweenSegment()
        {
            start = Color.white;
            target = Color.white;
        }

        public override IEnumerator Build()
            => text.CoColor(start, target, duration, easer.Evaluate);
    }

    [SegmentMenu("Towards", SegmentPath.TextFade, SegmentGroup.UI)]
    public sealed class TextFadeSegment : TextTimedSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator Build()
            => text.CoFade(target, duration, easer.Evaluate);
    }

    [SegmentMenu("Set", SegmentPath.TextFade, SegmentGroup.UI)]
    public sealed class TextFadeSetSegment : TextTimedSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator Build()
            => text.CoFade(target);
    }

    [SegmentMenu("Between", SegmentPath.TextFade, SegmentGroup.UI)]
    public sealed class TextFadeBetweenSegment : TextBetweenSegment<float>
    {
        public override void OnValidate()
        {
            start = Mathf.Clamp(start, 0.0f, 1.0f);
            target = Mathf.Clamp(target, 0.0f, 1.0f);
        }

        public override IEnumerator Build()
            => text.CoFade(start, target, duration, easer.Evaluate);
    }

    [SegmentMenu("Gradient", SegmentPath.Text, SegmentGroup.UI)]
    public sealed class TextGradientSegment : TextTimedSegment<Gradient>
    {
        public override IEnumerator Build()
            => text.CoGradient(target, duration, easer.Evaluate);
    }
    #endregion
}