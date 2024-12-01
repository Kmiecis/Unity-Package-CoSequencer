using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Common.Coroutines
{
    public static class RectTransformExtensions
    {
        #region AnchorMin
        public static IEnumerator CoAnchorMin(this RectTransform self, Vector2 target)
            => Yield.Into(target, self.SetAnchorMin);

        public static IEnumerator CoAnchorMin(this RectTransform self, Vector2 target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetAnchorMin, target, self.SetAnchorMin, timer);

        public static IEnumerator CoAnchorMin(this RectTransform self, Vector2 start, Vector2 target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetAnchorMin, timer);

        public static IEnumerator CoAnchorMinX(this RectTransform self, float target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetAnchorMinX, target, self.SetAnchorMinX, timer);

        public static IEnumerator CoAnchorMinX(this RectTransform self, float start, float target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetAnchorMinX, timer);

        public static IEnumerator CoAnchorMinY(this RectTransform self, float target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetAnchorMinY, target, self.SetAnchorMinY, timer);

        public static IEnumerator CoAnchorMinY(this RectTransform self, float start, float target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetAnchorMinY, timer);

        public static IEnumerator CoAnchorMinBy(this RectTransform self, Vector2 target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetAnchorMin, () => self.GetAnchorMinBy(target), self.SetAnchorMin, timer);

        public static IEnumerator CoAnchorMinFor(this RectTransform self, Vector2 direction, IEnumerator<float> deltaTimer)
            => Yield.ValueTo(t => direction * t, self.SetAnchorMinBy, deltaTimer);

        public static IEnumerator CoAnchorMin(this RectTransform self, Vector2 target, float duration, Func<float, float> easer = null)
            => self.CoAnchorMin(target, Yield.Time(duration, easer));

        public static IEnumerator CoAnchorMin(this RectTransform self, Vector2 start, Vector2 target, float duration, Func<float, float> easer = null)
            => self.CoAnchorMin(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoAnchorMinX(this RectTransform self, float target, float duration, Func<float, float> easer = null)
            => self.CoAnchorMinX(target, Yield.Time(duration, easer));

        public static IEnumerator CoAnchorMinX(this RectTransform self, float start, float target, float duration, Func<float, float> easer = null)
            => self.CoAnchorMinX(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoAnchorMinY(this RectTransform self, float target, float duration, Func<float, float> easer = null)
            => self.CoAnchorMinY(target, Yield.Time(duration, easer));

        public static IEnumerator CoAnchorMinY(this RectTransform self, float start, float target, float duration, Func<float, float> easer = null)
            => self.CoAnchorMinY(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoAnchorMinBy(this RectTransform self, Vector2 target, float duration, Func<float, float> easer = null)
            => self.CoAnchorMinBy(target, Yield.Time(duration, easer));

        public static IEnumerator CoAnchorMinFor(this RectTransform self, Vector2 direction, float duration, Func<float, float> easer = null)
            => self.CoAnchorMinFor(direction, Yield.DeltaTime(duration, easer));
        #endregion

        #region AnchorMax
        public static IEnumerator CoAnchorMax(this RectTransform self, Vector2 target)
            => Yield.Into(target, self.SetAnchorMax);

        public static IEnumerator CoAnchorMax(this RectTransform self, Vector2 target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetAnchorMax, target, self.SetAnchorMax, timer);

        public static IEnumerator CoAnchorMax(this RectTransform self, Vector2 start, Vector2 target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetAnchorMax, timer);

        public static IEnumerator CoAnchorMaxX(this RectTransform self, float target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetAnchorMaxX, target, self.SetAnchorMaxX, timer);

        public static IEnumerator CoAnchorMaxX(this RectTransform self, float start, float target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetAnchorMaxX, timer);

        public static IEnumerator CoAnchorMaxY(this RectTransform self, float target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetAnchorMaxY, target, self.SetAnchorMaxY, timer);

        public static IEnumerator CoAnchorMaxY(this RectTransform self, float start, float target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetAnchorMaxY, timer);

        public static IEnumerator CoAnchorMaxBy(this RectTransform self, Vector2 target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetAnchorMax, () => self.GetAnchorMaxBy(target), self.SetAnchorMax, timer);

        public static IEnumerator CoAnchorMaxFor(this RectTransform self, Vector2 direction, IEnumerator<float> deltaTimer)
            => Yield.ValueTo(t => direction * t, self.SetAnchorMaxBy, deltaTimer);

        public static IEnumerator CoAnchorMax(this RectTransform self, Vector2 target, float duration, Func<float, float> easer = null)
            => self.CoAnchorMax(target, Yield.Time(duration, easer));

        public static IEnumerator CoAnchorMax(this RectTransform self, Vector2 start, Vector2 target, float duration, Func<float, float> easer = null)
            => self.CoAnchorMax(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoAnchorMaxX(this RectTransform self, float target, float duration, Func<float, float> easer = null)
            => self.CoAnchorMaxX(target, Yield.Time(duration, easer));

        public static IEnumerator CoAnchorMaxX(this RectTransform self, float start, float target, float duration, Func<float, float> easer = null)
            => self.CoAnchorMaxX(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoAnchorMaxY(this RectTransform self, float target, float duration, Func<float, float> easer = null)
            => self.CoAnchorMaxY(target, Yield.Time(duration, easer));

        public static IEnumerator CoAnchorMaxY(this RectTransform self, float start, float target, float duration, Func<float, float> easer = null)
            => self.CoAnchorMaxY(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoAnchorMaxBy(this RectTransform self, Vector2 target, float duration, Func<float, float> easer = null)
            => self.CoAnchorMaxBy(target, Yield.Time(duration, easer));

        public static IEnumerator CoAnchorMaxFor(this RectTransform self, Vector2 direction, float duration, Func<float, float> easer = null)
            => self.CoAnchorMaxFor(direction, Yield.DeltaTime(duration, easer));
        #endregion

        #region AnchorMove
        public static IEnumerator CoAnchorMove(this RectTransform self, Vector2 target)
            => Yield.Into(target, self.SetAnchorPosition);

        public static IEnumerator CoAnchorMove(this RectTransform self, Vector2 target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetAnchorPosition, target, self.SetAnchorPosition, timer);

        public static IEnumerator CoAnchorMove(this RectTransform self, Vector2 start, Vector2 target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetAnchorPosition, timer);

        public static IEnumerator CoAnchorMoveX(this RectTransform self, float target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetAnchorPositionX, target, self.SetAnchorPositionX, timer);

        public static IEnumerator CoAnchorMoveX(this RectTransform self, float start, float target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetAnchorPositionX, timer);

        public static IEnumerator CoAnchorMoveY(this RectTransform self, float target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetAnchorPositionY, target, self.SetAnchorPositionY, timer);

        public static IEnumerator CoAnchorMoveY(this RectTransform self, float start, float target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetAnchorPositionY, timer);

        public static IEnumerator CoAnchorMoveBy(this RectTransform self, Vector2 target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetAnchorPosition, () => self.GetAnchorPositionBy(target), self.SetAnchorPosition, timer);

        public static IEnumerator CoAnchorMoveFor(this RectTransform self, Vector2 direction, IEnumerator<float> deltaTimer)
            => Yield.ValueTo(t => direction * t, self.SetAnchorPositionBy, deltaTimer);

        public static IEnumerator CoAnchorMove(this RectTransform self, Vector2 target, float duration, Func<float, float> easer = null)
            => self.CoAnchorMove(target, Yield.Time(duration, easer));

        public static IEnumerator CoAnchorMove(this RectTransform self, Vector2 start, Vector2 target, float duration, Func<float, float> easer = null)
            => self.CoAnchorMove(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoAnchorMoveX(this RectTransform self, float target, float duration, Func<float, float> easer = null)
            => self.CoAnchorMoveX(target, Yield.Time(duration, easer));

        public static IEnumerator CoAnchorMoveX(this RectTransform self, float start, float target, float duration, Func<float, float> easer = null)
            => self.CoAnchorMoveX(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoAnchorMoveY(this RectTransform self, float target, float duration, Func<float, float> easer = null)
            => self.CoAnchorMoveY(target, Yield.Time(duration, easer));

        public static IEnumerator CoAnchorMoveY(this RectTransform self, float start, float target, float duration, Func<float, float> easer = null)
            => self.CoAnchorMoveY(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoAnchorMoveBy(this RectTransform self, Vector2 target, float duration, Func<float, float> easer = null)
            => self.CoAnchorMoveBy(target, Yield.Time(duration, easer));

        public static IEnumerator CoAnchorMoveFor(this RectTransform self, Vector2 direction, float duration, Func<float, float> easer = null)
            => self.CoAnchorMoveFor(direction, Yield.DeltaTime(duration, easer));
        #endregion

        #region OffsetMin
        public static IEnumerator CoOffsetMin(this RectTransform self, Vector2 target)
            => Yield.Into(target, self.SetOffsetMin);

        public static IEnumerator CoOffsetMin(this RectTransform self, Vector2 target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetOffsetMin, target, self.SetOffsetMin, timer);

        public static IEnumerator CoOffsetMin(this RectTransform self, Vector2 start, Vector2 target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetOffsetMin, timer);

        public static IEnumerator CoOffsetMinX(this RectTransform self, float target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetOffsetMinX, target, self.SetOffsetMinX, timer);

        public static IEnumerator CoOffsetMinX(this RectTransform self, float start, float target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetOffsetMinX, timer);

        public static IEnumerator CoOffsetMinY(this RectTransform self, float target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetOffsetMinY, target, self.SetOffsetMinY, timer);

        public static IEnumerator CoOffsetMinY(this RectTransform self, float start, float target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetOffsetMinY, timer);

        public static IEnumerator CoOffsetMinBy(this RectTransform self, Vector2 target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetOffsetMin, () => self.GetOffsetMinBy(target), self.SetOffsetMin, timer);

        public static IEnumerator CoOffsetMinFor(this RectTransform self, Vector2 direction, IEnumerator<float> deltaTimer)
            => Yield.ValueTo(t => direction * t, self.SetOffsetMinBy, deltaTimer);

        public static IEnumerator CoOffsetMin(this RectTransform self, Vector2 target, float duration, Func<float, float> easer = null)
            => self.CoOffsetMin(target, Yield.Time(duration, easer));

        public static IEnumerator CoOffsetMin(this RectTransform self, Vector2 start, Vector2 target, float duration, Func<float, float> easer = null)
            => self.CoOffsetMin(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoOffsetMinX(this RectTransform self, float target, float duration, Func<float, float> easer = null)
            => self.CoOffsetMinX(target, Yield.Time(duration, easer));

        public static IEnumerator CoOffsetMinX(this RectTransform self, float start, float target, float duration, Func<float, float> easer = null)
            => self.CoOffsetMinX(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoOffsetMinY(this RectTransform self, float target, float duration, Func<float, float> easer = null)
            => self.CoOffsetMinY(target, Yield.Time(duration, easer));

        public static IEnumerator CoOffsetMinY(this RectTransform self, float start, float target, float duration, Func<float, float> easer = null)
            => self.CoOffsetMinY(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoOffsetMinBy(this RectTransform self, Vector2 target, float duration, Func<float, float> easer = null)
            => self.CoOffsetMinBy(target, Yield.Time(duration, easer));

        public static IEnumerator CoOffsetMinFor(this RectTransform self, Vector2 direction, float duration, Func<float, float> easer = null)
            => self.CoOffsetMinFor(direction, Yield.DeltaTime(duration, easer));
        #endregion

        #region OffsetMax
        public static IEnumerator CoOffsetMax(this RectTransform self, Vector2 target)
            => Yield.Into(target, self.SetOffsetMax);

        public static IEnumerator CoOffsetMax(this RectTransform self, Vector2 target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetOffsetMax, target, self.SetOffsetMax, timer);

        public static IEnumerator CoOffsetMax(this RectTransform self, Vector2 start, Vector2 target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetOffsetMax, timer);

        public static IEnumerator CoOffsetMaxX(this RectTransform self, float target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetOffsetMaxX, target, self.SetOffsetMaxX, timer);

        public static IEnumerator CoOffsetMaxX(this RectTransform self, float start, float target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetOffsetMaxX, timer);

        public static IEnumerator CoOffsetMaxY(this RectTransform self, float target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetOffsetMaxY, target, self.SetOffsetMaxY, timer);

        public static IEnumerator CoOffsetMaxY(this RectTransform self, float start, float target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetOffsetMaxY, timer);

        public static IEnumerator CoOffsetMaxBy(this RectTransform self, Vector2 target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetOffsetMax, () => self.GetOffsetMaxBy(target), self.SetOffsetMax, timer);

        public static IEnumerator CoOffsetMaxFor(this RectTransform self, Vector2 direction, IEnumerator<float> deltaTimer)
            => Yield.ValueTo(t => direction * t, self.SetOffsetMaxBy, deltaTimer);

        public static IEnumerator CoOffsetMax(this RectTransform self, Vector2 target, float duration, Func<float, float> easer = null)
            => self.CoOffsetMax(target, Yield.Time(duration, easer));

        public static IEnumerator CoOffsetMax(this RectTransform self, Vector2 start, Vector2 target, float duration, Func<float, float> easer = null)
            => self.CoOffsetMax(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoOffsetMaxX(this RectTransform self, float target, float duration, Func<float, float> easer = null)
            => self.CoOffsetMaxX(target, Yield.Time(duration, easer));

        public static IEnumerator CoOffsetMaxX(this RectTransform self, float start, float target, float duration, Func<float, float> easer = null)
            => self.CoOffsetMaxX(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoOffsetMaxY(this RectTransform self, float target, float duration, Func<float, float> easer = null)
            => self.CoOffsetMaxY(target, Yield.Time(duration, easer));

        public static IEnumerator CoOffsetMaxY(this RectTransform self, float start, float target, float duration, Func<float, float> easer = null)
            => self.CoOffsetMaxY(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoOffsetMaxBy(this RectTransform self, Vector2 target, float duration, Func<float, float> easer = null)
            => self.CoOffsetMaxBy(target, Yield.Time(duration, easer));

        public static IEnumerator CoOffsetMaxFor(this RectTransform self, Vector2 direction, float duration, Func<float, float> easer = null)
            => self.CoOffsetMaxFor(direction, Yield.DeltaTime(duration, easer));
        #endregion

        #region Pivot
        public static IEnumerator CoPivot(this RectTransform self, Vector2 target)
            => Yield.Into(target, self.SetPivot);

        public static IEnumerator CoPivot(this RectTransform self, Vector2 target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetPivot, target, self.SetPivot, timer);

        public static IEnumerator CoPivot(this RectTransform self, Vector2 start, Vector2 target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetPivot, timer);

        public static IEnumerator CoPivotX(this RectTransform self, float target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetPivotX, target, self.SetPivotX, timer);

        public static IEnumerator CoPivotX(this RectTransform self, float start, float target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetPivotX, timer);

        public static IEnumerator CoPivotY(this RectTransform self, float target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetPivotY, target, self.SetPivotY, timer);

        public static IEnumerator CoPivotY(this RectTransform self, float start, float target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetPivotY, timer);

        public static IEnumerator CoPivotBy(this RectTransform self, Vector2 target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetPivot, () => self.GetPivotBy(target), self.SetPivot, timer);

        public static IEnumerator CoPivotFor(this RectTransform self, Vector2 direction, IEnumerator<float> deltaTimer)
            => Yield.ValueTo(t => direction * t, self.SetPivotBy, deltaTimer);

        public static IEnumerator CoPivot(this RectTransform self, Vector2 target, float duration, Func<float, float> easer = null)
            => self.CoPivot(target, Yield.Time(duration, easer));

        public static IEnumerator CoPivot(this RectTransform self, Vector2 start, Vector2 target, float duration, Func<float, float> easer = null)
            => self.CoPivot(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoPivotX(this RectTransform self, float target, float duration, Func<float, float> easer = null)
            => self.CoPivotX(target, Yield.Time(duration, easer));

        public static IEnumerator CoPivotX(this RectTransform self, float start, float target, float duration, Func<float, float> easer = null)
            => self.CoPivotX(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoPivotY(this RectTransform self, float target, float duration, Func<float, float> easer = null)
            => self.CoPivotY(target, Yield.Time(duration, easer));

        public static IEnumerator CoPivotY(this RectTransform self, float start, float target, float duration, Func<float, float> easer = null)
            => self.CoPivotY(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoPivotBy(this RectTransform self, Vector2 target, float duration, Func<float, float> easer = null)
            => self.CoPivotBy(target, Yield.Time(duration, easer));

        public static IEnumerator CoPivotFor(this RectTransform self, Vector2 direction, float duration, Func<float, float> easer = null)
            => self.CoPivotFor(direction, Yield.DeltaTime(duration, easer));
        #endregion

        #region SizeDelta
        public static IEnumerator CoSizeDelta(this RectTransform self, Vector2 target)
            => Yield.Into(target, self.SetSizeDelta);

        public static IEnumerator CoSizeDelta(this RectTransform self, Vector2 target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetSizeDelta, target, self.SetSizeDelta, timer);

        public static IEnumerator CoSizeDelta(this RectTransform self, Vector2 start, Vector2 target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetSizeDelta, timer);

        public static IEnumerator CoSizeDeltaX(this RectTransform self, float target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetSizeDeltaX, target, self.SetSizeDeltaX, timer);

        public static IEnumerator CoSizeDeltaX(this RectTransform self, float start, float target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetSizeDeltaX, timer);

        public static IEnumerator CoSizeDeltaY(this RectTransform self, float target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetSizeDeltaY, target, self.SetSizeDeltaY, timer);

        public static IEnumerator CoSizeDeltaY(this RectTransform self, float start, float target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetSizeDeltaY, timer);

        public static IEnumerator CoSizeDeltaBy(this RectTransform self, Vector2 target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetSizeDelta, () => self.GetSizeDeltaBy(target), self.SetSizeDelta, timer);

        public static IEnumerator CoSizeDeltaFor(this RectTransform self, Vector2 direction, IEnumerator<float> deltaTimer)
            => Yield.ValueTo(t => direction * t, self.SetSizeDeltaBy, deltaTimer);

        public static IEnumerator CoSizeDelta(this RectTransform self, Vector2 target, float duration, Func<float, float> easer = null)
            => self.CoSizeDelta(target, Yield.Time(duration, easer));

        public static IEnumerator CoSizeDelta(this RectTransform self, Vector2 start, Vector2 target, float duration, Func<float, float> easer = null)
            => self.CoSizeDelta(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoSizeDeltaX(this RectTransform self, float target, float duration, Func<float, float> easer = null)
            => self.CoSizeDeltaX(target, Yield.Time(duration, easer));

        public static IEnumerator CoSizeDeltaX(this RectTransform self, float start, float target, float duration, Func<float, float> easer = null)
            => self.CoSizeDeltaX(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoSizeDeltaY(this RectTransform self, float target, float duration, Func<float, float> easer = null)
            => self.CoSizeDeltaY(target, Yield.Time(duration, easer));

        public static IEnumerator CoSizeDeltaY(this RectTransform self, float start, float target, float duration, Func<float, float> easer = null)
            => self.CoSizeDeltaY(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoSizeDeltaBy(this RectTransform self, Vector2 target, float duration, Func<float, float> easer = null)
            => self.CoSizeDeltaBy(target, Yield.Time(duration, easer));

        public static IEnumerator CoSizeDeltaFor(this RectTransform self, Vector2 direction, float duration, Func<float, float> easer = null)
            => self.CoSizeDeltaFor(direction, Yield.DeltaTime(duration, easer));
        #endregion
    }

    internal static class InternalRectTransformExtensions
    {
        #region Anchor
        public static Vector2 GetAnchorMin(this RectTransform self)
            => self.anchorMin;

        public static void SetAnchorMin(this RectTransform self, Vector2 value)
            => self.anchorMin = value;

        public static Vector2 GetAnchorMinBy(this RectTransform self, Vector2 value)
            => self.anchorMin + value;

        public static void SetAnchorMinBy(this RectTransform self, Vector2 value)
            => self.anchorMin += value;

        public static float GetAnchorMinX(this RectTransform self)
            => self.anchorMin.x;

        public static void SetAnchorMinX(this RectTransform self, float value)
            => self.anchorMin = self.anchorMin.WithX(value);

        public static float GetAnchorMinY(this RectTransform self)
            => self.anchorMin.y;

        public static void SetAnchorMinY(this RectTransform self, float value)
            => self.anchorMin = self.anchorMin.WithY(value);

        public static Vector2 GetAnchorMax(this RectTransform self)
            => self.anchorMax;

        public static void SetAnchorMax(this RectTransform self, Vector2 value)
            => self.anchorMax = value;

        public static Vector2 GetAnchorMaxBy(this RectTransform self, Vector2 value)
            => self.anchorMax + value;

        public static void SetAnchorMaxBy(this RectTransform self, Vector2 value)
            => self.anchorMax += value;

        public static float GetAnchorMaxX(this RectTransform self)
            => self.anchorMax.x;

        public static void SetAnchorMaxX(this RectTransform self, float value)
            => self.anchorMax = self.anchorMax.WithX(value);

        public static float GetAnchorMaxY(this RectTransform self)
            => self.anchorMax.y;

        public static void SetAnchorMaxY(this RectTransform self, float value)
            => self.anchorMax = self.anchorMax.WithY(value);
        #endregion

        #region Anchor position
        public static Vector2 GetAnchorPosition(this RectTransform self)
            => self.anchoredPosition;

        public static void SetAnchorPosition(this RectTransform self, Vector2 value)
            => self.anchoredPosition = value;

        public static Vector2 GetAnchorPositionBy(this RectTransform self, Vector2 value)
            => self.anchoredPosition + value;

        public static void SetAnchorPositionBy(this RectTransform self, Vector2 value)
            => self.anchoredPosition += value;

        public static float GetAnchorPositionX(this RectTransform self)
            => self.anchoredPosition.x;

        public static void SetAnchorPositionX(this RectTransform self, float value)
            => self.anchoredPosition = self.anchoredPosition.WithX(value);

        public static float GetAnchorPositionY(this RectTransform self)
            => self.anchoredPosition.y;

        public static void SetAnchorPositionY(this RectTransform self, float value)
            => self.anchoredPosition = self.anchoredPosition.WithY(value);
        #endregion

        #region Offset
        public static Vector2 GetOffsetMin(this RectTransform self)
            => self.offsetMin;

        public static void SetOffsetMin(this RectTransform self, Vector2 value)
            => self.offsetMin = value;

        public static Vector2 GetOffsetMinBy(this RectTransform self, Vector2 value)
            => self.offsetMin + value;

        public static void SetOffsetMinBy(this RectTransform self, Vector2 value)
            => self.offsetMin += value;

        public static float GetOffsetMinX(this RectTransform self)
            => self.offsetMin.x;

        public static void SetOffsetMinX(this RectTransform self, float value)
            => self.offsetMin = self.offsetMin.WithX(value);

        public static float GetOffsetMinY(this RectTransform self)
            => self.offsetMin.y;

        public static void SetOffsetMinY(this RectTransform self, float value)
            => self.offsetMin = self.offsetMin.WithY(value);

        public static Vector2 GetOffsetMax(this RectTransform self)
            => self.offsetMax;

        public static void SetOffsetMax(this RectTransform self, Vector2 value)
            => self.offsetMax = value;

        public static Vector2 GetOffsetMaxBy(this RectTransform self, Vector2 value)
            => self.offsetMax + value;

        public static void SetOffsetMaxBy(this RectTransform self, Vector2 value)
            => self.offsetMax += value;

        public static float GetOffsetMaxX(this RectTransform self)
            => self.offsetMax.x;

        public static void SetOffsetMaxX(this RectTransform self, float value)
            => self.offsetMax = self.offsetMax.WithX(value);

        public static float GetOffsetMaxY(this RectTransform self)
            => self.offsetMax.y;

        public static void SetOffsetMaxY(this RectTransform self, float value)
            => self.offsetMax = self.offsetMax.WithY(value);
        #endregion

        #region Pivot
        public static Vector2 GetPivot(this RectTransform self)
            => self.pivot;

        public static void SetPivot(this RectTransform self, Vector2 value)
            => self.pivot = value;

        public static float GetPivotX(this RectTransform self)
            => self.pivot.x;

        public static void SetPivotX(this RectTransform self, float value)
            => self.pivot = self.pivot.WithX(value);

        public static float GetPivotY(this RectTransform self)
            => self.pivot.y;

        public static void SetPivotY(this RectTransform self, float value)
            => self.pivot = self.pivot.WithY(value);

        public static Vector2 GetPivotBy(this RectTransform self, Vector2 value)
            => self.pivot + value;

        public static void SetPivotBy(this RectTransform self, Vector2 value)
            => self.pivot += value;
        #endregion

        #region Size delta
        public static Vector2 GetSizeDelta(this RectTransform self)
            => self.sizeDelta;

        public static void SetSizeDelta(this RectTransform self, Vector2 value)
            => self.sizeDelta = value;

        public static Vector2 GetSizeDeltaBy(this RectTransform self, Vector2 value)
            => self.sizeDelta + value;

        public static void SetSizeDeltaBy(this RectTransform self, Vector2 value)
            => self.sizeDelta += value;

        public static float GetSizeDeltaX(this RectTransform self)
            => self.sizeDelta.x;

        public static void SetSizeDeltaX(this RectTransform self, float value)
            => self.sizeDelta = self.sizeDelta.WithX(value);

        public static float GetSizeDeltaY(this RectTransform self)
            => self.sizeDelta.y;

        public static void SetSizeDeltaY(this RectTransform self, float value)
            => self.sizeDelta = self.sizeDelta.WithY(value);
        #endregion
    }
}
