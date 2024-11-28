using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines.Segments
{
    #region Move
    [Serializable]
    [SegmentMenu("Towards", SegmentPath.RigidbodyMove, SegmentGroup.Core)]
    public sealed class RigidbodyMoveSegment : TowardsSegment<Rigidbody, Vector3>
    {
        public override IEnumerator Build()
            => component.CoMove(target, duration, easer.Evaluate);
    }
    
    [Serializable]
    [SegmentMenu("Towards X", SegmentPath.RigidbodyMove, SegmentGroup.Core)]
    public sealed class RigidbodyMoveXSegment : TowardsSegment<Rigidbody, float>
    {
        public override IEnumerator Build()
            => component.CoMoveX(target, duration, easer.Evaluate);
    }
    
    [Serializable]
    [SegmentMenu("Towards Y", SegmentPath.RigidbodyMove, SegmentGroup.Core)]
    public sealed class RigidbodyMoveYSegment : TowardsSegment<Rigidbody, float>
    {
        public override IEnumerator Build()
            => component.CoMoveY(target, duration, easer.Evaluate);
    }
    
    [Serializable]
    [SegmentMenu("Towards Z", SegmentPath.RigidbodyMove, SegmentGroup.Core)]
    public sealed class RigidbodyMoveZSegment : TowardsSegment<Rigidbody, float>
    {
        public override IEnumerator Build()
            => component.CoMoveZ(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Towards XY", SegmentPath.RigidbodyMove, SegmentGroup.Core)]
    public sealed class RigidbodyMoveXYSegment : TowardsSegment<Rigidbody, Vector2>
    {
        public override IEnumerator Build()
            => component.CoMoveXY(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Towards YZ", SegmentPath.RigidbodyMove, SegmentGroup.Core)]
    public sealed class RigidbodyMoveYZSegment : TowardsSegment<Rigidbody, Vector2>
    {
        public override IEnumerator Build()
            => component.CoMoveYZ(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Towards XZ", SegmentPath.RigidbodyMove, SegmentGroup.Core)]
    public sealed class RigidbodyMoveXZSegment : TowardsSegment<Rigidbody, Vector2>
    {
        public override IEnumerator Build()
            => component.CoMoveXZ(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.RigidbodyMove, SegmentGroup.Core)]
    public sealed class RigidbodyMoveBetweenSegment : BetweenSegment<Rigidbody, Vector3>
    {
        public override IEnumerator Build()
            => component.CoMove(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between X", SegmentPath.RigidbodyMove, SegmentGroup.Core)]
    public sealed class RigidbodyMoveXBetweenSegment : BetweenSegment<Rigidbody, float>
    {
        public override IEnumerator Build()
            => component.CoMoveX(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between Y", SegmentPath.RigidbodyMove, SegmentGroup.Core)]
    public sealed class RigidbodyMoveYBetweenSegment : BetweenSegment<Rigidbody, float>
    {
        public override IEnumerator Build()
            => component.CoMoveY(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between Z", SegmentPath.RigidbodyMove, SegmentGroup.Core)]
    public sealed class RigidbodyMoveZBetweenSegment : BetweenSegment<Rigidbody, float>
    {
        public override IEnumerator Build()
            => component.CoMoveZ(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between XY", SegmentPath.RigidbodyMove, SegmentGroup.Core)]
    public sealed class RigidbodyMoveXYBetweenSegment : BetweenSegment<Rigidbody, Vector2>
    {
        public override IEnumerator Build()
            => component.CoMoveXY(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between YZ", SegmentPath.RigidbodyMove, SegmentGroup.Core)]
    public sealed class RigidbodyMoveYZBetweenSegment : BetweenSegment<Rigidbody, Vector2>
    {
        public override IEnumerator Build()
            => component.CoMoveYZ(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between XZ", SegmentPath.RigidbodyMove, SegmentGroup.Core)]
    public sealed class RigidbodyMoveXZBetweenSegment : BetweenSegment<Rigidbody, Vector2>
    {
        public override IEnumerator Build()
            => component.CoMoveXZ(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region Rotate
    [Serializable]
    [SegmentMenu("Towards", SegmentPath.RigidbodyRotate, SegmentGroup.Core)]
    public sealed class RigidbodyRotateSegment : TowardsSegment<Rigidbody, Vector3>
    {
        public override IEnumerator Build()
            => component.CoRotate(Quaternion.Euler(target), duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.RigidbodyRotate, SegmentGroup.Core)]
    public sealed class RigidbodyRotateBetweenSegment : BetweenSegment<Rigidbody, Vector3>
    {
        public override IEnumerator Build()
            => component.CoRotate(Quaternion.Euler(start), Quaternion.Euler(target), duration, easer.Evaluate);
    }
    #endregion
}