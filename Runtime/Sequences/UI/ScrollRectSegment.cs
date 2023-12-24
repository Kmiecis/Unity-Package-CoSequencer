using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Common.Coroutines
{
    [Serializable]
    public abstract class ScrollRectSegment<T> : TimedSegment
    {
        [SerializeField] protected ScrollRect _scroll;
        [SerializeField] protected T _target;
    }
    
    [SegmentMenu(nameof(ScrollRect), "Position")]
    public sealed class ScrollRectPositionSegment : ScrollRectSegment<Vector2>
    {
        public override void OnValidate()
            => _target = new Vector2(Mathf.Clamp(_target.x, 0.0f, 1.0f), Mathf.Clamp(_target.y, 0.0f, 1.0f));
        
        public override IEnumerator CoExecute()
            => _scroll.CoPosition(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(ScrollRect), "HorizontalPosition")]
    public sealed class ScrollRectHorizontalPositionSegment : ScrollRectSegment<float>
    {
        public override void OnValidate()
            => _target = Mathf.Clamp(_target, 0.0f, 1.0f);
        
        public override IEnumerator CoExecute()
            => _scroll.CoHorizontalPosition(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(ScrollRect), "VerticalPosition")]
    public sealed class ScrollRectVerticalPositionSegment : ScrollRectSegment<float>
    {
        public override void OnValidate()
            => _target = Mathf.Clamp(_target, 0.0f, 1.0f);
        
        public override IEnumerator CoExecute()
            => _scroll.CoVerticalPosition(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(ScrollRect), "Velocity")]
    public sealed class ScrollRectVelocitySegment : ScrollRectSegment<Vector2>
    {
        public override IEnumerator CoExecute()
            => _scroll.CoVelocity(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(ScrollRect), "HorizontalVelocity")]
    public sealed class ScrollRectHorizontalVelocitySegment : ScrollRectSegment<float>
    {
        public override IEnumerator CoExecute()
            => _scroll.CoHorizontalVelocity(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(ScrollRect), "VerticalVelocity")]
    public sealed class ScrollRectVerticalVelocitySegment : ScrollRectSegment<float>
    {
        public override IEnumerator CoExecute()
            => _scroll.CoVerticalVelocity(_target, _duration, _easer.Evaluate);
    }
}