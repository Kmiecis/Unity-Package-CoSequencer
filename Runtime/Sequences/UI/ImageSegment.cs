using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Common.Coroutines
{
    [Serializable]
    public abstract class ImageSegment<T> : Segment
    {
        [SerializeField] protected Image _image;
        [SerializeField] protected T _target;
    }
    
    [SegmentMenu(nameof(Image), "FillAmount")]
    public sealed class ImageFillAmountSegment : ImageSegment<float>
    {
        public override void OnValidate()
            => _target = Mathf.Clamp(_target, 0.0f, 1.0f);
        
        public override IEnumerator CoExecute()
            => _image.CoFillAmount(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Image), "Color")]
    public sealed class ImageColorSegment : ImageSegment<Color>
    {
        public override IEnumerator CoExecute()
            => _image.CoColor(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Image), "Fade")]
    public sealed class ImageFadeSegment : ImageSegment<float>
    {
        public override void OnValidate()
            => _target = Mathf.Clamp(_target, 0.0f, 1.0f);
        
        public override IEnumerator CoExecute()
            => _image.CoFade(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Image), "Gradient")]
    public sealed class ImageGradientSegment : ImageSegment<Gradient>
    {
        public override IEnumerator CoExecute()
            => _image.CoGradient(_target, _duration, _easer.Evaluate);
    }
}