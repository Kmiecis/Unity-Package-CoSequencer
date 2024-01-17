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
        public override IEnumerator CoExecute()
            => transform.CoMove(target, duration, easer.Evaluate);
    }

    [SegmentMenu("MoveBy", SegmentPath.Transform, SegmentGroup.Core)]
    public sealed class TransformMoveBySegment : TransformSegment<Vector3>
    {
        public override IEnumerator CoExecute()
            => transform.CoMoveBy(target, duration, easer.Evaluate);
    }

    [SegmentMenu("MoveX", SegmentPath.Transform, SegmentGroup.Core)]
    public sealed class TransformMoveXSegment : TransformSegment<float>
    {
        public override IEnumerator CoExecute()
            => transform.CoMoveX(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("MoveY", SegmentPath.Transform, SegmentGroup.Core)]
    public sealed class TransformMoveYSegment : TransformSegment<float>
    {
        public override IEnumerator CoExecute()
            => transform.CoMoveY(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("MoveZ", SegmentPath.Transform, SegmentGroup.Core)]
    public sealed class TransformMoveZSegment : TransformSegment<float>
    {
        public override IEnumerator CoExecute()
            => transform.CoMoveZ(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("LocalMove", SegmentPath.Transform, SegmentGroup.Core)]
    public sealed class TransformLocalMoveSegment : TransformSegment<Vector3>
    {
        public override IEnumerator CoExecute()
            => transform.CoLocalMove(target, duration, easer.Evaluate);
    }

    [SegmentMenu("LocalMoveBy", SegmentPath.Transform, SegmentGroup.Core)]
    public sealed class TransformLocalMoveBySegment : TransformSegment<Vector3>
    {
        public override IEnumerator CoExecute()
            => transform.CoLocalMoveBy(target, duration, easer.Evaluate);
    }

    [SegmentMenu("LocalMoveX", SegmentPath.Transform, SegmentGroup.Core)]
    public sealed class TransformLocalMoveXSegment : TransformSegment<float>
    {
        public override IEnumerator CoExecute()
            => transform.CoLocalMoveX(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("LocalMoveY", SegmentPath.Transform, SegmentGroup.Core)]
    public sealed class TransformLocalMoveYSegment : TransformSegment<float>
    {
        public override IEnumerator CoExecute()
            => transform.CoLocalMoveY(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("LocalMoveZ", SegmentPath.Transform, SegmentGroup.Core)]
    public sealed class TransformLocalMoveZSegment : TransformSegment<float>
    {
        public override IEnumerator CoExecute()
            => transform.CoLocalMoveZ(target, duration, easer.Evaluate);
    }

    [SegmentMenu("Rotate", SegmentPath.Transform, SegmentGroup.Core)]
    public sealed class TransformRotateSegment : TransformSegment<Quaternion>
    {
        public override void OnAdded()
            => target = Quaternion.identity;

        public override IEnumerator CoExecute()
            => transform.CoRotate(target, duration, easer.Evaluate);
    }

    [SegmentMenu("RotateBy", SegmentPath.Transform, SegmentGroup.Core)]
    public sealed class TransformRotateBySegment : TransformSegment<Quaternion>
    {
        public override void OnAdded()
            => target = Quaternion.identity;

        public override IEnumerator CoExecute()
            => transform.CoRotateBy(target, duration, easer.Evaluate);
    }

    [SegmentMenu("LocalRotate", SegmentPath.Transform, SegmentGroup.Core)]
    public sealed class TransformLocalRotateSegment : TransformSegment<Quaternion>
    {
        public override void OnAdded()
            => target = Quaternion.identity;

        public override IEnumerator CoExecute()
            => transform.CoLocalRotate(target, duration, easer.Evaluate);
    }

    [SegmentMenu("LocalRotateBy", SegmentPath.Transform, SegmentGroup.Core)]
    public sealed class TransformLocalRotateBySegment : TransformSegment<Quaternion>
    {
        public override void OnAdded()
            => target = Quaternion.identity;

        public override IEnumerator CoExecute()
            => transform.CoLocalRotateBy(target, duration, easer.Evaluate);
    }

    [SegmentMenu("LookAt", SegmentPath.Transform, SegmentGroup.Core)]
    public sealed class TransformLookAtSegment : TransformSegment<Vector3>
    {
        public override IEnumerator CoExecute()
            => transform.CoLookAt(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("LocalScale", SegmentPath.Transform, SegmentGroup.Core)]
    public sealed class TransformLocalScaleSegment : TransformSegment<Vector3>
    {
        public override IEnumerator CoExecute()
            => transform.CoLocalScale(target, duration, easer.Evaluate);
    }

    [SegmentMenu("LocalScaleBy", SegmentPath.Transform, SegmentGroup.Core)]
    public sealed class TransformLocalScaleBySegment : TransformSegment<Vector3>
    {
        public override IEnumerator CoExecute()
            => transform.CoLocalScaleBy(target, duration, easer.Evaluate);
    }

    [SegmentMenu("LocalScaleX", SegmentPath.Transform, SegmentGroup.Core)]
    public sealed class TransformLocalScaleXSegment : TransformSegment<float>
    {
        public override IEnumerator CoExecute()
            => transform.CoLocalScaleX(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("LocalScaleY", SegmentPath.Transform, SegmentGroup.Core)]
    public sealed class TransformLocalScaleYSegment : TransformSegment<float>
    {
        public override IEnumerator CoExecute()
            => transform.CoLocalScaleY(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("LocalScaleZ", SegmentPath.Transform, SegmentGroup.Core)]
    public sealed class TransformLocalScaleZSegment : TransformSegment<float>
    {
        public override IEnumerator CoExecute()
            => transform.CoLocalScaleZ(target, duration, easer.Evaluate);
    }
}