using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines.Segments
{
    [Serializable]
    public abstract class RigidbodyTimedSegment<T> : TimedSegment
    {
        public Rigidbody rigidbody;
        public T target;
    }

    [Serializable]
    public abstract class RigidbodyBetweenSegment<T> : TimedSegment
    {
        public Rigidbody rigidbody;
        public T start;
        public T target;
    }

    #region Move
    [SegmentMenu("Towards", SegmentPath.RigidbodyMove, SegmentGroup.Core)]
    public sealed class RigidbodyMoveSegment : RigidbodyTimedSegment<Vector3>
    {
        public override IEnumerator Build()
            => rigidbody.CoMove(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("Towards X", SegmentPath.RigidbodyMove, SegmentGroup.Core)]
    public sealed class RigidbodyMoveXSegment : RigidbodyTimedSegment<float>
    {
        public override IEnumerator Build()
            => rigidbody.CoMoveX(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("Towards Y", SegmentPath.RigidbodyMove, SegmentGroup.Core)]
    public sealed class RigidbodyMoveYSegment : RigidbodyTimedSegment<float>
    {
        public override IEnumerator Build()
            => rigidbody.CoMoveY(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("Towards Z", SegmentPath.RigidbodyMove, SegmentGroup.Core)]
    public sealed class RigidbodyMoveZSegment : RigidbodyTimedSegment<float>
    {
        public override IEnumerator Build()
            => rigidbody.CoMoveZ(target, duration, easer.Evaluate);
    }

    [SegmentMenu("Towards XY", SegmentPath.RigidbodyMove, SegmentGroup.Core)]
    public sealed class RigidbodyMoveXYSegment : RigidbodyTimedSegment<Vector2>
    {
        public override IEnumerator Build()
            => rigidbody.CoMoveXY(target, duration, easer.Evaluate);
    }

    [SegmentMenu("Towards YZ", SegmentPath.RigidbodyMove, SegmentGroup.Core)]
    public sealed class RigidbodyMoveYZSegment : RigidbodyTimedSegment<Vector2>
    {
        public override IEnumerator Build()
            => rigidbody.CoMoveYZ(target, duration, easer.Evaluate);
    }

    [SegmentMenu("Towards XZ", SegmentPath.RigidbodyMove, SegmentGroup.Core)]
    public sealed class RigidbodyMoveXZSegment : RigidbodyTimedSegment<Vector2>
    {
        public override IEnumerator Build()
            => rigidbody.CoMoveXZ(target, duration, easer.Evaluate);
    }

    [SegmentMenu("Between", SegmentPath.RigidbodyMove, SegmentGroup.Core)]
    public sealed class RigidbodyMoveBetweenSegment : RigidbodyBetweenSegment<Vector3>
    {
        public override IEnumerator Build()
            => rigidbody.CoMove(start, target, duration, easer.Evaluate);
    }

    [SegmentMenu("Between X", SegmentPath.RigidbodyMove, SegmentGroup.Core)]
    public sealed class RigidbodyMoveXBetweenSegment : RigidbodyBetweenSegment<float>
    {
        public override IEnumerator Build()
            => rigidbody.CoMoveX(start, target, duration, easer.Evaluate);
    }

    [SegmentMenu("Between Y", SegmentPath.RigidbodyMove, SegmentGroup.Core)]
    public sealed class RigidbodyMoveYBetweenSegment : RigidbodyBetweenSegment<float>
    {
        public override IEnumerator Build()
            => rigidbody.CoMoveY(start, target, duration, easer.Evaluate);
    }

    [SegmentMenu("Between Z", SegmentPath.RigidbodyMove, SegmentGroup.Core)]
    public sealed class RigidbodyMoveZBetweenSegment : RigidbodyBetweenSegment<float>
    {
        public override IEnumerator Build()
            => rigidbody.CoMoveZ(start, target, duration, easer.Evaluate);
    }

    [SegmentMenu("Between XY", SegmentPath.RigidbodyMove, SegmentGroup.Core)]
    public sealed class RigidbodyMoveXYBetweenSegment : RigidbodyBetweenSegment<Vector2>
    {
        public override IEnumerator Build()
            => rigidbody.CoMoveXY(start, target, duration, easer.Evaluate);
    }

    [SegmentMenu("Between YZ", SegmentPath.RigidbodyMove, SegmentGroup.Core)]
    public sealed class RigidbodyMoveYZBetweenSegment : RigidbodyBetweenSegment<Vector2>
    {
        public override IEnumerator Build()
            => rigidbody.CoMoveYZ(start, target, duration, easer.Evaluate);
    }

    [SegmentMenu("Between XZ", SegmentPath.RigidbodyMove, SegmentGroup.Core)]
    public sealed class RigidbodyMoveXZBetweenSegment : RigidbodyBetweenSegment<Vector2>
    {
        public override IEnumerator Build()
            => rigidbody.CoMoveXZ(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region Rotate
    [SegmentMenu("Towards", SegmentPath.RigidbodyRotate, SegmentGroup.Core)]
    public sealed class RigidbodyRotateSegment : RigidbodyTimedSegment<Vector3>
    {
        public override IEnumerator Build()
            => rigidbody.CoRotate(Quaternion.Euler(target), duration, easer.Evaluate);
    }

    [SegmentMenu("Between", SegmentPath.RigidbodyRotate, SegmentGroup.Core)]
    public sealed class RigidbodyRotateBetweenSegment : RigidbodyBetweenSegment<Vector3>
    {
        public override IEnumerator Build()
            => rigidbody.CoRotate(Quaternion.Euler(start), Quaternion.Euler(target), duration, easer.Evaluate);
    }
    #endregion
}