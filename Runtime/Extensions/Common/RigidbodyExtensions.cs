using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines
{
    public static class RigidbodyExtensions
    {
        public static IEnumerator CoMove(this Rigidbody self, Vector3 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetPosition, self.MovePosition, target, UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoMoveX(this Rigidbody self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetPositionX, self.MovePositionX, target, UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoMoveY(this Rigidbody self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetPositionY, self.MovePositionY, target, UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoMoveZ(this Rigidbody self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetPositionZ, self.MovePositionZ, target, UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoRotate(this Rigidbody self, Quaternion target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetRotation, self.MoveRotation, target, UCoroutine.YieldTimeEased(duration, easer));
    }

    internal static class InternalRigidbodyExtensions
    {
        #region Position
        public static Vector3 GetPosition(this Rigidbody self)
            => self.position;

        public static void SetPosition(this Rigidbody self, Vector3 value)
            => self.position = value;

        public static float GetPositionX(this Rigidbody self)
            => self.position.x;

        public static void SetPositionX(this Rigidbody self, float value)
            => self.position = self.position.WithX(value);

        public static float GetPositionY(this Rigidbody self)
            => self.position.y;

        public static void SetPositionY(this Rigidbody self, float value)
            => self.position = self.position.WithY(value);

        public static float GetPositionZ(this Rigidbody self)
            => self.position.z;

        public static void SetPositionZ(this Rigidbody self, float value)
            => self.position = self.position.WithZ(value);
        #endregion

        #region Rotation
        public static Quaternion GetRotation(this Rigidbody self)
            => self.rotation;

        public static void SetRotation(this Rigidbody self, Quaternion value)
            => self.rotation = value;
        #endregion

        #region Move position
        public static void MovePositionX(this Rigidbody self, float value)
            => self.MovePosition(self.position.WithX(value));

        public static void MovePositionY(this Rigidbody self, float value)
            => self.MovePosition(self.position.WithY(value));

        public static void MovePositionZ(this Rigidbody self, float value)
            => self.MovePosition(self.position.WithZ(value));
        #endregion
    }
}
