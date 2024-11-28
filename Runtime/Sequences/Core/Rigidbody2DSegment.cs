using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines.Segments
{
    #region Move
    [Serializable]
    [SegmentMenu("Towards", SegmentPath.Rigidbody2DMove, SegmentGroup.Core)]
    public sealed class Rigidbody2DMoveSegment : TowardsSegment<Rigidbody2D, Vector2>
    {
        public override IEnumerator Build()
            => component.CoMove(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Towards X", SegmentPath.Rigidbody2DMove, SegmentGroup.Core)]
    public sealed class Rigidbody2DMoveXSegment : TowardsSegment<Rigidbody2D, float>
    {
        public override IEnumerator Build()
            => component.CoMoveX(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Towards Y", SegmentPath.Rigidbody2DMove, SegmentGroup.Core)]
    public sealed class Rigidbody2DMoveYSegment : TowardsSegment<Rigidbody2D, float>
    {
        public override IEnumerator Build()
            => component.CoMoveY(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.Rigidbody2DMove, SegmentGroup.Core)]
    public sealed class Rigidbody2DMoveBetweenSegment : BetweenSegment<Rigidbody2D, Vector2>
    {
        public override IEnumerator Build()
            => component.CoMove(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between X", SegmentPath.Rigidbody2DMove, SegmentGroup.Core)]
    public sealed class Rigidbody2DMoveXBetweenSegment : BetweenSegment<Rigidbody2D, float>
    {
        public override IEnumerator Build()
            => component.CoMoveX(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between Y", SegmentPath.Rigidbody2DMove, SegmentGroup.Core)]
    public sealed class Rigidbody2DMoveYBetweenSegment : BetweenSegment<Rigidbody2D, float>
    {
        public override IEnumerator Build()
            => component.CoMoveY(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region Rotate
    [Serializable]
    [SegmentMenu("Towards", SegmentPath.Rigidbody2DRotate, SegmentGroup.Core)]
    public sealed class Rigidbody2DRotateSegment : TowardsSegment<Rigidbody2D, float>
    {
        public override IEnumerator Build()
            => component.CoRotate(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.Rigidbody2DRotate, SegmentGroup.Core)]
    public sealed class Rigidbody2DRotateBetweenSegment : BetweenSegment<Rigidbody2D, float>
    {
        public override IEnumerator Build()
            => component.CoRotate(start, target, duration, easer.Evaluate);
    }
    #endregion
}