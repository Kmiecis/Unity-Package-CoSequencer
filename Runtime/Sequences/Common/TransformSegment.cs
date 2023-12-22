using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines
{
    [Serializable]
    public abstract class TransformSegment<T> : Segment
    {
        [SerializeField] protected Transform _transform;
        [SerializeField] protected T _target;
    }

    [SegmentMenu(nameof(Transform), "Move")]
    public sealed class TransformMoveSegment : TransformSegment<Vector3>
    {
        public override IEnumerator CoExecute()
            => _transform.CoMove(_target, _duration, _easer.Evaluate);
    }

    [SegmentMenu(nameof(Transform), "MoveX")]
    public sealed class TransformMoveXSegment : TransformSegment<float>
    {
        public override IEnumerator CoExecute()
            => _transform.CoMoveX(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Transform), "MoveY")]
    public sealed class TransformMoveYSegment : TransformSegment<float>
    {
        public override IEnumerator CoExecute()
            => _transform.CoMoveY(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Transform), "MoveZ")]
    public sealed class TransformMoveZSegment : TransformSegment<float>
    {
        public override IEnumerator CoExecute()
            => _transform.CoMoveZ(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Transform), "LocalMove")]
    public sealed class TransformLocalMoveSegment : TransformSegment<Vector3>
    {
        public override IEnumerator CoExecute()
            => _transform.CoLocalMove(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Transform), "LocalMoveX")]
    public sealed class TransformLocalMoveXSegment : TransformSegment<float>
    {
        public override IEnumerator CoExecute()
            => _transform.CoLocalMoveX(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Transform), "LocalMoveY")]
    public sealed class TransformLocalMoveYSegment : TransformSegment<float>
    {
        public override IEnumerator CoExecute()
            => _transform.CoLocalMoveY(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Transform), "LocalMoveZ")]
    public sealed class TransformLocalMoveZSegment : TransformSegment<float>
    {
        public override IEnumerator CoExecute()
            => _transform.CoLocalMoveZ(_target, _duration, _easer.Evaluate);
    }

    [SegmentMenu(nameof(Transform), "Rotate")]
    public sealed class TransformRotateSegment : TransformSegment<Quaternion>
    {
        public override IEnumerator CoExecute()
            => _transform.CoRotate(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Transform), "LocalRotate")]
    public sealed class TransformLocalRotateSegment : TransformSegment<Quaternion>
    {
        public override IEnumerator CoExecute()
            => _transform.CoLocalRotate(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Transform), "LookAt")]
    public sealed class TransformLookAtSegment : TransformSegment<Vector3>
    {
        public override IEnumerator CoExecute()
            => _transform.CoLookAt(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Transform), "LocalScale")]
    public sealed class TransformLocalScaleSegment : TransformSegment<Vector3>
    {
        public override IEnumerator CoExecute()
            => _transform.CoLocalScale(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Transform), "LocalScaleX")]
    public sealed class TransformLocalScaleXSegment : TransformSegment<float>
    {
        public override IEnumerator CoExecute()
            => _transform.CoLocalScaleX(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Transform), "LocalScaleY")]
    public sealed class TransformLocalScaleYSegment : TransformSegment<float>
    {
        public override IEnumerator CoExecute()
            => _transform.CoLocalScaleY(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Transform), "LocalScaleZ")]
    public sealed class TransformLocalScaleZSegment : TransformSegment<float>
    {
        public override IEnumerator CoExecute()
            => _transform.CoLocalScaleZ(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Transform), "LocalUniformScale")]
    public sealed class TransformLocalUniformScaleSegment : TransformSegment<float>
    {
        public override IEnumerator CoExecute()
            => _transform.CoLocalScale(_target, _duration, _easer.Evaluate);
    }
}