using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Common.Coroutines.Segments
{
    [Serializable]
    public abstract class LayoutElementSegment<T> : Segment
    {
        public LayoutElement element;
        public T target;
    }

    [Serializable]
    public abstract class LayoutElementTimedSegment<T> : TimedSegment
    {
        public LayoutElement element;
        public T target;
    }

    [Serializable]
    public abstract class LayoutElementBetweenSegment<T> : TimedSegment
    {
        public LayoutElement element;
        public T start;
        public T target;
    }

    #region FlexibleWidth
    [SegmentMenu("Towards", SegmentPath.LayoutElementFlexibleWidth, SegmentGroup.UI)]
    public sealed class LayoutElementFlexibleWidthSegment : LayoutElementTimedSegment<float>
    {
        public override IEnumerator Build()
            => element.CoFlexibleWidth(target, duration, easer.Evaluate);
    }

    [SegmentMenu("Set", SegmentPath.LayoutElementFlexibleWidth, SegmentGroup.UI)]
    public sealed class LayoutElementFlexibleWidthSetSegment : LayoutElementSegment<float>
    {
        public override IEnumerator Build()
            => element.CoFlexibleWidth(target);
    }

    [SegmentMenu("Between", SegmentPath.LayoutElementFlexibleWidth, SegmentGroup.UI)]
    public sealed class LayoutElementFlexibleWidtBetweenhSegment : LayoutElementBetweenSegment<float>
    {
        public override IEnumerator Build()
            => element.CoFlexibleWidth(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region FlexibleHeight
    [SegmentMenu("Towards", SegmentPath.LayoutElementFlexibleHeight, SegmentGroup.UI)]
    public sealed class LayoutElementFlexibleHeightSegment : LayoutElementTimedSegment<float>
    {
        public override IEnumerator Build()
            => element.CoFlexibleHeight(target, duration, easer.Evaluate);
    }

    [SegmentMenu("Set", SegmentPath.LayoutElementFlexibleHeight, SegmentGroup.UI)]
    public sealed class LayoutElementFlexibleHeightSetSegment : LayoutElementSegment<float>
    {
        public override IEnumerator Build()
            => element.CoFlexibleHeight(target);
    }

    [SegmentMenu("Between", SegmentPath.LayoutElementFlexibleHeight, SegmentGroup.UI)]
    public sealed class LayoutElementFlexibleHeightBetweenSegment : LayoutElementBetweenSegment<float>
    {
        public override IEnumerator Build()
            => element.CoFlexibleHeight(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region FlexibleSize
    [SegmentMenu("Towards", SegmentPath.LayoutElementFlexibleSize, SegmentGroup.UI)]
    public sealed class LayoutElementFlexibleSizeSegment : LayoutElementTimedSegment<Vector2>
    {
        public override IEnumerator Build()
            => element.CoFlexibleSize(target, duration, easer.Evaluate);
    }

    [SegmentMenu("Set", SegmentPath.LayoutElementFlexibleSize, SegmentGroup.UI)]
    public sealed class LayoutElementFlexibleSizeSetSegment : LayoutElementSegment<Vector2>
    {
        public override IEnumerator Build()
            => element.CoFlexibleSize(target);
    }

    [SegmentMenu("Between", SegmentPath.LayoutElementFlexibleSize, SegmentGroup.UI)]
    public sealed class LayoutElementFlexibleSizeBetweenSegment : LayoutElementBetweenSegment<Vector2>
    {
        public override IEnumerator Build()
            => element.CoFlexibleSize(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region MinWidth
    [SegmentMenu("Towards", SegmentPath.LayoutElementMinWidth, SegmentGroup.UI)]
    public sealed class LayoutElementMinWidthSegment : LayoutElementTimedSegment<float>
    {
        public override IEnumerator Build()
            => element.CoMinWidth(target, duration, easer.Evaluate);
    }

    [SegmentMenu("Set", SegmentPath.LayoutElementMinWidth, SegmentGroup.UI)]
    public sealed class LayoutElementMinWidthSetSegment : LayoutElementSegment<float>
    {
        public override IEnumerator Build()
            => element.CoMinWidth(target);
    }

    [SegmentMenu("Between", SegmentPath.LayoutElementMinWidth, SegmentGroup.UI)]
    public sealed class LayoutElementMinWidthBetweenSegment : LayoutElementBetweenSegment<float>
    {
        public override IEnumerator Build()
            => element.CoMinWidth(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region MinHeight
    [SegmentMenu("Towards", SegmentPath.LayoutElementMinHeight, SegmentGroup.UI)]
    public sealed class LayoutElementMinHeightSegment : LayoutElementTimedSegment<float>
    {
        public override IEnumerator Build()
            => element.CoMinHeight(target, duration, easer.Evaluate);
    }

    [SegmentMenu("Set", SegmentPath.LayoutElementMinHeight, SegmentGroup.UI)]
    public sealed class LayoutElementMinHeightSetSegment : LayoutElementSegment<float>
    {
        public override IEnumerator Build()
            => element.CoMinHeight(target);
    }

    [SegmentMenu("Between", SegmentPath.LayoutElementMinHeight, SegmentGroup.UI)]
    public sealed class LayoutElementMinHeightBetweenSegment : LayoutElementBetweenSegment<float>
    {
        public override IEnumerator Build()
            => element.CoMinHeight(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region MinSize
    [SegmentMenu("Towards", SegmentPath.LayoutElementMinSize, SegmentGroup.UI)]
    public sealed class LayoutElementMinSizeSegment : LayoutElementTimedSegment<Vector2>
    {
        public override IEnumerator Build()
            => element.CoMinSize(target, duration, easer.Evaluate);
    }

    [SegmentMenu("Set", SegmentPath.LayoutElementMinSize, SegmentGroup.UI)]
    public sealed class LayoutElementMinSizeSetSegment : LayoutElementSegment<Vector2>
    {
        public override IEnumerator Build()
            => element.CoMinSize(target);
    }

    [SegmentMenu("Between", SegmentPath.LayoutElementMinSize, SegmentGroup.UI)]
    public sealed class LayoutElementMinSizeBetweenSegment : LayoutElementBetweenSegment<Vector2>
    {
        public override IEnumerator Build()
            => element.CoMinSize(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region PreferredWidth
    [SegmentMenu("Towards", SegmentPath.LayoutElementPreferredWidth, SegmentGroup.UI)]
    public sealed class LayoutElementPreferredWidthSegment : LayoutElementTimedSegment<float>
    {
        public override IEnumerator Build()
            => element.CoPreferredWidth(target, duration, easer.Evaluate);
    }

    [SegmentMenu("Set", SegmentPath.LayoutElementPreferredWidth, SegmentGroup.UI)]
    public sealed class LayoutElementPreferredWidthSetSegment : LayoutElementSegment<float>
    {
        public override IEnumerator Build()
            => element.CoPreferredWidth(target);
    }

    [SegmentMenu("Between", SegmentPath.LayoutElementPreferredWidth, SegmentGroup.UI)]
    public sealed class LayoutElementPreferredWidthBetweenSegment : LayoutElementBetweenSegment<float>
    {
        public override IEnumerator Build()
            => element.CoPreferredWidth(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region PreferredHeight
    [SegmentMenu("Towards", SegmentPath.LayoutElementPreferredHeight, SegmentGroup.UI)]
    public sealed class LayoutElementPreferredHeightSegment : LayoutElementTimedSegment<float>
    {
        public override IEnumerator Build()
            => element.CoPreferredHeight(target, duration, easer.Evaluate);
    }

    [SegmentMenu("Set", SegmentPath.LayoutElementPreferredHeight, SegmentGroup.UI)]
    public sealed class LayoutElementPreferredHeightSetSegment : LayoutElementSegment<float>
    {
        public override IEnumerator Build()
            => element.CoPreferredHeight(target);
    }

    [SegmentMenu("Between", SegmentPath.LayoutElementPreferredHeight, SegmentGroup.UI)]
    public sealed class LayoutElementPreferredHeightBetweenSegment : LayoutElementBetweenSegment<float>
    {
        public override IEnumerator Build()
            => element.CoPreferredHeight(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region PreferredSize
    [SegmentMenu("Towards", SegmentPath.LayoutElementPreferredSize, SegmentGroup.UI)]
    public sealed class LayoutElementPreferredSizeSegment : LayoutElementTimedSegment<Vector2>
    {
        public override IEnumerator Build()
            => element.CoPreferredSize(target, duration, easer.Evaluate);
    }

    [SegmentMenu("Set", SegmentPath.LayoutElementPreferredSize, SegmentGroup.UI)]
    public sealed class LayoutElementPreferredSizeSetSegment : LayoutElementSegment<Vector2>
    {
        public override IEnumerator Build()
            => element.CoPreferredSize(target);
    }

    [SegmentMenu("Between", SegmentPath.LayoutElementPreferredSize, SegmentGroup.UI)]
    public sealed class LayoutElementPreferredSizeBetweenSegment : LayoutElementBetweenSegment<Vector2>
    {
        public override IEnumerator Build()
            => element.CoPreferredSize(start, target, duration, easer.Evaluate);
    }
    #endregion
}