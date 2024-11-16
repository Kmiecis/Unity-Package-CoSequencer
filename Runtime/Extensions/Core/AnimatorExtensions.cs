using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines
{
    public static class AnimatorExtensions
    {
        #region FeetPivot
        public static IEnumerator CoFeetPivot(this Animator self, float target)
            => Yield.Into(target, self.SetFeetPivot);

        public static IEnumerator CoFeetPivot(this Animator self, float target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(self.GetFeetPivot, target, self.SetFeetPivot, Yield.Time(duration, easer));

        public static IEnumerator CoFeetPivot(this Animator self, float start, float target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(start, target, self.SetFeetPivot, Yield.Time(duration, easer));
        #endregion

        #region PlaybackTime
        public static IEnumerator CoPlaybackTime(this Animator self, float target)
            => Yield.Into(target, self.SetPlaybackTime);

        public static IEnumerator CoPlaybackTime(this Animator self, float target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(self.GetPlaybackTime, target, self.SetPlaybackTime, Yield.Time(duration, easer));

        public static IEnumerator CoPlaybackTime(this Animator self, float start, float target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(start, target, self.SetPlaybackTime, Yield.Time(duration, easer));
        #endregion

        #region RootMove
        public static IEnumerator CoRootMove(this Animator self, Vector3 target)
            => Yield.Into(target, self.SetRootPosition);

        public static IEnumerator CoRootMove(this Animator self, Vector3 target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(self.GetRootPosition, target, self.SetRootPosition, Yield.Time(duration, easer));

        public static IEnumerator CoRootMove(this Animator self, Vector3 start, Vector3 target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(start, target, self.SetRootPosition, Yield.Time(duration, easer));

        public static IEnumerator CoRootMove(this Animator self, Animator target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(self.GetRootPosition, target.GetRootPosition, self.SetRootPosition, Yield.Time(duration, easer));

        public static IEnumerator CoRootMove(this Animator self, Vector3 start, Animator target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(start, target.GetRootPosition, self.SetRootPosition, Yield.Time(duration, easer));

        public static IEnumerator CoRootMoveBy(this Animator self, Vector3 offset, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(self.GetRootPosition, () => self.GetRootPositionBy(offset), self.SetRootPosition, Yield.Time(duration, easer));
        #endregion

        #region RootRotate
        public static IEnumerator CoRootRotate(this Animator self, Quaternion target)
            => Yield.Into(target, self.SetRootRotation);

        public static IEnumerator CoRootRotate(this Animator self, Quaternion target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(self.GetRootRotation, target, self.SetRootRotation, Yield.Time(duration, easer));

        public static IEnumerator CoRootRotate(this Animator self, Quaternion start, Quaternion target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(start, target, self.SetRootRotation, Yield.Time(duration, easer));

        public static IEnumerator CoRootRotate(this Animator self, Animator target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(self.GetRootRotation, target.GetRootRotation, self.SetRootRotation, Yield.Time(duration, easer));

        public static IEnumerator CoRootRotate(this Animator self, Quaternion start, Animator target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(start, target.GetRootRotation, self.SetRootRotation, Yield.Time(duration, easer));

        public static IEnumerator CoRootRotateBy(this Animator self, Quaternion offset, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(self.GetRootRotation, () => self.GetRootRotationBy(offset), self.SetRootRotation, Yield.Time(duration, easer));
        #endregion

        #region Speed
        public static IEnumerator CoSpeed(this Animator self, float target)
            => Yield.Into(target, self.SetSpeed);

        public static IEnumerator CoSpeed(this Animator self, float target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(self.GetSpeed, target, self.SetSpeed, Yield.Time(duration, easer));

        public static IEnumerator CoSpeed(this Animator self, float start, float target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(start, target, self.SetSpeed, Yield.Time(duration, easer));
        #endregion

        #region Float
        public static IEnumerator CoFloat(this Animator self, int id, float target)
            => Yield.Into(target, v => self.SetFloat(id, v));

        public static IEnumerator CoFloat(this Animator self, int id, float target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(() => self.GetFloat(id), target, f => self.SetFloat(id, f), Yield.Time(duration, easer));

        public static IEnumerator CoFloat(this Animator self, int id, float start, float target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(start, target, f => self.SetFloat(id, f), Yield.Time(duration, easer));
        #endregion

        #region LayerWeight
        public static IEnumerator CoLayerWeight(this Animator self, int layerIndex, float target)
            => Yield.Into(target, w => self.SetLayerWeight(layerIndex, w));

        public static IEnumerator CoLayerWeight(this Animator self, int layerIndex, float target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(() => self.GetLayerWeight(layerIndex), target, w => self.SetLayerWeight(layerIndex, w), Yield.Time(duration, easer));

        public static IEnumerator CoLayerWeight(this Animator self, int layerIndex, float start, float target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(start, target, w => self.SetLayerWeight(layerIndex, w), Yield.Time(duration, easer));
        #endregion

        #region LookAtPosition
        public static IEnumerator CoLookAtPosition(this Animator self, Vector3 target)
            => Yield.Into(target, self.SetLookAtPosition);

        public static IEnumerator CoLookAtPosition(this Animator self, Vector3 start, Vector3 target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(start, target, self.SetLookAtPosition, Yield.Time(duration, easer));
        #endregion

        #region LookAtWeight
        public static IEnumerator CoLookAtWeight(this Animator self, float target)
            => Yield.Into(target, self.SetLookAtWeight);

        public static IEnumerator CoLookAtWeight(this Animator self, float start, float target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(start, target, self.SetLookAtWeight, Yield.Time(duration, easer));
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