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
    
    [SegmentMenu(nameof(ScrollRect), "Position")]
    public sealed class ScrollRectPositionSegment : ScrollRectSegment<Vector2>
    {
        public override void OnValidate()
            => target = new Vector2(Mathf.Clamp(target.x, 0.0f, 1.0f), Mathf.Clamp(target.y, 0.0f, 1.0f));
        
        public override IEnumerator CoExecute()
            => scroll.CoPosition(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(ScrollRect), "HorizontalPosition")]
    public sealed class ScrollRectHorizontalPositionSegment : ScrollRectSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);
        
        public override IEnumerator CoExecute()
            => scroll.CoHorizontalPosition(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(ScrollRect), "VerticalPosition")]
    public sealed class ScrollRectVerticalPositionSegment : ScrollRectSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);
        
        public override IEnumerator CoExecute()
            => scroll.CoVerticalPosition(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(ScrollRect), "Velocity")]
    public sealed class ScrollRectVelocitySegment : ScrollRectSegment<Vector2>
    {
        public override IEnumerator CoExecute()
            => scroll.CoVelocity(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(ScrollRect), "HorizontalVelocity")]
    public sealed class ScrollRectHorizontalVelocitySegment : ScrollRectSegment<float>
    {
        public override IEnumerator CoExecute()
            => scroll.CoHorizontalVelocity(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(ScrollRect), "VerticalVelocity")]
    public sealed class ScrollRectVerticalVelocitySegment : ScrollRectSegment<float>
    {
        public override IEnumerator CoExecute()
            => scroll.CoVerticalVelocity(target, duration, easer.Evaluate);
    }
}