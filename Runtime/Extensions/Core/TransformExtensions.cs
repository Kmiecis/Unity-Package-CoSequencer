using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines
{
    public static class TransformExtensions
    {
        #region Move
        public static IEnumerator CoMove(this Transform self, Vector3 target)
            => UCoroutine.Yield(self.SetPosition, target);

        public static IEnumerator CoMove(this Transform self, Vector3 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetPosition, target, self.SetPosition, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoMove(this Transform self, Vector3 start, Vector3 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetPosition, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoMove(this Transform self, Transform target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetPosition, target.GetPosition, self.SetPosition, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoMove(this Transform self, Vector3 start, Transform target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target.GetPosition, self.SetPosition, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoMoveX(this Transform self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetPositionX, target, self.SetPositionX, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoMoveX(this Transform self, float start, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetPositionX, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoMoveY(this Transform self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetPositionY, target, self.SetPositionY, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoMoveY(this Transform self, float start, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetPositionY, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoMoveZ(this Transform self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetPositionZ, target, self.SetPositionZ, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoMoveZ(this Transform self, float start, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetPositionZ, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoMoveXY(this Transform self, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetPositionXY, target, self.SetPositionXY, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoMoveXY(this Transform self, Vector2 start, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetPositionXY, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoMoveYZ(this Transform self, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetPositionYZ, target, self.SetPositionYZ, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoMoveYZ(this Transform self, Vector2 start, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetPositionYZ, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoMoveXZ(this Transform self, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetPositionXZ, target, self.SetPositionXZ, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoMoveXZ(this Transform self, Vector2 start, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetPositionXZ, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoMoveBy(this Transform self, Vector3 offset, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetPosition, () => self.GetPositionBy(offset), self.SetPosition, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoMoveFor(this Transform self, Vector3 direction, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(t => direction * t, self.SetPositionBy, UCoroutine.YieldDeltaTime(duration, easer));
        #endregion

        #region LocalMove
        public static IEnumerator CoLocalMove(this Transform self, Vector3 target)
            => UCoroutine.Yield(self.SetLocalPosition, target);

        public static IEnumerator CoLocalMove(this Transform self, Vector3 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetLocalPosition, target, self.SetLocalPosition, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoLocalMove(this Transform self, Vector3 start, Vector3 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetLocalPosition, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoLocalMove(this Transform self, Transform target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetLocalPosition, target.GetLocalPosition, self.SetLocalPosition, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoLocalMove(this Transform self, Vector3 start, Transform target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target.GetLocalPosition, self.SetLocalPosition, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoLocalMoveX(this Transform self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetLocalPositionX, target, self.SetLocalPositionX, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoLocalMoveX(this Transform self, float start, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetLocalPositionX, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoLocalMoveY(this Transform self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetLocalPositionY, target, self.SetLocalPositionY, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoLocalMoveY(this Transform self, float start, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetLocalPositionY, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoLocalMoveZ(this Transform self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetLocalPositionZ, target, self.SetLocalPositionZ, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoLocalMoveZ(this Transform self, float start, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetLocalPositionZ, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoLocalMoveXY(this Transform self, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetLocalPositionXY, target, self.SetLocalPositionXY, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoLocalMoveXY(this Transform self, Vector2 start, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetLocalPositionXY, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoLocalMoveYZ(this Transform self, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetLocalPositionYZ, target, self.SetLocalPositionYZ, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoLocalMoveYZ(this Transform self, Vector2 start, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetLocalPositionYZ, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoLocalMoveXZ(this Transform self, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetLocalPositionXZ, target, self.SetLocalPositionXZ, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoLocalMoveXZ(this Transform self, Vector2 start, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetLocalPositionXZ, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoLocalMoveBy(this Transform self, Vector3 offset, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetLocalPosition, () => self.GetLocalOffsetPosition(offset), self.SetLocalPosition, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoLocalMoveFor(this Transform self, Vector3 direction, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(t => direction * t, self.SetLocalOffsetPosition, UCoroutine.YieldDeltaTime(duration, easer));
        #endregion

        #region Rotate
        public static IEnumerator CoRotate(this Transform self, Quaternion target)
            => UCoroutine.Yield(self.SetRotation, target);

        public static IEnumerator CoRotate(this Transform self, Quaternion target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetRotation, target, self.SetRotation, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoRotate(this Transform self, Quaternion start, Quaternion target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetRotation, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoRotate(this Transform self, Transform target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetRotation, target.GetRotation, self.SetRotation, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoRotate(this Transform self, Quaternion start, Transform target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target.GetRotation, self.SetRotation, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoRotateBy(this Transform self, Quaternion offset, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetRotation, () => self.GetRotationBy(offset), self.SetRotation, UCoroutine.YieldTime(duration, easer));
        #endregion

        #region LocalRotate
        public static IEnumerator CoLocalRotate(this Transform self, Quaternion target)
            => UCoroutine.Yield(self.SetLocalRotation, target);

        public static IEnumerator CoLocalRotate(this Transform self, Quaternion target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetLocalRotation, target, self.SetLocalRotation, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoLocalRotate(this Transform self, Quaternion start, Quaternion target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetLocalRotation, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoLocalRotate(this Transform self, Transform target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetLocalRotation, target.GetLocalRotation, self.SetLocalRotation, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoLocalRotate(this Transform self, Quaternion start, Transform target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target.GetLocalRotation, self.SetLocalRotation, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoLocalRotateBy(this Transform self, Quaternion offset, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetLocalRotation, () => self.GetLocalRotationBy(offset), self.SetLocalRotation, UCoroutine.YieldTime(duration, easer));
        #endregion

        #region LookAt
        public static IEnumerator CoLookAt(this Transform self, Vector3 position, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetRotation, () => self.GetLookAtRotation(position), self.SetRotation, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoLookAt(this Transform self, Transform target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetRotation, () => self.GetLookAtRotation(target), self.SetRotation,UCoroutine.YieldTime(duration, easer));
        #endregion

        #region LocalLookAt
        public static IEnumerator CoLocalLookAt(this Transform self, Vector3 position, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetLocalRotation, () => self.GetLocalLookAtRotation(position), self.SetLocalRotation, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoLocalLookAt(this Transform self, Transform target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetLocalRotation, () => self.GetLocalLookAtRotation(target), self.SetLocalRotation, UCoroutine.YieldTime(duration, easer));
        #endregion

        #region LocalScale
        public static IEnumerator CoLocalScale(this Transform self, Vector3 target)
            => UCoroutine.Yield(self.SetLocalScale, target);

        public static IEnumerator CoLocalScale(this Transform self, Vector3 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetLocalScale, target, self.SetLocalScale, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoLocalScale(this Transform self, Vector3 start, Vector3 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetLocalScale, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoLocalScale(this Transform self, Transform target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetLocalScale, target.GetLocalScale, self.SetLocalScale, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoLocalScale(this Transform self, Vector3 start, Transform target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target.GetLocalScale, self.SetLocalScale, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoLocalScaleX(this Transform self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetLocalScaleX, target, self.SetLocalScaleX, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoLocalScaleX(this Transform self, float start, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetLocalScaleX, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoLocalScaleY(this Transform self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetLocalScaleY, target, self.SetLocalScaleY, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoLocalScaleY(this Transform self, float start, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetLocalScaleY, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoLocalScaleZ(this Transform self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetLocalScaleZ, target, self.SetLocalScaleZ, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoLocalScaleZ(this Transform self, float start, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetLocalScaleZ, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoLocalScaleXY(this Transform self, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetLocalScaleXY, target, self.SetLocalScaleXY, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoLocalScaleXY(this Transform self, Vector2 start, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetLocalScaleXY, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoLocalScaleYZ(this Transform self, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetLocalScaleYZ, target, self.SetLocalScaleYZ, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoLocalScaleYZ(this Transform self, Vector2 start, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetLocalScaleYZ, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoLocalScaleXZ(this Transform self, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetLocalScaleXZ, target, self.SetLocalScaleXZ, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoLocalScaleXZ(this Transform self, Vector2 start, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetLocalScaleXZ, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoLocalScaleBy(this Transform self, Vector3 offset, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetLocalScale, () => self.GetLocalScaleBy(offset), self.SetLocalScale, UCoroutine.YieldTime(duration, easer));
        #endregion
    }

    internal static class InternalTransformExtensions
    {
        #region Position
        public static Vector3 GetPosition(this Transform self)
            => self.position;

        public static void SetPosition(this Transform self, Vector3 value)
            => self.position = value;

        public static Vector3 GetPositionBy(this Transform self, Vector3 delta)
            => self.position + delta;

        public static void SetPositionBy(this Transform self, Vector3 delta)
            => self.position += delta;

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

        public static Vector2 GetPositionXY(this Transform self)
            => self.position.XY();

        public static void SetPositionXY(this Transform self, Vector2 value)
            => self.position = self.position.WithXY(value);

        public static Vector2 GetPositionYZ(this Transform self)
            => self.position.YZ();

        public static void SetPositionYZ(this Transform self, Vector2 value)
            => self.position = self.position.WithYZ(value);

        public static Vector2 GetPositionXZ(this Transform self)
            => self.position.XZ();

        public static void SetPositionXZ(this Transform self, Vector2 value)
            => self.position = self.position.WithXZ(value);
        #endregion

        #region Local position
        public static Vector3 GetLocalPosition(this Transform self)
            => self.localPosition;

        public static void SetLocalPosition(this Transform self, Vector3 value)
            => self.localPosition = value;

        public static Vector3 GetLocalOffsetPosition(this Transform self, Vector3 value)
            => self.localPosition + value;

        public static void SetLocalOffsetPosition(this Transform self, Vector3 value)
            => self.localPosition += value;

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

        public static Vector2 GetLocalPositionXY(this Transform self)
            => self.localPosition.XY();

        public static void SetLocalPositionXY(this Transform self, Vector2 value)
            => self.localPosition = self.localPosition.WithXY(value);

        public static Vector2 GetLocalPositionYZ(this Transform self)
            => self.localPosition.YZ();

        public static void SetLocalPositionYZ(this Transform self, Vector2 value)
            => self.localPosition = self.localPosition.WithYZ(value);

        public static Vector2 GetLocalPositionXZ(this Transform self)
            => self.localPosition.XZ();

        public static void SetLocalPositionXZ(this Transform self, Vector2 value)
            => self.localPosition = self.localPosition.WithXZ(value);
        #endregion

        #region Rotation
        public static Quaternion GetRotation(this Transform self)
            => self.rotation;

        public static void SetRotation(this Transform self, Quaternion value)
            => self.rotation = value;

        public static Quaternion GetRotationBy(this Transform self, Quaternion value)
            => self.rotation * value;

        public static void SetRotationBy(this Transform self, Quaternion value)
            => self.rotation *= value;

        public static Vector3 GetEulerRotation(this Transform self)
            => self.eulerAngles;

        public static void SetEulerRotation(this Transform self, Vector3 value)
            => self.eulerAngles = value;

        public static float GetEulerRotationX(this Transform self)
            => self.eulerAngles.x;

        public static void SetEulerRotationX(this Transform self, float value)
            => self.eulerAngles = self.eulerAngles.WithX(value);

        public static float GetEulerRotationY(this Transform self)
            => self.eulerAngles.y;

        public static void SetEulerRotationY(this Transform self, float value)
            => self.eulerAngles = self.eulerAngles.WithY(value);

        public static float GetEulerRotationZ(this Transform self)
            => self.eulerAngles.z;

        public static void SetEulerRotationZ(this Transform self, float value)
            => self.eulerAngles = self.eulerAngles.WithZ(value);

        public static Quaternion GetLookAtRotation(this Transform self, Vector3 value)
            => Quaternion.LookRotation((value - self.position).normalized);

        public static Quaternion GetLookAtRotation(this Transform self, Transform value)
            => Quaternion.LookRotation((value.position - self.position).normalized);
        #endregion

        #region Local rotation
        public static Quaternion GetLocalRotation(this Transform self)
            => self.localRotation;

        public static void SetLocalRotation(this Transform self, Quaternion value)
            => self.localRotation = value;

        public static Quaternion GetLocalRotationBy(this Transform self, Quaternion value)
            => self.localRotation * value;

        public static void SetLocalRotationBy(this Transform self, Quaternion value)
            => self.localRotation *= value;

        public static Vector3 GetLocalEulerRotation(this Transform self)
            => self.localEulerAngles;

        public static void SetLocalEulerRotation(this Transform self, Vector3 value)
            => self.localEulerAngles = value;

        public static float GetLocalEulerRotationX(this Transform self)
            => self.localEulerAngles.x;

        public static void SetLocalEulerRotationX(this Transform self, float value)
            => self.localEulerAngles = self.localEulerAngles.WithX(value);

        public static float GetLocalEulerRotationY(this Transform self)
            => self.localEulerAngles.y;

        public static void SetLocalEulerRotationY(this Transform self, float value)
            => self.localEulerAngles = self.localEulerAngles.WithY(value);

        public static float GetLocalEulerRotationZ(this Transform self)
            => self.localEulerAngles.z;

        public static void SetLocalEulerRotationZ(this Transform self, float value)
            => self.localEulerAngles = self.localEulerAngles.WithZ(value);

        public static Quaternion GetLocalLookAtRotation(this Transform self, Vector3 value)
            => Quaternion.LookRotation((value - self.localPosition).normalized);

        public static Quaternion GetLocalLookAtRotation(this Transform self, Transform value)
            => Quaternion.LookRotation((value.localPosition - self.localPosition).normalized);
        #endregion

        #region Local scale
        public static Vector3 GetLocalScale(this Transform self)
            => self.localScale;

        public static void SetLocalScale(this Transform self, Vector3 value)
            => self.localScale = value;

        public static Vector3 GetLocalScaleBy(this Transform self, Vector3 value)
            => self.localScale + value;

        public static void SetLocalScaleBy(this Transform self, Vector3 value)
            => self.localScale += value;

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

        public static Vector2 GetLocalScaleXY(this Transform self)
            => self.localScale.XY();

        public static void SetLocalScaleXY(this Transform self, Vector2 value)
            => self.localScale = self.localScale.WithXY(value);

        public static Vector2 GetLocalScaleYZ(this Transform self)
            => self.localScale.YZ();

        public static void SetLocalScaleYZ(this Transform self, Vector2 value)
            => self.localScale = self.localScale.WithYZ(value);

        public static Vector2 GetLocalScaleXZ(this Transform self)
            => self.localScale.XZ();

        public static void SetLocalScaleXZ(this Transform self, Vector2 value)
            => self.localScale = self.localScale.WithXZ(value);
        #endregion
    }
}
