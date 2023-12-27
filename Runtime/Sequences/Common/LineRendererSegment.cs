using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines.Segments
{
    [Serializable]
    public abstract class LineRendererSegment<T> : TimedSegment
    {
        public LineRenderer renderer;
        public T target;
    }
    
    [SegmentMenu(nameof(LineRenderer), "StartColor")]
    public sealed class LineRendererStartColorSegment : LineRendererSegment<Color>
    {
        public override void OnAdded()
            => target = Color.white;

        public override IEnumerator CoExecute()
            => renderer.CoStartColor(target, duration, easer.Evaluate);
    }

    [SegmentMenu(nameof(LineRenderer), "StartFade")]
    public sealed class LineRendererStartFadeSegment : LineRendererSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator CoExecute()
            => renderer.CoStartFade(target, duration, easer.Evaluate);
    }

    [SegmentMenu(nameof(LineRenderer), "EndColor")]
    public sealed class LineRendererEndColorSegment : LineRendererSegment<Color>
    {
        public override void OnAdded()
            => target = Color.white;

        public override IEnumerator CoExecute()
            => renderer.CoEndColor(target, duration, easer.Evaluate);
    }

    [SegmentMenu(nameof(LineRenderer), "EndFade")]
    public sealed class LineRendererEndFadeSegment : LineRendererSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator CoExecute()
            => renderer.CoEndFade(target, duration, easer.Evaluate);
    }

    [SegmentMenu(nameof(LineRenderer), "StartWidth")]
    public sealed class LineRendererStartWidthSegment : LineRendererSegment<float>
    {
        public override IEnumerator CoExecute()
            => renderer.CoStartWidth(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(LineRenderer), "EndWidth")]
    public sealed class LineRendererEndWidthSegment : LineRendererSegment<float>
    {
        public override IEnumerator CoExecute()
            => renderer.CoEndWidth(target, duration, easer.Evaluate);
    }
}