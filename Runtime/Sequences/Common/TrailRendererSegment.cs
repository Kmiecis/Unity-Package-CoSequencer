using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines.Segments
{
    [Serializable]
    public abstract class TrailRendererSegment<T> : TimedSegment
    {
        public TrailRenderer renderer;
        public T target;
    }
    
    [SegmentMenu(nameof(TrailRenderer), "StartColor")]
    public sealed class TrailRendererStartColorSegment : TrailRendererSegment<Color>
    {
        public override void OnAdded()
            => target = Color.white;

        public override IEnumerator CoExecute()
            => renderer.CoStartColor(target, duration, easer.Evaluate);
    }

    [SegmentMenu(nameof(TrailRenderer), "StartFade")]
    public sealed class TrailRendererStartFadeSegment : TrailRendererSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator CoExecute()
            => renderer.CoStartFade(target, duration, easer.Evaluate);
    }

    [SegmentMenu(nameof(TrailRenderer), "EndColor")]
    public sealed class TrailRendererEndColorSegment : TrailRendererSegment<Color>
    {
        public override void OnAdded()
            => target = Color.white;

        public override IEnumerator CoExecute()
            => renderer.CoEndColor(target, duration, easer.Evaluate);
    }

    [SegmentMenu(nameof(TrailRenderer), "EndFade")]
    public sealed class TrailRendererEndFadeSegment : TrailRendererSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator CoExecute()
            => renderer.CoEndFade(target, duration, easer.Evaluate);
    }

    [SegmentMenu(nameof(TrailRenderer), "Time")]
    public sealed class TrailRendererTimeSegment : TrailRendererSegment<float>
    {
        public override IEnumerator CoExecute()
            => renderer.CoTime(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(TrailRenderer), "StartWidth")]
    public sealed class TrailRendererStartWidthSegment : TrailRendererSegment<float>
    {
        public override IEnumerator CoExecute()
            => renderer.CoStartWidth(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(TrailRenderer), "EndWidth")]
    public sealed class TrailRendererEndWidthSegment : TrailRendererSegment<float>
    {
        public override IEnumerator CoExecute()
            => renderer.CoEndWidth(target, duration, easer.Evaluate);
    }
}