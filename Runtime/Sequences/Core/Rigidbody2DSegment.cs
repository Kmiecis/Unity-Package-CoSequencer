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

    [SegmentMenu("Move", SegmentPath.Rigidbody2D, SegmentGroup.Core)]
    public sealed class Rigidbody2DMoveSegment : Rigidbody2DSegment<Vector2>
    {
        public override IEnumerator GetSequence()
            => rigidbody.CoMove(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("MoveX", SegmentPath.Rigidbody2D, SegmentGroup.Core)]
    public sealed class Rigidbody2DMoveXSegment : Rigidbody2DSegment<float>
    {
        public override IEnumerator GetSequence()
            => rigidbody.CoMoveX(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("MoveY", SegmentPath.Rigidbody2D, SegmentGroup.Core)]
    public sealed class Rigidbody2DMoveYSegment : Rigidbody2DSegment<float>
    {
        public override IEnumerator GetSequence()
            => rigidbody.CoMoveY(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("Rotate", SegmentPath.Rigidbody2D, SegmentGroup.Core)]
    public sealed class Rigidbody2DRotateSegment : Rigidbody2DSegment<float>
    {
        public override IEnumerator GetSequence()
            => rigidbody.CoRotate(target, duration, easer.Evaluate);
    }
}