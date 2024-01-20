using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines
{
    public static class TransformExtensions
    {
        public static IEnumerator CoMove(this Transform self, Vector3 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetPosition, self.SetPosition, target, UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoMove(this Transform self, Transform target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetPosition, self.SetPosition, target.GetPosition, UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoMoveBy(this Transform self, Vector3 offset, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetPosition, self.SetPosition, () => self.GetPositionBy(offset), UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoMoveX(this Transform self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetPositionX, self.SetPositionX, target, UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoMoveY(this Transform self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetPositionY, self.SetPositionY, target, UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoMoveZ(this Transform self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetPositionZ, self.SetPositionZ, target, UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoLocalMove(this Transform self, Vector3 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetLocalPosition, self.SetLocalPosition, target, UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoLocalMove(this Transform self, Transform target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetLocalPosition, self.SetLocalPosition, target.GetLocalPosition, UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoLocalMoveBy(this Transform self, Vector3 offset, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetLocalPosition, self.SetLocalPosition, () => self.GetLocalPositionBy(offset), UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoLocalMoveX(this Transform self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetLocalPositionX, self.SetLocalPositionX, target, UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoLocalMoveY(this Transform self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetLocalPositionY, self.SetLocalPositionY, target, UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoLocalMoveZ(this Transform self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetLocalPositionZ, self.SetLocalPositionZ, target, UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoRotate(this Transform self, Quaternion target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetRotation, self.SetRotation, target, UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoRotate(this Transform self, Transform target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetRotation, self.SetRotation, target.GetRotation, UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoRotateBy(this Transform self, Quaternion offset, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetRotation, self.SetRotation, () => self.GetRotationBy(offset), UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoLocalRotate(this Transform self, Quaternion target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetLocalRotation, self.SetLocalRotation, target, UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoLocalRotate(this Transform self, Transform target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetLocalRotation, self.SetLocalRotation, target.GetLocalRotation, UCoroutine.YieldTimeEased(duration, easer));
        
        public static IEnumerator CoLocalRotateBy(this Transform self, Quaternion offset, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetLocalRotation, self.SetLocalRotation, () => self.GetLocalRotationBy(offset), UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoLookAt(this Transform self, Vector3 position, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetRotation, self.SetRotation, () => self.GetLookAtRotation(position), UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoLookAt(this Transform self, Transform target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetRotation, self.SetRotation, () => self.GetLookAtRotation(target), UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoLocalLookAt(this Transform self, Vector3 position, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetLocalRotation, self.SetLocalRotation, () => self.GetLocalLookAtRotation(position), UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoLocalLookAt(this Transform self, Transform target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetLocalRotation, self.SetLocalRotation, () => self.GetLocalLookAtRotation(target), UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoLocalScale(this Transform self, Vector3 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetLocalScale, self.SetLocalScale, target, UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoLocalScale(this Transform self, Transform target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetLocalScale, self.SetLocalScale, target.GetLocalScale, UCoroutine.YieldTimeEased(duration, easer));
        
        public static IEnumerator CoLocalScaleBy(this Transform self, Vector3 offset, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetLocalScale, self.SetLocalScale, () => self.GetLocalScaleBy(offset), UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoLocalScaleX(this Transform self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetLocalScaleX, self.SetLocalScaleX, target, UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoLocalScaleY(this Transform self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetLocalScaleY, self.SetLocalScaleY, target, UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoLocalScaleZ(this Transform self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetLocalScaleZ, self.SetLocalScaleZ, target, UCoroutine.YieldTimeEased(duration, easer));
    }

    internal static class InternalTransformExtensions
    {
        #region Position
        public static Vector3 GetPosition(this Transform self)
            => self.position;

        public static void SetPosition(this Transform self, Vector3 value)
            => self.position = value;

        public static Vector3 GetPositionBy(this Transform self, Vector3 value)
            => self.position + value;

        public static void SetPositionBy(this Transform self, Vector3 value)
            => self.position += value;

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

        public static Vector3 GetLocalPositionBy(this Transform self, Vector3 value)
            => self.localPosition + value;

        public static void SetLocalPositionBy(this Transform self, Vector3 value)
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
        #endregion
    }
}
