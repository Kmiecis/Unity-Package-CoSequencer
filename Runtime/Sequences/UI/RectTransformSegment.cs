using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines.Segments
{
    #region AnchorMin
    [Serializable]
    [SegmentMenu("Set", SegmentPath.RectTransformAnchorMin, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMinSetSegment : SetSegment<RectTransform, Vector2>
    {
        public override IEnumerator Build()
            => component.CoAnchorMin(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.RectTransformAnchorMin, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMinSegment : TowardsSegment<RectTransform, Vector2>
    {
        public override IEnumerator Build()
            => component.CoAnchorMin(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Towards X", SegmentPath.RectTransformAnchorMin, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMinXSegment : TowardsSegment<RectTransform, float>
    {
        public override IEnumerator Build()
            => component.CoAnchorMinX(target, duration, easer.Evaluate);
    }
    
    [Serializable]
    [SegmentMenu("Towards Y", SegmentPath.RectTransformAnchorMin, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMinYSegment : TowardsSegment<RectTransform, float>
    {
        public override IEnumerator Build()
            => component.CoAnchorMinY(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.RectTransformAnchorMin, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMinBetweenSegment : BetweenSegment<RectTransform, Vector2>
    {
        public override IEnumerator Build()
            => component.CoAnchorMin(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between X", SegmentPath.RectTransformAnchorMin, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMinXBetweenSegment : BetweenSegment<RectTransform, float>
    {
        public override IEnumerator Build()
            => component.CoAnchorMinX(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between Y", SegmentPath.RectTransformAnchorMin, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMinYBetweenSegment : BetweenSegment<RectTransform, float>
    {
        public override IEnumerator Build()
            => component.CoAnchorMinY(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("By", SegmentPath.RectTransformAnchorMin, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMinBySegment : TowardsSegment<RectTransform, Vector2>
    {
        public override IEnumerator Build()
            => component.CoAnchorMinBy(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("For", SegmentPath.RectTransformAnchorMin, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMinForSegment : TowardsSegment<RectTransform, Vector2>
    {
        public override IEnumerator Build()
            => component.CoAnchorMinFor(target, duration, easer.Evaluate);
    }
    #endregion

    #region AnchorMax
    [Serializable]
    [SegmentMenu("Set", SegmentPath.RectTransformAnchorMax, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMaxSetSegment : SetSegment<RectTransform, Vector2>
    {
        public override IEnumerator Build()
            => component.CoAnchorMax(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.RectTransformAnchorMax, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMaxSegment : TowardsSegment<RectTransform, Vector2>
    {
        public override IEnumerator Build()
            => component.CoAnchorMax(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Towards X", SegmentPath.RectTransformAnchorMax, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMaxXSegment : TowardsSegment<RectTransform, float>
    {
        public override IEnumerator Build()
            => component.CoAnchorMaxX(target, duration, easer.Evaluate);
    }
    
    [Serializable]
    [SegmentMenu("Towards Y", SegmentPath.RectTransformAnchorMax, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMaxYSegment : TowardsSegment<RectTransform, float>
    {
        public override IEnumerator Build()
            => component.CoAnchorMaxY(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.RectTransformAnchorMax, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMaxBetweenSegment : BetweenSegment<RectTransform, Vector2>
    {
        public override IEnumerator Build()
            => component.CoAnchorMax(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between X", SegmentPath.RectTransformAnchorMax, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMaxXBetweenSegment : BetweenSegment<RectTransform, float>
    {
        public override IEnumerator Build()
            => component.CoAnchorMaxX(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between Y", SegmentPath.RectTransformAnchorMax, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMaxYBetweenSegment : BetweenSegment<RectTransform, float>
    {
        public override IEnumerator Build()
            => component.CoAnchorMaxY(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("By", SegmentPath.RectTransformAnchorMax, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMaxBySegment : TowardsSegment<RectTransform, Vector2>
    {
        public override IEnumerator Build()
            => component.CoAnchorMaxBy(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("For", SegmentPath.RectTransformAnchorMax, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMaxForSegment : TowardsSegment<RectTransform, Vector2>
    {
        public override IEnumerator Build()
            => component.CoAnchorMaxFor(target, duration, easer.Evaluate);
    }
    #endregion

    #region AnchorMove
    [Serializable]
    [SegmentMenu("Set", SegmentPath.RectTransformAnchorMove, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMoveSetSegment : SetSegment<RectTransform, Vector2>
    {
        public override IEnumerator Build()
            => component.CoAnchorMove(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.RectTransformAnchorMove, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMoveSegment : TowardsSegment<RectTransform, Vector2>
    {
        public override IEnumerator Build()
            => component.CoAnchorMove(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Towards X", SegmentPath.RectTransformAnchorMove, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMoveXSegment : TowardsSegment<RectTransform, float>
    {
        public override IEnumerator Build()
            => component.CoAnchorMoveX(target, duration, easer.Evaluate);
    }
    
    [Serializable]
    [SegmentMenu("Towards Y", SegmentPath.RectTransformAnchorMove, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMoveYSegment : TowardsSegment<RectTransform, float>
    {
        public override IEnumerator Build()
            => component.CoAnchorMoveY(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.RectTransformAnchorMove, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMoveBetweenSegment : BetweenSegment<RectTransform, Vector2>
    {
        public override IEnumerator Build()
            => component.CoAnchorMove(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between X", SegmentPath.RectTransformAnchorMove, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMoveXBetweenSegment : BetweenSegment<RectTransform, float>
    {
        public override IEnumerator Build()
            => component.CoAnchorMoveX(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between Y", SegmentPath.RectTransformAnchorMove, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMoveYBetweenSegment : BetweenSegment<RectTransform, float>
    {
        public override IEnumerator Build()
            => component.CoAnchorMoveY(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("By", SegmentPath.RectTransformAnchorMove, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMoveBySegment : TowardsSegment<RectTransform, Vector2>
    {
        public override IEnumerator Build()
            => component.CoAnchorMoveBy(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("For", SegmentPath.RectTransformAnchorMove, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMoveForSegment : TowardsSegment<RectTransform, Vector2>
    {
        public override IEnumerator Build()
            => component.CoAnchorMoveFor(target, duration, easer.Evaluate);
    }
    #endregion

    #region OffsetMin
    [Serializable]
    [SegmentMenu("Set", SegmentPath.RectTransformOffsetMin, SegmentGroup.UI)]
    public sealed class RectTransformOffsetMinSetSegment : SetSegment<RectTransform, Vector2>
    {
        public override IEnumerator Build()
            => component.CoOffsetMin(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.RectTransformOffsetMin, SegmentGroup.UI)]
    public sealed class RectTransformOffsetMinSegment : TowardsSegment<RectTransform, Vector2>
    {
        public override IEnumerator Build()
            => component.CoOffsetMin(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Towards X", SegmentPath.RectTransformOffsetMin, SegmentGroup.UI)]
    public sealed class RectTransformOffsetMinXSegment : TowardsSegment<RectTransform, float>
    {
        public override IEnumerator Build()
            => component.CoOffsetMinX(target, duration, easer.Evaluate);
    }
    
    [Serializable]
    [SegmentMenu("Towards Y", SegmentPath.RectTransformOffsetMin, SegmentGroup.UI)]
    public sealed class RectTransformOffsetMinYSegment : TowardsSegment<RectTransform, float>
    {
        public override IEnumerator Build()
            => component.CoOffsetMinY(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.RectTransformOffsetMin, SegmentGroup.UI)]
    public sealed class RectTransformOffsetMinBetweenSegment : BetweenSegment<RectTransform, Vector2>
    {
        public override IEnumerator Build()
            => component.CoOffsetMin(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between X", SegmentPath.RectTransformOffsetMin, SegmentGroup.UI)]
    public sealed class RectTransformOffsetMinXBetweenSegment : BetweenSegment<RectTransform, float>
    {
        public override IEnumerator Build()
            => component.CoOffsetMinX(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between Y", SegmentPath.RectTransformOffsetMin, SegmentGroup.UI)]
    public sealed class RectTransformOffsetMinYBetweenSegment : BetweenSegment<RectTransform, float>
    {
        public override IEnumerator Build()
            => component.CoOffsetMinY(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("By", SegmentPath.RectTransformOffsetMin, SegmentGroup.UI)]
    public sealed class RectTransformOffsetMinBySegment : TowardsSegment<RectTransform, Vector2>
    {
        public override IEnumerator Build()
            => component.CoOffsetMinBy(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("For", SegmentPath.RectTransformOffsetMin, SegmentGroup.UI)]
    public sealed class RectTransformOffsetMinForSegment : TowardsSegment<RectTransform, Vector2>
    {
        public override IEnumerator Build()
            => component.CoOffsetMinFor(target, duration, easer.Evaluate);
    }
    #endregion

    #region OffsetMax
    [Serializable]
    [SegmentMenu("Set", SegmentPath.RectTransformOffsetMax, SegmentGroup.UI)]
    public sealed class RectTransformOffsetMaxSetSegment : SetSegment<RectTransform, Vector2>
    {
        public override IEnumerator Build()
            => component.CoOffsetMax(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.RectTransformOffsetMax, SegmentGroup.UI)]
    public sealed class RectTransformOffsetMaxSegment : TowardsSegment<RectTransform, Vector2>
    {
        public override IEnumerator Build()
            => component.CoOffsetMax(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Towards X", SegmentPath.RectTransformOffsetMax, SegmentGroup.UI)]
    public sealed class RectTransformOffsetMaxXSegment : TowardsSegment<RectTransform, float>
    {
        public override IEnumerator Build()
            => component.CoOffsetMaxX(target, duration, easer.Evaluate);
    }
    
    [Serializable]
    [SegmentMenu("Towards Y", SegmentPath.RectTransformOffsetMax, SegmentGroup.UI)]
    public sealed class RectTransformOffsetMaxYSegment : TowardsSegment<RectTransform, float>
    {
        public override IEnumerator Build()
            => component.CoOffsetMaxY(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.RectTransformOffsetMax, SegmentGroup.UI)]
    public sealed class RectTransformOffsetMaxBetweenSegment : BetweenSegment<RectTransform, Vector2>
    {
        public override IEnumerator Build()
            => component.CoOffsetMax(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between X", SegmentPath.RectTransformOffsetMax, SegmentGroup.UI)]
    public sealed class RectTransformOffsetMaxXBetweenSegment : BetweenSegment<RectTransform, float>
    {
        public override IEnumerator Build()
            => component.CoOffsetMaxX(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between Y", SegmentPath.RectTransformOffsetMax, SegmentGroup.UI)]
    public sealed class RectTransformOffsetMaxYBetweenSegment : BetweenSegment<RectTransform, float>
    {
        public override IEnumerator Build()
            => component.CoOffsetMaxY(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("By", SegmentPath.RectTransformOffsetMax, SegmentGroup.UI)]
    public sealed class RectTransformOffsetMaxBySegment : TowardsSegment<RectTransform, Vector2>
    {
        public override IEnumerator Build()
            => component.CoOffsetMaxBy(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("For", SegmentPath.RectTransformOffsetMax, SegmentGroup.UI)]
    public sealed class RectTransformOffsetMaxForSegment : TowardsSegment<RectTransform, Vector2>
    {
        public override IEnumerator Build()
            => component.CoOffsetMaxFor(target, duration, easer.Evaluate);
    }
    #endregion

    #region Pivot
    [Serializable]
    [SegmentMenu("Set", SegmentPath.RectTransformPivot, SegmentGroup.UI)]
    public sealed class RectTransformPivotSetSegment : SetSegment<RectTransform, Vector2>
    {
        public override IEnumerator Build()
            => component.CoPivot(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.RectTransformPivot, SegmentGroup.UI)]
    public sealed class RectTransformPivotSegment : TowardsSegment<RectTransform, Vector2>
    {
        public override IEnumerator Build()
            => component.CoPivot(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Towards X", SegmentPath.RectTransformPivot, SegmentGroup.UI)]
    public sealed class RectTransformPivotXSegment : TowardsSegment<RectTransform, float>
    {
        public override IEnumerator Build()
            => component.CoPivotX(target, duration, easer.Evaluate);
    }
    
    [Serializable]
    [SegmentMenu("Towards Y", SegmentPath.RectTransformPivot, SegmentGroup.UI)]
    public sealed class RectTransformPivotYSegment : TowardsSegment<RectTransform, float>
    {
        public override IEnumerator Build()
            => component.CoPivotY(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.RectTransformPivot, SegmentGroup.UI)]
    public sealed class RectTransformPivotBetweenSegment : BetweenSegment<RectTransform, Vector2>
    {
        public override IEnumerator Build()
            => component.CoPivot(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between X", SegmentPath.RectTransformPivot, SegmentGroup.UI)]
    public sealed class RectTransformPivotXBetweenSegment : BetweenSegment<RectTransform, float>
    {
        public override IEnumerator Build()
            => component.CoPivotX(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between Y", SegmentPath.RectTransformPivot, SegmentGroup.UI)]
    public sealed class RectTransformPivotYBetweenSegment : BetweenSegment<RectTransform, float>
    {
        public override IEnumerator Build()
            => component.CoPivotY(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("By", SegmentPath.RectTransformPivot, SegmentGroup.UI)]
    public sealed class RectTransformPivotBySegment : TowardsSegment<RectTransform, Vector2>
    {
        public override IEnumerator Build()
            => component.CoPivotBy(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("For", SegmentPath.RectTransformPivot, SegmentGroup.UI)]
    public sealed class RectTransformPivotForSegment : TowardsSegment<RectTransform, Vector2>
    {
        public override IEnumerator Build()
            => component.CoPivotFor(target, duration, easer.Evaluate);
    }
    #endregion

    #region SizeDelta
    [Serializable]
    [SegmentMenu("Set", SegmentPath.RectTransformSizeDelta, SegmentGroup.UI)]
    public sealed class RectTransformSizeDeltaSetSegment : SetSegment<RectTransform, Vector2>
    {
        public override IEnumerator Build()
            => component.CoSizeDelta(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.RectTransformSizeDelta, SegmentGroup.UI)]
    public sealed class RectTransformSizeDeltaSegment : TowardsSegment<RectTransform, Vector2>
    {
        public override IEnumerator Build()
            => component.CoSizeDelta(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Towards X", SegmentPath.RectTransformSizeDelta, SegmentGroup.UI)]
    public sealed class RectTransformSizeDeltaXSegment : TowardsSegment<RectTransform, float>
    {
        public override IEnumerator Build()
            => component.CoSizeDeltaX(target, duration, easer.Evaluate);
    }
    
    [Serializable]
    [SegmentMenu("Towards Y", SegmentPath.RectTransformSizeDelta, SegmentGroup.UI)]
    public sealed class RectTransformSizeDeltaYSegment : TowardsSegment<RectTransform, float>
    {
        public override IEnumerator Build()
            => component.CoSizeDeltaY(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.RectTransformSizeDelta, SegmentGroup.UI)]
    public sealed class RectTransformSizeDeltaBetweenSegment : BetweenSegment<RectTransform, Vector2>
    {
        public override IEnumerator Build()
            => component.CoSizeDelta(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between X", SegmentPath.RectTransformSizeDelta, SegmentGroup.UI)]
    public sealed class RectTransformSizeDeltaXBetweenSegment : BetweenSegment<RectTransform, float>
    {
        public override IEnumerator Build()
            => component.CoSizeDeltaX(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between Y", SegmentPath.RectTransformSizeDelta, SegmentGroup.UI)]
    public sealed class RectTransformSizeDeltaYBetweenSegment : BetweenSegment<RectTransform, float>
    {
        public override IEnumerator Build()
            => component.CoSizeDeltaY(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("By", SegmentPath.RectTransformSizeDelta, SegmentGroup.UI)]
    public sealed class RectTransformSizeDeltaBySegment : TowardsSegment<RectTransform, Vector2>
    {
        public override IEnumerator Build()
            => component.CoSizeDeltaBy(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("For", SegmentPath.RectTransformSizeDelta, SegmentGroup.UI)]
    public sealed class RectTransformSizeDeltaForSegment : TowardsSegment<RectTransform, Vector2>
    {
        public override IEnumerator Build()
            => component.CoSizeDeltaFor(target, duration, easer.Evaluate);
    }
    #endregion
}