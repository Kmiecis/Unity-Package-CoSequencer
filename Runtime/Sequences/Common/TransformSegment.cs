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

    [SegmentMenu(nameof(Transform), "Move")]
    public sealed class TransformMoveSegment : TransformSegment<Vector3>
    {
        public override IEnumerator CoExecute()
            => transform.CoMove(target, duration, easer.Evaluate);
    }

    [SegmentMenu(nameof(Transform), "MoveBy")]
    public sealed class TransformMoveBySegment : TransformSegment<Vector3>
    {
        public override IEnumerator CoExecute()
            => transform.CoMoveBy(target, duration, easer.Evaluate);
    }

    [SegmentMenu(nameof(Transform), "MoveX")]
    public sealed class TransformMoveXSegment : TransformSegment<float>
    {
        public override IEnumerator CoExecute()
            => transform.CoMoveX(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Transform), "MoveY")]
    public sealed class TransformMoveYSegment : TransformSegment<float>
    {
        public override IEnumerator CoExecute()
            => transform.CoMoveY(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Transform), "MoveZ")]
    public sealed class TransformMoveZSegment : TransformSegment<float>
    {
        public override IEnumerator CoExecute()
            => transform.CoMoveZ(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Transform), "LocalMove")]
    public sealed class TransformLocalMoveSegment : TransformSegment<Vector3>
    {
        public override IEnumerator CoExecute()
            => transform.CoLocalMove(target, duration, easer.Evaluate);
    }

    [SegmentMenu(nameof(Transform), "LocalMoveBy")]
    public sealed class TransformLocalMoveBySegment : TransformSegment<Vector3>
    {
        public override IEnumerator CoExecute()
            => transform.CoLocalMoveBy(target, duration, easer.Evaluate);
    }

    [SegmentMenu(nameof(Transform), "LocalMoveX")]
    public sealed class TransformLocalMoveXSegment : TransformSegment<float>
    {
        public override IEnumerator CoExecute()
            => transform.CoLocalMoveX(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Transform), "LocalMoveY")]
    public sealed class TransformLocalMoveYSegment : TransformSegment<float>
    {
        public override IEnumerator CoExecute()
            => transform.CoLocalMoveY(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Transform), "LocalMoveZ")]
    public sealed class TransformLocalMoveZSegment : TransformSegment<float>
    {
        public override IEnumerator CoExecute()
            => transform.CoLocalMoveZ(target, duration, easer.Evaluate);
    }

    [SegmentMenu(nameof(Transform), "Rotate")]
    public sealed class TransformRotateSegment : TransformSegment<Quaternion>
    {
        public override void OnAdded()
            => target = Quaternion.identity;

        public override IEnumerator CoExecute()
            => transform.CoRotate(target, duration, easer.Evaluate);
    }

    [SegmentMenu(nameof(Transform), "RotateBy")]
    public sealed class TransformRotateBySegment : TransformSegment<Quaternion>
    {
        public override void OnAdded()
            => target = Quaternion.identity;

        public override IEnumerator CoExecute()
            => transform.CoRotateBy(target, duration, easer.Evaluate);
    }

    [SegmentMenu(nameof(Transform), "LocalRotate")]
    public sealed class TransformLocalRotateSegment : TransformSegment<Quaternion>
    {
        public override void OnAdded()
            => target = Quaternion.identity;

        public override IEnumerator CoExecute()
            => transform.CoLocalRotate(target, duration, easer.Evaluate);
    }

    [SegmentMenu(nameof(Transform), "LocalRotateBy")]
    public sealed class TransformLocalRotateBySegment : TransformSegment<Quaternion>
    {
        public override void OnAdded()
            => target = Quaternion.identity;

        public override IEnumerator CoExecute()
            => transform.CoLocalRotateBy(target, duration, easer.Evaluate);
    }

    [SegmentMenu(nameof(Transform), "LookAt")]
    public sealed class TransformLookAtSegment : TransformSegment<Vector3>
    {
        public override IEnumerator CoExecute()
            => transform.CoLookAt(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Transform), "LocalScale")]
    public sealed class TransformLocalScaleSegment : TransformSegment<Vector3>
    {
        public override IEnumerator CoExecute()
            => transform.CoLocalScale(target, duration, easer.Evaluate);
    }

    [SegmentMenu(nameof(Transform), "LocalScaleBy")]
    public sealed class TransformLocalScaleBySegment : TransformSegment<Vector3>
    {
        public override IEnumerator CoExecute()
            => transform.CoLocalScaleBy(target, duration, easer.Evaluate);
    }

    [SegmentMenu(nameof(Transform), "LocalScaleX")]
    public sealed class TransformLocalScaleXSegment : TransformSegment<float>
    {
        public override IEnumerator CoExecute()
            => transform.CoLocalScaleX(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Transform), "LocalScaleY")]
    public sealed class TransformLocalScaleYSegment : TransformSegment<float>
    {
        public override IEnumerator CoExecute()
            => transform.CoLocalScaleY(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Transform), "LocalScaleZ")]
    public sealed class TransformLocalScaleZSegment : TransformSegment<float>
    {
        public override IEnumerator CoExecute()
            => transform.CoLocalScaleZ(target, duration, easer.Evaluate);
    }
}