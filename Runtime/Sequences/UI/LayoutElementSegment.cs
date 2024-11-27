using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Common.Coroutines.Segments
{
    public abstract class LayoutElementSegment<T> : Segment
    {
        public LayoutElement element;
        public T target;
    }

    public abstract class LayoutElementTimedSegment<T> : TimedSegment
    {
        public LayoutElement element;
        public T target;
    }

    public abstract class LayoutElementBetweenSegment<T> : TimedSegment
    {
        public LayoutElement element;
        public T start;
        public T target;
    }

    #region FlexibleWidth
    [Serializable]
    [SegmentMenu("Set", SegmentPath.LayoutElementFlexibleWidth, SegmentGroup.UI)]
    public sealed class LayoutElementFlexibleWidthSetSegment : LayoutElementSegment<float>
    {
        public override IEnumerator Build()
            => element.CoFlexibleWidth(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.LayoutElementFlexibleWidth, SegmentGroup.UI)]
    public sealed class LayoutElementFlexibleWidthSegment : LayoutElementTimedSegment<float>
    {
        public override IEnumerator Build()
            => element.CoFlexibleWidth(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.LayoutElementFlexibleWidth, SegmentGroup.UI)]
    public sealed class LayoutElementFlexibleWidtBetweenhSegment : LayoutElementBetweenSegment<float>
    {
        public override IEnumerator Build()
            => element.CoFlexibleWidth(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region FlexibleHeight
    [Serializable]
    [SegmentMenu("Set", SegmentPath.LayoutElementFlexibleHeight, SegmentGroup.UI)]
    public sealed class LayoutElementFlexibleHeightSetSegment : LayoutElementSegment<float>
    {
        public override IEnumerator Build()
            => element.CoFlexibleHeight(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.LayoutElementFlexibleHeight, SegmentGroup.UI)]
    public sealed class LayoutElementFlexibleHeightSegment : LayoutElementTimedSegment<float>
    {
        public override IEnumerator Build()
            => element.CoFlexibleHeight(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.LayoutElementFlexibleHeight, SegmentGroup.UI)]
    public sealed class LayoutElementFlexibleHeightBetweenSegment : LayoutElementBetweenSegment<float>
    {
        public override IEnumerator Build()
            => element.CoFlexibleHeight(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region FlexibleSize
    [Serializable]
    [SegmentMenu("Set", SegmentPath.LayoutElementFlexibleSize, SegmentGroup.UI)]
    public sealed class LayoutElementFlexibleSizeSetSegment : LayoutElementSegment<Vector2>
    {
        public override IEnumerator Build()
            => element.CoFlexibleSize(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.LayoutElementFlexibleSize, SegmentGroup.UI)]
    public sealed class LayoutElementFlexibleSizeSegment : LayoutElementTimedSegment<Vector2>
    {
        public override IEnumerator Build()
            => element.CoFlexibleSize(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.LayoutElementFlexibleSize, SegmentGroup.UI)]
    public sealed class LayoutElementFlexibleSizeBetweenSegment : LayoutElementBetweenSegment<Vector2>
    {
        public override IEnumerator Build()
            => element.CoFlexibleSize(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region MinWidth
    [Serializable]
    [SegmentMenu("Set", SegmentPath.LayoutElementMinWidth, SegmentGroup.UI)]
    public sealed class LayoutElementMinWidthSetSegment : LayoutElementSegment<float>
    {
        public override IEnumerator Build()
            => element.CoMinWidth(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.LayoutElementMinWidth, SegmentGroup.UI)]
    public sealed class LayoutElementMinWidthSegment : LayoutElementTimedSegment<float>
    {
        public override IEnumerator Build()
            => element.CoMinWidth(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.LayoutElementMinWidth, SegmentGroup.UI)]
    public sealed class LayoutElementMinWidthBetweenSegment : LayoutElementBetweenSegment<float>
    {
        public override IEnumerator Build()
            => element.CoMinWidth(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region MinHeight
    [Serializable]
    [SegmentMenu("Set", SegmentPath.LayoutElementMinHeight, SegmentGroup.UI)]
    public sealed class LayoutElementMinHeightSetSegment : LayoutElementSegment<float>
    {
        public override IEnumerator Build()
            => element.CoMinHeight(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.LayoutElementMinHeight, SegmentGroup.UI)]
    public sealed class LayoutElementMinHeightSegment : LayoutElementTimedSegment<float>
    {
        public override IEnumerator Build()
            => element.CoMinHeight(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.LayoutElementMinHeight, SegmentGroup.UI)]
    public sealed class LayoutElementMinHeightBetweenSegment : LayoutElementBetweenSegment<float>
    {
        public override IEnumerator Build()
            => element.CoMinHeight(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region MinSize
    [Serializable]
    [SegmentMenu("Set", SegmentPath.LayoutElementMinSize, SegmentGroup.UI)]
    public sealed class LayoutElementMinSizeSetSegment : LayoutElementSegment<Vector2>
    {
        public override IEnumerator Build()
            => element.CoMinSize(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.LayoutElementMinSize, SegmentGroup.UI)]
    public sealed class LayoutElementMinSizeSegment : LayoutElementTimedSegment<Vector2>
    {
        public override IEnumerator Build()
            => element.CoMinSize(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.LayoutElementMinSize, SegmentGroup.UI)]
    public sealed class LayoutElementMinSizeBetweenSegment : LayoutElementBetweenSegment<Vector2>
    {
        public override IEnumerator Build()
            => element.CoMinSize(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region PreferredWidth
    [Serializable]
    [SegmentMenu("Set", SegmentPath.LayoutElementPreferredWidth, SegmentGroup.UI)]
    public sealed class LayoutElementPreferredWidthSetSegment : LayoutElementSegment<float>
    {
        public override IEnumerator Build()
            => element.CoPreferredWidth(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.LayoutElementPreferredWidth, SegmentGroup.UI)]
    public sealed class LayoutElementPreferredWidthSegment : LayoutElementTimedSegment<float>
    {
        public override IEnumerator Build()
            => element.CoPreferredWidth(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.LayoutElementPreferredWidth, SegmentGroup.UI)]
    public sealed class LayoutElementPreferredWidthBetweenSegment : LayoutElementBetweenSegment<float>
    {
        public override IEnumerator Build()
            => element.CoPreferredWidth(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region PreferredHeight
    [Serializable]
    [SegmentMenu("Set", SegmentPath.LayoutElementPreferredHeight, SegmentGroup.UI)]
    public sealed class LayoutElementPreferredHeightSetSegment : LayoutElementSegment<float>
    {
        public override IEnumerator Build()
            => element.CoPreferredHeight(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.LayoutElementPreferredHeight, SegmentGroup.UI)]
    public sealed class LayoutElementPreferredHeightSegment : LayoutElementTimedSegment<float>
    {
        public override IEnumerator Build()
            => element.CoPreferredHeight(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.LayoutElementPreferredHeight, SegmentGroup.UI)]
    public sealed class LayoutElementPreferredHeightBetweenSegment : LayoutElementBetweenSegment<float>
    {
        public override IEnumerator Build()
            => element.CoPreferredHeight(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region PreferredSize
    [Serializable]
    [SegmentMenu("Set", SegmentPath.LayoutElementPreferredSize, SegmentGroup.UI)]
    public sealed class LayoutElementPreferredSizeSetSegment : LayoutElementSegment<Vector2>
    {
        public override IEnumerator Build()
            => element.CoPreferredSize(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.LayoutElementPreferredSize, SegmentGroup.UI)]
    public sealed class LayoutElementPreferredSizeSegment : LayoutElementTimedSegment<Vector2>
    {
        public override IEnumerator Build()
            => element.CoPreferredSize(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.LayoutElementPreferredSize, SegmentGroup.UI)]
    public sealed class LayoutElementPreferredSizeBetweenSegment : LayoutElementBetweenSegment<Vector2>
    {
        public override IEnumerator Build()
            => element.CoPreferredSize(start, target, duration, easer.Evaluate);
    }
    #endregion
}