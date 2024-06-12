using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines.Segments
{
    [Serializable]
    public abstract class RectTransformSegment<T> : Segment
    {
        public RectTransform transform;
        public T target;
    }

    [Serializable]
    public abstract class RectTransformTimedSegment<T> : TimedSegment
    {
        public RectTransform transform;
        public T target;
    }

    [Serializable]
    public abstract class RectTransformBetweenSegment<T> : TimedSegment
    {
        public RectTransform transform;
        public T start;
        public T target;
    }

    #region AnchorMin
    [SegmentMenu("Set", SegmentPath.RectTransformAnchorMin, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMinSetSegment : RectTransformSegment<Vector2>
    {
        public override IEnumerator Build()
            => transform.CoAnchorMin(target);
    }

    [SegmentMenu("Towards", SegmentPath.RectTransformAnchorMin, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMinSegment : RectTransformTimedSegment<Vector2>
    {
        public override IEnumerator Build()
            => transform.CoAnchorMin(target, duration, easer.Evaluate);
    }

    [SegmentMenu("Towards X", SegmentPath.RectTransformAnchorMin, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMinXSegment : RectTransformTimedSegment<float>
    {
        public override IEnumerator Build()
            => transform.CoAnchorMinX(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("Towards Y", SegmentPath.RectTransformAnchorMin, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMinYSegment : RectTransformTimedSegment<float>
    {
        public override IEnumerator Build()
            => transform.CoAnchorMinY(target, duration, easer.Evaluate);
    }

    [SegmentMenu("Between", SegmentPath.RectTransformAnchorMin, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMinBetweenSegment : RectTransformBetweenSegment<Vector2>
    {
        public override IEnumerator Build()
            => transform.CoAnchorMin(start, target, duration, easer.Evaluate);
    }

    [SegmentMenu("Between X", SegmentPath.RectTransformAnchorMin, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMinXBetweenSegment : RectTransformBetweenSegment<float>
    {
        public override IEnumerator Build()
            => transform.CoAnchorMinX(start, target, duration, easer.Evaluate);
    }

    [SegmentMenu("Between Y", SegmentPath.RectTransformAnchorMin, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMinYBetweenSegment : RectTransformBetweenSegment<float>
    {
        public override IEnumerator Build()
            => transform.CoAnchorMinY(start, target, duration, easer.Evaluate);
    }

    [SegmentMenu("By", SegmentPath.RectTransformAnchorMin, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMinBySegment : RectTransformTimedSegment<Vector2>
    {
        public override IEnumerator Build()
            => transform.CoAnchorMinBy(target, duration, easer.Evaluate);
    }

    [SegmentMenu("For", SegmentPath.RectTransformAnchorMin, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMinForSegment : RectTransformTimedSegment<Vector2>
    {
        public override IEnumerator Build()
            => transform.CoAnchorMinFor(target, duration, easer.Evaluate);
    }
    #endregion

    #region AnchorMax
    [SegmentMenu("Set", SegmentPath.RectTransformAnchorMax, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMaxSetSegment : RectTransformSegment<Vector2>
    {
        public override IEnumerator Build()
            => transform.CoAnchorMax(target);
    }

    [SegmentMenu("Towards", SegmentPath.RectTransformAnchorMax, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMaxSegment : RectTransformTimedSegment<Vector2>
    {
        public override IEnumerator Build()
            => transform.CoAnchorMax(target, duration, easer.Evaluate);
    }

    [SegmentMenu("Towards X", SegmentPath.RectTransformAnchorMax, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMaxXSegment : RectTransformTimedSegment<float>
    {
        public override IEnumerator Build()
            => transform.CoAnchorMaxX(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("Towards Y", SegmentPath.RectTransformAnchorMax, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMaxYSegment : RectTransformTimedSegment<float>
    {
        public override IEnumerator Build()
            => transform.CoAnchorMaxY(target, duration, easer.Evaluate);
    }

    [SegmentMenu("Between", SegmentPath.RectTransformAnchorMax, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMaxBetweenSegment : RectTransformBetweenSegment<Vector2>
    {
        public override IEnumerator Build()
            => transform.CoAnchorMax(start, target, duration, easer.Evaluate);
    }

    [SegmentMenu("Between X", SegmentPath.RectTransformAnchorMax, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMaxXBetweenSegment : RectTransformBetweenSegment<float>
    {
        public override IEnumerator Build()
            => transform.CoAnchorMaxX(start, target, duration, easer.Evaluate);
    }

    [SegmentMenu("Between Y", SegmentPath.RectTransformAnchorMax, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMaxYBetweenSegment : RectTransformBetweenSegment<float>
    {
        public override IEnumerator Build()
            => transform.CoAnchorMaxY(start, target, duration, easer.Evaluate);
    }

    [SegmentMenu("By", SegmentPath.RectTransformAnchorMax, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMaxBySegment : RectTransformTimedSegment<Vector2>
    {
        public override IEnumerator Build()
            => transform.CoAnchorMaxBy(target, duration, easer.Evaluate);
    }

    [SegmentMenu("For", SegmentPath.RectTransformAnchorMax, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMaxForSegment : RectTransformTimedSegment<Vector2>
    {
        public override IEnumerator Build()
            => transform.CoAnchorMaxFor(target, duration, easer.Evaluate);
    }
    #endregion

    #region AnchorMove
    [SegmentMenu("Set", SegmentPath.RectTransformAnchorMove, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMoveSetSegment : RectTransformSegment<Vector2>
    {
        public override IEnumerator Build()
            => transform.CoAnchorMove(target);
    }

    [SegmentMenu("Towards", SegmentPath.RectTransformAnchorMove, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMoveSegment : RectTransformTimedSegment<Vector2>
    {
        public override IEnumerator Build()
            => transform.CoAnchorMove(target, duration, easer.Evaluate);
    }

    [SegmentMenu("Towards X", SegmentPath.RectTransformAnchorMove, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMoveXSegment : RectTransformTimedSegment<float>
    {
        public override IEnumerator Build()
            => transform.CoAnchorMoveX(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("Towards Y", SegmentPath.RectTransformAnchorMove, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMoveYSegment : RectTransformTimedSegment<float>
    {
        public override IEnumerator Build()
            => transform.CoAnchorMoveY(target, duration, easer.Evaluate);
    }

    [SegmentMenu("Between", SegmentPath.RectTransformAnchorMove, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMoveBetweenSegment : RectTransformBetweenSegment<Vector2>
    {
        public override IEnumerator Build()
            => transform.CoAnchorMove(start, target, duration, easer.Evaluate);
    }

    [SegmentMenu("Between X", SegmentPath.RectTransformAnchorMove, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMoveXBetweenSegment : RectTransformBetweenSegment<float>
    {
        public override IEnumerator Build()
            => transform.CoAnchorMoveX(start, target, duration, easer.Evaluate);
    }

    [SegmentMenu("Between Y", SegmentPath.RectTransformAnchorMove, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMoveYBetweenSegment : RectTransformBetweenSegment<float>
    {
        public override IEnumerator Build()
            => transform.CoAnchorMoveY(start, target, duration, easer.Evaluate);
    }

    [SegmentMenu("By", SegmentPath.RectTransformAnchorMove, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMoveBySegment : RectTransformTimedSegment<Vector2>
    {
        public override IEnumerator Build()
            => transform.CoAnchorMoveBy(target, duration, easer.Evaluate);
    }

    [SegmentMenu("For", SegmentPath.RectTransformAnchorMove, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMoveForSegment : RectTransformTimedSegment<Vector2>
    {
        public override IEnumerator Build()
            => transform.CoAnchorMoveFor(target, duration, easer.Evaluate);
    }
    #endregion

    #region OffsetMin
    [SegmentMenu("Set", SegmentPath.RectTransformOffsetMin, SegmentGroup.UI)]
    public sealed class RectTransformOffsetMinSetSegment : RectTransformSegment<Vector2>
    {
        public override IEnumerator Build()
            => transform.CoOffsetMin(target);
    }

    [SegmentMenu("Towards", SegmentPath.RectTransformOffsetMin, SegmentGroup.UI)]
    public sealed class RectTransformOffsetMinSegment : RectTransformTimedSegment<Vector2>
    {
        public override IEnumerator Build()
            => transform.CoOffsetMin(target, duration, easer.Evaluate);
    }

    [SegmentMenu("Towards X", SegmentPath.RectTransformOffsetMin, SegmentGroup.UI)]
    public sealed class RectTransformOffsetMinXSegment : RectTransformTimedSegment<float>
    {
        public override IEnumerator Build()
            => transform.CoOffsetMinX(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("Towards Y", SegmentPath.RectTransformOffsetMin, SegmentGroup.UI)]
    public sealed class RectTransformOffsetMinYSegment : RectTransformTimedSegment<float>
    {
        public override IEnumerator Build()
            => transform.CoOffsetMinY(target, duration, easer.Evaluate);
    }

    [SegmentMenu("Between", SegmentPath.RectTransformOffsetMin, SegmentGroup.UI)]
    public sealed class RectTransformOffsetMinBetweenSegment : RectTransformBetweenSegment<Vector2>
    {
        public override IEnumerator Build()
            => transform.CoOffsetMin(start, target, duration, easer.Evaluate);
    }

    [SegmentMenu("Between X", SegmentPath.RectTransformOffsetMin, SegmentGroup.UI)]
    public sealed class RectTransformOffsetMinXBetweenSegment : RectTransformBetweenSegment<float>
    {
        public override IEnumerator Build()
            => transform.CoOffsetMinX(start, target, duration, easer.Evaluate);
    }

    [SegmentMenu("Between Y", SegmentPath.RectTransformOffsetMin, SegmentGroup.UI)]
    public sealed class RectTransformOffsetMinYBetweenSegment : RectTransformBetweenSegment<float>
    {
        public override IEnumerator Build()
            => transform.CoOffsetMinY(start, target, duration, easer.Evaluate);
    }

    [SegmentMenu("By", SegmentPath.RectTransformOffsetMin, SegmentGroup.UI)]
    public sealed class RectTransformOffsetMinBySegment : RectTransformTimedSegment<Vector2>
    {
        public override IEnumerator Build()
            => transform.CoOffsetMinBy(target, duration, easer.Evaluate);
    }

    [SegmentMenu("For", SegmentPath.RectTransformOffsetMin, SegmentGroup.UI)]
    public sealed class RectTransformOffsetMinForSegment : RectTransformTimedSegment<Vector2>
    {
        public override IEnumerator Build()
            => transform.CoOffsetMinFor(target, duration, easer.Evaluate);
    }
    #endregion

    #region OffsetMax
    [SegmentMenu("Set", SegmentPath.RectTransformOffsetMax, SegmentGroup.UI)]
    public sealed class RectTransformOffsetMaxSetSegment : RectTransformSegment<Vector2>
    {
        public override IEnumerator Build()
            => transform.CoOffsetMax(target);
    }

    [SegmentMenu("Towards", SegmentPath.RectTransformOffsetMax, SegmentGroup.UI)]
    public sealed class RectTransformOffsetMaxSegment : RectTransformTimedSegment<Vector2>
    {
        public override IEnumerator Build()
            => transform.CoOffsetMax(target, duration, easer.Evaluate);
    }

    [SegmentMenu("Towards X", SegmentPath.RectTransformOffsetMax, SegmentGroup.UI)]
    public sealed class RectTransformOffsetMaxXSegment : RectTransformTimedSegment<float>
    {
        public override IEnumerator Build()
            => transform.CoOffsetMaxX(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("Towards Y", SegmentPath.RectTransformOffsetMax, SegmentGroup.UI)]
    public sealed class RectTransformOffsetMaxYSegment : RectTransformTimedSegment<float>
    {
        public override IEnumerator Build()
            => transform.CoOffsetMaxY(target, duration, easer.Evaluate);
    }

    [SegmentMenu("Between", SegmentPath.RectTransformOffsetMax, SegmentGroup.UI)]
    public sealed class RectTransformOffsetMaxBetweenSegment : RectTransformBetweenSegment<Vector2>
    {
        public override IEnumerator Build()
            => transform.CoOffsetMax(start, target, duration, easer.Evaluate);
    }

    [SegmentMenu("Between X", SegmentPath.RectTransformOffsetMax, SegmentGroup.UI)]
    public sealed class RectTransformOffsetMaxXBetweenSegment : RectTransformBetweenSegment<float>
    {
        public override IEnumerator Build()
            => transform.CoOffsetMaxX(start, target, duration, easer.Evaluate);
    }

    [SegmentMenu("Between Y", SegmentPath.RectTransformOffsetMax, SegmentGroup.UI)]
    public sealed class RectTransformOffsetMaxYBetweenSegment : RectTransformBetweenSegment<float>
    {
        public override IEnumerator Build()
            => transform.CoOffsetMaxY(start, target, duration, easer.Evaluate);
    }

    [SegmentMenu("By", SegmentPath.RectTransformOffsetMax, SegmentGroup.UI)]
    public sealed class RectTransformOffsetMaxBySegment : RectTransformTimedSegment<Vector2>
    {
        public override IEnumerator Build()
            => transform.CoOffsetMaxBy(target, duration, easer.Evaluate);
    }

    [SegmentMenu("For", SegmentPath.RectTransformOffsetMax, SegmentGroup.UI)]
    public sealed class RectTransformOffsetMaxForSegment : RectTransformTimedSegment<Vector2>
    {
        public override IEnumerator Build()
            => transform.CoOffsetMaxFor(target, duration, easer.Evaluate);
    }
    #endregion

    #region Pivot
    [SegmentMenu("Set", SegmentPath.RectTransformPivot, SegmentGroup.UI)]
    public sealed class RectTransformPivotSetSegment : RectTransformSegment<Vector2>
    {
        public override IEnumerator Build()
            => transform.CoPivot(target);
    }

    [SegmentMenu("Towards", SegmentPath.RectTransformPivot, SegmentGroup.UI)]
    public sealed class RectTransformPivotSegment : RectTransformTimedSegment<Vector2>
    {
        public override IEnumerator Build()
            => transform.CoPivot(target, duration, easer.Evaluate);
    }

    [SegmentMenu("Towards X", SegmentPath.RectTransformPivot, SegmentGroup.UI)]
    public sealed class RectTransformPivotXSegment : RectTransformTimedSegment<float>
    {
        public override IEnumerator Build()
            => transform.CoPivotX(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("Towards Y", SegmentPath.RectTransformPivot, SegmentGroup.UI)]
    public sealed class RectTransformPivotYSegment : RectTransformTimedSegment<float>
    {
        public override IEnumerator Build()
            => transform.CoPivotY(target, duration, easer.Evaluate);
    }

    [SegmentMenu("Between", SegmentPath.RectTransformPivot, SegmentGroup.UI)]
    public sealed class RectTransformPivotBetweenSegment : RectTransformBetweenSegment<Vector2>
    {
        public override IEnumerator Build()
            => transform.CoPivot(start, target, duration, easer.Evaluate);
    }

    [SegmentMenu("Between X", SegmentPath.RectTransformPivot, SegmentGroup.UI)]
    public sealed class RectTransformPivotXBetweenSegment : RectTransformBetweenSegment<float>
    {
        public override IEnumerator Build()
            => transform.CoPivotX(start, target, duration, easer.Evaluate);
    }

    [SegmentMenu("Between Y", SegmentPath.RectTransformPivot, SegmentGroup.UI)]
    public sealed class RectTransformPivotYBetweenSegment : RectTransformBetweenSegment<float>
    {
        public override IEnumerator Build()
            => transform.CoPivotY(start, target, duration, easer.Evaluate);
    }

    [SegmentMenu("By", SegmentPath.RectTransformPivot, SegmentGroup.UI)]
    public sealed class RectTransformPivotBySegment : RectTransformTimedSegment<Vector2>
    {
        public override IEnumerator Build()
            => transform.CoPivotBy(target, duration, easer.Evaluate);
    }

    [SegmentMenu("For", SegmentPath.RectTransformPivot, SegmentGroup.UI)]
    public sealed class RectTransformPivotForSegment : RectTransformTimedSegment<Vector2>
    {
        public override IEnumerator Build()
            => transform.CoPivotFor(target, duration, easer.Evaluate);
    }
    #endregion

    #region SizeDelta
    [SegmentMenu("Set", SegmentPath.RectTransformSizeDelta, SegmentGroup.UI)]
    public sealed class RectTransformSizeDeltaSetSegment : RectTransformSegment<Vector2>
    {
        public override IEnumerator Build()
            => transform.CoSizeDelta(target);
    }

    [SegmentMenu("Towards", SegmentPath.RectTransformSizeDelta, SegmentGroup.UI)]
    public sealed class RectTransformSizeDeltaSegment : RectTransformTimedSegment<Vector2>
    {
        public override IEnumerator Build()
            => transform.CoSizeDelta(target, duration, easer.Evaluate);
    }

    [SegmentMenu("Towards X", SegmentPath.RectTransformSizeDelta, SegmentGroup.UI)]
    public sealed class RectTransformSizeDeltaXSegment : RectTransformTimedSegment<float>
    {
        public override IEnumerator Build()
            => transform.CoSizeDeltaX(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("Towards Y", SegmentPath.RectTransformSizeDelta, SegmentGroup.UI)]
    public sealed class RectTransformSizeDeltaYSegment : RectTransformTimedSegment<float>
    {
        public override IEnumerator Build()
            => transform.CoSizeDeltaY(target, duration, easer.Evaluate);
    }

    [SegmentMenu("Between", SegmentPath.RectTransformSizeDelta, SegmentGroup.UI)]
    public sealed class RectTransformSizeDeltaBetweenSegment : RectTransformBetweenSegment<Vector2>
    {
        public override IEnumerator Build()
            => transform.CoSizeDelta(start, target, duration, easer.Evaluate);
    }

    [SegmentMenu("Between X", SegmentPath.RectTransformSizeDelta, SegmentGroup.UI)]
    public sealed class RectTransformSizeDeltaXBetweenSegment : RectTransformBetweenSegment<float>
    {
        public override IEnumerator Build()
            => transform.CoSizeDeltaX(start, target, duration, easer.Evaluate);
    }

    [SegmentMenu("Between Y", SegmentPath.RectTransformSizeDelta, SegmentGroup.UI)]
    public sealed class RectTransformSizeDeltaYBetweenSegment : RectTransformBetweenSegment<float>
    {
        public override IEnumerator Build()
            => transform.CoSizeDeltaY(start, target, duration, easer.Evaluate);
    }

    [SegmentMenu("By", SegmentPath.RectTransformSizeDelta, SegmentGroup.UI)]
    public sealed class RectTransformSizeDeltaBySegment : RectTransformTimedSegment<Vector2>
    {
        public override IEnumerator Build()
            => transform.CoSizeDeltaBy(target, duration, easer.Evaluate);
    }

    [SegmentMenu("For", SegmentPath.RectTransformSizeDelta, SegmentGroup.UI)]
    public sealed class RectTransformSizeDeltaForSegment : RectTransformTimedSegment<Vector2>
    {
        public override IEnumerator Build()
            => transform.CoSizeDeltaFor(target, duration, easer.Evaluate);
    }
    #endregion
}