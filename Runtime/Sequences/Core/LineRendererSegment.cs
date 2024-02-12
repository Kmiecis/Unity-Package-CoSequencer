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
    
    [SegmentMenu("StartColor", SegmentPath.LineRenderer, SegmentGroup.Core)]
    public sealed class LineRendererStartColorSegment : LineRendererSegment<Color>
    {
        public LineRendererStartColorSegment()
            => target = Color.white;

        public override IEnumerator GetSequence()
            => renderer.CoStartColor(target, duration, easer.Evaluate);
    }

    [SegmentMenu("StartFade", SegmentPath.LineRenderer, SegmentGroup.Core)]
    public sealed class LineRendererStartFadeSegment : LineRendererSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator GetSequence()
            => renderer.CoStartFade(target, duration, easer.Evaluate);
    }

    [SegmentMenu("EndColor", SegmentPath.LineRenderer, SegmentGroup.Core)]
    public sealed class LineRendererEndColorSegment : LineRendererSegment<Color>
    {
        public LineRendererEndColorSegment()
            => target = Color.white;

        public override IEnumerator GetSequence()
            => renderer.CoEndColor(target, duration, easer.Evaluate);
    }

    [SegmentMenu("EndFade", SegmentPath.LineRenderer, SegmentGroup.Core)]
    public sealed class LineRendererEndFadeSegment : LineRendererSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator GetSequence()
            => renderer.CoEndFade(target, duration, easer.Evaluate);
    }

    [SegmentMenu("StartWidth", SegmentPath.LineRenderer, SegmentGroup.Core)]
    public sealed class LineRendererStartWidthSegment : LineRendererSegment<float>
    {
        public override IEnumerator GetSequence()
            => renderer.CoStartWidth(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("EndWidth", SegmentPath.LineRenderer, SegmentGroup.Core)]
    public sealed class LineRendererEndWidthSegment : LineRendererSegment<float>
    {
        public override IEnumerator GetSequence()
            => renderer.CoEndWidth(target, duration, easer.Evaluate);
    }
}