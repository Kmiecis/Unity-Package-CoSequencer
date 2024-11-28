using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Common.Coroutines.Segments
{
    #region FlexibleWidth
    [Serializable]
    [SegmentMenu("Set", SegmentPath.LayoutElementFlexibleWidth, SegmentGroup.UI)]
    public sealed class LayoutElementFlexibleWidthSetSegment : SetSegment<LayoutElement, float>
    {
        public override IEnumerator Build()
            => component.CoFlexibleWidth(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.LayoutElementFlexibleWidth, SegmentGroup.UI)]
    public sealed class LayoutElementFlexibleWidthSegment : TowardsSegment<LayoutElement, float>
    {
        public override IEnumerator Build()
            => component.CoFlexibleWidth(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.LayoutElementFlexibleWidth, SegmentGroup.UI)]
    public sealed class LayoutElementFlexibleWidtBetweenhSegment : BetweenSegment<LayoutElement, float>
    {
        public override IEnumerator Build()
            => component.CoFlexibleWidth(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region FlexibleHeight
    [Serializable]
    [SegmentMenu("Set", SegmentPath.LayoutElementFlexibleHeight, SegmentGroup.UI)]
    public sealed class LayoutElementFlexibleHeightSetSegment : SetSegment<LayoutElement, float>
    {
        public override IEnumerator Build()
            => component.CoFlexibleHeight(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.LayoutElementFlexibleHeight, SegmentGroup.UI)]
    public sealed class LayoutElementFlexibleHeightSegment : TowardsSegment<LayoutElement, float>
    {
        public override IEnumerator Build()
            => component.CoFlexibleHeight(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.LayoutElementFlexibleHeight, SegmentGroup.UI)]
    public sealed class LayoutElementFlexibleHeightBetweenSegment : BetweenSegment<LayoutElement, float>
    {
        public override IEnumerator Build()
            => component.CoFlexibleHeight(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region FlexibleSize
    [Serializable]
    [SegmentMenu("Set", SegmentPath.LayoutElementFlexibleSize, SegmentGroup.UI)]
    public sealed class LayoutElementFlexibleSizeSetSegment : SetSegment<LayoutElement, Vector2>
    {
        public override IEnumerator Build()
            => component.CoFlexibleSize(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.LayoutElementFlexibleSize, SegmentGroup.UI)]
    public sealed class LayoutElementFlexibleSizeSegment : TowardsSegment<LayoutElement, Vector2>
    {
        public override IEnumerator Build()
            => component.CoFlexibleSize(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.LayoutElementFlexibleSize, SegmentGroup.UI)]
    public sealed class LayoutElementFlexibleSizeBetweenSegment : BetweenSegment<LayoutElement, Vector2>
    {
        public override IEnumerator Build()
            => component.CoFlexibleSize(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region MinWidth
    [Serializable]
    [SegmentMenu("Set", SegmentPath.LayoutElementMinWidth, SegmentGroup.UI)]
    public sealed class LayoutElementMinWidthSetSegment : SetSegment<LayoutElement, float>
    {
        public override IEnumerator Build()
            => component.CoMinWidth(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.LayoutElementMinWidth, SegmentGroup.UI)]
    public sealed class LayoutElementMinWidthSegment : TowardsSegment<LayoutElement, float>
    {
        public override IEnumerator Build()
            => component.CoMinWidth(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.LayoutElementMinWidth, SegmentGroup.UI)]
    public sealed class LayoutElementMinWidthBetweenSegment : BetweenSegment<LayoutElement, float>
    {
        public override IEnumerator Build()
            => component.CoMinWidth(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region MinHeight
    [Serializable]
    [SegmentMenu("Set", SegmentPath.LayoutElementMinHeight, SegmentGroup.UI)]
    public sealed class LayoutElementMinHeightSetSegment : SetSegment<LayoutElement, float>
    {
        public override IEnumerator Build()
            => component.CoMinHeight(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.LayoutElementMinHeight, SegmentGroup.UI)]
    public sealed class LayoutElementMinHeightSegment : TowardsSegment<LayoutElement, float>
    {
        public override IEnumerator Build()
            => component.CoMinHeight(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.LayoutElementMinHeight, SegmentGroup.UI)]
    public sealed class LayoutElementMinHeightBetweenSegment : BetweenSegment<LayoutElement, float>
    {
        public override IEnumerator Build()
            => component.CoMinHeight(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region MinSize
    [Serializable]
    [SegmentMenu("Set", SegmentPath.LayoutElementMinSize, SegmentGroup.UI)]
    public sealed class LayoutElementMinSizeSetSegment : SetSegment<LayoutElement, Vector2>
    {
        public override IEnumerator Build()
            => component.CoMinSize(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.LayoutElementMinSize, SegmentGroup.UI)]
    public sealed class LayoutElementMinSizeSegment : TowardsSegment<LayoutElement, Vector2>
    {
        public override IEnumerator Build()
            => component.CoMinSize(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.LayoutElementMinSize, SegmentGroup.UI)]
    public sealed class LayoutElementMinSizeBetweenSegment : BetweenSegment<LayoutElement, Vector2>
    {
        public override IEnumerator Build()
            => component.CoMinSize(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region PreferredWidth
    [Serializable]
    [SegmentMenu("Set", SegmentPath.LayoutElementPreferredWidth, SegmentGroup.UI)]
    public sealed class LayoutElementPreferredWidthSetSegment : SetSegment<LayoutElement, float>
    {
        public override IEnumerator Build()
            => component.CoPreferredWidth(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.LayoutElementPreferredWidth, SegmentGroup.UI)]
    public sealed class LayoutElementPreferredWidthSegment : TowardsSegment<LayoutElement, float>
    {
        public override IEnumerator Build()
            => component.CoPreferredWidth(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.LayoutElementPreferredWidth, SegmentGroup.UI)]
    public sealed class LayoutElementPreferredWidthBetweenSegment : BetweenSegment<LayoutElement, float>
    {
        public override IEnumerator Build()
            => component.CoPreferredWidth(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region PreferredHeight
    [Serializable]
    [SegmentMenu("Set", SegmentPath.LayoutElementPreferredHeight, SegmentGroup.UI)]
    public sealed class LayoutElementPreferredHeightSetSegment : SetSegment<LayoutElement, float>
    {
        public override IEnumerator Build()
            => component.CoPreferredHeight(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.LayoutElementPreferredHeight, SegmentGroup.UI)]
    public sealed class LayoutElementPreferredHeightSegment : TowardsSegment<LayoutElement, float>
    {
        public override IEnumerator Build()
            => component.CoPreferredHeight(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.LayoutElementPreferredHeight, SegmentGroup.UI)]
    public sealed class LayoutElementPreferredHeightBetweenSegment : BetweenSegment<LayoutElement, float>
    {
        public override IEnumerator Build()
            => component.CoPreferredHeight(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region PreferredSize
    [Serializable]
    [SegmentMenu("Set", SegmentPath.LayoutElementPreferredSize, SegmentGroup.UI)]
    public sealed class LayoutElementPreferredSizeSetSegment : SetSegment<LayoutElement, Vector2>
    {
        public override IEnumerator Build()
            => component.CoPreferredSize(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.LayoutElementPreferredSize, SegmentGroup.UI)]
    public sealed class LayoutElementPreferredSizeSegment : TowardsSegment<LayoutElement, Vector2>
    {
        public override IEnumerator Build()
            => component.CoPreferredSize(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.LayoutElementPreferredSize, SegmentGroup.UI)]
    public sealed class LayoutElementPreferredSizeBetweenSegment : BetweenSegment<LayoutElement, Vector2>
    {
        public override IEnumerator Build()
            => component.CoPreferredSize(start, target, duration, easer.Evaluate);
    }
    #endregion
}