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
    
    [SegmentMenu(nameof(Rigidbody), "Move")]
    public sealed class RigidbodyMoveSegment : RigidbodySegment<Vector3>
    {
        public override IEnumerator CoExecute()
            => rigidbody.CoMove(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Rigidbody), "MoveX")]
    public sealed class RigidbodyMoveXSegment : RigidbodySegment<float>
    {
        public override IEnumerator CoExecute()
            => rigidbody.CoMoveX(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Rigidbody), "MoveY")]
    public sealed class RigidbodyMoveYSegment : RigidbodySegment<float>
    {
        public override IEnumerator CoExecute()
            => rigidbody.CoMoveY(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Rigidbody), "MoveZ")]
    public sealed class RigidbodyMoveZSegment : RigidbodySegment<float>
    {
        public override IEnumerator CoExecute()
            => rigidbody.CoMoveZ(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Rigidbody), "Rotate")]
    public sealed class RigidbodyRotateSegment : RigidbodySegment<Quaternion>
    {
        public override IEnumerator CoExecute()
            => rigidbody.CoRotate(target, duration, easer.Evaluate);
    }
}