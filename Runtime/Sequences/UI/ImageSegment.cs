using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Common.Coroutines.Segments
{
    public abstract class ImageSegment<T> : Segment
    {
        public Image image;
        public T target;
    }

    public abstract class ImageTimedSegment<T> : TimedSegment
    {
        public Image image;
        public T target;
    }

    public abstract class ImageBetweenSegment<T> : TimedSegment
    {
        public Image image;
        public T start;
        public T target;
    }

    #region FillAmount
    [Serializable]
    [SegmentMenu("Towards", SegmentPath.ImageFillAmount, SegmentGroup.UI)]
    public sealed class ImageFillAmountSegment : ImageTimedSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);
        
        public override IEnumerator Build()
            => image.CoFillAmount(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Set", SegmentPath.ImageFillAmount, SegmentGroup.UI)]
    public sealed class ImageFillAmountSetSegment : ImageSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator Build()
            => image.CoFillAmount(target);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.ImageFillAmount, SegmentGroup.UI)]
    public sealed class ImageFillAmountBetweenSegment : ImageBetweenSegment<float>
    {
        public override void OnValidate()
        {
            start = Mathf.Clamp(start, 0.0f, 1.0f);
            target = Mathf.Clamp(target, 0.0f, 1.0f);
        }

        public override IEnumerator Build()
            => image.CoFillAmount(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region Graphic
    [Serializable]
    [SegmentMenu("Towards", SegmentPath.ImageColor, SegmentGroup.UI)]
    public sealed class ImageColorSegment : ImageTimedSegment<Color>
    {
        public ImageColorSegment()
            => target = Color.white;

        public override IEnumerator Build()
            => image.CoColor(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Set", SegmentPath.ImageColor, SegmentGroup.UI)]
    public sealed class ImageColorSetSegment : ImageTimedSegment<Color>
    {
        public ImageColorSetSegment()
            => target = Color.white;

        public override IEnumerator Build()
            => image.CoColor(target);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.ImageColor, SegmentGroup.UI)]
    public sealed class ImageColorBetweenSegment : ImageBetweenSegment<Color>
    {
        public ImageColorBetweenSegment()
        {
            start = Color.white;
            target = Color.white;
        }

        public override IEnumerator Build()
            => image.CoColor(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.ImageFade, SegmentGroup.UI)]
    public sealed class ImageFadeSegment : ImageTimedSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator Build()
            => image.CoFade(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Set", SegmentPath.ImageFade, SegmentGroup.UI)]
    public sealed class ImageFadeSetSegment : ImageTimedSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator Build()
            => image.CoFade(target);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.ImageFade, SegmentGroup.UI)]
    public sealed class ImageFadeBetweenSegment : ImageBetweenSegment<float>
    {
        public override void OnValidate()
        {
            start = Mathf.Clamp(start, 0.0f, 1.0f);
            target = Mathf.Clamp(target, 0.0f, 1.0f);
        }

        public override IEnumerator Build()
            => image.CoFade(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Gradient", SegmentPath.Image, SegmentGroup.UI)]
    public sealed class ImageGradientSegment : ImageTimedSegment<Gradient>
    {
        public override IEnumerator Build()
            => image.CoGradient(target, duration, easer.Evaluate);
    }
    #endregion
}