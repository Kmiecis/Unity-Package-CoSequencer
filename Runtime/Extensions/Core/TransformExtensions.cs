using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Common.Coroutines
{
    public static class TransformExtensions
    {
        #region Move
        public static IEnumerator CoMove(this Transform self, Vector3 target)
            => Yield.Into(target, self.SetPosition);

        public static IEnumerator CoMove(this Transform self, Vector3 target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetPosition, target, self.SetPosition, timer);

        public static IEnumerator CoMove(this Transform self, Vector3 start, Vector3 target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetPosition, timer);

        public static IEnumerator CoMove(this Transform self, Transform target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetPosition, target.GetPosition, self.SetPosition, timer);

        public static IEnumerator CoMove(this Transform self, Vector3 start, Transform target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target.GetPosition, self.SetPosition, timer);

        public static IEnumerator CoMoveX(this Transform self, float target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetPositionX, target, self.SetPositionX, timer);

        public static IEnumerator CoMoveX(this Transform self, float start, float target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetPositionX, timer);

        public static IEnumerator CoMoveY(this Transform self, float target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetPositionY, target, self.SetPositionY, timer);

        public static IEnumerator CoMoveY(this Transform self, float start, float target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetPositionY, timer);

        public static IEnumerator CoMoveZ(this Transform self, float target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetPositionZ, target, self.SetPositionZ, timer);

        public static IEnumerator CoMoveZ(this Transform self, float start, float target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetPositionZ, timer);

        public static IEnumerator CoMoveXY(this Transform self, Vector2 target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetPositionXY, target, self.SetPositionXY, timer);

        public static IEnumerator CoMoveXY(this Transform self, Vector2 start, Vector2 target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetPositionXY, timer);

        public static IEnumerator CoMoveYZ(this Transform self, Vector2 target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetPositionYZ, target, self.SetPositionYZ, timer);

        public static IEnumerator CoMoveYZ(this Transform self, Vector2 start, Vector2 target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetPositionYZ, timer);

        public static IEnumerator CoMoveXZ(this Transform self, Vector2 target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetPositionXZ, target, self.SetPositionXZ, timer);

        public static IEnumerator CoMoveXZ(this Transform self, Vector2 start, Vector2 target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetPositionXZ, timer);

        public static IEnumerator CoMoveBy(this Transform self, Vector3 offset, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetPosition, () => self.GetPositionBy(offset), self.SetPosition, timer);

        public static IEnumerator CoMoveFor(this Transform self, Vector3 direction, IEnumerator<float> deltaTimer)
            => Yield.ValueTo(t => direction * t, self.SetPositionBy, deltaTimer);

        public static IEnumerator CoMove(this Transform self, Vector3 target, float duration, Func<float, float> easer = null)
            => self.CoMove(target, Yield.Time(duration, easer));

        public static IEnumerator CoMove(this Transform self, Vector3 start, Vector3 target, float duration, Func<float, float> easer = null)
            => self.CoMove(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoMove(this Transform self, Transform target, float duration, Func<float, float> easer = null)
            => self.CoMove(target, Yield.Time(duration, easer));

        public static IEnumerator CoMove(this Transform self, Vector3 start, Transform target, float duration, Func<float, float> easer = null)
            => self.CoMove(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoMoveX(this Transform self, float target, float duration, Func<float, float> easer = null)
            => self.CoMoveX(target, Yield.Time(duration, easer));

        public static IEnumerator CoMoveX(this Transform self, float start, float target, float duration, Func<float, float> easer = null)
            => self.CoMoveX(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoMoveY(this Transform self, float target, float duration, Func<float, float> easer = null)
            => self.CoMoveY(target, Yield.Time(duration, easer));

        public static IEnumerator CoMoveY(this Transform self, float start, float target, float duration, Func<float, float> easer = null)
            => self.CoMoveY(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoMoveZ(this Transform self, float target, float duration, Func<float, float> easer = null)
            => self.CoMoveZ(target, Yield.Time(duration, easer));

        public static IEnumerator CoMoveZ(this Transform self, float start, float target, float duration, Func<float, float> easer = null)
            => self.CoMoveZ(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoMoveXY(this Transform self, Vector2 target, float duration, Func<float, float> easer = null)
            => self.CoMoveXY(target, Yield.Time(duration, easer));

        public static IEnumerator CoMoveXY(this Transform self, Vector2 start, Vector2 target, float duration, Func<float, float> easer = null)
            => self.CoMoveXY(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoMoveYZ(this Transform self, Vector2 target, float duration, Func<float, float> easer = null)
            => self.CoMoveYZ(target, Yield.Time(duration, easer));

        public static IEnumerator CoMoveYZ(this Transform self, Vector2 start, Vector2 target, float duration, Func<float, float> easer = null)
            => self.CoMoveYZ(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoMoveXZ(this Transform self, Vector2 target, float duration, Func<float, float> easer = null)
            => self.CoMoveXZ(target, Yield.Time(duration, easer));

        public static IEnumerator CoMoveXZ(this Transform self, Vector2 start, Vector2 target, float duration, Func<float, float> easer = null)
            => self.CoMoveXZ(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoMoveBy(this Transform self, Vector3 offset, float duration, Func<float, float> easer = null)
            => self.CoMoveBy(offset, Yield.Time(duration, easer));

        public static IEnumerator CoMoveFor(this Transform self, Vector3 direction, float duration, Func<float, float> easer = null)
            => self.CoMoveFor(direction, Yield.DeltaTime(duration, easer));
        #endregion

        #region LocalMove
        public static IEnumerator CoLocalMove(this Transform self, Vector3 target)
            => Yield.Into(target, self.SetLocalPosition);

        public static IEnumerator CoLocalMove(this Transform self, Vector3 target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetLocalPosition, target, self.SetLocalPosition, timer);

        public static IEnumerator CoLocalMove(this Transform self, Vector3 start, Vector3 target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetLocalPosition, timer);

        public static IEnumerator CoLocalMove(this Transform self, Transform target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetLocalPosition, target.GetLocalPosition, self.SetLocalPosition, timer);

        public static IEnumerator CoLocalMove(this Transform self, Vector3 start, Transform target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target.GetLocalPosition, self.SetLocalPosition, timer);

        public static IEnumerator CoLocalMoveX(this Transform self, float target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetLocalPositionX, target, self.SetLocalPositionX, timer);

        public static IEnumerator CoLocalMoveX(this Transform self, float start, float target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetLocalPositionX, timer);

        public static IEnumerator CoLocalMoveY(this Transform self, float target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetLocalPositionY, target, self.SetLocalPositionY, timer);

        public static IEnumerator CoLocalMoveY(this Transform self, float start, float target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetLocalPositionY, timer);

        public static IEnumerator CoLocalMoveZ(this Transform self, float target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetLocalPositionZ, target, self.SetLocalPositionZ, timer);

        public static IEnumerator CoLocalMoveZ(this Transform self, float start, float target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetLocalPositionZ, timer);

        public static IEnumerator CoLocalMoveXY(this Transform self, Vector2 target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetLocalPositionXY, target, self.SetLocalPositionXY, timer);

        public static IEnumerator CoLocalMoveXY(this Transform self, Vector2 start, Vector2 target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetLocalPositionXY, timer);

        public static IEnumerator CoLocalMoveYZ(this Transform self, Vector2 target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetLocalPositionYZ, target, self.SetLocalPositionYZ, timer);

        public static IEnumerator CoLocalMoveYZ(this Transform self, Vector2 start, Vector2 target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetLocalPositionYZ, timer);

        public static IEnumerator CoLocalMoveXZ(this Transform self, Vector2 target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetLocalPositionXZ, target, self.SetLocalPositionXZ, timer);

        public static IEnumerator CoLocalMoveXZ(this Transform self, Vector2 start, Vector2 target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetLocalPositionXZ, timer);

        public static IEnumerator CoLocalMoveBy(this Transform self, Vector3 offset, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetLocalPosition, () => self.GetLocalOffsetPosition(offset), self.SetLocalPosition, timer);

        public static IEnumerator CoLocalMoveFor(this Transform self, Vector3 direction, IEnumerator<float> deltaTimer)
            => Yield.ValueTo(t => direction * t, self.SetLocalOffsetPosition, deltaTimer);

        public static IEnumerator CoLocalMove(this Transform self, Vector3 target, float duration, Func<float, float> easer = null)
            => self.CoLocalMove(target, Yield.Time(duration, easer));

        public static IEnumerator CoLocalMove(this Transform self, Vector3 start, Vector3 target, float duration, Func<float, float> easer = null)
            => self.CoLocalMove(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoLocalMove(this Transform self, Transform target, float duration, Func<float, float> easer = null)
            => self.CoLocalMove(target, Yield.Time(duration, easer));

        public static IEnumerator CoLocalMove(this Transform self, Vector3 start, Transform target, float duration, Func<float, float> easer = null)
            => self.CoLocalMove(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoLocalMoveX(this Transform self, float target, float duration, Func<float, float> easer = null)
            => self.CoLocalMoveX(target, Yield.Time(duration, easer));

        public static IEnumerator CoLocalMoveX(this Transform self, float start, float target, float duration, Func<float, float> easer = null)
            => self.CoLocalMoveX(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoLocalMoveY(this Transform self, float target, float duration, Func<float, float> easer = null)
            => self.CoLocalMoveY(target, Yield.Time(duration, easer));

        public static IEnumerator CoLocalMoveY(this Transform self, float start, float target, float duration, Func<float, float> easer = null)
            => self.CoLocalMoveY(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoLocalMoveZ(this Transform self, float target, float duration, Func<float, float> easer = null)
            => self.CoLocalMoveZ(target, Yield.Time(duration, easer));

        public static IEnumerator CoLocalMoveZ(this Transform self, float start, float target, float duration, Func<float, float> easer = null)
            => self.CoLocalMoveZ(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoLocalMoveXY(this Transform self, Vector2 target, float duration, Func<float, float> easer = null)
            => self.CoLocalMoveXY(target, Yield.Time(duration, easer));

        public static IEnumerator CoLocalMoveXY(this Transform self, Vector2 start, Vector2 target, float duration, Func<float, float> easer = null)
            => self.CoLocalMoveXY(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoLocalMoveYZ(this Transform self, Vector2 target, float duration, Func<float, float> easer = null)
            => self.CoLocalMoveYZ(target, Yield.Time(duration, easer));

        public static IEnumerator CoLocalMoveYZ(this Transform self, Vector2 start, Vector2 target, float duration, Func<float, float> easer = null)
            => self.CoLocalMoveYZ(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoLocalMoveXZ(this Transform self, Vector2 target, float duration, Func<float, float> easer = null)
            => self.CoLocalMoveXZ(target, Yield.Time(duration, easer));

        public static IEnumerator CoLocalMoveXZ(this Transform self, Vector2 start, Vector2 target, float duration, Func<float, float> easer = null)
            => self.CoLocalMoveXZ(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoLocalMoveBy(this Transform self, Vector3 offset, float duration, Func<float, float> easer = null)
            => self.CoLocalMoveBy(offset, Yield.Time(duration, easer));

        public static IEnumerator CoLocalMoveFor(this Transform self, Vector3 direction, float duration, Func<float, float> easer = null)
            => self.CoLocalMoveFor(direction, Yield.DeltaTime(duration, easer));
        #endregion

        #region Rotate
        public static IEnumerator CoRotate(this Transform self, Quaternion target)
            => Yield.Into(target, self.SetRotation);

        public static IEnumerator CoRotate(this Transform self, Quaternion target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetRotation, target, self.SetRotation, timer);

        public static IEnumerator CoRotate(this Transform self, Quaternion start, Quaternion target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetRotation, timer);

        public static IEnumerator CoRotate(this Transform self, Transform target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetRotation, target.GetRotation, self.SetRotation, timer);

        public static IEnumerator CoRotate(this Transform self, Quaternion start, Transform target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target.GetRotation, self.SetRotation, timer);

        public static IEnumerator CoRotateBy(this Transform self, Quaternion offset, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetRotation, () => self.GetRotationBy(offset), self.SetRotation, timer);

        public static IEnumerator CoRotate(this Transform self, Quaternion target, float duration, Func<float, float> easer = null)
            => self.CoRotate(target, Yield.Time(duration, easer));

        public static IEnumerator CoRotate(this Transform self, Quaternion start, Quaternion target, float duration, Func<float, float> easer = null)
            => self.CoRotate(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoRotate(this Transform self, Transform target, float duration, Func<float, float> easer = null)
            => self.CoRotate(target, Yield.Time(duration, easer));

        public static IEnumerator CoRotate(this Transform self, Quaternion start, Transform target, float duration, Func<float, float> easer = null)
            => self.CoRotate(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoRotateBy(this Transform self, Quaternion offset, float duration, Func<float, float> easer = null)
            => self.CoRotateBy(offset, Yield.Time(duration, easer));
        #endregion

        #region LocalRotate
        public static IEnumerator CoLocalRotate(this Transform self, Quaternion target)
            => Yield.Into(target, self.SetLocalRotation);

        public static IEnumerator CoLocalRotate(this Transform self, Quaternion target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetLocalRotation, target, self.SetLocalRotation, timer);

        public static IEnumerator CoLocalRotate(this Transform self, Quaternion start, Quaternion target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetLocalRotation, timer);

        public static IEnumerator CoLocalRotate(this Transform self, Transform target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetLocalRotation, target.GetLocalRotation, self.SetLocalRotation, timer);

        public static IEnumerator CoLocalRotate(this Transform self, Quaternion start, Transform target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target.GetLocalRotation, self.SetLocalRotation, timer);

        public static IEnumerator CoLocalRotateBy(this Transform self, Quaternion offset, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetLocalRotation, () => self.GetLocalRotationBy(offset), self.SetLocalRotation, timer);

        public static IEnumerator CoLocalRotate(this Transform self, Quaternion target, float duration, Func<float, float> easer = null)
            => self.CoLocalRotate(target, Yield.Time(duration, easer));

        public static IEnumerator CoLocalRotate(this Transform self, Quaternion start, Quaternion target, float duration, Func<float, float> easer = null)
            => self.CoLocalRotate(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoLocalRotate(this Transform self, Transform target, float duration, Func<float, float> easer = null)
            => self.CoLocalRotate(target, Yield.Time(duration, easer));

        public static IEnumerator CoLocalRotate(this Transform self, Quaternion start, Transform target, float duration, Func<float, float> easer = null)
            => self.CoLocalRotate(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoLocalRotateBy(this Transform self, Quaternion offset, float duration, Func<float, float> easer = null)
            => self.CoLocalRotateBy(offset, Yield.Time(duration, easer));
        #endregion

        #region LookAt
        public static IEnumerator CoLookAt(this Transform self, Vector3 position, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetRotation, () => self.GetLookAtRotation(position), self.SetRotation, timer);

        public static IEnumerator CoLookAt(this Transform self, Transform target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetRotation, () => self.GetLookAtRotation(target), self.SetRotation, timer);

        public static IEnumerator CoLookAt(this Transform self, Vector3 position, float duration, Func<float, float> easer = null)
            => self.CoLookAt(position, Yield.Time(duration, easer));

        public static IEnumerator CoLookAt(this Transform self, Transform target, float duration, Func<float, float> easer = null)
            => self.CoLookAt(target, Yield.Time(duration, easer));
        #endregion

        #region LocalLookAt
        public static IEnumerator CoLocalLookAt(this Transform self, Vector3 position, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetLocalRotation, () => self.GetLocalLookAtRotation(position), self.SetLocalRotation, timer);

        public static IEnumerator CoLocalLookAt(this Transform self, Transform target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetLocalRotation, () => self.GetLocalLookAtRotation(target), self.SetLocalRotation, timer);

        public static IEnumerator CoLocalLookAt(this Transform self, Vector3 position, float duration, Func<float, float> easer = null)
            => self.CoLocalLookAt(position, Yield.Time(duration, easer));

        public static IEnumerator CoLocalLookAt(this Transform self, Transform target, float duration, Func<float, float> easer = null)
            => self.CoLocalLookAt(target, Yield.Time(duration, easer));
        #endregion

        #region LocalScale
        public static IEnumerator CoLocalScale(this Transform self, Vector3 target)
            => Yield.Into(target, self.SetLocalScale);

        public static IEnumerator CoLocalScale(this Transform self, Vector3 target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetLocalScale, target, self.SetLocalScale, timer);

        public static IEnumerator CoLocalScale(this Transform self, Vector3 start, Vector3 target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetLocalScale, timer);

        public static IEnumerator CoLocalScale(this Transform self, Transform target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetLocalScale, target.GetLocalScale, self.SetLocalScale, timer);

        public static IEnumerator CoLocalScale(this Transform self, Vector3 start, Transform target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target.GetLocalScale, self.SetLocalScale, timer);

        public static IEnumerator CoLocalScaleX(this Transform self, float target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetLocalScaleX, target, self.SetLocalScaleX, timer);

        public static IEnumerator CoLocalScaleX(this Transform self, float start, float target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetLocalScaleX, timer);

        public static IEnumerator CoLocalScaleY(this Transform self, float target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetLocalScaleY, target, self.SetLocalScaleY, timer);

        public static IEnumerator CoLocalScaleY(this Transform self, float start, float target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetLocalScaleY, timer);

        public static IEnumerator CoLocalScaleZ(this Transform self, float target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetLocalScaleZ, target, self.SetLocalScaleZ, timer);

        public static IEnumerator CoLocalScaleZ(this Transform self, float start, float target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetLocalScaleZ, timer);

        public static IEnumerator CoLocalScaleXY(this Transform self, Vector2 target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetLocalScaleXY, target, self.SetLocalScaleXY, timer);

        public static IEnumerator CoLocalScaleXY(this Transform self, Vector2 start, Vector2 target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetLocalScaleXY, timer);

        public static IEnumerator CoLocalScaleYZ(this Transform self, Vector2 target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetLocalScaleYZ, target, self.SetLocalScaleYZ, timer);

        public static IEnumerator CoLocalScaleYZ(this Transform self, Vector2 start, Vector2 target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetLocalScaleYZ, timer);

        public static IEnumerator CoLocalScaleXZ(this Transform self, Vector2 target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetLocalScaleXZ, target, self.SetLocalScaleXZ, timer);

        public static IEnumerator CoLocalScaleXZ(this Transform self, Vector2 start, Vector2 target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetLocalScaleXZ, timer);

        public static IEnumerator CoLocalScaleBy(this Transform self, Vector3 offset, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetLocalScale, () => self.GetLocalScaleBy(offset), self.SetLocalScale, timer);

        public static IEnumerator CoLocalScale(this Transform self, Vector3 target, float duration, Func<float, float> easer = null)
            => self.CoLocalScale(target, Yield.Time(duration, easer));

        public static IEnumerator CoLocalScale(this Transform self, Vector3 start, Vector3 target, float duration, Func<float, float> easer = null)
            => self.CoLocalScale(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoLocalScale(this Transform self, Transform target, float duration, Func<float, float> easer = null)
            => self.CoLocalScale(target, Yield.Time(duration, easer));

        public static IEnumerator CoLocalScale(this Transform self, Vector3 start, Transform target, float duration, Func<float, float> easer = null)
            => self.CoLocalScale(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoLocalScaleX(this Transform self, float target, float duration, Func<float, float> easer = null)
            => self.CoLocalScaleX(target, Yield.Time(duration, easer));

        public static IEnumerator CoLocalScaleX(this Transform self, float start, float target, float duration, Func<float, float> easer = null)
            => self.CoLocalScaleX(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoLocalScaleY(this Transform self, float target, float duration, Func<float, float> easer = null)
            => self.CoLocalScaleY(target, Yield.Time(duration, easer));

        public static IEnumerator CoLocalScaleY(this Transform self, float start, float target, float duration, Func<float, float> easer = null)
            => self.CoLocalScaleY(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoLocalScaleZ(this Transform self, float target, float duration, Func<float, float> easer = null)
            => self.CoLocalScaleZ(target, Yield.Time(duration, easer));

        public static IEnumerator CoLocalScaleZ(this Transform self, float start, float target, float duration, Func<float, float> easer = null)
            => self.CoLocalScaleZ(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoLocalScaleXY(this Transform self, Vector2 target, float duration, Func<float, float> easer = null)
            => self.CoLocalScaleXY(target, Yield.Time(duration, easer));

        public static IEnumerator CoLocalScaleXY(this Transform self, Vector2 start, Vector2 target, float duration, Func<float, float> easer = null)
            => self.CoLocalScaleXY(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoLocalScaleYZ(this Transform self, Vector2 target, float duration, Func<float, float> easer = null)
            => self.CoLocalScaleYZ(target, Yield.Time(duration, easer));

        public static IEnumerator CoLocalScaleYZ(this Transform self, Vector2 start, Vector2 target, float duration, Func<float, float> easer = null)
            => self.CoLocalScaleYZ(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoLocalScaleXZ(this Transform self, Vector2 target, float duration, Func<float, float> easer = null)
            => self.CoLocalScaleXZ(target, Yield.Time(duration, easer));

        public static IEnumerator CoLocalScaleXZ(this Transform self, Vector2 start, Vector2 target, float duration, Func<float, float> easer = null)
            => self.CoLocalScaleXZ(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoLocalScaleBy(this Transform self, Vector3 offset, float duration, Func<float, float> easer = null)
            => self.CoLocalScaleBy(offset, Yield.Time(duration, easer));
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
