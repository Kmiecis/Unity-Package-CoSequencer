using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Common.Coroutines.Segments
{
    public abstract class TextSegment<T> : Segment
    {
        public Text text;
        public T target;
    }

    public abstract class TextTimedSegment<T> : TimedSegment
    {
        public Text text;
        public T target;
    }

    public abstract class TextBetweenSegment<T> : TimedSegment
    {
        public Text text;
        public T start;
        public T target;
    }

    #region FontSize
    [Serializable]
    [SegmentMenu("Set", SegmentPath.TextFontSize, SegmentGroup.UI)]
    public sealed class TextFontSizeSetSegment : TextSegment<int>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0, 300);

        public override IEnumerator Build()
            => text.CoFontSize(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.TextFontSize, SegmentGroup.UI)]
    public sealed class TextFontSizeSegment : TextTimedSegment<int>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0, 300);

        public override IEnumerator Build()
            => text.CoFontSize(target, duration, easer.Evaluate);
    }

    [Serializable]
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
    [Serializable]
    [SegmentMenu("Set", SegmentPath.TextText, SegmentGroup.UI)]
    public sealed class TextTextSetSegment : TextSegment<string>
    {
        public override IEnumerator Build()
            => text.CoText(target);
    }

    [Serializable]
    [SegmentMenu("Unwind", SegmentPath.TextText, SegmentGroup.UI)]
    public sealed class TextTextSegment : TextTimedSegment<string>
    {
        public override IEnumerator Build()
            => text.CoText(target, duration, easer.Evaluate);
    }
    #endregion

    #region Graphic
    [Serializable]
    [SegmentMenu("Set", SegmentPath.TextColor, SegmentGroup.UI)]
    public sealed class TextColorSetSegment : TextTimedSegment<Color>
    {
        public TextColorSetSegment()
            => target = Color.white;

        public override IEnumerator Build()
            => text.CoColor(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.TextColor, SegmentGroup.UI)]
    public sealed class TextColorSegment : TextTimedSegment<Color>
    {
        public TextColorSegment()
            => target = Color.white;

        public override IEnumerator Build()
            => text.CoColor(target, duration, easer.Evaluate);
    }

    [Serializable]
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

    [Serializable]
    [SegmentMenu("Set", SegmentPath.TextFade, SegmentGroup.UI)]
    public sealed class TextFadeSetSegment : TextTimedSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator Build()
            => text.CoFade(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.TextFade, SegmentGroup.UI)]
    public sealed class TextFadeSegment : TextTimedSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator Build()
            => text.CoFade(target, duration, easer.Evaluate);
    }

    [Serializable]
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

    [Serializable]
    [SegmentMenu("Gradient", SegmentPath.Text, SegmentGroup.UI)]
    public sealed class TextGradientSegment : TextTimedSegment<Gradient>
    {
        public override IEnumerator Build()
            => text.CoGradient(target, duration, easer.Evaluate);
    }
    #endregion
}