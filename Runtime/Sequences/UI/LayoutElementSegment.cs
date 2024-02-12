using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Common.Coroutines.Segments
{
    [Serializable]
    public abstract class LayoutElementSegment<T> : TimedSegment
    {
        public LayoutElement element;
        public T target;
    }
    
    [SegmentMenu("FlexibleWidth", SegmentPath.LayoutElement, SegmentGroup.UI)]
    public sealed class LayoutElementFlexibleWidthSegment : LayoutElementSegment<float>
    {
        public override IEnumerator GetSequence()
            => element.CoFlexibleWidth(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("FlexibleHeight", SegmentPath.LayoutElement, SegmentGroup.UI)]
    public sealed class LayoutElementFlexibleHeightSegment : LayoutElementSegment<float>
    {
        public override IEnumerator GetSequence()
            => element.CoFlexibleHeight(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("FlexibleSize", SegmentPath.LayoutElement, SegmentGroup.UI)]
    public sealed class LayoutElementFlexibleSizeSegment : LayoutElementSegment<Vector2>
    {
        public override IEnumerator GetSequence()
            => element.CoFlexibleSize(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("MinWidth", SegmentPath.LayoutElement, SegmentGroup.UI)]
    public sealed class LayoutElementMinWidthSegment : LayoutElementSegment<float>
    {
        public override IEnumerator GetSequence()
            => element.CoMinWidth(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("MinHeight", SegmentPath.LayoutElement, SegmentGroup.UI)]
    public sealed class LayoutElementMinHeightSegment : LayoutElementSegment<float>
    {
        public override IEnumerator GetSequence()
            => element.CoMinHeight(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("MinSize", SegmentPath.LayoutElement, SegmentGroup.UI)]
    public sealed class LayoutElementMinSizeSegment : LayoutElementSegment<Vector2>
    {
        public override IEnumerator GetSequence()
            => element.CoMinSize(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("PreferredWidth", SegmentPath.LayoutElement, SegmentGroup.UI)]
    public sealed class LayoutElementPreferredWidthSegment : LayoutElementSegment<float>
    {
        public override IEnumerator GetSequence()
            => element.CoPreferredWidth(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("PreferredHeight", SegmentPath.LayoutElement, SegmentGroup.UI)]
    public sealed class LayoutElementPreferredHeightSegment : LayoutElementSegment<float>
    {
        public override IEnumerator GetSequence()
            => element.CoPreferredHeight(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("PreferredSize", SegmentPath.LayoutElement, SegmentGroup.UI)]
    public sealed class LayoutElementPreferredSizeSegment : LayoutElementSegment<Vector2>
    {
        public override IEnumerator GetSequence()
            => element.CoPreferredSize(target, duration, easer.Evaluate);
    }
}