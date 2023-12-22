using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines
{
    [Serializable]
    public abstract class Rigidbody2DSegment<T> : Segment
    {
        [SerializeField] protected Rigidbody2D _rigidbody;
        [SerializeField] protected T _target;
    }

    [SegmentMenu(nameof(Rigidbody2D), "Move")]
    public sealed class Rigidbody2DMoveSegment : Rigidbody2DSegment<Vector2>
    {
        public override IEnumerator CoExecute()
            => _rigidbody.CoMove(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Rigidbody2D), "MoveX")]
    public sealed class Rigidbody2DMoveXSegment : Rigidbody2DSegment<float>
    {
        public override IEnumerator CoExecute()
            => _rigidbody.CoMoveX(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Rigidbody2D), "MoveY")]
    public sealed class Rigidbody2DMoveYSegment : Rigidbody2DSegment<float>
    {
        public override IEnumerator CoExecute()
            => _rigidbody.CoMoveY(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Rigidbody2D), "Rotate")]
    public sealed class Rigidbody2DRotateSegment : Rigidbody2DSegment<float>
    {
        public override IEnumerator CoExecute()
            => _rigidbody.CoRotate(_target, _duration, _easer.Evaluate);
    }
}