using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Common.Coroutines
{
    [Serializable]
    public abstract class TextSegment<T> : TimedSegment
    {
        [SerializeField] protected Text _text;
        [SerializeField] protected T _target;
    }

    [SegmentMenu(nameof(Text), "FontSize")]
    public sealed class TextFontSizeSegment : TextSegment<int>
    {
        public override void OnValidate()
            => _target = Mathf.Clamp(_target, 0, 300);

        public override IEnumerator CoExecute()
            => _text.CoFontSize(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Text), "Color")]
    public sealed class TextColorSegment : TextSegment<Color>
    {
        public override void OnAdded()
            => _target = Color.white;

        public override IEnumerator CoExecute()
            => _text.CoColor(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Text), "Fade")]
    public sealed class TextFadeSegment : TextSegment<float>
    {
        public override void OnValidate()
            => _target = Mathf.Clamp(_target, 0.0f, 1.0f);

        public override IEnumerator CoExecute()
            => _text.CoFade(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Text), "Gradient")]
    public sealed class TextGradientSegment : TextSegment<Gradient>
    {
        public override IEnumerator CoExecute()
            => _text.CoGradient(_target, _duration, _easer.Evaluate);
    }
}