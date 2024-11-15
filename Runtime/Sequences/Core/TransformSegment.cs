using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines.Segments
{
    public abstract class TransformSegment<T> : Segment
    {
        public Transform transform;
        public T target;
    }

    public abstract class TransformTimedSegment<T> : TimedSegment
    {
        public Transform transform;
        public T target;
    }

    public abstract class TransformBetweenSegment<T> : TimedSegment
    {
        public Transform transform;
        public T start;
        public T target;
    }

    #region Move
    [Serializable]
    [SegmentMenu("Set", SegmentPath.TransformMove, SegmentGroup.Core)]
    public sealed class TransformMoveSetSegment : TransformSegment<Vector3>
    {
        public override IEnumerator Build()
            => transform.CoMove(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.TransformMove, SegmentGroup.Core)]
    public sealed class TransformMoveSegment : TransformTimedSegment<Vector3>
    {
        public override IEnumerator Build()
            => transform.CoMove(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Towards X", SegmentPath.TransformMove, SegmentGroup.Core)]
    public sealed class TransformMoveXSegment : TransformTimedSegment<float>
    {
        public override IEnumerator Build()
            => transform.CoMoveX(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Towards Y", SegmentPath.TransformMove, SegmentGroup.Core)]
    public sealed class TransformMoveYSegment : TransformTimedSegment<float>
    {
        public override IEnumerator Build()
            => transform.CoMoveY(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Towards Z", SegmentPath.TransformMove, SegmentGroup.Core)]
    public sealed class TransformMoveZSegment : TransformTimedSegment<float>
    {
        public override IEnumerator Build()
            => transform.CoMoveZ(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Towards XY", SegmentPath.TransformMove, SegmentGroup.Core)]
    public sealed class TransformMoveXYSegment : TransformTimedSegment<Vector2>
    {
        public override IEnumerator Build()
            => transform.CoMoveXY(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Towards YZ", SegmentPath.TransformMove, SegmentGroup.Core)]
    public sealed class TransformMoveYZSegment : TransformTimedSegment<Vector2>
    {
        public override IEnumerator Build()
            => transform.CoMoveYZ(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Towards XZ", SegmentPath.TransformMove, SegmentGroup.Core)]
    public sealed class TransformMoveXZSegment : TransformTimedSegment<Vector2>
    {
        public override IEnumerator Build()
            => transform.CoMoveXZ(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.TransformMove, SegmentGroup.Core)]
    public sealed class TransformMoveBetweenSegment : TransformBetweenSegment<Vector3>
    {
        public override IEnumerator Build()
            => transform.CoMove(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between X", SegmentPath.TransformMove, SegmentGroup.Core)]
    public sealed class TransformMoveBetweenXSegment : TransformBetweenSegment<float>
    {
        public override IEnumerator Build()
            => transform.CoMoveX(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between Y", SegmentPath.TransformMove, SegmentGroup.Core)]
    public sealed class TransformMoveBetweenYSegment : TransformBetweenSegment<float>
    {
        public override IEnumerator Build()
            => transform.CoMoveY(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between Z", SegmentPath.TransformMove, SegmentGroup.Core)]
    public sealed class TransformMoveBetweenZSegment : TransformBetweenSegment<float>
    {
        public override IEnumerator Build()
            => transform.CoMoveZ(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between XY", SegmentPath.TransformMove, SegmentGroup.Core)]
    public sealed class TransformMoveBetweenXYSegment : TransformBetweenSegment<Vector2>
    {
        public override IEnumerator Build()
            => transform.CoMoveXY(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between YZ", SegmentPath.TransformMove, SegmentGroup.Core)]
    public sealed class TransformMoveBetweenYZSegment : TransformBetweenSegment<Vector2>
    {
        public override IEnumerator Build()
            => transform.CoMoveYZ(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between XZ", SegmentPath.TransformMove, SegmentGroup.Core)]
    public sealed class TransformMoveBetweenXZSegment : TransformBetweenSegment<Vector2>
    {
        public override IEnumerator Build()
            => transform.CoMoveXZ(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Target", SegmentPath.TransformMove, SegmentGroup.Core)]
    public sealed class TransformMoveToSegment : TransformTimedSegment<Transform>
    {
        public override IEnumerator Build()
            => transform.CoMove(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("By", SegmentPath.TransformMove, SegmentGroup.Core)]
    public sealed class TransformMoveBySegment : TransformTimedSegment<Vector3>
    {
        public override IEnumerator Build()
            => transform.CoMoveBy(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("For", SegmentPath.TransformMove, SegmentGroup.Core)]
    public sealed class TransformMoveForSegment : TransformTimedSegment<Vector3>
    {
        public TransformMoveForSegment() =>
            easer = UAnimationCurve.One();

        public override IEnumerator Build()
            => transform.CoMoveFor(target, duration, easer.Evaluate);
    }
    #endregion

    #region Rotate
    [Serializable]
    [SegmentMenu("Set", SegmentPath.TransformRotate, SegmentGroup.Core)]
    public sealed class TransformRotateSetSegment : TransformSegment<Vector3>
    {
        public override IEnumerator Build()
            => transform.CoRotate(Quaternion.Euler(target));
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.TransformRotate, SegmentGroup.Core)]
    public sealed class TransformRotateSegment : TransformTimedSegment<Vector3>
    {
        public override IEnumerator Build()
            => transform.CoRotate(Quaternion.Euler(target), duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.TransformRotate, SegmentGroup.Core)]
    public sealed class TransformRotateBetweenSegment : TransformBetweenSegment<Vector3>
    {
        public override IEnumerator Build()
            => transform.CoRotate(Quaternion.Euler(start), Quaternion.Euler(target), duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Target", SegmentPath.TransformRotate, SegmentGroup.Core)]
    public sealed class TransformRotateAsSegment : TransformTimedSegment<Transform>
    {
        public override IEnumerator Build()
            => transform.CoRotate(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("By", SegmentPath.TransformRotate, SegmentGroup.Core)]
    public sealed class TransformRotateBySegment : TransformTimedSegment<Vector3>
    {
        public override IEnumerator Build()
            => transform.CoRotateBy(Quaternion.Euler(target), duration, easer.Evaluate);
    }
    #endregion

    #region LocalMove
    [Serializable]
    [SegmentMenu("Set", SegmentPath.TransformLocalMove, SegmentGroup.Core)]
    public sealed class TransformLocalMoveSetSegment : TransformSegment<Vector3>
    {
        public override IEnumerator Build()
            => transform.CoLocalMove(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.TransformLocalMove, SegmentGroup.Core)]
    public sealed class TransformLocalMoveSegment : TransformTimedSegment<Vector3>
    {
        public override IEnumerator Build()
            => transform.CoLocalMove(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Towards X", SegmentPath.TransformLocalMove, SegmentGroup.Core)]
    public sealed class TransformLocalMoveXSegment : TransformTimedSegment<float>
    {
        public override IEnumerator Build()
            => transform.CoLocalMoveX(target, duration, easer.Evaluate);
    }
    
    [Serializable]
    [SegmentMenu("Towards Y", SegmentPath.TransformLocalMove, SegmentGroup.Core)]
    public sealed class TransformLocalMoveYSegment : TransformTimedSegment<float>
    {
        public override IEnumerator Build()
            => transform.CoLocalMoveY(target, duration, easer.Evaluate);
    }
    
    [Serializable]
    [SegmentMenu("Towards Z", SegmentPath.TransformLocalMove, SegmentGroup.Core)]
    public sealed class TransformLocalMoveZSegment : TransformTimedSegment<float>
    {
        public override IEnumerator Build()
            => transform.CoLocalMoveZ(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Towards XY", SegmentPath.TransformLocalMove, SegmentGroup.Core)]
    public sealed class TransformLocalMoveXYSegment : TransformTimedSegment<Vector2>
    {
        public override IEnumerator Build()
            => transform.CoLocalMoveXY(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Towards YZ", SegmentPath.TransformLocalMove, SegmentGroup.Core)]
    public sealed class TransformLocalMoveYZSegment : TransformTimedSegment<Vector2>
    {
        public override IEnumerator Build()
            => transform.CoLocalMoveYZ(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Towards XZ", SegmentPath.TransformLocalMove, SegmentGroup.Core)]
    public sealed class TransformLocalMoveXZSegment : TransformTimedSegment<Vector2>
    {
        public override IEnumerator Build()
            => transform.CoLocalMoveXZ(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.TransformLocalMove, SegmentGroup.Core)]
    public sealed class TransformLocalMoveBetweenSegment : TransformBetweenSegment<Vector3>
    {
        public override IEnumerator Build()
            => transform.CoLocalMove(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between X", SegmentPath.TransformLocalMove, SegmentGroup.Core)]
    public sealed class TransformLocalMoveBetweenXSegment : TransformBetweenSegment<float>
    {
        public override IEnumerator Build()
            => transform.CoLocalMoveX(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between Y", SegmentPath.TransformLocalMove, SegmentGroup.Core)]
    public sealed class TransformLocalMoveBetweenYSegment : TransformBetweenSegment<float>
    {
        public override IEnumerator Build()
            => transform.CoLocalMoveY(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between Z", SegmentPath.TransformLocalMove, SegmentGroup.Core)]
    public sealed class TransformLocalMoveBetweenZSegment : TransformBetweenSegment<float>
    {
        public override IEnumerator Build()
            => transform.CoLocalMoveZ(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between XY", SegmentPath.TransformLocalMove, SegmentGroup.Core)]
    public sealed class TransformLocalMoveBetweenXYSegment : TransformBetweenSegment<Vector2>
    {
        public override IEnumerator Build()
            => transform.CoLocalMoveXY(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between YZ", SegmentPath.TransformLocalMove, SegmentGroup.Core)]
    public sealed class TransformLocalMoveBetweenYZSegment : TransformBetweenSegment<Vector2>
    {
        public override IEnumerator Build()
            => transform.CoLocalMoveYZ(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between XZ", SegmentPath.TransformLocalMove, SegmentGroup.Core)]
    public sealed class TransformLocalMoveBetweenXZSegment : TransformBetweenSegment<Vector2>
    {
        public override IEnumerator Build()
            => transform.CoLocalMoveXZ(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Target", SegmentPath.TransformLocalMove, SegmentGroup.Core)]
    public sealed class TransformLocalMoveToSegment : TransformTimedSegment<Transform>
    {
        public override IEnumerator Build()
            => transform.CoLocalMove(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("By", SegmentPath.TransformLocalMove, SegmentGroup.Core)]
    public sealed class TransformLocalMoveBySegment : TransformTimedSegment<Vector3>
    {
        public override IEnumerator Build()
            => transform.CoLocalMoveBy(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("For", SegmentPath.TransformLocalMove, SegmentGroup.Core)]
    public sealed class TransformLocalMoveForSegment : TransformTimedSegment<Vector3>
    {
        public TransformLocalMoveForSegment() =>
            easer = UAnimationCurve.One();

        public override IEnumerator Build()
            => transform.CoLocalMoveFor(target, duration, easer.Evaluate);
    }
    #endregion

    #region LocalRotate
    [Serializable]
    [SegmentMenu("Set", SegmentPath.TransformLocalRotate, SegmentGroup.Core)]
    public sealed class TransformLocalRotateSetSegment : TransformSegment<Vector3>
    {
        public override IEnumerator Build()
            => transform.CoLocalRotate(Quaternion.Euler(target));
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.TransformLocalRotate, SegmentGroup.Core)]
    public sealed class TransformLocalRotateSegment : TransformTimedSegment<Vector3>
    {
        public override IEnumerator Build()
            => transform.CoLocalRotate(Quaternion.Euler(target), duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.TransformLocalRotate, SegmentGroup.Core)]
    public sealed class TransformLocalRotateBetweenSegment : TransformBetweenSegment<Vector3>
    {
        public override IEnumerator Build()
            => transform.CoLocalRotate(Quaternion.Euler(start), Quaternion.Euler(target), duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Target", SegmentPath.TransformLocalRotate, SegmentGroup.Core)]
    public sealed class TransformLocalRotateAsSegment : TransformTimedSegment<Transform>
    {
        public override IEnumerator Build()
            => transform.CoLocalRotate(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("By", SegmentPath.TransformLocalRotate, SegmentGroup.Core)]
    public sealed class TransformLocalRotateBySegment : TransformTimedSegment<Vector3>
    {
        public override IEnumerator Build()
            => transform.CoLocalRotateBy(Quaternion.Euler(target), duration, easer.Evaluate);
    }
    #endregion

    #region LocalScale
    [Serializable]
    [SegmentMenu("Set", SegmentPath.TransformLocalScale, SegmentGroup.Core)]
    public sealed class TransformLocalScaleSetSegment : TransformSegment<Vector3>
    {
        public override IEnumerator Build()
            => transform.CoLocalScale(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.TransformLocalScale, SegmentGroup.Core)]
    public sealed class TransformLocalScaleSegment : TransformTimedSegment<Vector3>
    {
        public override IEnumerator Build()
            => transform.CoLocalScale(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Towards X", SegmentPath.TransformLocalScale, SegmentGroup.Core)]
    public sealed class TransformLocalScaleXSegment : TransformTimedSegment<float>
    {
        public override IEnumerator Build()
            => transform.CoLocalScaleX(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Towards Y", SegmentPath.TransformLocalScale, SegmentGroup.Core)]
    public sealed class TransformLocalScaleYSegment : TransformTimedSegment<float>
    {
        public override IEnumerator Build()
            => transform.CoLocalScaleY(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Towards Z", SegmentPath.TransformLocalScale, SegmentGroup.Core)]
    public sealed class TransformLocalScaleZSegment : TransformTimedSegment<float>
    {
        public override IEnumerator Build()
            => transform.CoLocalScaleZ(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Towards XY", SegmentPath.TransformLocalScale, SegmentGroup.Core)]
    public sealed class TransformLocalScaleXYSegment : TransformTimedSegment<Vector2>
    {
        public override IEnumerator Build()
            => transform.CoLocalScaleXY(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Towards YZ", SegmentPath.TransformLocalScale, SegmentGroup.Core)]
    public sealed class TransformLocalScaleYZSegment : TransformTimedSegment<Vector2>
    {
        public override IEnumerator Build()
            => transform.CoLocalScaleYZ(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Towards XZ", SegmentPath.TransformLocalScale, SegmentGroup.Core)]
    public sealed class TransformLocalScaleXZSegment : TransformTimedSegment<Vector2>
    {
        public override IEnumerator Build()
            => transform.CoLocalScaleXZ(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.TransformLocalScale, SegmentGroup.Core)]
    public sealed class TransformLocalScaleBetweenSegment : TransformBetweenSegment<Vector3>
    {
        public override IEnumerator Build()
            => transform.CoLocalScale(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between X", SegmentPath.TransformLocalScale, SegmentGroup.Core)]
    public sealed class TransformLocalScaleBetweenXSegment : TransformBetweenSegment<float>
    {
        public override IEnumerator Build()
            => transform.CoLocalScaleX(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between Y", SegmentPath.TransformLocalScale, SegmentGroup.Core)]
    public sealed class TransformLocalScaleBetweenYSegment : TransformBetweenSegment<float>
    {
        public override IEnumerator Build()
            => transform.CoLocalScaleY(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between Z", SegmentPath.TransformLocalScale, SegmentGroup.Core)]
    public sealed class TransformLocalScaleBetweenZSegment : TransformBetweenSegment<float>
    {
        public override IEnumerator Build()
            => transform.CoLocalScaleZ(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between XY", SegmentPath.TransformLocalScale, SegmentGroup.Core)]
    public sealed class TransformLocalScaleBetweenXYSegment : TransformBetweenSegment<Vector2>
    {
        public override IEnumerator Build()
            => transform.CoLocalScaleXY(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between YZ", SegmentPath.TransformLocalScale, SegmentGroup.Core)]
    public sealed class TransformLocalScaleBetweenYZSegment : TransformBetweenSegment<Vector2>
    {
        public override IEnumerator Build()
            => transform.CoLocalScaleYZ(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between XZ", SegmentPath.TransformLocalScale, SegmentGroup.Core)]
    public sealed class TransformLocalScaleBetweenXZSegment : TransformBetweenSegment<Vector2>
    {
        public override IEnumerator Build()
            => transform.CoLocalScaleXZ(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Target", SegmentPath.TransformLocalScale, SegmentGroup.Core)]
    public sealed class TransformLocalScaleAsSegment : TransformTimedSegment<Transform>
    {
        public override IEnumerator Build()
            => transform.CoLocalScale(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("By", SegmentPath.TransformLocalScale, SegmentGroup.Core)]
    public sealed class TransformLocalScaleBySegment : TransformTimedSegment<Vector3>
    {
        public override IEnumerator Build()
            => transform.CoLocalScaleBy(target, duration, easer.Evaluate);
    }
    #endregion

    #region LookAt
    [Serializable]
    [SegmentMenu("Position", SegmentPath.TransformLookAt, SegmentGroup.Core)]
    public sealed class TransformLookAtPositionSegment : TransformTimedSegment<Vector3>
    {
        public override IEnumerator Build()
            => transform.CoLookAt(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Target", SegmentPath.TransformLookAt, SegmentGroup.Core)]
    public sealed class TransformLookAtTransformSegment : TransformTimedSegment<Transform>
    {
        public override IEnumerator Build()
            => transform.CoLookAt(target, duration, easer.Evaluate);
    }
    #endregion
}