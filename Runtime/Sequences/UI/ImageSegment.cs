using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Common.Coroutines.Segments
{
    #region FillAmount
    [Serializable]
    [SegmentMenu("Set", SegmentPath.ImageFillAmount, SegmentGroup.UI)]
    public sealed class ImageFillAmountSetSegment : SetSegment<Image, float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator Build()
            => component.CoFillAmount(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.ImageFillAmount, SegmentGroup.UI)]
    public sealed class ImageFillAmountSegment : TowardsSegment<Image, float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);
        
        public override IEnumerator Build()
            => component.CoFillAmount(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.ImageFillAmount, SegmentGroup.UI)]
    public sealed class ImageFillAmountBetweenSegment : BetweenSegment<Image, float>
    {
        public override void OnValidate()
        {
            start = Mathf.Clamp(start, 0.0f, 1.0f);
            target = Mathf.Clamp(target, 0.0f, 1.0f);
        }

        public override IEnumerator Build()
            => component.CoFillAmount(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region Graphic
    [Serializable]
    [SegmentMenu("Set", SegmentPath.ImageColor, SegmentGroup.UI)]
    public sealed class ImageColorSetSegment : TowardsSegment<Image, Color>
    {
        public ImageColorSetSegment()
            => target = Color.white;

        public override IEnumerator Build()
            => component.CoColor(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.ImageColor, SegmentGroup.UI)]
    public sealed class ImageColorSegment : TowardsSegment<Image, Color>
    {
        public ImageColorSegment()
            => target = Color.white;

        public override IEnumerator Build()
            => component.CoColor(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.ImageColor, SegmentGroup.UI)]
    public sealed class ImageColorBetweenSegment : BetweenSegment<Image, Color>
    {
        public ImageColorBetweenSegment()
        {
            start = Color.white;
            target = Color.white;
        }

        public override IEnumerator Build()
            => component.CoColor(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Set", SegmentPath.ImageFade, SegmentGroup.UI)]
    public sealed class ImageFadeSetSegment : TowardsSegment<Image, float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator Build()
            => component.CoFade(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.ImageFade, SegmentGroup.UI)]
    public sealed class ImageFadeSegment : TowardsSegment<Image, float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator Build()
            => component.CoFade(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.ImageFade, SegmentGroup.UI)]
    public sealed class ImageFadeBetweenSegment : BetweenSegment<Image, float>
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
    [SegmentMenu("Gradient", SegmentPath.Image, SegmentGroup.UI)]
    public sealed class ImageGradientSegment : TowardsSegment<Image, Gradient>
    {
        public override IEnumerator Build()
            => component.CoGradient(target, duration, easer.Evaluate);
    }
    #endregion
}