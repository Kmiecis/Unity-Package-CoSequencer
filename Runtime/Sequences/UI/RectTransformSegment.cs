using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines.Segments
{
    [Serializable]
    public abstract class RectTransformSegment<T> : TimedSegment
    {
        public RectTransform transform;
        public T target;
    }
    
    [SegmentMenu("AnchorMin", SegmentPath.RectTransform, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMinSegment : RectTransformSegment<Vector2>
    {
        public override IEnumerator GetSequence()
            => transform.CoAnchorMin(target, duration, easer.Evaluate);
    }

    [SegmentMenu("AnchorMinBy", SegmentPath.RectTransform, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMinBySegment : RectTransformSegment<Vector2>
    {
        public override IEnumerator GetSequence()
            => transform.CoAnchorMinBy(target, duration, easer.Evaluate);
    }

    [SegmentMenu("AnchorMinX", SegmentPath.RectTransform, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMinXSegment : RectTransformSegment<float>
    {
        public override IEnumerator GetSequence()
            => transform.CoAnchorMinX(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("AnchorMinY", SegmentPath.RectTransform, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMinYSegment : RectTransformSegment<float>
    {
        public override IEnumerator GetSequence()
            => transform.CoAnchorMinY(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("AnchorMax", SegmentPath.RectTransform, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMaxSegment : RectTransformSegment<Vector2>
    {
        public override IEnumerator GetSequence()
            => transform.CoAnchorMax(target, duration, easer.Evaluate);
    }

    [SegmentMenu("AnchorMaxBy", SegmentPath.RectTransform, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMaxBySegment : RectTransformSegment<Vector2>
    {
        public override IEnumerator GetSequence()
            => transform.CoAnchorMaxBy(target, duration, easer.Evaluate);
    }

    [SegmentMenu("AnchorMaxX", SegmentPath.RectTransform, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMaxXSegment : RectTransformSegment<float>
    {
        public override IEnumerator GetSequence()
            => transform.CoAnchorMaxX(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("AnchorMaxY", SegmentPath.RectTransform, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMaxYSegment : RectTransformSegment<float>
    {
        public override IEnumerator GetSequence()
            => transform.CoAnchorMaxY(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("AnchorMove", SegmentPath.RectTransform, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMoveSegment : RectTransformSegment<Vector2>
    {
        public override IEnumerator GetSequence()
            => transform.CoAnchorMove(target, duration, easer.Evaluate);
    }

    [SegmentMenu("AnchorMoveBy", SegmentPath.RectTransform, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMoveBySegment : RectTransformSegment<Vector2>
    {
        public override IEnumerator GetSequence()
            => transform.CoAnchorMoveBy(target, duration, easer.Evaluate);
    }

    [SegmentMenu("AnchorMoveX", SegmentPath.RectTransform, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMoveXSegment : RectTransformSegment<float>
    {
        public override IEnumerator GetSequence()
            => transform.CoAnchorMoveX(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("AnchorMoveY", SegmentPath.RectTransform, SegmentGroup.UI)]
    public sealed class RectTransformAnchorMoveYSegment : RectTransformSegment<float>
    {
        public override IEnumerator GetSequence()
            => transform.CoAnchorMoveY(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("OffsetMin", SegmentPath.RectTransform, SegmentGroup.UI)]
    public sealed class RectTransformOffsetMinSegment : RectTransformSegment<Vector2>
    {
        public override IEnumerator GetSequence()
            => transform.CoOffsetMin(target, duration, easer.Evaluate);
    }

    [SegmentMenu("OffsetMinBy", SegmentPath.RectTransform, SegmentGroup.UI)]
    public sealed class RectTransformOffsetMinBySegment : RectTransformSegment<Vector2>
    {
        public override IEnumerator GetSequence()
            => transform.CoOffsetMinBy(target, duration, easer.Evaluate);
    }

    [SegmentMenu("OffsetMinX", SegmentPath.RectTransform, SegmentGroup.UI)]
    public sealed class RectTransformOffsetMinXSegment : RectTransformSegment<float>
    {
        public override IEnumerator GetSequence()
            => transform.CoOffsetMinX(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("OffsetMinY", SegmentPath.RectTransform, SegmentGroup.UI)]
    public sealed class RectTransformOffsetMinYSegment : RectTransformSegment<float>
    {
        public override IEnumerator GetSequence()
            => transform.CoOffsetMinY(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("OffsetMax", SegmentPath.RectTransform, SegmentGroup.UI)]
    public sealed class RectTransformOffsetMaxSegment : RectTransformSegment<Vector2>
    {
        public override IEnumerator GetSequence()
            => transform.CoOffsetMax(target, duration, easer.Evaluate);
    }

    [SegmentMenu("OffsetMaxBy", SegmentPath.RectTransform, SegmentGroup.UI)]
    public sealed class RectTransformOffsetMaxBySegment : RectTransformSegment<Vector2>
    {
        public override IEnumerator GetSequence()
            => transform.CoOffsetMaxBy(target, duration, easer.Evaluate);
    }

    [SegmentMenu("OffsetMaxX", SegmentPath.RectTransform, SegmentGroup.UI)]
    public sealed class RectTransformOffsetMaxXSegment : RectTransformSegment<float>
    {
        public override IEnumerator GetSequence()
            => transform.CoOffsetMaxX(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("OffsetMaxY", SegmentPath.RectTransform, SegmentGroup.UI)]
    public sealed class RectTransformOffsetMaxYSegment : RectTransformSegment<float>
    {
        public override IEnumerator GetSequence()
            => transform.CoOffsetMaxY(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("Pivot", SegmentPath.RectTransform, SegmentGroup.UI)]
    public sealed class RectTransformPivotSegment : RectTransformSegment<Vector2>
    {
        public override IEnumerator GetSequence()
            => transform.CoPivot(target, duration, easer.Evaluate);
    }

    [SegmentMenu("PivotBy", SegmentPath.RectTransform, SegmentGroup.UI)]
    public sealed class RectTransformPivotBySegment : RectTransformSegment<Vector2>
    {
        public override IEnumerator GetSequence()
            => transform.CoPivotBy(target, duration, easer.Evaluate);
    }

    [SegmentMenu("PivotX", SegmentPath.RectTransform, SegmentGroup.UI)]
    public sealed class RectTransformPivotXSegment : RectTransformSegment<float>
    {
        public override IEnumerator GetSequence()
            => transform.CoPivotX(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("PivotY", SegmentPath.RectTransform, SegmentGroup.UI)]
    public sealed class RectTransformPivotYSegment : RectTransformSegment<float>
    {
        public override IEnumerator GetSequence()
            => transform.CoPivotY(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("SizeDelta", SegmentPath.RectTransform, SegmentGroup.UI)]
    public sealed class RectTransformSizeDeltaSegment : RectTransformSegment<Vector2>
    {
        public override IEnumerator GetSequence()
            => transform.CoSizeDelta(target, duration, easer.Evaluate);
    }

    [SegmentMenu("SizeDeltaBy", SegmentPath.RectTransform, SegmentGroup.UI)]
    public sealed class RectTransformSizeDeltaBySegment : RectTransformSegment<Vector2>
    {
        public override IEnumerator GetSequence()
            => transform.CoSizeDeltaBy(target, duration, easer.Evaluate);
    }

    [SegmentMenu("SizeDeltaX", SegmentPath.RectTransform, SegmentGroup.UI)]
    public sealed class RectTransformSizeDeltaXSegment : RectTransformSegment<float>
    {
        public override IEnumerator GetSequence()
            => transform.CoSizeDeltaX(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("SizeDeltaY", SegmentPath.RectTransform, SegmentGroup.UI)]
    public sealed class RectTransformSizeDeltaYSegment : RectTransformSegment<float>
    {
        public override IEnumerator GetSequence()
            => transform.CoSizeDeltaY(target, duration, easer.Evaluate);
    }
}