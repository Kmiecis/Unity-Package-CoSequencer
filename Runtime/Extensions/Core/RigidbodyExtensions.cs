using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Common.Coroutines
{
    public static class RigidbodyExtensions
    {
        #region Move
        public static IEnumerator CoMove(this Rigidbody self, Vector3 target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetPosition, target, self.MovePosition, timer);

        public static IEnumerator CoMove(this Rigidbody self, Vector3 start, Vector3 target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.MovePosition, timer);

        public static IEnumerator CoMoveX(this Rigidbody self, float target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetPositionX, target, self.MovePositionX, timer);

        public static IEnumerator CoMoveX(this Rigidbody self, float start, float target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.MovePositionX, timer);

        public static IEnumerator CoMoveY(this Rigidbody self, float target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetPositionY, target, self.MovePositionY, timer);

        public static IEnumerator CoMoveY(this Rigidbody self, float start, float target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.MovePositionY, timer);

        public static IEnumerator CoMoveZ(this Rigidbody self, float target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetPositionZ, target, self.MovePositionZ, timer);

        public static IEnumerator CoMoveZ(this Rigidbody self, float start, float target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.MovePositionZ, timer);

        public static IEnumerator CoMoveXY(this Rigidbody self, Vector2 target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetPositionXY, target, self.MovePositionXY, timer);

        public static IEnumerator CoMoveXY(this Rigidbody self, Vector2 start, Vector2 target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.MovePositionXY, timer);

        public static IEnumerator CoMoveYZ(this Rigidbody self, Vector2 target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetPositionYZ, target, self.MovePositionYZ, timer);

        public static IEnumerator CoMoveYZ(this Rigidbody self, Vector2 start, Vector2 target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.MovePositionYZ, timer);

        public static IEnumerator CoMoveXZ(this Rigidbody self, Vector2 target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetPositionXZ, target, self.MovePositionXZ, timer);

        public static IEnumerator CoMoveXZ(this Rigidbody self, Vector2 start, Vector2 target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.MovePositionXZ, timer);

        public static IEnumerator CoMove(this Rigidbody self, Vector3 target, float duration, Func<float, float> easer = null)
            => self.CoMove(target, Yield.Time(duration, easer));

        public static IEnumerator CoMove(this Rigidbody self, Vector3 start, Vector3 target, float duration, Func<float, float> easer = null)
            => self.CoMove(start, target,Yield.Time(duration, easer));

        public static IEnumerator CoMoveX(this Rigidbody self, float target, float duration, Func<float, float> easer = null)
            => self.CoMoveX(target, Yield.Time(duration, easer));

        public static IEnumerator CoMoveX(this Rigidbody self, float start, float target, float duration, Func<float, float> easer = null)
            => self.CoMoveX(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoMoveY(this Rigidbody self, float target, float duration, Func<float, float> easer = null)
            => self.CoMoveY(target, Yield.Time(duration, easer));

        public static IEnumerator CoMoveY(this Rigidbody self, float start, float target, float duration, Func<float, float> easer = null)
            => self.CoMoveY(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoMoveZ(this Rigidbody self, float target, float duration, Func<float, float> easer = null)
            => self.CoMoveZ(target, Yield.Time(duration, easer));

        public static IEnumerator CoMoveZ(this Rigidbody self, float start, float target, float duration, Func<float, float> easer = null)
            => self.CoMoveZ(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoMoveXY(this Rigidbody self, Vector2 target, float duration, Func<float, float> easer = null)
            => self.CoMoveXY(target, Yield.Time(duration, easer));

        public static IEnumerator CoMoveXY(this Rigidbody self, Vector2 start, Vector2 target, float duration, Func<float, float> easer = null)
            => self.CoMoveXY(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoMoveYZ(this Rigidbody self, Vector2 target, float duration, Func<float, float> easer = null)
            => self.CoMoveYZ(target, Yield.Time(duration, easer));

        public static IEnumerator CoMoveYZ(this Rigidbody self, Vector2 start, Vector2 target, float duration, Func<float, float> easer = null)
            => self.CoMoveYZ(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoMoveXZ(this Rigidbody self, Vector2 target, float duration, Func<float, float> easer = null)
            => self.CoMoveXZ(target, Yield.Time(duration, easer));

        public static IEnumerator CoMoveXZ(this Rigidbody self, Vector2 start, Vector2 target, float duration, Func<float, float> easer = null)
            => self.CoMoveXZ(start, target, Yield.Time(duration, easer));
        #endregion

        #region Rotate
        public static IEnumerator CoRotate(this Rigidbody self, Quaternion target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetRotation, target, self.MoveRotation, timer);

        public static IEnumerator CoRotate(this Rigidbody self, Quaternion start, Quaternion target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.MoveRotation, timer);

        public static IEnumerator CoRotate(this Rigidbody self, Quaternion target, float duration, Func<float, float> easer = null)
            => self.CoRotate(target, Yield.Time(duration, easer));

        public static IEnumerator CoRotate(this Rigidbody self, Quaternion start, Quaternion target, float duration, Func<float, float> easer = null)
            => self.CoRotate(start, target, Yield.Time(duration, easer));
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
