using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines
{
    public static class RectTransformExtensions
    {
        public static Func<IEnumerator> CoAnchorMin(this RectTransform self, Vector2 target, float duration, Func<float, float> easer = null)
            => () => UCoroutine.YieldValueTo(self.GetAnchorMin, self.SetAnchorMin, target, duration, easer);

        public static Func<IEnumerator> CoAnchorMinX(this RectTransform self, float target, float duration, Func<float, float> easer = null)
            => () => UCoroutine.YieldValueTo(self.GetAnchorMinX, self.SetAnchorMinX, target, duration, easer);

        public static Func<IEnumerator> CoAnchorMinY(this RectTransform self, float target, float duration, Func<float, float> easer = null)
            => () => UCoroutine.YieldValueTo(self.GetAnchorMinY, self.SetAnchorMinY, target, duration, easer);

        public static Func<IEnumerator> CoAnchorMax(this RectTransform self, Vector2 target, float duration, Func<float, float> easer = null)
            => () => UCoroutine.YieldValueTo(self.GetAnchorMax, self.SetAnchorMax, target, duration, easer);

        public static Func<IEnumerator> CoAnchorMaxX(this RectTransform self, float target, float duration, Func<float, float> easer = null)
            => () => UCoroutine.YieldValueTo(self.GetAnchorMaxX, self.SetAnchorMaxX, target, duration, easer);

        public static Func<IEnumerator> CoAnchorMaxY(this RectTransform self, float target, float duration, Func<float, float> easer = null)
            => () => UCoroutine.YieldValueTo(self.GetAnchorMaxY, self.SetAnchorMaxY, target, duration, easer);

        public static Func<IEnumerator> CoAnchorMove(this RectTransform self, Vector2 target, float duration, Func<float, float> easer = null)
            => () => UCoroutine.YieldValueTo(self.GetAnchorPosition, self.SetAnchorPosition, target, duration, easer);

        public static Func<IEnumerator> CoAnchorMoveX(this RectTransform self, float target, float duration, Func<float, float> easer = null)
            => () => UCoroutine.YieldValueTo(self.GetAnchorPositionX, self.SetAnchorPositionX, target, duration, easer);

        public static Func<IEnumerator> CoAnchorMoveY(this RectTransform self, float target, float duration, Func<float, float> easer = null)
            => () => UCoroutine.YieldValueTo(self.GetAnchorPositionY, self.SetAnchorPositionY, target, duration, easer);

        public static Func<IEnumerator> CoOffsetMin(this RectTransform self, Vector2 target, float duration, Func<float, float> easer = null)
            => () => UCoroutine.YieldValueTo(self.GetOffsetMin, self.SetOffsetMin, target, duration, easer);

        public static Func<IEnumerator> CoOffsetMinX(this RectTransform self, float target, float duration, Func<float, float> easer = null)
            => () => UCoroutine.YieldValueTo(self.GetOffsetMinX, self.SetOffsetMinX, target, duration, easer);

        public static Func<IEnumerator> CoOffsetMinY(this RectTransform self, float target, float duration, Func<float, float> easer = null)
            => () => UCoroutine.YieldValueTo(self.GetOffsetMinY, self.SetOffsetMinY, target, duration, easer);

        public static Func<IEnumerator> CoOffsetMax(this RectTransform self, Vector2 target, float duration, Func<float, float> easer = null)
            => () => UCoroutine.YieldValueTo(self.GetOffsetMax, self.SetOffsetMax, target, duration, easer);

        public static Func<IEnumerator> CoOffsetMaxX(this RectTransform self, float target, float duration, Func<float, float> easer = null)
            => () => UCoroutine.YieldValueTo(self.GetOffsetMaxX, self.SetOffsetMaxX, target, duration, easer);

        public static Func<IEnumerator> CoOffsetMaxY(this RectTransform self, float target, float duration, Func<float, float> easer = null)
            => () => UCoroutine.YieldValueTo(self.GetOffsetMaxY, self.SetOffsetMaxY, target, duration, easer);

        public static Func<IEnumerator> CoPivot(this RectTransform self, Vector2 target, float duration, Func<float, float> easer = null)
            => () => UCoroutine.YieldValueTo(self.GetPivot, self.SetPivot, target, duration, easer);

        public static Func<IEnumerator> CoPivotX(this RectTransform self, float target, float duration, Func<float, float> easer = null)
            => () => UCoroutine.YieldValueTo(self.GetPivotX, self.SetPivotX, target, duration, easer);

        public static Func<IEnumerator> CoPivotY(this RectTransform self, float target, float duration, Func<float, float> easer = null)
            => () => UCoroutine.YieldValueTo(self.GetPivotY, self.SetPivotY, target, duration, easer);

        public static Func<IEnumerator> CoSizeDelta(this RectTransform self, Vector2 target, float duration, Func<float, float> easer = null)
            => () => UCoroutine.YieldValueTo(self.GetSizeDelta, self.SetSizeDelta, target, duration, easer);

        public static Func<IEnumerator> CoSizeDeltaX(this RectTransform self, float target, float duration, Func<float, float> easer = null)
            => () => UCoroutine.YieldValueTo(self.GetSizeDeltaX, self.SetSizeDeltaX, target, duration, easer);

        public static Func<IEnumerator> CoSizeDeltaY(this RectTransform self, float target, float duration, Func<float, float> easer = null)
            => () => UCoroutine.YieldValueTo(self.GetSizeDeltaY, self.SetSizeDeltaY, target, duration, easer);
    }

    internal static class InternalRectTransformExtensions
    {
        #region Anchor
        public static Vector2 GetAnchorMin(this RectTransform self)
            => self.anchorMin;

        public static void SetAnchorMin(this RectTransform self, Vector2 value)
            => self.anchorMin = value;

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
        #endregion

        #region Size delta
        public static Vector2 GetSizeDelta(this RectTransform self)
            => self.sizeDelta;

        public static void SetSizeDelta(this RectTransform self, Vector2 value)
            => self.sizeDelta = value;

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
