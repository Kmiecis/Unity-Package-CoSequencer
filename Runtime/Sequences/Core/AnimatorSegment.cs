using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines.Segments
{
    public abstract class AnimatorSegment<T> : Segment
    {
        public Animator animator;
        public T target;
    }

    public abstract class AnimatorTimedSegment<T> : TimedSegment
    {
        public Animator animator;
        public T target;
    }

    public abstract class AnimatorBetweenSegment<T> : TimedSegment
    {
        public Animator animator;
        public T start;
        public T target;
    }

    public abstract class AnimatorWithIdSegmentBase : Segment
    {
        public Animator animator;
        [SerializeField] protected string _property;
        [SerializeField][HideInInspector] protected int _propertyId;

        public override void OnValidate()
        {
            _propertyId = Animator.StringToHash(_property);
        }
    }

    public abstract class AnimatorWithIdSegment<T> : AnimatorWithIdSegmentBase
    {
        public T target;
    }

    public abstract class AnimatorWithIdTimedSegment<T> : AnimatorWithIdSegmentBase
    {
        public T target;
        public float duration = 1.0f;
        public AnimationCurve easer = UAnimationCurve.EaseInOutNormalized();
    }

    public abstract class AnimatorWithIdBetweenSegment<T> : AnimatorWithIdSegmentBase
    {
        public T start;
        public T target;
        public float duration = 1.0f;
        public AnimationCurve easer = UAnimationCurve.EaseInOutNormalized();
    }

    public abstract class AnimatorWithLayerSegmentBase : Segment
    {
        public Animator animator;
        public int layer;
    }

    public abstract class AnimatorWithLayerSegment<T> : AnimatorWithLayerSegmentBase
    {
        public T target;
    }

    public abstract class AnimatorWithLayerTimedSegment<T> : AnimatorWithLayerSegmentBase
    {
        public T target;
        public float duration = 1.0f;
        public AnimationCurve easer = UAnimationCurve.EaseInOutNormalized();
    }

    public abstract class AnimatorWithLayerBetweenSegment<T> : AnimatorWithLayerSegmentBase
    {
        public T start;
        public T target;
        public float duration = 1.0f;
        public AnimationCurve easer = UAnimationCurve.EaseInOutNormalized();
    }

    #region FeetPivot
    [Serializable]
    [SegmentMenu("Towards", SegmentPath.AnimatorFeetPivot, SegmentGroup.Core)]
    public sealed class AnimatorFeetPivotSegment : AnimatorTimedSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator Build()
            => animator.CoFeetPivot(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Set", SegmentPath.AnimatorFeetPivot, SegmentGroup.Core)]
    public sealed class AnimatorFeetPivotSetSegment : AnimatorSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator Build()
            => animator.CoFeetPivot(target);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.AnimatorFeetPivot, SegmentGroup.Core)]
    public sealed class AnimatorFeetPivotBetweenSegment : AnimatorBetweenSegment<float>
    {
        public override void OnValidate()
        {
            start = Mathf.Clamp(target, 0.0f, 1.0f);
            target = Mathf.Clamp(target, 0.0f, 1.0f);
        }

        public override IEnumerator Build()
            => animator.CoFeetPivot(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region PlaybackTime
    [Serializable]
    [SegmentMenu("Towards", SegmentPath.AnimatorPlaybackTime, SegmentGroup.Core)]
    public sealed class AnimatorPlaybackTimeSegment : AnimatorTimedSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, animator.recorderStartTime, animator.recorderStopTime);

        public override IEnumerator Build()
            => animator.CoPlaybackTime(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Set", SegmentPath.AnimatorPlaybackTime, SegmentGroup.Core)]
    public sealed class AnimatorPlaybackTimeSetSegment : AnimatorSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, animator.recorderStartTime, animator.recorderStopTime);

        public override IEnumerator Build()
            => animator.CoPlaybackTime(target);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.AnimatorPlaybackTime, SegmentGroup.Core)]
    public sealed class AnimatorPlaybackTimeBetweenSegment : AnimatorBetweenSegment<float>
    {
        public override void OnValidate()
        {
            start = Mathf.Clamp(target, animator.recorderStartTime, animator.recorderStopTime);
            target = Mathf.Clamp(target, animator.recorderStartTime, animator.recorderStopTime);
        }

        public override IEnumerator Build()
            => animator.CoPlaybackTime(target, duration, easer.Evaluate);
    }
    #endregion

    #region RootMove
    [Serializable]
    [SegmentMenu("Set", SegmentPath.AnimatorRootMove, SegmentGroup.Core)]
    public sealed class AnimatorRootMoveSetSegment : AnimatorSegment<Vector3>
    {
        public override IEnumerator Build()
            => animator.CoRootMove(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.AnimatorRootMove, SegmentGroup.Core)]
    public sealed class AnimatorRootMoveSegment : AnimatorTimedSegment<Vector3>
    {
        public override IEnumerator Build()
            => animator.CoRootMove(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.AnimatorRootMove, SegmentGroup.Core)]
    public sealed class AnimatorRootMoveBetweenSegment : AnimatorBetweenSegment<Vector3>
    {
        public override IEnumerator Build()
            => animator.CoRootMove(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Target", SegmentPath.AnimatorRootMove, SegmentGroup.Core)]
    public sealed class AnimatorRootMoveToSegment : AnimatorTimedSegment<Animator>
    {
        public override IEnumerator Build()
            => animator.CoRootMove(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("By", SegmentPath.AnimatorRootMove, SegmentGroup.Core)]
    public sealed class AnimatorRootMoveBySegment : AnimatorTimedSegment<Vector3>
    {
        public override IEnumerator Build()
            => animator.CoRootMoveBy(target, duration, easer.Evaluate);
    }
    #endregion

    #region RootRotate
    [Serializable]
    [SegmentMenu("Set", SegmentPath.AnimatorRootRotate, SegmentGroup.Core)]
    public sealed class AnimatorRootRotateSetSegment : AnimatorSegment<Vector3>
    {
        public override IEnumerator Build()
            => animator.CoRootRotate(Quaternion.Euler(target));
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.AnimatorRootRotate, SegmentGroup.Core)]
    public sealed class AnimatorRootRotateSegment : AnimatorTimedSegment<Vector3>
    {
        public override IEnumerator Build()
            => animator.CoRootRotate(Quaternion.Euler(target), duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.AnimatorRootRotate, SegmentGroup.Core)]
    public sealed class AnimatorRootRotateBetweenSegment : AnimatorBetweenSegment<Vector3>
    {
        public override IEnumerator Build()
            => animator.CoRootRotate(Quaternion.Euler(start), Quaternion.Euler(target), duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Target", SegmentPath.AnimatorRootRotate, SegmentGroup.Core)]
    public sealed class AnimatorRootRotateAsSegment : AnimatorTimedSegment<Animator>
    {
        public override IEnumerator Build()
            => animator.CoRootRotate(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("By", SegmentPath.AnimatorRootRotate, SegmentGroup.Core)]
    public sealed class AnimatorRootRotateBySegment : AnimatorTimedSegment<Vector3>
    {
        public override IEnumerator Build()
            => animator.CoRootRotateBy(Quaternion.Euler(target), duration, easer.Evaluate);
    }
    #endregion

    #region Speed
    [Serializable]
    [SegmentMenu("Towards", SegmentPath.AnimatorSpeed, SegmentGroup.Core)]
    public sealed class AnimatorSpeedSegment : AnimatorTimedSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator Build()
            => animator.CoSpeed(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Set", SegmentPath.AnimatorSpeed, SegmentGroup.Core)]
    public sealed class AnimatorSpeedSetSegment : AnimatorSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator Build()
            => animator.CoSpeed(target);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.AnimatorSpeed, SegmentGroup.Core)]
    public sealed class AnimatorSpeedBetweenSegment : AnimatorBetweenSegment<float>
    {
        public override void OnValidate()
        {
            start = Mathf.Clamp(target, 0.0f, 1.0f);
            target = Mathf.Clamp(target, 0.0f, 1.0f);
        }

        public override IEnumerator Build()
            => animator.CoSpeed(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region Float
    [Serializable]
    [SegmentMenu("Towards", SegmentPath.AnimatorFloat, SegmentGroup.Core)]
    public sealed class AnimatorFloatSegment : AnimatorWithIdTimedSegment<float>
    {
        public override IEnumerator Build()
            => animator.CoFloat(_propertyId, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Set", SegmentPath.AnimatorFloat, SegmentGroup.Core)]
    public sealed class AnimatorFloatSetSegment : AnimatorWithIdSegment<float>
    {
        public override IEnumerator Build()
            => animator.CoFloat(_propertyId, target);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.AnimatorFloat, SegmentGroup.Core)]
    public sealed class AnimatorFloatBetweenSegment : AnimatorWithIdBetweenSegment<float>
    {
        public override IEnumerator Build()
            => animator.CoFloat(_propertyId, start, target, duration, easer.Evaluate);
    }
    #endregion

    #region LayerWeight
    [Serializable]
    [SegmentMenu("Towards", SegmentPath.AnimatorLayerWeight, SegmentGroup.Core)]
    public sealed class AnimatorLayerWeightSegment : AnimatorWithLayerTimedSegment<float>
    {
        public override IEnumerator Build()
            => animator.CoLayerWeight(layer, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Set", SegmentPath.AnimatorLayerWeight, SegmentGroup.Core)]
    public sealed class AnimatorLayerWeightSetSegment : AnimatorWithLayerSegment<float>
    {
        public override IEnumerator Build()
            => animator.CoLayerWeight(layer, target);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.AnimatorLayerWeight, SegmentGroup.Core)]
    public sealed class AnimatorLayerWeightBetweenSegment : AnimatorWithLayerBetweenSegment<float>
    {
        public override IEnumerator Build()
            => animator.CoLayerWeight(layer, start, target, duration, easer.Evaluate);
    }
    #endregion

    #region LookAtPosition
    [Serializable]
    [SegmentMenu("Set", SegmentPath.AnimatorLookAtPosition, SegmentGroup.Core)]
    public sealed class AnimatorLookAtPositionSetSegment : AnimatorSegment<Vector3>
    {
        public override IEnumerator Build()
            => animator.CoLookAtPosition(target);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.AnimatorLookAtPosition, SegmentGroup.Core)]
    public sealed class AnimatorLookAtPositionBetweenSegment : AnimatorBetweenSegment<Vector3>
    {
        public override IEnumerator Build()
            => animator.CoLookAtPosition(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region LookAtWeight
    [Serializable]
    [SegmentMenu("Set", SegmentPath.AnimatorLookAtWeight, SegmentGroup.Core)]
    public sealed class AnimatorLookAtWeightSetSegment : AnimatorSegment<float>
    {
        public override IEnumerator Build()
            => animator.CoLookAtWeight(target);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.AnimatorLookAtWeight, SegmentGroup.Core)]
    public sealed class AnimatorLookAtWeightBetweenSegment : AnimatorBetweenSegment<float>
    {
        public override IEnumerator Build()
            => animator.CoLookAtWeight(start, target, duration, easer.Evaluate);
    }
    #endregion
}