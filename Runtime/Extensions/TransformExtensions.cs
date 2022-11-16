using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines
{
    public static class TransformExtensions
    {
        public static IEnumerator CoMove(this Transform self, Vector3 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetPosition, self.SetPosition, target, duration, easer);

        public static IEnumerator CoMoveX(this Transform self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetPositionX, self.SetPositionX, target, duration, easer);

        public static IEnumerator CoMoveY(this Transform self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetPositionY, self.SetPositionY, target, duration, easer);

        public static IEnumerator CoMoveZ(this Transform self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetPositionZ, self.SetPositionZ, target, duration, easer);

        public static IEnumerator CoLocalMove(this Transform self, Vector3 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetLocalPosition, self.SetLocalPosition, target, duration, easer);

        public static IEnumerator CoLocalMoveX(this Transform self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetLocalPositionX, self.SetLocalPositionX, target, duration, easer);

        public static IEnumerator CoLocalMoveY(this Transform self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetLocalPositionY, self.SetLocalPositionY, target, duration, easer);

        public static IEnumerator CoLocalMoveZ(this Transform self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetLocalPositionZ, self.SetLocalPositionZ, target, duration, easer);

        public static IEnumerator CoRotate(this Transform self, Quaternion target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetRotation, self.SetRotation, target, duration, easer);

        public static IEnumerator CoLocalRotate(this Transform self, Quaternion target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetLocalRotation, self.SetLocalRotation, target, duration, easer);

        public static IEnumerator CoLocalScale(this Transform self, Vector3 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetLocalScale, self.SetLocalScale, target, duration, easer);

        public static IEnumerator CoLocalScaleX(this Transform self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetLocalScaleX, self.SetLocalScaleX, target, duration, easer);

        public static IEnumerator CoLocalScaleY(this Transform self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetLocalScaleY, self.SetLocalScaleY, target, duration, easer);

        public static IEnumerator CoLocalScaleZ(this Transform self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetLocalScaleZ, self.SetLocalScaleZ, target, duration, easer);
    }

    internal static class InternalTransformExtensions
    {
        #region Position
        public static Vector3 GetPosition(this Transform self)
            => self.position;

        public static void SetPosition(this Transform self, Vector3 value)
            => self.position = value;

        public static float GetPositionX(this Transform self)
            => self.position.x;

        public static void SetPositionX(this Transform self, float value)
            => self.position = self.position.WithX(value);

        public static float GetPositionY(this Transform self)
            => self.position.y;

        public static void SetPositionY(this Transform self, float value)
            => self.position = self.position.WithY(value);

        public static float GetPositionZ(this Transform self)
            => self.position.z;

        public static void SetPositionZ(this Transform self, float value)
            => self.position = self.position.WithZ(value);
        #endregion

        #region Local position
        public static Vector3 GetLocalPosition(this Transform self)
            => self.localPosition;

        public static void SetLocalPosition(this Transform self, Vector3 value)
            => self.localPosition = value;

        public static float GetLocalPositionX(this Transform self)
            => self.localPosition.x;

        public static void SetLocalPositionX(this Transform self, float value)
            => self.localPosition = self.localPosition.WithX(value);

        public static float GetLocalPositionY(this Transform self)
            => self.localPosition.y;

        public static void SetLocalPositionY(this Transform self, float value)
            => self.localPosition = self.localPosition.WithY(value);

        public static float GetLocalPositionZ(this Transform self)
            => self.localPosition.z;

        public static void SetLocalPositionZ(this Transform self, float value)
            => self.localPosition = self.localPosition.WithZ(value);
        #endregion

        #region Rotation
        public static Quaternion GetRotation(this Transform self)
            => self.rotation;

        public static void SetRotation(this Transform self, Quaternion value)
            => self.rotation = value;
        #endregion

        #region Local rotation
        public static Quaternion GetLocalRotation(this Transform self)
            => self.localRotation;

        public static void SetLocalRotation(this Transform self, Quaternion value)
            => self.localRotation = value;
        #endregion

        #region Local scale
        public static Vector3 GetLocalScale(this Transform self)
            => self.localScale;

        public static void SetLocalScale(this Transform self, Vector3 value)
            => self.localScale = value;

        public static float GetLocalScaleX(this Transform self)
            => self.localScale.x;

        public static void SetLocalScaleX(this Transform self, float value)
            => self.localScale = self.localScale.WithX(value);

        public static float GetLocalScaleY(this Transform self)
            => self.localScale.y;

        public static void SetLocalScaleY(this Transform self, float value)
            => self.localScale = self.localScale.WithY(value);

        public static float GetLocalScaleZ(this Transform self)
            => self.localScale.z;

        public static void SetLocalScaleZ(this Transform self, float value)
            => self.localScale = self.localScale.WithZ(value);
        #endregion
    }
}
