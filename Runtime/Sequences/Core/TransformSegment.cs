using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines.Segments
{
    [Serializable]
    public abstract class TransformSegment<T> : TimedSegment
    {
        public Transform transform;
        public T target;
    }

    [SegmentMenu("Move", SegmentPath.Transform, SegmentGroup.Core)]
    public sealed class TransformMoveSegment : TransformSegment<Vector3>
    {
        public override IEnumerator GetSequence()
            => transform.CoMove(target, duration, easer.Evaluate);
    }

    [SegmentMenu("Move (Transform)", SegmentPath.Transform, SegmentGroup.Core)]
    public sealed class TransformMoveToSegment : TransformSegment<Transform>
    {
        public override IEnumerator GetSequence()
            => transform.CoMove(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("MoveBy", SegmentPath.Transform, SegmentGroup.Core)]
    public sealed class TransformMoveBySegment : TransformSegment<Vector3>
    {
        public override IEnumerator GetSequence()
            => transform.CoMoveBy(target, duration, easer.Evaluate);
    }

    [SegmentMenu("MoveX", SegmentPath.Transform, SegmentGroup.Core)]
    public sealed class TransformMoveXSegment : TransformSegment<float>
    {
        public override IEnumerator GetSequence()
            => transform.CoMoveX(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("MoveY", SegmentPath.Transform, SegmentGroup.Core)]
    public sealed class TransformMoveYSegment : TransformSegment<float>
    {
        public override IEnumerator GetSequence()
            => transform.CoMoveY(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("MoveZ", SegmentPath.Transform, SegmentGroup.Core)]
    public sealed class TransformMoveZSegment : TransformSegment<float>
    {
        public override IEnumerator GetSequence()
            => transform.CoMoveZ(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("LocalMove", SegmentPath.Transform, SegmentGroup.Core)]
    public sealed class TransformLocalMoveSegment : TransformSegment<Vector3>
    {
        public override IEnumerator GetSequence()
            => transform.CoLocalMove(target, duration, easer.Evaluate);
    }

    [SegmentMenu("LocalMove (Transform)", SegmentPath.Transform, SegmentGroup.Core)]
    public sealed class TransformLocalMoveToSegment : TransformSegment<Transform>
    {
        public override IEnumerator GetSequence()
            => transform.CoLocalMove(target, duration, easer.Evaluate);
    }

    [SegmentMenu("LocalMoveBy", SegmentPath.Transform, SegmentGroup.Core)]
    public sealed class TransformLocalMoveBySegment : TransformSegment<Vector3>
    {
        public override IEnumerator GetSequence()
            => transform.CoLocalMoveBy(target, duration, easer.Evaluate);
    }

    [SegmentMenu("LocalMoveX", SegmentPath.Transform, SegmentGroup.Core)]
    public sealed class TransformLocalMoveXSegment : TransformSegment<float>
    {
        public override IEnumerator GetSequence()
            => transform.CoLocalMoveX(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("LocalMoveY", SegmentPath.Transform, SegmentGroup.Core)]
    public sealed class TransformLocalMoveYSegment : TransformSegment<float>
    {
        public override IEnumerator GetSequence()
            => transform.CoLocalMoveY(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("LocalMoveZ", SegmentPath.Transform, SegmentGroup.Core)]
    public sealed class TransformLocalMoveZSegment : TransformSegment<float>
    {
        public override IEnumerator GetSequence()
            => transform.CoLocalMoveZ(target, duration, easer.Evaluate);
    }

    [SegmentMenu("Rotate", SegmentPath.Transform, SegmentGroup.Core)]
    public sealed class TransformRotateSegment : TransformSegment<Vector3>
    {
        public override IEnumerator GetSequence()
            => transform.CoRotate(Quaternion.Euler(target), duration, easer.Evaluate);
    }

    [SegmentMenu("Rotate (Transform)", SegmentPath.Transform, SegmentGroup.Core)]
    public sealed class TransformRotateAsSegment : TransformSegment<Transform>
    {
        public override IEnumerator GetSequence()
            => transform.CoRotate(target, duration, easer.Evaluate);
    }

    [SegmentMenu("RotateBy", SegmentPath.Transform, SegmentGroup.Core)]
    public sealed class TransformRotateBySegment : TransformSegment<Vector3>
    {
        public override IEnumerator GetSequence()
            => transform.CoRotateBy(Quaternion.Euler(target), duration, easer.Evaluate);
    }

    [SegmentMenu("LocalRotate", SegmentPath.Transform, SegmentGroup.Core)]
    public sealed class TransformLocalRotateSegment : TransformSegment<Vector3>
    {
        public override IEnumerator GetSequence()
            => transform.CoLocalRotate(Quaternion.Euler(target), duration, easer.Evaluate);
    }

    [SegmentMenu("LocalRotate (Transform)", SegmentPath.Transform, SegmentGroup.Core)]
    public sealed class TransformLocalRotateAsSegment : TransformSegment<Transform>
    {
        public override IEnumerator GetSequence()
            => transform.CoLocalRotate(target, duration, easer.Evaluate);
    }

    [SegmentMenu("LocalRotateBy", SegmentPath.Transform, SegmentGroup.Core)]
    public sealed class TransformLocalRotateBySegment : TransformSegment<Vector3>
    {
        public override IEnumerator GetSequence()
            => transform.CoLocalRotateBy(Quaternion.Euler(target), duration, easer.Evaluate);
    }

    [SegmentMenu("LookAtPosition", SegmentPath.Transform, SegmentGroup.Core)]
    public sealed class TransformLookAtPositionSegment : TransformSegment<Vector3>
    {
        public override IEnumerator GetSequence()
            => transform.CoLookAt(target, duration, easer.Evaluate);
    }

    [SegmentMenu("LookAtTransform", SegmentPath.Transform, SegmentGroup.Core)]
    public sealed class TransformLookAtTransformSegment : TransformSegment<Transform>
    {
        public override IEnumerator GetSequence()
            => transform.CoLookAt(target, duration, easer.Evaluate);
    }

    [SegmentMenu("LocalScale", SegmentPath.Transform, SegmentGroup.Core)]
    public sealed class TransformLocalScaleSegment : TransformSegment<Vector3>
    {
        public override IEnumerator GetSequence()
            => transform.CoLocalScale(target, duration, easer.Evaluate);
    }

    [SegmentMenu("LocalScale (Transform)", SegmentPath.Transform, SegmentGroup.Core)]
    public sealed class TransformLocalScaleAsSegment : TransformSegment<Transform>
    {
        public override IEnumerator GetSequence()
            => transform.CoLocalScale(target, duration, easer.Evaluate);
    }

    [SegmentMenu("LocalScaleBy", SegmentPath.Transform, SegmentGroup.Core)]
    public sealed class TransformLocalScaleBySegment : TransformSegment<Vector3>
    {
        public override IEnumerator GetSequence()
            => transform.CoLocalScaleBy(target, duration, easer.Evaluate);
    }

    [SegmentMenu("LocalScaleX", SegmentPath.Transform, SegmentGroup.Core)]
    public sealed class TransformLocalScaleXSegment : TransformSegment<float>
    {
        public override IEnumerator GetSequence()
            => transform.CoLocalScaleX(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("LocalScaleY", SegmentPath.Transform, SegmentGroup.Core)]
    public sealed class TransformLocalScaleYSegment : TransformSegment<float>
    {
        public override IEnumerator GetSequence()
            => transform.CoLocalScaleY(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("LocalScaleZ", SegmentPath.Transform, SegmentGroup.Core)]
    public sealed class TransformLocalScaleZSegment : TransformSegment<float>
    {
        public override IEnumerator GetSequence()
            => transform.CoLocalScaleZ(target, duration, easer.Evaluate);
    }
}