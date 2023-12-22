using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines
{
    [Serializable]
    public abstract class CanvasGroupSegment<T> : Segment
    {
        [SerializeField] protected CanvasGroup _canvas;
        [SerializeField] protected T _target;
    }

    [SegmentMenu(nameof(CanvasGroup), "Fade")]
    public sealed class CanvasGroupFadeSegment : CanvasGroupSegment<float>
    {
        public override void OnValidate()
            => _target = Mathf.Clamp(_target, 0.0f, 1.0f);
        
        public override IEnumerator CoExecute()
            => _canvas.CoFade(_target, _duration, _easer.Evaluate);
    }
}