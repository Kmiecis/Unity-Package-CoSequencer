using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines.Segments
{
    public abstract class AnimatorWithLayerSetSegment<TValue> : SetSegment<Animator, TValue>
    {
        public int layer;
    }

    public abstract class AnimatorWithLayerTowardsSegment<TValue> : TowardsSegment<Animator, TValue>
    {
        public int layer;
    }

    public abstract class AnimatorWithLayerBetweenSegment<TValue> : BetweenSegment<Animator, TValue>
    {
        public int layer;
    }

    public abstract class AnimatorWithIdSetSegment<TValue> : SetSegment<Animator, TValue>
    {
        [SerializeField] protected string _property;
        [SerializeField][HideInInspector] protected int _propertyId;

        public override void OnValidate()
            => _propertyId = Animator.StringToHash(_property);
    }

    public abstract class AnimatorWithIdTowardsSegment<TValue> : TowardsSegment<Animator, TValue>
    {
        [SerializeField] protected string _property;
        [SerializeField][HideInInspector] protected int _propertyId;

        public override void OnValidate()
            => _propertyId = Animator.StringToHash(_property);
    }

    public abstract class AnimatorWithIdBetweenSegment<TValue> : BetweenSegment<Animator, TValue>
    {
        [SerializeField] protected string _property;
        [SerializeField][HideInInspector] protected int _propertyId;

        public override void OnValidate()
            => _propertyId = Animator.StringToHash(_property);
    }

    #region FeetPivot
    [Serializable]
    [SegmentMenu("Set", SegmentPath.AnimatorFeetPivot, SegmentGroup.Core)]
    public sealed class AnimatorFeetPivotSetSegment : SetSegment<Animator, float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator Build()
            => component.CoFeetPivot(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.AnimatorFeetPivot, SegmentGroup.Core)]
    public sealed class AnimatorFeetPivotSegment : TowardsSegment<Animator, float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator Build()
            => component.CoFeetPivot(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.AnimatorFeetPivot, SegmentGroup.Core)]
    public sealed class AnimatorFeetPivotBetweenSegment : BetweenSegment<Animator, float>
    {
        public override void OnValidate()
        {
            start = Mathf.Clamp(target, 0.0f, 1.0f);
            target = Mathf.Clamp(target, 0.0f, 1.0f);
        }

        public override IEnumerator Build()
            => component.CoFeetPivot(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region PlaybackTime
    [Serializable]
    [SegmentMenu("Set", SegmentPath.AnimatorPlaybackTime, SegmentGroup.Core)]
    public sealed class AnimatorPlaybackTimeSetSegment : SetSegment<Animator, float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, component.recorderStartTime, component.recorderStopTime);

        public override IEnumerator Build()
            => component.CoPlaybackTime(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.AnimatorPlaybackTime, SegmentGroup.Core)]
    public sealed class AnimatorPlaybackTimeSegment : TowardsSegment<Animator, float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, component.recorderStartTime, component.recorderStopTime);

        public override IEnumerator Build()
            => component.CoPlaybackTime(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.AnimatorPlaybackTime, SegmentGroup.Core)]
    public sealed class AnimatorPlaybackTimeBetweenSegment : BetweenSegment<Animator, float>
    {
        public override void OnValidate()
        {
            start = Mathf.Clamp(target, component.recorderStartTime, component.recorderStopTime);
            target = Mathf.Clamp(target, component.recorderStartTime, component.recorderStopTime);
        }

        public override IEnumerator Build()
            => component.CoPlaybackTime(target, duration, easer.Evaluate);
    }
    #endregion

    #region RootMove
    [Serializable]
    [SegmentMenu("Set", SegmentPath.AnimatorRootMove, SegmentGroup.Core)]
    public sealed class AnimatorRootMoveSetSegment : SetSegment<Animator, Vector3>
    {
        public override IEnumerator Build()
            => component.CoRootMove(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.AnimatorRootMove, SegmentGroup.Core)]
    public sealed class AnimatorRootMoveSegment : TowardsSegment<Animator, Vector3>
    {
        public override IEnumerator Build()
            => component.CoRootMove(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.AnimatorRootMove, SegmentGroup.Core)]
    public sealed class AnimatorRootMoveBetweenSegment : BetweenSegment<Animator, Vector3>
    {
        public override IEnumerator Build()
            => component.CoRootMove(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Target", SegmentPath.AnimatorRootMove, SegmentGroup.Core)]
    public sealed class AnimatorRootMoveToSegment : TowardsSegment<Animator, Animator>
    {
        public override IEnumerator Build()
            => component.CoRootMove(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("By", SegmentPath.AnimatorRootMove, SegmentGroup.Core)]
    public sealed class AnimatorRootMoveBySegment : TowardsSegment<Animator, Vector3>
    {
        public override IEnumerator Build()
            => component.CoRootMoveBy(target, duration, easer.Evaluate);
    }
    #endregion

    #region RootRotate
    [Serializable]
    [SegmentMenu("Set", SegmentPath.AnimatorRootRotate, SegmentGroup.Core)]
    public sealed class AnimatorRootRotateSetSegment : SetSegment<Animator, Vector3>
    {
        public override IEnumerator Build()
            => component.CoRootRotate(Quaternion.Euler(target));
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.AnimatorRootRotate, SegmentGroup.Core)]
    public sealed class AnimatorRootRotateSegment : TowardsSegment<Animator, Vector3>
    {
        public override IEnumerator Build()
            => component.CoRootRotate(Quaternion.Euler(target), duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.AnimatorRootRotate, SegmentGroup.Core)]
    public sealed class AnimatorRootRotateBetweenSegment : BetweenSegment<Animator, Vector3>
    {
        public override IEnumerator Build()
            => component.CoRootRotate(Quaternion.Euler(start), Quaternion.Euler(target), duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Target", SegmentPath.AnimatorRootRotate, SegmentGroup.Core)]
    public sealed class AnimatorRootRotateAsSegment : TowardsSegment<Animator, Animator>
    {
        public override IEnumerator Build()
            => component.CoRootRotate(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("By", SegmentPath.AnimatorRootRotate, SegmentGroup.Core)]
    public sealed class AnimatorRootRotateBySegment : TowardsSegment<Animator, Vector3>
    {
        public override IEnumerator Build()
            => component.CoRootRotateBy(Quaternion.Euler(target), duration, easer.Evaluate);
    }
    #endregion

    #region Speed
    [Serializable]
    [SegmentMenu("Set", SegmentPath.AnimatorSpeed, SegmentGroup.Core)]
    public sealed class AnimatorSpeedSetSegment : SetSegment<Animator, float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator Build()
            => component.CoSpeed(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.AnimatorSpeed, SegmentGroup.Core)]
    public sealed class AnimatorSpeedSegment : TowardsSegment<Animator, float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator Build()
            => component.CoSpeed(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.AnimatorSpeed, SegmentGroup.Core)]
    public sealed class AnimatorSpeedBetweenSegment : BetweenSegment<Animator, float>
    {
        public override void OnValidate()
        {
            start = Mathf.Clamp(target, 0.0f, 1.0f);
            target = Mathf.Clamp(target, 0.0f, 1.0f);
        }

        public override IEnumerator Build()
            => component.CoSpeed(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region Float
    [Serializable]
    [SegmentMenu("Set", SegmentPath.AnimatorFloat, SegmentGroup.Core)]
    public sealed class AnimatorFloatSetSegment : AnimatorWithIdSetSegment<float>
    {
        public override IEnumerator Build()
            => component.CoFloat(_propertyId, target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.AnimatorFloat, SegmentGroup.Core)]
    public sealed class AnimatorFloatSegment : AnimatorWithIdTowardsSegment<float>
    {
        public override IEnumerator Build()
            => component.CoFloat(_propertyId, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.AnimatorFloat, SegmentGroup.Core)]
    public sealed class AnimatorFloatBetweenSegment : AnimatorWithIdBetweenSegment<float>
    {
        public override IEnumerator Build()
            => component.CoFloat(_propertyId, start, target, duration, easer.Evaluate);
    }
    #endregion

    #region LayerWeight
    [Serializable]
    [SegmentMenu("Set", SegmentPath.AnimatorLayerWeight, SegmentGroup.Core)]
    public sealed class AnimatorLayerWeightSetSegment : AnimatorWithLayerSetSegment<float>
    {
        public override IEnumerator Build()
            => component.CoLayerWeight(layer, target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.AnimatorLayerWeight, SegmentGroup.Core)]
    public sealed class AnimatorLayerWeightSegment : AnimatorWithLayerTowardsSegment<float>
    {
        public override IEnumerator Build()
            => component.CoLayerWeight(layer, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.AnimatorLayerWeight, SegmentGroup.Core)]
    public sealed class AnimatorLayerWeightBetweenSegment : AnimatorWithLayerBetweenSegment<float>
    {
        public override IEnumerator Build()
            => component.CoLayerWeight(layer, start, target, duration, easer.Evaluate);
    }
    #endregion

    #region LookAtPosition
    [Serializable]
    [SegmentMenu("Set", SegmentPath.AnimatorLookAtPosition, SegmentGroup.Core)]
    public sealed class AnimatorLookAtPositionSetSegment : SetSegment<Animator, Vector3>
    {
        public override IEnumerator Build()
            => component.CoLookAtPosition(target);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.AnimatorLookAtPosition, SegmentGroup.Core)]
    public sealed class AnimatorLookAtPositionBetweenSegment : BetweenSegment<Animator, Vector3>
    {
        public override IEnumerator Build()
            => component.CoLookAtPosition(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region LookAtWeight
    [Serializable]
    [SegmentMenu("Set", SegmentPath.AnimatorLookAtWeight, SegmentGroup.Core)]
    public sealed class AnimatorLookAtWeightSetSegment : SetSegment<Animator, float>
    {
        public override IEnumerator Build()
            => component.CoLookAtWeight(target);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.AnimatorLookAtWeight, SegmentGroup.Core)]
    public sealed class AnimatorLookAtWeightBetweenSegment : BetweenSegment<Animator, float>
    {
        public override IEnumerator Build()
            => component.CoLookAtWeight(start, target, duration, easer.Evaluate);
    }
    #endregion
}