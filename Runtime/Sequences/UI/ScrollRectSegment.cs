using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Common.Coroutines.Segments
{
    [Serializable]
    public abstract class ScrollRectSegment<T> : TimedSegment
    {
        public ScrollRect scroll;
        public T target;
    }
    
    [SegmentMenu("Position", SegmentPath.ScrollRect, SegmentGroup.UI)]
    public sealed class ScrollRectPositionSegment : ScrollRectSegment<Vector2>
    {
        public override void OnValidate()
            => target = new Vector2(Mathf.Clamp(target.x, 0.0f, 1.0f), Mathf.Clamp(target.y, 0.0f, 1.0f));
        
        public override IEnumerator GetSequence()
            => scroll.CoPosition(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("HorizontalPosition", SegmentPath.ScrollRect, SegmentGroup.UI)]
    public sealed class ScrollRectHorizontalPositionSegment : ScrollRectSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);
        
        public override IEnumerator GetSequence()
            => scroll.CoHorizontalPosition(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("VerticalPosition", SegmentPath.ScrollRect, SegmentGroup.UI)]
    public sealed class ScrollRectVerticalPositionSegment : ScrollRectSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);
        
        public override IEnumerator GetSequence()
            => scroll.CoVerticalPosition(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("Velocity", SegmentPath.ScrollRect, SegmentGroup.UI)]
    public sealed class ScrollRectVelocitySegment : ScrollRectSegment<Vector2>
    {
        public override IEnumerator GetSequence()
            => scroll.CoVelocity(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("HorizontalVelocity", SegmentPath.ScrollRect, SegmentGroup.UI)]
    public sealed class ScrollRectHorizontalVelocitySegment : ScrollRectSegment<float>
    {
        public override IEnumerator GetSequence()
            => scroll.CoHorizontalVelocity(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("VerticalVelocity", SegmentPath.ScrollRect, SegmentGroup.UI)]
    public sealed class ScrollRectVerticalVelocitySegment : ScrollRectSegment<float>
    {
        public override IEnumerator GetSequence()
            => scroll.CoVerticalVelocity(target, duration, easer.Evaluate);
    }
}