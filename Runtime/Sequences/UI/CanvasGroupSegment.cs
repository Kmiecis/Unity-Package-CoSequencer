using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines.Segments
{
    [Serializable]
    public abstract class CanvasGroupSegment<T> : Segment
    {
        public CanvasGroup canvas;
        public T target;
    }

    [Serializable]
    public abstract class CanvasGroupTimedSegment<T> : TimedSegment
    {
        public CanvasGroup canvas;
        public T target;
    }

    [Serializable]
    public abstract class CanvasGroupBetweenSegment<T> : TimedSegment
    {
        public CanvasGroup canvas;
        public T start;
        public T target;
    }

    #region Fade
    [SegmentMenu("Towards", SegmentPath.CanvasGroupFade, SegmentGroup.UI)]
    public sealed class CanvasGroupFadeSegment : CanvasGroupTimedSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);
        
        public override IEnumerator Build()
            => canvas.CoFade(target, duration, easer.Evaluate);
    }

    [SegmentMenu("Set", SegmentPath.CanvasGroupFade, SegmentGroup.UI)]
    public sealed class CanvasGroupFadeSetSegment : CanvasGroupSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator Build()
            => canvas.CoFade(target);
    }

    [SegmentMenu("Between", SegmentPath.CanvasGroupFade, SegmentGroup.UI)]
    public sealed class CanvasGroupFadeBetweenSegment : CanvasGroupBetweenSegment<float>
    {
        public override void OnValidate()
        {
            start = Mathf.Clamp(start, 0.0f, 1.0f);
            target = Mathf.Clamp(target, 0.0f, 1.0f);
        }

        public override IEnumerator Build()
            => canvas.CoFade(start, target, duration, easer.Evaluate);
    }
    #endregion
}