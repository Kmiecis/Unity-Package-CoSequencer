using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines.Segments
{
    #region Move
    [Serializable]
    [SegmentMenu("Set", SegmentPath.TransformMove, SegmentGroup.Core)]
    public sealed class TransformMoveSetSegment : SetSegment<Transform, Vector3>
    {
        public override IEnumerator Build()
            => component.CoMove(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.TransformMove, SegmentGroup.Core)]
    public sealed class TransformMoveSegment : TowardsSegment<Transform, Vector3>
    {
        public override IEnumerator Build()
            => component.CoMove(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Towards X", SegmentPath.TransformMove, SegmentGroup.Core)]
    public sealed class TransformMoveXSegment : TowardsSegment<Transform, float>
    {
        public override IEnumerator Build()
            => component.CoMoveX(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Towards Y", SegmentPath.TransformMove, SegmentGroup.Core)]
    public sealed class TransformMoveYSegment : TowardsSegment<Transform, float>
    {
        public override IEnumerator Build()
            => component.CoMoveY(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Towards Z", SegmentPath.TransformMove, SegmentGroup.Core)]
    public sealed class TransformMoveZSegment : TowardsSegment<Transform, float>
    {
        public override IEnumerator Build()
            => component.CoMoveZ(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Towards XY", SegmentPath.TransformMove, SegmentGroup.Core)]
    public sealed class TransformMoveXYSegment : TowardsSegment<Transform, Vector2>
    {
        public override IEnumerator Build()
            => component.CoMoveXY(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Towards YZ", SegmentPath.TransformMove, SegmentGroup.Core)]
    public sealed class TransformMoveYZSegment : TowardsSegment<Transform, Vector2>
    {
        public override IEnumerator Build()
            => component.CoMoveYZ(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Towards XZ", SegmentPath.TransformMove, SegmentGroup.Core)]
    public sealed class TransformMoveXZSegment : TowardsSegment<Transform, Vector2>
    {
        public override IEnumerator Build()
            => component.CoMoveXZ(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.TransformMove, SegmentGroup.Core)]
    public sealed class TransformMoveBetweenSegment : BetweenSegment<Transform, Vector3>
    {
        public override IEnumerator Build()
            => component.CoMove(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between X", SegmentPath.TransformMove, SegmentGroup.Core)]
    public sealed class TransformMoveBetweenXSegment : BetweenSegment<Transform, float>
    {
        public override IEnumerator Build()
            => component.CoMoveX(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between Y", SegmentPath.TransformMove, SegmentGroup.Core)]
    public sealed class TransformMoveBetweenYSegment : BetweenSegment<Transform, float>
    {
        public override IEnumerator Build()
            => component.CoMoveY(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between Z", SegmentPath.TransformMove, SegmentGroup.Core)]
    public sealed class TransformMoveBetweenZSegment : BetweenSegment<Transform, float>
    {
        public override IEnumerator Build()
            => component.CoMoveZ(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between XY", SegmentPath.TransformMove, SegmentGroup.Core)]
    public sealed class TransformMoveBetweenXYSegment : BetweenSegment<Transform, Vector2>
    {
        public override IEnumerator Build()
            => component.CoMoveXY(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between YZ", SegmentPath.TransformMove, SegmentGroup.Core)]
    public sealed class TransformMoveBetweenYZSegment : BetweenSegment<Transform, Vector2>
    {
        public override IEnumerator Build()
            => component.CoMoveYZ(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between XZ", SegmentPath.TransformMove, SegmentGroup.Core)]
    public sealed class TransformMoveBetweenXZSegment : BetweenSegment<Transform, Vector2>
    {
        public override IEnumerator Build()
            => component.CoMoveXZ(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Target", SegmentPath.TransformMove, SegmentGroup.Core)]
    public sealed class TransformMoveToSegment : TowardsSegment<Transform, Transform>
    {
        public override IEnumerator Build()
            => component.CoMove(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("By", SegmentPath.TransformMove, SegmentGroup.Core)]
    public sealed class TransformMoveBySegment : TowardsSegment<Transform, Vector3>
    {
        public override IEnumerator Build()
            => component.CoMoveBy(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("For", SegmentPath.TransformMove, SegmentGroup.Core)]
    public sealed class TransformMoveForSegment : TowardsSegment<Transform, Vector3>
    {
        public TransformMoveForSegment() =>
            easer = UAnimationCurve.One();

        public override IEnumerator Build()
            => component.CoMoveFor(target, duration, easer.Evaluate);
    }
    #endregion

    #region Rotate
    [Serializable]
    [SegmentMenu("Set", SegmentPath.TransformRotate, SegmentGroup.Core)]
    public sealed class TransformRotateSetSegment : SetSegment<Transform, Vector3>
    {
        public override IEnumerator Build()
            => component.CoRotate(Quaternion.Euler(target));
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.TransformRotate, SegmentGroup.Core)]
    public sealed class TransformRotateSegment : TowardsSegment<Transform, Vector3>
    {
        public override IEnumerator Build()
            => component.CoRotate(Quaternion.Euler(target), duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.TransformRotate, SegmentGroup.Core)]
    public sealed class TransformRotateBetweenSegment : BetweenSegment<Transform, Vector3>
    {
        public override IEnumerator Build()
            => component.CoRotate(Quaternion.Euler(start), Quaternion.Euler(target), duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Target", SegmentPath.TransformRotate, SegmentGroup.Core)]
    public sealed class TransformRotateAsSegment : TowardsSegment<Transform, Transform>
    {
        public override IEnumerator Build()
            => component.CoRotate(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("By", SegmentPath.TransformRotate, SegmentGroup.Core)]
    public sealed class TransformRotateBySegment : TowardsSegment<Transform, Vector3>
    {
        public override IEnumerator Build()
            => component.CoRotateBy(Quaternion.Euler(target), duration, easer.Evaluate);
    }
    #endregion

    #region LocalMove
    [Serializable]
    [SegmentMenu("Set", SegmentPath.TransformLocalMove, SegmentGroup.Core)]
    public sealed class TransformLocalMoveSetSegment : SetSegment<Transform, Vector3>
    {
        public override IEnumerator Build()
            => component.CoLocalMove(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.TransformLocalMove, SegmentGroup.Core)]
    public sealed class TransformLocalMoveSegment : TowardsSegment<Transform, Vector3>
    {
        public override IEnumerator Build()
            => component.CoLocalMove(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Towards X", SegmentPath.TransformLocalMove, SegmentGroup.Core)]
    public sealed class TransformLocalMoveXSegment : TowardsSegment<Transform, float>
    {
        public override IEnumerator Build()
            => component.CoLocalMoveX(target, duration, easer.Evaluate);
    }
    
    [Serializable]
    [SegmentMenu("Towards Y", SegmentPath.TransformLocalMove, SegmentGroup.Core)]
    public sealed class TransformLocalMoveYSegment : TowardsSegment<Transform, float>
    {
        public override IEnumerator Build()
            => component.CoLocalMoveY(target, duration, easer.Evaluate);
    }
    
    [Serializable]
    [SegmentMenu("Towards Z", SegmentPath.TransformLocalMove, SegmentGroup.Core)]
    public sealed class TransformLocalMoveZSegment : TowardsSegment<Transform, float>
    {
        public override IEnumerator Build()
            => component.CoLocalMoveZ(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Towards XY", SegmentPath.TransformLocalMove, SegmentGroup.Core)]
    public sealed class TransformLocalMoveXYSegment : TowardsSegment<Transform, Vector2>
    {
        public override IEnumerator Build()
            => component.CoLocalMoveXY(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Towards YZ", SegmentPath.TransformLocalMove, SegmentGroup.Core)]
    public sealed class TransformLocalMoveYZSegment : TowardsSegment<Transform, Vector2>
    {
        public override IEnumerator Build()
            => component.CoLocalMoveYZ(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Towards XZ", SegmentPath.TransformLocalMove, SegmentGroup.Core)]
    public sealed class TransformLocalMoveXZSegment : TowardsSegment<Transform, Vector2>
    {
        public override IEnumerator Build()
            => component.CoLocalMoveXZ(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.TransformLocalMove, SegmentGroup.Core)]
    public sealed class TransformLocalMoveBetweenSegment : BetweenSegment<Transform, Vector3>
    {
        public override IEnumerator Build()
            => component.CoLocalMove(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between X", SegmentPath.TransformLocalMove, SegmentGroup.Core)]
    public sealed class TransformLocalMoveBetweenXSegment : BetweenSegment<Transform, float>
    {
        public override IEnumerator Build()
            => component.CoLocalMoveX(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between Y", SegmentPath.TransformLocalMove, SegmentGroup.Core)]
    public sealed class TransformLocalMoveBetweenYSegment : BetweenSegment<Transform, float>
    {
        public override IEnumerator Build()
            => component.CoLocalMoveY(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between Z", SegmentPath.TransformLocalMove, SegmentGroup.Core)]
    public sealed class TransformLocalMoveBetweenZSegment : BetweenSegment<Transform, float>
    {
        public override IEnumerator Build()
            => component.CoLocalMoveZ(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between XY", SegmentPath.TransformLocalMove, SegmentGroup.Core)]
    public sealed class TransformLocalMoveBetweenXYSegment : BetweenSegment<Transform, Vector2>
    {
        public override IEnumerator Build()
            => component.CoLocalMoveXY(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between YZ", SegmentPath.TransformLocalMove, SegmentGroup.Core)]
    public sealed class TransformLocalMoveBetweenYZSegment : BetweenSegment<Transform, Vector2>
    {
        public override IEnumerator Build()
            => component.CoLocalMoveYZ(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between XZ", SegmentPath.TransformLocalMove, SegmentGroup.Core)]
    public sealed class TransformLocalMoveBetweenXZSegment : BetweenSegment<Transform, Vector2>
    {
        public override IEnumerator Build()
            => component.CoLocalMoveXZ(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Target", SegmentPath.TransformLocalMove, SegmentGroup.Core)]
    public sealed class TransformLocalMoveToSegment : TowardsSegment<Transform, Transform>
    {
        public override IEnumerator Build()
            => component.CoLocalMove(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("By", SegmentPath.TransformLocalMove, SegmentGroup.Core)]
    public sealed class TransformLocalMoveBySegment : TowardsSegment<Transform, Vector3>
    {
        public override IEnumerator Build()
            => component.CoLocalMoveBy(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("For", SegmentPath.TransformLocalMove, SegmentGroup.Core)]
    public sealed class TransformLocalMoveForSegment : TowardsSegment<Transform, Vector3>
    {
        public TransformLocalMoveForSegment() =>
            easer = UAnimationCurve.One();

        public override IEnumerator Build()
            => component.CoLocalMoveFor(target, duration, easer.Evaluate);
    }
    #endregion

    #region LocalRotate
    [Serializable]
    [SegmentMenu("Set", SegmentPath.TransformLocalRotate, SegmentGroup.Core)]
    public sealed class TransformLocalRotateSetSegment : SetSegment<Transform, Vector3>
    {
        public override IEnumerator Build()
            => component.CoLocalRotate(Quaternion.Euler(target));
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.TransformLocalRotate, SegmentGroup.Core)]
    public sealed class TransformLocalRotateSegment : TowardsSegment<Transform, Vector3>
    {
        public override IEnumerator Build()
            => component.CoLocalRotate(Quaternion.Euler(target), duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.TransformLocalRotate, SegmentGroup.Core)]
    public sealed class TransformLocalRotateBetweenSegment : BetweenSegment<Transform, Vector3>
    {
        public override IEnumerator Build()
            => component.CoLocalRotate(Quaternion.Euler(start), Quaternion.Euler(target), duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Target", SegmentPath.TransformLocalRotate, SegmentGroup.Core)]
    public sealed class TransformLocalRotateAsSegment : TowardsSegment<Transform, Transform>
    {
        public override IEnumerator Build()
            => component.CoLocalRotate(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("By", SegmentPath.TransformLocalRotate, SegmentGroup.Core)]
    public sealed class TransformLocalRotateBySegment : TowardsSegment<Transform, Vector3>
    {
        public override IEnumerator Build()
            => component.CoLocalRotateBy(Quaternion.Euler(target), duration, easer.Evaluate);
    }
    #endregion

    #region LocalScale
    [Serializable]
    [SegmentMenu("Set", SegmentPath.TransformLocalScale, SegmentGroup.Core)]
    public sealed class TransformLocalScaleSetSegment : SetSegment<Transform, Vector3>
    {
        public override IEnumerator Build()
            => component.CoLocalScale(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.TransformLocalScale, SegmentGroup.Core)]
    public sealed class TransformLocalScaleSegment : TowardsSegment<Transform, Vector3>
    {
        public override IEnumerator Build()
            => component.CoLocalScale(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Towards X", SegmentPath.TransformLocalScale, SegmentGroup.Core)]
    public sealed class TransformLocalScaleXSegment : TowardsSegment<Transform, float>
    {
        public override IEnumerator Build()
            => component.CoLocalScaleX(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Towards Y", SegmentPath.TransformLocalScale, SegmentGroup.Core)]
    public sealed class TransformLocalScaleYSegment : TowardsSegment<Transform, float>
    {
        public override IEnumerator Build()
            => component.CoLocalScaleY(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Towards Z", SegmentPath.TransformLocalScale, SegmentGroup.Core)]
    public sealed class TransformLocalScaleZSegment : TowardsSegment<Transform, float>
    {
        public override IEnumerator Build()
            => component.CoLocalScaleZ(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Towards XY", SegmentPath.TransformLocalScale, SegmentGroup.Core)]
    public sealed class TransformLocalScaleXYSegment : TowardsSegment<Transform, Vector2>
    {
        public override IEnumerator Build()
            => component.CoLocalScaleXY(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Towards YZ", SegmentPath.TransformLocalScale, SegmentGroup.Core)]
    public sealed class TransformLocalScaleYZSegment : TowardsSegment<Transform, Vector2>
    {
        public override IEnumerator Build()
            => component.CoLocalScaleYZ(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Towards XZ", SegmentPath.TransformLocalScale, SegmentGroup.Core)]
    public sealed class TransformLocalScaleXZSegment : TowardsSegment<Transform, Vector2>
    {
        public override IEnumerator Build()
            => component.CoLocalScaleXZ(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.TransformLocalScale, SegmentGroup.Core)]
    public sealed class TransformLocalScaleBetweenSegment : BetweenSegment<Transform, Vector3>
    {
        public override IEnumerator Build()
            => component.CoLocalScale(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between X", SegmentPath.TransformLocalScale, SegmentGroup.Core)]
    public sealed class TransformLocalScaleBetweenXSegment : BetweenSegment<Transform, float>
    {
        public override IEnumerator Build()
            => component.CoLocalScaleX(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between Y", SegmentPath.TransformLocalScale, SegmentGroup.Core)]
    public sealed class TransformLocalScaleBetweenYSegment : BetweenSegment<Transform, float>
    {
        public override IEnumerator Build()
            => component.CoLocalScaleY(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between Z", SegmentPath.TransformLocalScale, SegmentGroup.Core)]
    public sealed class TransformLocalScaleBetweenZSegment : BetweenSegment<Transform, float>
    {
        public override IEnumerator Build()
            => component.CoLocalScaleZ(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between XY", SegmentPath.TransformLocalScale, SegmentGroup.Core)]
    public sealed class TransformLocalScaleBetweenXYSegment : BetweenSegment<Transform, Vector2>
    {
        public override IEnumerator Build()
            => component.CoLocalScaleXY(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between YZ", SegmentPath.TransformLocalScale, SegmentGroup.Core)]
    public sealed class TransformLocalScaleBetweenYZSegment : BetweenSegment<Transform, Vector2>
    {
        public override IEnumerator Build()
            => component.CoLocalScaleYZ(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between XZ", SegmentPath.TransformLocalScale, SegmentGroup.Core)]
    public sealed class TransformLocalScaleBetweenXZSegment : BetweenSegment<Transform, Vector2>
    {
        public override IEnumerator Build()
            => component.CoLocalScaleXZ(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Target", SegmentPath.TransformLocalScale, SegmentGroup.Core)]
    public sealed class TransformLocalScaleAsSegment : TowardsSegment<Transform, Transform>
    {
        public override IEnumerator Build()
            => component.CoLocalScale(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("By", SegmentPath.TransformLocalScale, SegmentGroup.Core)]
    public sealed class TransformLocalScaleBySegment : TowardsSegment<Transform, Vector3>
    {
        public override IEnumerator Build()
            => component.CoLocalScaleBy(target, duration, easer.Evaluate);
    }
    #endregion

    #region LookAt
    [Serializable]
    [SegmentMenu("Position", SegmentPath.TransformLookAt, SegmentGroup.Core)]
    public sealed class TransformLookAtPositionSegment : TowardsSegment<Transform, Vector3>
    {
        public override IEnumerator Build()
            => component.CoLookAt(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Target", SegmentPath.TransformLookAt, SegmentGroup.Core)]
    public sealed class TransformLookAtTransformSegment : TowardsSegment<Transform, Transform>
    {
        public override IEnumerator Build()
            => component.CoLookAt(target, duration, easer.Evaluate);
    }
    #endregion
}