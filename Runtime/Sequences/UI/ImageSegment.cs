using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Common.Coroutines.Segments
{
    [Serializable]
    public abstract class ImageSegment<T> : TimedSegment
    {
        public Image image;
        public T target;
    }
    
    [SegmentMenu("FillAmount", SegmentPath.Image, SegmentGroup.UI)]
    public sealed class ImageFillAmountSegment : ImageSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);
        
        public override IEnumerator CoExecute()
            => image.CoFillAmount(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("Color", SegmentPath.Image, SegmentGroup.UI)]
    public sealed class ImageColorSegment : ImageSegment<Color>
    {
        public override void OnAdded()
            => target = Color.white;

        public override IEnumerator CoExecute()
            => image.CoColor(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("Fade", SegmentPath.Image, SegmentGroup.UI)]
    public sealed class ImageFadeSegment : ImageSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);
        
        public override IEnumerator CoExecute()
            => image.CoFade(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("Gradient", SegmentPath.Image, SegmentGroup.UI)]
    public sealed class ImageGradientSegment : ImageSegment<Gradient>
    {
        public override IEnumerator CoExecute()
            => image.CoGradient(target, duration, easer.Evaluate);
    }
}