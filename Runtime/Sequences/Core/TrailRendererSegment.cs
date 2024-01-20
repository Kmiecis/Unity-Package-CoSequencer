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
    
    [SegmentMenu("StartColor", SegmentPath.TrailRenderer, SegmentGroup.Core)]
    public sealed class TrailRendererStartColorSegment : TrailRendererSegment<Color>
    {
        public override void OnAdded()
            => target = Color.white;

        public override IEnumerator CoExecute()
            => renderer.CoStartColor(target, duration, easer.Evaluate);
    }

    [SegmentMenu("StartFade", SegmentPath.TrailRenderer, SegmentGroup.Core)]
    public sealed class TrailRendererStartFadeSegment : TrailRendererSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator CoExecute()
            => renderer.CoStartFade(target, duration, easer.Evaluate);
    }

    [SegmentMenu("EndColor", SegmentPath.TrailRenderer, SegmentGroup.Core)]
    public sealed class TrailRendererEndColorSegment : TrailRendererSegment<Color>
    {
        public override void OnAdded()
            => target = Color.white;

        public override IEnumerator CoExecute()
            => renderer.CoEndColor(target, duration, easer.Evaluate);
    }

    [SegmentMenu("EndFade", SegmentPath.TrailRenderer, SegmentGroup.Core)]
    public sealed class TrailRendererEndFadeSegment : TrailRendererSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator CoExecute()
            => renderer.CoEndFade(target, duration, easer.Evaluate);
    }

    [SegmentMenu("Time", SegmentPath.TrailRenderer, SegmentGroup.Core)]
    public sealed class TrailRendererTimeSegment : TrailRendererSegment<float>
    {
        public override IEnumerator CoExecute()
            => renderer.CoTime(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("StartWidth", SegmentPath.TrailRenderer, SegmentGroup.Core)]
    public sealed class TrailRendererStartWidthSegment : TrailRendererSegment<float>
    {
        public override IEnumerator CoExecute()
            => renderer.CoStartWidth(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("EndWidth", SegmentPath.TrailRenderer, SegmentGroup.Core)]
    public sealed class TrailRendererEndWidthSegment : TrailRendererSegment<float>
    {
        public override IEnumerator CoExecute()
            => renderer.CoEndWidth(target, duration, easer.Evaluate);
    }
}