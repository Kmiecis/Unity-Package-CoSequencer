using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines
{
    public static class RigidbodyExtensions
    {
        #region Move
        public static IEnumerator CoMove(this Rigidbody self, Vector3 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetPosition, target, self.MovePosition, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoMove(this Rigidbody self, Vector3 start, Vector3 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.MovePosition, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoMoveX(this Rigidbody self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetPositionX, target, self.MovePositionX, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoMoveX(this Rigidbody self, float start, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.MovePositionX, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoMoveY(this Rigidbody self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetPositionY, target, self.MovePositionY, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoMoveY(this Rigidbody self, float start, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.MovePositionY, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoMoveZ(this Rigidbody self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetPositionZ, target, self.MovePositionZ, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoMoveZ(this Rigidbody self, float start, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.MovePositionZ, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoMoveXY(this Rigidbody self, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetPositionXY, target, self.MovePositionXY, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoMoveXY(this Rigidbody self, Vector2 start, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.MovePositionXY, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoMoveYZ(this Rigidbody self, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetPositionYZ, target, self.MovePositionYZ, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoMoveYZ(this Rigidbody self, Vector2 start, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.MovePositionYZ, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoMoveXZ(this Rigidbody self, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetPositionXZ, target, self.MovePositionXZ, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoMoveXZ(this Rigidbody self, Vector2 start, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.MovePositionXZ, UCoroutine.YieldTime(duration, easer));
        #endregion

        #region Rotate
        public static IEnumerator CoRotate(this Rigidbody self, Quaternion target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetRotation, target, self.MoveRotation, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoRotate(this Rigidbody self, Quaternion start, Quaternion target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.MoveRotation, UCoroutine.YieldTime(duration, easer));
        #endregion
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

        public static Vector2 GetPositionXY(this Rigidbody self)
            => self.position.XY();

        public static void SetPositionXY(this Rigidbody self, Vector2 value)
            => self.position = self.position.WithXY(value);

        public static Vector2 GetPositionYZ(this Rigidbody self)
            => self.position.YZ();

        public static void SetPositionYZ(this Rigidbody self, Vector2 value)
            => self.position = self.position.WithYZ(value);

        public static Vector2 GetPositionXZ(this Rigidbody self)
            => self.position.XZ();

        public static void SetPositionXZ(this Rigidbody self, Vector2 value)
            => self.position = self.position.WithXZ(value);
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

        public static void MovePositionXY(this Rigidbody self, Vector2 value)
            => self.MovePosition(self.position.WithXY(value));

        public static void MovePositionYZ(this Rigidbody self, Vector2 value)
            => self.MovePosition(self.position.WithYZ(value));

        public static void MovePositionXZ(this Rigidbody self, Vector2 value)
            => self.MovePosition(self.position.WithXZ(value));
        #endregion
    }
}
