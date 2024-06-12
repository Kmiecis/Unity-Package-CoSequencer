using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Common.Coroutines.Segments
{
    [Serializable]
    public abstract class ScrollRectSegment<T> : Segment
    {
        public ScrollRect scroll;
        public T target;
    }

    [Serializable]
    public abstract class ScrollRectTimedSegment<T> : TimedSegment
    {
        public ScrollRect scroll;
        public T target;
    }

    [Serializable]
    public abstract class ScrollRectBetweenSegment<T> : TimedSegment
    {
        public ScrollRect scroll;
        public T start;
        public T target;
    }

    #region Position
    [SegmentMenu("Towards", SegmentPath.ScrollRectPosition, SegmentGroup.UI)]
    public sealed class ScrollRectPositionSegment : ScrollRectTimedSegment<Vector2>
    {
        public override void OnValidate()
            => target = new Vector2(Mathf.Clamp(target.x, 0.0f, 1.0f), Mathf.Clamp(target.y, 0.0f, 1.0f));
        
        public override IEnumerator Build()
            => scroll.CoPosition(target, duration, easer.Evaluate);
    }

    [SegmentMenu("Set", SegmentPath.ScrollRectPosition, SegmentGroup.UI)]
    public sealed class ScrollRectPositionSetSegment : ScrollRectSegment<Vector2>
    {
        public override void OnValidate()
            => target = new Vector2(Mathf.Clamp(target.x, 0.0f, 1.0f), Mathf.Clamp(target.y, 0.0f, 1.0f));

        public override IEnumerator Build()
            => scroll.CoPosition(target);
    }

    [SegmentMenu("Between", SegmentPath.ScrollRectPosition, SegmentGroup.UI)]
    public sealed class ScrollRectPositionBetweenSegment : ScrollRectBetweenSegment<Vector2>
    {
        public override void OnValidate()
        {
            start = new Vector2(Mathf.Clamp(start.x, 0.0f, 1.0f), Mathf.Clamp(start.y, 0.0f, 1.0f));
            target = new Vector2(Mathf.Clamp(target.x, 0.0f, 1.0f), Mathf.Clamp(target.y, 0.0f, 1.0f));
        }

        public override IEnumerator Build()
            => scroll.CoPosition(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region HorizontalPosition
    [SegmentMenu("Towards", SegmentPath.ScrollRectHorizontalPosition, SegmentGroup.UI)]
    public sealed class ScrollRectHorizontalPositionSegment : ScrollRectTimedSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);
        
        public override IEnumerator Build()
            => scroll.CoHorizontalPosition(target, duration, easer.Evaluate);
    }

    [SegmentMenu("Set", SegmentPath.ScrollRectHorizontalPosition, SegmentGroup.UI)]
    public sealed class ScrollRectHorizontalPositionSetSegment : ScrollRectSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator Build()
            => scroll.CoHorizontalPosition(target);
    }

    [SegmentMenu("Between", SegmentPath.ScrollRectHorizontalPosition, SegmentGroup.UI)]
    public sealed class ScrollRectHorizontalPositionBetweenSegment : ScrollRectBetweenSegment<float>
    {
        public override void OnValidate()
        {
            start = Mathf.Clamp(start, 0.0f, 1.0f);
            target = Mathf.Clamp(target, 0.0f, 1.0f);
        }

        public override IEnumerator Build()
            => scroll.CoHorizontalPosition(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region VerticalPosition
    [SegmentMenu("Towards", SegmentPath.ScrollRectVerticalPosition, SegmentGroup.UI)]
    public sealed class ScrollRectVerticalPositionSegment : ScrollRectTimedSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);
        
        public override IEnumerator Build()
            => scroll.CoVerticalPosition(target, duration, easer.Evaluate);
    }

    [SegmentMenu("Set", SegmentPath.ScrollRectVerticalPosition, SegmentGroup.UI)]
    public sealed class ScrollRectVerticalPositionSetSegment : ScrollRectSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator Build()
            => scroll.CoVerticalPosition(target);
    }

    [SegmentMenu("Between", SegmentPath.ScrollRectVerticalPosition, SegmentGroup.UI)]
    public sealed class ScrollRectVerticalPositionBetweenSegment : ScrollRectBetweenSegment<float>
    {
        public override void OnValidate()
        {
            start = Mathf.Clamp(start, 0.0f, 1.0f);
            target = Mathf.Clamp(target, 0.0f, 1.0f);
        }

        public override IEnumerator Build()
            => scroll.CoVerticalPosition(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region Velocity
    [SegmentMenu("Towards", SegmentPath.ScrollRectVelocity, SegmentGroup.UI)]
    public sealed class ScrollRectVelocitySegment : ScrollRectTimedSegment<Vector2>
    {
        public override IEnumerator Build()
            => scroll.CoVelocity(target, duration, easer.Evaluate);
    }

    [SegmentMenu("Set", SegmentPath.ScrollRectVelocity, SegmentGroup.UI)]
    public sealed class ScrollRectVelocitySetSegment : ScrollRectSegment<Vector2>
    {
        public override IEnumerator Build()
            => scroll.CoVelocity(target);
    }

    [SegmentMenu("Between", SegmentPath.ScrollRectVelocity, SegmentGroup.UI)]
    public sealed class ScrollRectVelocityBetweenSegment : ScrollRectBetweenSegment<Vector2>
    {
        public override IEnumerator Build()
            => scroll.CoVelocity(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region HorizontalVelocity
    [SegmentMenu("Towards", SegmentPath.ScrollRectHorizontalVelocity, SegmentGroup.UI)]
    public sealed class ScrollRectHorizontalVelocitySegment : ScrollRectTimedSegment<float>
    {
        public override IEnumerator Build()
            => scroll.CoHorizontalVelocity(target, duration, easer.Evaluate);
    }

    [SegmentMenu("Set", SegmentPath.ScrollRectHorizontalVelocity, SegmentGroup.UI)]
    public sealed class ScrollRectHorizontalVelocitySetSegment : ScrollRectSegment<float>
    {
        public override IEnumerator Build()
            => scroll.CoHorizontalVelocity(target);
    }

    [SegmentMenu("Between", SegmentPath.ScrollRectHorizontalVelocity, SegmentGroup.UI)]
    public sealed class ScrollRectHorizontalVelocityBetweenSegment : ScrollRectBetweenSegment<float>
    {
        public override IEnumerator Build()
            => scroll.CoHorizontalVelocity(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region VerticalVelocity
    [SegmentMenu("Towards", SegmentPath.ScrollRectVerticalVelocity, SegmentGroup.UI)]
    public sealed class ScrollRectVerticalVelocitySegment : ScrollRectTimedSegment<float>
    {
        public override IEnumerator Build()
            => scroll.CoVerticalVelocity(target, duration, easer.Evaluate);
    }

    [SegmentMenu("Set", SegmentPath.ScrollRectVerticalVelocity, SegmentGroup.UI)]
    public sealed class ScrollRectVerticalVelocitySetSegment : ScrollRectSegment<float>
    {
        public override IEnumerator Build()
            => scroll.CoVerticalVelocity(target);
    }

    [SegmentMenu("Between", SegmentPath.ScrollRectVerticalVelocity, SegmentGroup.UI)]
    public sealed class ScrollRectVerticalVelocityBetweenSegment : ScrollRectBetweenSegment<float>
    {
        public override IEnumerator Build()
            => scroll.CoVerticalVelocity(start, target, duration, easer.Evaluate);
    }
    #endregion
}