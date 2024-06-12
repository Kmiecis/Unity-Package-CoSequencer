using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines
{
    public static class RectTransformExtensions
    {
        #region AnchorMin
        public static IEnumerator CoAnchorMin(this RectTransform self, Vector2 target)
            => UCoroutine.Yield(self.SetAnchorMin, target);

        public static IEnumerator CoAnchorMin(this RectTransform self, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetAnchorMin, target, self.SetAnchorMin, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoAnchorMin(this RectTransform self, Vector2 start, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetAnchorMin, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoAnchorMinX(this RectTransform self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetAnchorMinX, target, self.SetAnchorMinX, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoAnchorMinX(this RectTransform self, float start, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetAnchorMinX, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoAnchorMinY(this RectTransform self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetAnchorMinY, target, self.SetAnchorMinY, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoAnchorMinY(this RectTransform self, float start, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetAnchorMinY, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoAnchorMinBy(this RectTransform self, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetAnchorMin, () => self.GetAnchorMinBy(target), self.SetAnchorMin, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoAnchorMinFor(this RectTransform self, Vector2 direction, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(t => direction * t, self.SetAnchorMinBy, UCoroutine.YieldDeltaTime(duration, easer));
        #endregion

        #region AnchorMax
        public static IEnumerator CoAnchorMax(this RectTransform self, Vector2 target)
            => UCoroutine.Yield(self.SetAnchorMax, target);

        public static IEnumerator CoAnchorMax(this RectTransform self, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetAnchorMax, target, self.SetAnchorMax, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoAnchorMax(this RectTransform self, Vector2 start, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetAnchorMax, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoAnchorMaxX(this RectTransform self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetAnchorMaxX, target, self.SetAnchorMaxX, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoAnchorMaxX(this RectTransform self, float start, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetAnchorMaxX, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoAnchorMaxY(this RectTransform self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetAnchorMaxY, target, self.SetAnchorMaxY, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoAnchorMaxY(this RectTransform self, float start, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetAnchorMaxY, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoAnchorMaxBy(this RectTransform self, Vector2 target, float duration, Func<float, float> easer = null)
           => UCoroutine.YieldValueTo(self.GetAnchorMax, () => self.GetAnchorMaxBy(target), self.SetAnchorMax, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoAnchorMaxFor(this RectTransform self, Vector2 direction, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(t => direction * t, self.SetAnchorMaxBy, UCoroutine.YieldDeltaTime(duration, easer));
        #endregion

        #region AnchorMove
        public static IEnumerator CoAnchorMove(this RectTransform self, Vector2 target)
            => UCoroutine.Yield(self.SetAnchorPosition, target);

        public static IEnumerator CoAnchorMove(this RectTransform self, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetAnchorPosition, target, self.SetAnchorPosition, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoAnchorMove(this RectTransform self, Vector2 start, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetAnchorPosition, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoAnchorMoveX(this RectTransform self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetAnchorPositionX, target, self.SetAnchorPositionX, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoAnchorMoveX(this RectTransform self, float start, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetAnchorPositionX, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoAnchorMoveY(this RectTransform self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetAnchorPositionY, target, self.SetAnchorPositionY, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoAnchorMoveY(this RectTransform self, float start, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetAnchorPositionY, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoAnchorMoveBy(this RectTransform self, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetAnchorPosition, () => self.GetAnchorPositionBy(target), self.SetAnchorPosition, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoAnchorMoveFor(this RectTransform self, Vector2 direction, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(t => direction * t, self.SetAnchorPositionBy, UCoroutine.YieldDeltaTime(duration, easer));
        #endregion

        #region OffsetMin
        public static IEnumerator CoOffsetMin(this RectTransform self, Vector2 target)
            => UCoroutine.Yield(self.SetOffsetMin, target);

        public static IEnumerator CoOffsetMin(this RectTransform self, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetOffsetMin, target, self.SetOffsetMin, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoOffsetMin(this RectTransform self, Vector2 start, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetOffsetMin, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoOffsetMinX(this RectTransform self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetOffsetMinX, target, self.SetOffsetMinX, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoOffsetMinX(this RectTransform self, float start, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetOffsetMinX, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoOffsetMinY(this RectTransform self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetOffsetMinY, target, self.SetOffsetMinY, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoOffsetMinY(this RectTransform self, float start, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetOffsetMinY, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoOffsetMinBy(this RectTransform self, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetOffsetMin, () => self.GetOffsetMinBy(target), self.SetOffsetMin, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoOffsetMinFor(this RectTransform self, Vector2 direction, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(t => direction * t, self.SetOffsetMinBy, UCoroutine.YieldDeltaTime(duration, easer));
        #endregion

        #region OffsetMax
        public static IEnumerator CoOffsetMax(this RectTransform self, Vector2 target)
            => UCoroutine.Yield(self.SetOffsetMax, target);

        public static IEnumerator CoOffsetMax(this RectTransform self, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetOffsetMax, target, self.SetOffsetMax, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoOffsetMax(this RectTransform self, Vector2 start, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetOffsetMax, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoOffsetMaxX(this RectTransform self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetOffsetMaxX, target, self.SetOffsetMaxX, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoOffsetMaxX(this RectTransform self, float start, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetOffsetMaxX, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoOffsetMaxY(this RectTransform self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetOffsetMaxY, target, self.SetOffsetMaxY, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoOffsetMaxY(this RectTransform self, float start, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetOffsetMaxY, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoOffsetMaxBy(this RectTransform self, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetOffsetMax, () => self.GetOffsetMaxBy(target), self.SetOffsetMax, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoOffsetMaxFor(this RectTransform self, Vector2 direction, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(t => direction * t, self.SetOffsetMaxBy, UCoroutine.YieldDeltaTime(duration, easer));
        #endregion

        #region Pivot
        public static IEnumerator CoPivot(this RectTransform self, Vector2 target)
            => UCoroutine.Yield(self.SetPivot, target);

        public static IEnumerator CoPivot(this RectTransform self, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetPivot, target, self.SetPivot, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoPivot(this RectTransform self, Vector2 start, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetPivot, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoPivotX(this RectTransform self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetPivotX, target, self.SetPivotX, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoPivotX(this RectTransform self, float start, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetPivotX, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoPivotY(this RectTransform self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetPivotY, target, self.SetPivotY, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoPivotY(this RectTransform self, float start, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetPivotY, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoPivotBy(this RectTransform self, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetPivot, () => self.GetPivotBy(target), self.SetPivot, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoPivotFor(this RectTransform self, Vector2 direction, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(t => direction * t, self.SetPivotBy, UCoroutine.YieldDeltaTime(duration, easer));
        #endregion

        #region SizeDelta
        public static IEnumerator CoSizeDelta(this RectTransform self, Vector2 target)
            => UCoroutine.Yield(self.SetSizeDelta, target);

        public static IEnumerator CoSizeDelta(this RectTransform self, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetSizeDelta, target, self.SetSizeDelta, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoSizeDelta(this RectTransform self, Vector2 start, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetSizeDelta, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoSizeDeltaX(this RectTransform self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetSizeDeltaX, target, self.SetSizeDeltaX, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoSizeDeltaX(this RectTransform self, float start, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetSizeDeltaX, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoSizeDeltaY(this RectTransform self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetSizeDeltaY, target, self.SetSizeDeltaY, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoSizeDeltaY(this RectTransform self, float start, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetSizeDeltaY, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoSizeDeltaBy(this RectTransform self, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetSizeDelta, () => self.GetSizeDeltaBy(target), self.SetSizeDelta, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoSizeDeltaFor(this RectTransform self, Vector2 direction, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(t => direction * t, self.SetSizeDeltaBy, UCoroutine.YieldDeltaTime(duration, easer));
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
