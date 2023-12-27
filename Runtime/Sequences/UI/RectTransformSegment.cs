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
    
    [SegmentMenu(nameof(RectTransform), "AnchorMin")]
    public sealed class RectTransformAnchorMinSegment : RectTransformSegment<Vector2>
    {
        public override IEnumerator CoExecute()
            => transform.CoAnchorMin(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(RectTransform), "AnchorMinX")]
    public sealed class RectTransformAnchorMinXSegment : RectTransformSegment<float>
    {
        public override IEnumerator CoExecute()
            => transform.CoAnchorMinX(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(RectTransform), "AnchorMinY")]
    public sealed class RectTransformAnchorMinYSegment : RectTransformSegment<float>
    {
        public override IEnumerator CoExecute()
            => transform.CoAnchorMinY(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(RectTransform), "AnchorMax")]
    public sealed class RectTransformAnchorMaxSegment : RectTransformSegment<Vector2>
    {
        public override IEnumerator CoExecute()
            => transform.CoAnchorMax(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(RectTransform), "AnchorMaxX")]
    public sealed class RectTransformAnchorMaxXSegment : RectTransformSegment<float>
    {
        public override IEnumerator CoExecute()
            => transform.CoAnchorMaxX(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(RectTransform), "AnchorMaxY")]
    public sealed class RectTransformAnchorMaxYSegment : RectTransformSegment<float>
    {
        public override IEnumerator CoExecute()
            => transform.CoAnchorMaxY(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(RectTransform), "AnchorMove")]
    public sealed class RectTransformAnchorMoveSegment : RectTransformSegment<Vector2>
    {
        public override IEnumerator CoExecute()
            => transform.CoAnchorMove(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(RectTransform), "AnchorMoveX")]
    public sealed class RectTransformAnchorMoveXSegment : RectTransformSegment<float>
    {
        public override IEnumerator CoExecute()
            => transform.CoAnchorMoveX(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(RectTransform), "AnchorMoveY")]
    public sealed class RectTransformAnchorMoveYSegment : RectTransformSegment<float>
    {
        public override IEnumerator CoExecute()
            => transform.CoAnchorMoveY(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(RectTransform), "OffsetMin")]
    public sealed class RectTransformOffsetMinSegment : RectTransformSegment<Vector2>
    {
        public override IEnumerator CoExecute()
            => transform.CoOffsetMin(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(RectTransform), "OffsetMinX")]
    public sealed class RectTransformOffsetMinXSegment : RectTransformSegment<float>
    {
        public override IEnumerator CoExecute()
            => transform.CoOffsetMinX(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(RectTransform), "OffsetMinY")]
    public sealed class RectTransformOffsetMinYSegment : RectTransformSegment<float>
    {
        public override IEnumerator CoExecute()
            => transform.CoOffsetMinY(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(RectTransform), "OffsetMax")]
    public sealed class RectTransformOffsetMaxSegment : RectTransformSegment<Vector2>
    {
        public override IEnumerator CoExecute()
            => transform.CoOffsetMax(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(RectTransform), "OffsetMaxX")]
    public sealed class RectTransformOffsetMaxXSegment : RectTransformSegment<float>
    {
        public override IEnumerator CoExecute()
            => transform.CoOffsetMaxX(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(RectTransform), "OffsetMaxY")]
    public sealed class RectTransformOffsetMaxYSegment : RectTransformSegment<float>
    {
        public override IEnumerator CoExecute()
            => transform.CoOffsetMaxY(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(RectTransform), "Pivot")]
    public sealed class RectTransformPivotSegment : RectTransformSegment<Vector2>
    {
        public override IEnumerator CoExecute()
            => transform.CoPivot(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(RectTransform), "PivotX")]
    public sealed class RectTransformPivotXSegment : RectTransformSegment<float>
    {
        public override IEnumerator CoExecute()
            => transform.CoPivotX(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(RectTransform), "PivotY")]
    public sealed class RectTransformPivotYSegment : RectTransformSegment<float>
    {
        public override IEnumerator CoExecute()
            => transform.CoPivotY(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(RectTransform), "SizeDelta")]
    public sealed class RectTransformSizeDeltaSegment : RectTransformSegment<Vector2>
    {
        public override IEnumerator CoExecute()
            => transform.CoSizeDelta(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(RectTransform), "SizeDeltaX")]
    public sealed class RectTransformSizeDeltaXSegment : RectTransformSegment<float>
    {
        public override IEnumerator CoExecute()
            => transform.CoSizeDeltaX(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(RectTransform), "SizeDeltaY")]
    public sealed class RectTransformSizeDeltaYSegment : RectTransformSegment<float>
    {
        public override IEnumerator CoExecute()
            => transform.CoSizeDeltaY(target, duration, easer.Evaluate);
    }
}