using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines.Segments
{
    public abstract class Rigidbody2DTimedSegment<T> : TimedSegment
    {
        public Rigidbody2D rigidbody;
        public T target;
    }

    public abstract class Rigidbody2DBetweenSegment<T> : TimedSegment
    {
        public Rigidbody2D rigidbody;
        public T start;
        public T target;
    }

    #region Move
    [Serializable]
    [SegmentMenu("Towards", SegmentPath.Rigidbody2DMove, SegmentGroup.Core)]
    public sealed class Rigidbody2DMoveSegment : Rigidbody2DTimedSegment<Vector2>
    {
        public override IEnumerator Build()
            => rigidbody.CoMove(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Towards X", SegmentPath.Rigidbody2DMove, SegmentGroup.Core)]
    public sealed class Rigidbody2DMoveXSegment : Rigidbody2DTimedSegment<float>
    {
        public override IEnumerator Build()
            => rigidbody.CoMoveX(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Towards Y", SegmentPath.Rigidbody2DMove, SegmentGroup.Core)]
    public sealed class Rigidbody2DMoveYSegment : Rigidbody2DTimedSegment<float>
    {
        public override IEnumerator Build()
            => rigidbody.CoMoveY(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.Rigidbody2DMove, SegmentGroup.Core)]
    public sealed class Rigidbody2DMoveBetweenSegment : Rigidbody2DBetweenSegment<Vector2>
    {
        public override IEnumerator Build()
            => rigidbody.CoMove(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between X", SegmentPath.Rigidbody2DMove, SegmentGroup.Core)]
    public sealed class Rigidbody2DMoveXBetweenSegment : Rigidbody2DBetweenSegment<float>
    {
        public override IEnumerator Build()
            => rigidbody.CoMoveX(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between Y", SegmentPath.Rigidbody2DMove, SegmentGroup.Core)]
    public sealed class Rigidbody2DMoveYBetweenSegment : Rigidbody2DBetweenSegment<float>
    {
        public override IEnumerator Build()
            => rigidbody.CoMoveY(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region Rotate
    [Serializable]
    [SegmentMenu("Towards", SegmentPath.Rigidbody2DRotate, SegmentGroup.Core)]
    public sealed class Rigidbody2DRotateSegment : Rigidbody2DTimedSegment<float>
    {
        public override IEnumerator Build()
            => rigidbody.CoRotate(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.Rigidbody2DRotate, SegmentGroup.Core)]
    public sealed class Rigidbody2DRotateBetweenSegment : Rigidbody2DBetweenSegment<float>
    {
        public override IEnumerator Build()
            => rigidbody.CoRotate(start, target, duration, easer.Evaluate);
    }
    #endregion
}