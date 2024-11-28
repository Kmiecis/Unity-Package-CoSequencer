using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Common.Coroutines.Segments
{
    #region Position
    [Serializable]
    [SegmentMenu("Set", SegmentPath.ScrollRectPosition, SegmentGroup.UI)]
    public sealed class ScrollRectPositionSetSegment : SetSegment<ScrollRect, Vector2>
    {
        public override void OnValidate()
            => target = new Vector2(Mathf.Clamp(target.x, 0.0f, 1.0f), Mathf.Clamp(target.y, 0.0f, 1.0f));

        public override IEnumerator Build()
            => component.CoPosition(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.ScrollRectPosition, SegmentGroup.UI)]
    public sealed class ScrollRectPositionSegment : TowardsSegment<ScrollRect, Vector2>
    {
        public override void OnValidate()
            => target = new Vector2(Mathf.Clamp(target.x, 0.0f, 1.0f), Mathf.Clamp(target.y, 0.0f, 1.0f));
        
        public override IEnumerator Build()
            => component.CoPosition(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.ScrollRectPosition, SegmentGroup.UI)]
    public sealed class ScrollRectPositionBetweenSegment : BetweenSegment<ScrollRect, Vector2>
    {
        public override void OnValidate()
        {
            start = new Vector2(Mathf.Clamp(start.x, 0.0f, 1.0f), Mathf.Clamp(start.y, 0.0f, 1.0f));
            target = new Vector2(Mathf.Clamp(target.x, 0.0f, 1.0f), Mathf.Clamp(target.y, 0.0f, 1.0f));
        }

        public override IEnumerator Build()
            => component.CoPosition(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region HorizontalPosition
    [Serializable]
    [SegmentMenu("Set", SegmentPath.ScrollRectHorizontalPosition, SegmentGroup.UI)]
    public sealed class ScrollRectHorizontalPositionSetSegment : SetSegment<ScrollRect, float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator Build()
            => component.CoHorizontalPosition(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.ScrollRectHorizontalPosition, SegmentGroup.UI)]
    public sealed class ScrollRectHorizontalPositionSegment : TowardsSegment<ScrollRect, float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);
        
        public override IEnumerator Build()
            => component.CoHorizontalPosition(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.ScrollRectHorizontalPosition, SegmentGroup.UI)]
    public sealed class ScrollRectHorizontalPositionBetweenSegment : BetweenSegment<ScrollRect, float>
    {
        public override void OnValidate()
        {
            start = Mathf.Clamp(start, 0.0f, 1.0f);
            target = Mathf.Clamp(target, 0.0f, 1.0f);
        }

        public override IEnumerator Build()
            => component.CoHorizontalPosition(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region VerticalPosition
    [Serializable]
    [SegmentMenu("Set", SegmentPath.ScrollRectVerticalPosition, SegmentGroup.UI)]
    public sealed class ScrollRectVerticalPositionSetSegment : SetSegment<ScrollRect, float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator Build()
            => component.CoVerticalPosition(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.ScrollRectVerticalPosition, SegmentGroup.UI)]
    public sealed class ScrollRectVerticalPositionSegment : TowardsSegment<ScrollRect, float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);
        
        public override IEnumerator Build()
            => component.CoVerticalPosition(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.ScrollRectVerticalPosition, SegmentGroup.UI)]
    public sealed class ScrollRectVerticalPositionBetweenSegment : BetweenSegment<ScrollRect, float>
    {
        public override void OnValidate()
        {
            start = Mathf.Clamp(start, 0.0f, 1.0f);
            target = Mathf.Clamp(target, 0.0f, 1.0f);
        }

        public override IEnumerator Build()
            => component.CoVerticalPosition(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region Velocity
    [Serializable]
    [SegmentMenu("Set", SegmentPath.ScrollRectVelocity, SegmentGroup.UI)]
    public sealed class ScrollRectVelocitySetSegment : SetSegment<ScrollRect, Vector2>
    {
        public override IEnumerator Build()
            => component.CoVelocity(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.ScrollRectVelocity, SegmentGroup.UI)]
    public sealed class ScrollRectVelocitySegment : TowardsSegment<ScrollRect, Vector2>
    {
        public override IEnumerator Build()
            => component.CoVelocity(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.ScrollRectVelocity, SegmentGroup.UI)]
    public sealed class ScrollRectVelocityBetweenSegment : BetweenSegment<ScrollRect, Vector2>
    {
        public override IEnumerator Build()
            => component.CoVelocity(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region HorizontalVelocity
    [Serializable]
    [SegmentMenu("Set", SegmentPath.ScrollRectHorizontalVelocity, SegmentGroup.UI)]
    public sealed class ScrollRectHorizontalVelocitySetSegment : SetSegment<ScrollRect, float>
    {
        public override IEnumerator Build()
            => component.CoHorizontalVelocity(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.ScrollRectHorizontalVelocity, SegmentGroup.UI)]
    public sealed class ScrollRectHorizontalVelocitySegment : TowardsSegment<ScrollRect, float>
    {
        public override IEnumerator Build()
            => component.CoHorizontalVelocity(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.ScrollRectHorizontalVelocity, SegmentGroup.UI)]
    public sealed class ScrollRectHorizontalVelocityBetweenSegment : BetweenSegment<ScrollRect, float>
    {
        public override IEnumerator Build()
            => component.CoHorizontalVelocity(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region VerticalVelocity
    [Serializable]
    [SegmentMenu("Set", SegmentPath.ScrollRectVerticalVelocity, SegmentGroup.UI)]
    public sealed class ScrollRectVerticalVelocitySetSegment : SetSegment<ScrollRect, float>
    {
        public override IEnumerator Build()
            => component.CoVerticalVelocity(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.ScrollRectVerticalVelocity, SegmentGroup.UI)]
    public sealed class ScrollRectVerticalVelocitySegment : TowardsSegment<ScrollRect, float>
    {
        public override IEnumerator Build()
            => component.CoVerticalVelocity(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.ScrollRectVerticalVelocity, SegmentGroup.UI)]
    public sealed class ScrollRectVerticalVelocityBetweenSegment : BetweenSegment<ScrollRect, float>
    {
        public override IEnumerator Build()
            => component.CoVerticalVelocity(start, target, duration, easer.Evaluate);
    }
    #endregion
}