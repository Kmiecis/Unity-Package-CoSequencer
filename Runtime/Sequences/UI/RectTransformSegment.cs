using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines
{
    [Serializable]
    public abstract class RectTransformSegment<T> : Segment
    {
        [SerializeField] protected RectTransform _transform;
        [SerializeField] protected T _target;
    }
    
    [SegmentMenu(nameof(RectTransform), "AnchorMin")]
    public sealed class RectTransformAnchorMinSegment : RectTransformSegment<Vector2>
    {
        public override IEnumerator CoExecute()
            => _transform.CoAnchorMin(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(RectTransform), "AnchorMinX")]
    public sealed class RectTransformAnchorMinXSegment : RectTransformSegment<float>
    {
        public override IEnumerator CoExecute()
            => _transform.CoAnchorMinX(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(RectTransform), "AnchorMinY")]
    public sealed class RectTransformAnchorMinYSegment : RectTransformSegment<float>
    {
        public override IEnumerator CoExecute()
            => _transform.CoAnchorMinY(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(RectTransform), "AnchorMax")]
    public sealed class RectTransformAnchorMaxSegment : RectTransformSegment<Vector2>
    {
        public override IEnumerator CoExecute()
            => _transform.CoAnchorMax(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(RectTransform), "AnchorMaxX")]
    public sealed class RectTransformAnchorMaxXSegment : RectTransformSegment<float>
    {
        public override IEnumerator CoExecute()
            => _transform.CoAnchorMaxX(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(RectTransform), "AnchorMaxY")]
    public sealed class RectTransformAnchorMaxYSegment : RectTransformSegment<float>
    {
        public override IEnumerator CoExecute()
            => _transform.CoAnchorMaxY(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(RectTransform), "AnchorMove")]
    public sealed class RectTransformAnchorMoveSegment : RectTransformSegment<Vector2>
    {
        public override IEnumerator CoExecute()
            => _transform.CoAnchorMove(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(RectTransform), "AnchorMoveX")]
    public sealed class RectTransformAnchorMoveXSegment : RectTransformSegment<float>
    {
        public override IEnumerator CoExecute()
            => _transform.CoAnchorMoveX(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(RectTransform), "AnchorMoveY")]
    public sealed class RectTransformAnchorMoveYSegment : RectTransformSegment<float>
    {
        public override IEnumerator CoExecute()
            => _transform.CoAnchorMoveY(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(RectTransform), "OffsetMin")]
    public sealed class RectTransformOffsetMinSegment : RectTransformSegment<Vector2>
    {
        public override IEnumerator CoExecute()
            => _transform.CoOffsetMin(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(RectTransform), "OffsetMinX")]
    public sealed class RectTransformOffsetMinXSegment : RectTransformSegment<float>
    {
        public override IEnumerator CoExecute()
            => _transform.CoOffsetMinX(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(RectTransform), "OffsetMinY")]
    public sealed class RectTransformOffsetMinYSegment : RectTransformSegment<float>
    {
        public override IEnumerator CoExecute()
            => _transform.CoOffsetMinY(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(RectTransform), "OffsetMax")]
    public sealed class RectTransformOffsetMaxSegment : RectTransformSegment<Vector2>
    {
        public override IEnumerator CoExecute()
            => _transform.CoOffsetMax(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(RectTransform), "OffsetMaxX")]
    public sealed class RectTransformOffsetMaxXSegment : RectTransformSegment<float>
    {
        public override IEnumerator CoExecute()
            => _transform.CoOffsetMaxX(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(RectTransform), "OffsetMaxY")]
    public sealed class RectTransformOffsetMaxYSegment : RectTransformSegment<float>
    {
        public override IEnumerator CoExecute()
            => _transform.CoOffsetMaxY(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(RectTransform), "Pivot")]
    public sealed class RectTransformPivotSegment : RectTransformSegment<Vector2>
    {
        public override IEnumerator CoExecute()
            => _transform.CoPivot(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(RectTransform), "PivotX")]
    public sealed class RectTransformPivotXSegment : RectTransformSegment<float>
    {
        public override IEnumerator CoExecute()
            => _transform.CoPivotX(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(RectTransform), "PivotY")]
    public sealed class RectTransformPivotYSegment : RectTransformSegment<float>
    {
        public override IEnumerator CoExecute()
            => _transform.CoPivotY(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(RectTransform), "SizeDelta")]
    public sealed class RectTransformSizeDeltaSegment : RectTransformSegment<Vector2>
    {
        public override IEnumerator CoExecute()
            => _transform.CoSizeDelta(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(RectTransform), "SizeDeltaX")]
    public sealed class RectTransformSizeDeltaXSegment : RectTransformSegment<float>
    {
        public override IEnumerator CoExecute()
            => _transform.CoSizeDeltaX(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(RectTransform), "SizeDeltaY")]
    public sealed class RectTransformSizeDeltaYSegment : RectTransformSegment<float>
    {
        public override IEnumerator CoExecute()
            => _transform.CoSizeDeltaY(_target, _duration, _easer.Evaluate);
    }
}