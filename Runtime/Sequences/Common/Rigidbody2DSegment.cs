using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines.Segments
{
    [Serializable]
    public abstract class Rigidbody2DSegment<T> : TimedSegment
    {
        public Rigidbody2D rigidbody;
        public T target;
    }

    [SegmentMenu(nameof(Rigidbody2D), "Move")]
    public sealed class Rigidbody2DMoveSegment : Rigidbody2DSegment<Vector2>
    {
        public override IEnumerator CoExecute()
            => rigidbody.CoMove(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Rigidbody2D), "MoveX")]
    public sealed class Rigidbody2DMoveXSegment : Rigidbody2DSegment<float>
    {
        public override IEnumerator CoExecute()
            => rigidbody.CoMoveX(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Rigidbody2D), "MoveY")]
    public sealed class Rigidbody2DMoveYSegment : Rigidbody2DSegment<float>
    {
        public override IEnumerator CoExecute()
            => rigidbody.CoMoveY(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Rigidbody2D), "Rotate")]
    public sealed class Rigidbody2DRotateSegment : Rigidbody2DSegment<float>
    {
        public override IEnumerator CoExecute()
            => rigidbody.CoRotate(target, duration, easer.Evaluate);
    }
}