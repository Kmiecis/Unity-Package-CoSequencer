using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines.Segments
{
    [Serializable]
    public abstract class RigidbodySegment<T> : TimedSegment
    {
        public Rigidbody rigidbody;
        public T target;
    }
    
    [SegmentMenu("Move", SegmentPath.Rigidbody, SegmentGroup.Core)]
    public sealed class RigidbodyMoveSegment : RigidbodySegment<Vector3>
    {
        public override IEnumerator CoExecute()
            => rigidbody.CoMove(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("MoveX", SegmentPath.Rigidbody, SegmentGroup.Core)]
    public sealed class RigidbodyMoveXSegment : RigidbodySegment<float>
    {
        public override IEnumerator CoExecute()
            => rigidbody.CoMoveX(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("MoveY", SegmentPath.Rigidbody, SegmentGroup.Core)]
    public sealed class RigidbodyMoveYSegment : RigidbodySegment<float>
    {
        public override IEnumerator CoExecute()
            => rigidbody.CoMoveY(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("MoveZ", SegmentPath.Rigidbody, SegmentGroup.Core)]
    public sealed class RigidbodyMoveZSegment : RigidbodySegment<float>
    {
        public override IEnumerator CoExecute()
            => rigidbody.CoMoveZ(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("Rotate", SegmentPath.Rigidbody, SegmentGroup.Core)]
    public sealed class RigidbodyRotateSegment : RigidbodySegment<Vector3>
    {
        public override IEnumerator CoExecute()
            => rigidbody.CoRotate(Quaternion.Euler(target), duration, easer.Evaluate);
    }
}