using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Common.Coroutines
{
    public static class AnimatorExtensions
    {
        #region FeetPivot
        public static IEnumerator CoFeetPivot(this Animator self, float target)
            => Yield.Into(target, self.SetFeetPivot);

        public static IEnumerator CoFeetPivot(this Animator self, float target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetFeetPivot, target, self.SetFeetPivot, timer);

        public static IEnumerator CoFeetPivot(this Animator self, float start, float target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetFeetPivot, timer);

        public static IEnumerator CoFeetPivot(this Animator self, float target, float duration, Func<float, float> easer = null)
            => self.CoFeetPivot(target, Yield.Time(duration, easer));

        public static IEnumerator CoFeetPivot(this Animator self, float start, float target, float duration, Func<float, float> easer = null)
            => self.CoFeetPivot(start, target, Yield.Time(duration, easer));
        #endregion

        #region PlaybackTime
        public static IEnumerator CoPlaybackTime(this Animator self, float target)
            => Yield.Into(target, self.SetPlaybackTime);

        public static IEnumerator CoPlaybackTime(this Animator self, float target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetPlaybackTime, target, self.SetPlaybackTime, timer);

        public static IEnumerator CoPlaybackTime(this Animator self, float start, float target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetPlaybackTime, timer);

        public static IEnumerator CoPlaybackTime(this Animator self, float target, float duration, Func<float, float> easer = null)
            => self.CoPlaybackTime(target, Yield.Time(duration, easer));

        public static IEnumerator CoPlaybackTime(this Animator self, float start, float target, float duration, Func<float, float> easer = null)
            => self.CoPlaybackTime(start, target, Yield.Time(duration, easer));
        #endregion

        #region RootMove
        public static IEnumerator CoRootMove(this Animator self, Vector3 target)
            => Yield.Into(target, self.SetRootPosition);

        public static IEnumerator CoRootMove(this Animator self, Vector3 target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetRootPosition, target, self.SetRootPosition, timer);

        public static IEnumerator CoRootMove(this Animator self, Vector3 start, Vector3 target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetRootPosition, timer);

        public static IEnumerator CoRootMove(this Animator self, Animator target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetRootPosition, target.GetRootPosition, self.SetRootPosition, timer);

        public static IEnumerator CoRootMove(this Animator self, Vector3 start, Animator target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target.GetRootPosition, self.SetRootPosition, timer);

        public static IEnumerator CoRootMoveBy(this Animator self, Vector3 offset, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetRootPosition, () => self.GetRootPositionBy(offset), self.SetRootPosition, timer);

        public static IEnumerator CoRootMove(this Animator self, Vector3 target, float duration, Func<float, float> easer = null)
            => self.CoRootMove(target, Yield.Time(duration, easer));

        public static IEnumerator CoRootMove(this Animator self, Vector3 start, Vector3 target, float duration, Func<float, float> easer = null)
            => self.CoRootMove(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoRootMove(this Animator self, Animator target, float duration, Func<float, float> easer = null)
            => self.CoRootMove(target, Yield.Time(duration, easer));

        public static IEnumerator CoRootMove(this Animator self, Vector3 start, Animator target, float duration, Func<float, float> easer = null)
            => self.CoRootMove(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoRootMoveBy(this Animator self, Vector3 offset, float duration, Func<float, float> easer = null)
            => self.CoRootMoveBy(offset, Yield.Time(duration, easer));
        #endregion

        #region RootRotate
        public static IEnumerator CoRootRotate(this Animator self, Quaternion target)
            => Yield.Into(target, self.SetRootRotation);

        public static IEnumerator CoRootRotate(this Animator self, Quaternion target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetRootRotation, target, self.SetRootRotation, timer);

        public static IEnumerator CoRootRotate(this Animator self, Quaternion start, Quaternion target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetRootRotation, timer);

        public static IEnumerator CoRootRotate(this Animator self, Animator target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetRootRotation, target.GetRootRotation, self.SetRootRotation, timer);

        public static IEnumerator CoRootRotate(this Animator self, Quaternion start, Animator target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target.GetRootRotation, self.SetRootRotation, timer);

        public static IEnumerator CoRootRotateBy(this Animator self, Quaternion offset, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetRootRotation, () => self.GetRootRotationBy(offset), self.SetRootRotation, timer);

        public static IEnumerator CoRootRotate(this Animator self, Quaternion target, float duration, Func<float, float> easer = null)
            => self.CoRootRotate(target, Yield.Time(duration, easer));

        public static IEnumerator CoRootRotate(this Animator self, Quaternion start, Quaternion target, float duration, Func<float, float> easer = null)
            => self.CoRootRotate(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoRootRotate(this Animator self, Animator target, float duration, Func<float, float> easer = null)
            => self.CoRootRotate(target, Yield.Time(duration, easer));

        public static IEnumerator CoRootRotate(this Animator self, Quaternion start, Animator target, float duration, Func<float, float> easer = null)
            => self.CoRootRotate(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoRootRotateBy(this Animator self, Quaternion offset, float duration, Func<float, float> easer = null)
            => self.CoRootRotateBy(offset, Yield.Time(duration, easer));
        #endregion

        #region Speed
        public static IEnumerator CoSpeed(this Animator self, float target)
            => Yield.Into(target, self.SetSpeed);

        public static IEnumerator CoSpeed(this Animator self, float target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetSpeed, target, self.SetSpeed, timer);

        public static IEnumerator CoSpeed(this Animator self, float start, float target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetSpeed, timer);

        public static IEnumerator CoSpeed(this Animator self, float target, float duration, Func<float, float> easer = null)
            => self.CoSpeed(target, Yield.Time(duration, easer));

        public static IEnumerator CoSpeed(this Animator self, float start, float target, float duration, Func<float, float> easer = null)
            => self.CoSpeed(start, target, Yield.Time(duration, easer));
        #endregion

        #region Float
        public static IEnumerator CoFloat(this Animator self, int id, float target)
            => Yield.Into(target, v => self.SetFloat(id, v));

        public static IEnumerator CoFloat(this Animator self, int id, float target, IEnumerator<float> timer)
            => Yield.ValueTo(() => self.GetFloat(id), target, f => self.SetFloat(id, f), timer);

        public static IEnumerator CoFloat(this Animator self, int id, float start, float target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, f => self.SetFloat(id, f), timer);

        public static IEnumerator CoFloat(this Animator self, int id, float target, float duration, Func<float, float> easer = null)
            => self.CoFloat(id, target, Yield.Time(duration, easer));

        public static IEnumerator CoFloat(this Animator self, int id, float start, float target, float duration, Func<float, float> easer = null)
            => self.CoFloat(id, start, target, Yield.Time(duration, easer));
        #endregion

        #region LayerWeight
        public static IEnumerator CoLayerWeight(this Animator self, int layerIndex, float target)
            => Yield.Into(target, w => self.SetLayerWeight(layerIndex, w));

        public static IEnumerator CoLayerWeight(this Animator self, int layerIndex, float target, IEnumerator<float> timer)
            => Yield.ValueTo(() => self.GetLayerWeight(layerIndex), target, w => self.SetLayerWeight(layerIndex, w), timer);

        public static IEnumerator CoLayerWeight(this Animator self, int layerIndex, float start, float target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, w => self.SetLayerWeight(layerIndex, w), timer);

        public static IEnumerator CoLayerWeight(this Animator self, int layerIndex, float target, float duration, Func<float, float> easer = null)
            => self.CoLayerWeight(layerIndex, target, Yield.Time(duration, easer));

        public static IEnumerator CoLayerWeight(this Animator self, int layerIndex, float start, float target, float duration, Func<float, float> easer = null)
            => self.CoLayerWeight(layerIndex, start, target, Yield.Time(duration, easer));
        #endregion

        #region LookAtPosition
        public static IEnumerator CoLookAtPosition(this Animator self, Vector3 target)
            => Yield.Into(target, self.SetLookAtPosition);

        public static IEnumerator CoLookAtPosition(this Animator self, Vector3 start, Vector3 target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetLookAtPosition, timer);

        public static IEnumerator CoLookAtPosition(this Animator self, Vector3 start, Vector3 target, float duration, Func<float, float> easer = null)
            => self.CoLookAtPosition(start, target, Yield.Time(duration, easer));
        #endregion

        #region LookAtWeight
        public static IEnumerator CoLookAtWeight(this Animator self, float target)
            => Yield.Into(target, self.SetLookAtWeight);

        public static IEnumerator CoLookAtWeight(this Animator self, float start, float target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetLookAtWeight, timer);

        public static IEnumerator CoLookAtWeight(this Animator self, float start, float target, float duration, Func<float, float> easer = null)
            => self.CoLookAtWeight(start, target, Yield.Time(duration, easer));
        #endregion
    }

    internal static class InternalAnimatorExtensions
    {
        #region FeetPivot
        public static float GetFeetPivot(this Animator self)
            => self.feetPivotActive;

        public static void SetFeetPivot(this Animator self, float value)
            => self.feetPivotActive = value;
        #endregion

        #region Speed
        public static float GetPlaybackTime(this Animator self)
            => self.playbackTime;

        public static void SetPlaybackTime(this Animator self, float value)
            => self.playbackTime = value;
        #endregion

        #region RootPosition
        public static Vector3 GetRootPosition(this Animator self)
            => self.rootPosition;

        public static void SetRootPosition(this Animator self, Vector3 value)
            => self.rootPosition = value;

        public static Vector3 GetRootPositionBy(this Animator self, Vector3 delta)
            => self.rootPosition + delta;

        public static void SetRootPositionBy(this Animator self, Vector3 delta)
            => self.rootPosition += delta;
        #endregion

        #region RootRotation
        public static Quaternion GetRootRotation(this Animator self)
            => self.rootRotation;

        public static void SetRootRotation(this Animator self, Quaternion value)
            => self.rootRotation = value;

        public static Quaternion GetRootRotationBy(this Animator self, Quaternion value)
            => self.rootRotation * value;

        public static void SetRootRotationBy(this Animator self, Quaternion value)
            => self.rootRotation *= value;
        #endregion

        #region Speed
        public static float GetSpeed(this Animator self)
            => self.speed;

        public static void SetSpeed(this Animator self, float value)
            => self.speed = value;
        #endregion
    }
}