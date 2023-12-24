using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines
{
    [Serializable]
    public abstract class RigidbodySegment<T> : TimedSegment
    {
        [SerializeField] protected Rigidbody _rigidbody;
        [SerializeField] protected T _target;
    }
    
    [SegmentMenu(nameof(Rigidbody), "Move")]
    public sealed class RigidbodyMoveSegment : RigidbodySegment<Vector3>
    {
        public override IEnumerator CoExecute()
            => _rigidbody.CoMove(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Rigidbody), "MoveX")]
    public sealed class RigidbodyMoveXSegment : RigidbodySegment<float>
    {
        public override IEnumerator CoExecute()
            => _rigidbody.CoMoveX(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Rigidbody), "MoveY")]
    public sealed class RigidbodyMoveYSegment : RigidbodySegment<float>
    {
        public override IEnumerator CoExecute()
            => _rigidbody.CoMoveY(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Rigidbody), "MoveZ")]
    public sealed class RigidbodyMoveZSegment : RigidbodySegment<float>
    {
        public override IEnumerator CoExecute()
            => _rigidbody.CoMoveZ(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Rigidbody), "Rotate")]
    public sealed class RigidbodyRotateSegment : RigidbodySegment<Quaternion>
    {
        public override IEnumerator CoExecute()
            => _rigidbody.CoRotate(_target, _duration, _easer.Evaluate);
    }
}