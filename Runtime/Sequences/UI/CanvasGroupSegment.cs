using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines.Segments
{
    [Serializable]
    public abstract class CanvasGroupSegment<T> : TimedSegment
    {
        public CanvasGroup canvas;
        public T target;
    }

    [SegmentMenu(nameof(CanvasGroup), "Fade")]
    public sealed class CanvasGroupFadeSegment : CanvasGroupSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);
        
        public override IEnumerator CoExecute()
            => canvas.CoFade(target, duration, easer.Evaluate);
    }
}