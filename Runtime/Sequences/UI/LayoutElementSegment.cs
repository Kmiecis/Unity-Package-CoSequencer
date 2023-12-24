using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Common.Coroutines
{
    [Serializable]
    public abstract class LayoutElementSegment<T> : TimedSegment
    {
        [SerializeField] protected LayoutElement _element;
        [SerializeField] protected T _target;
    }
    
    [SegmentMenu(nameof(LayoutElement), "FlexibleWidth")]
    public sealed class LayoutElementFlexibleWidthSegment : LayoutElementSegment<float>
    {
        public override IEnumerator CoExecute()
            => _element.CoFlexibleWidth(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(LayoutElement), "FlexibleHeight")]
    public sealed class LayoutElementFlexibleHeightSegment : LayoutElementSegment<float>
    {
        public override IEnumerator CoExecute()
            => _element.CoFlexibleHeight(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(LayoutElement), "FlexibleSize")]
    public sealed class LayoutElementFlexibleSizeSegment : LayoutElementSegment<Vector2>
    {
        public override IEnumerator CoExecute()
            => _element.CoFlexibleSize(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(LayoutElement), "MinWidth")]
    public sealed class LayoutElementMinWidthSegment : LayoutElementSegment<float>
    {
        public override IEnumerator CoExecute()
            => _element.CoMinWidth(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(LayoutElement), "MinHeight")]
    public sealed class LayoutElementMinHeightSegment : LayoutElementSegment<float>
    {
        public override IEnumerator CoExecute()
            => _element.CoMinHeight(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(LayoutElement), "MinSize")]
    public sealed class LayoutElementMinSizeSegment : LayoutElementSegment<Vector2>
    {
        public override IEnumerator CoExecute()
            => _element.CoMinSize(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(LayoutElement), "PreferredWidth")]
    public sealed class LayoutElementPreferredWidthSegment : LayoutElementSegment<float>
    {
        public override IEnumerator CoExecute()
            => _element.CoPreferredWidth(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(LayoutElement), "PreferredHeight")]
    public sealed class LayoutElementPreferredHeightSegment : LayoutElementSegment<float>
    {
        public override IEnumerator CoExecute()
            => _element.CoPreferredHeight(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(LayoutElement), "PreferredSize")]
    public sealed class LayoutElementPreferredSizeSegment : LayoutElementSegment<Vector2>
    {
        public override IEnumerator CoExecute()
            => _element.CoPreferredSize(_target, _duration, _easer.Evaluate);
    }
}