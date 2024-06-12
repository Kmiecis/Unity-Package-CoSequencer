using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines
{
    public static class Rigidbody2DExtensions
    {
        #region Move
        public static IEnumerator CoMove(this Rigidbody2D self, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetPosition, target, self.MovePosition, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoMove(this Rigidbody2D self, Vector2 start, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.MovePosition, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoMoveX(this Rigidbody2D self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetPositionX, target, self.MovePositionX, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoMoveX(this Rigidbody2D self, float start, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.MovePositionX, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoMoveY(this Rigidbody2D self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetPositionY, target, self.MovePositionY, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoMoveY(this Rigidbody2D self, float start, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.MovePositionY, UCoroutine.YieldTime(duration, easer));
        #endregion

        #region Rotate
        public static IEnumerator CoRotate(this Rigidbody2D self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetRotation, target, self.MoveRotation, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoRotate(this Rigidbody2D self, float start, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.MoveRotation, UCoroutine.YieldTime(duration, easer));
        #endregion
    }

    internal static class InternalRigidbody2DExtensions
    {
        #region Position
        public static Vector2 GetPosition(this Rigidbody2D self)
            => self.position;

        public static void SetPosition(this Rigidbody2D self, Vector2 value)
            => self.position = value;

        public static float GetPositionX(this Rigidbody2D self)
            => self.position.x;

        public static void SetPositionX(this Rigidbody2D self, float value)
            => self.position = self.position.WithX(value);

        public static float GetPositionY(this Rigidbody2D self)
            => self.position.y;

        public static void SetPositionY(this Rigidbody2D self, float value)
            => self.position = self.position.WithY(value);
        #endregion

        #region Rotation
        public static float GetRotation(this Rigidbody2D self)
            => self.rotation;

        public static void SetRotation(this Rigidbody2D self, float value)
            => self.rotation = value;
        #endregion

        #region Move position
        public static void MovePositionX(this Rigidbody2D self, float value)
            => self.MovePosition(self.position.WithX(value));

        public static void MovePositionY(this Rigidbody2D self, float value)
            => self.MovePosition(self.position.WithY(value));
        #endregion
    }
}
