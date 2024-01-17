using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Common.Coroutines.Segments
{
    [Serializable]
    public abstract class TextSegment<T> : TimedSegment
    {
        public Text text;
        public T target;
    }

    [SegmentMenu("FontSize", SegmentPath.Text, SegmentGroup.UI)]
    public sealed class TextFontSizeSegment : TextSegment<int>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0, 300);

        public override IEnumerator CoExecute()
            => text.CoFontSize(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("Color", SegmentPath.Text, SegmentGroup.UI)]
    public sealed class TextColorSegment : TextSegment<Color>
    {
        public override void OnAdded()
            => target = Color.white;

        public override IEnumerator CoExecute()
            => text.CoColor(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("Fade", SegmentPath.Text, SegmentGroup.UI)]
    public sealed class TextFadeSegment : TextSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator CoExecute()
            => text.CoFade(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("Gradient", SegmentPath.Text, SegmentGroup.UI)]
    public sealed class TextGradientSegment : TextSegment<Gradient>
    {
        public override IEnumerator CoExecute()
            => text.CoGradient(target, duration, easer.Evaluate);
    }
}