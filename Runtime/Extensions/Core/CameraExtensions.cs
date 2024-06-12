using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines
{
    public static class CameraExtensions
    {
        #region Aspect
        public static IEnumerator CoAspect(this Camera self, float target)
            => UCoroutine.Yield(self.SetAspect, target);

        public static IEnumerator CoAspect(this Camera self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetAspect, target, self.SetAspect, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoAspect(this Camera self, float start, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetAspect, UCoroutine.YieldTime(duration, easer));
        #endregion

        #region BackgroundColor
        public static IEnumerator CoBackgroundColor(this Camera self, Color target)
            => UCoroutine.Yield(self.SetBackgroundColor, target);

        public static IEnumerator CoBackgroundColor(this Camera self, Color target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetBackgroundColor, target, self.SetBackgroundColor, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoBackgroundColor(this Camera self, Color start, Color target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetBackgroundColor, UCoroutine.YieldTime(duration, easer));
        #endregion

        #region NearClipPlane
        public static IEnumerator CoNearClipPlane(this Camera self, float target)
            => UCoroutine.Yield(self.SetNearClipPlane, target);

        public static IEnumerator CoNearClipPlane(this Camera self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetNearClipPlane, target, self.SetNearClipPlane, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoNearClipPlane(this Camera self, float start, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetNearClipPlane, UCoroutine.YieldTime(duration, easer));
        #endregion

        #region FarClipPlane
        public static IEnumerator CoFarClipPlane(this Camera self, float target)
            => UCoroutine.Yield(self.SetFarClipPlane, target);

        public static IEnumerator CoFarClipPlane(this Camera self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetFarClipPlane, target, self.SetFarClipPlane, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoFarClipPlane(this Camera self, float start, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetFarClipPlane, UCoroutine.YieldTime(duration, easer));
        #endregion

        #region FieldOfView
        public static IEnumerator CoFieldOfView(this Camera self, float target)
            => UCoroutine.Yield(self.SetFieldOfView, target);

        public static IEnumerator CoFieldOfView(this Camera self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetFieldOfView, target, self.SetFieldOfView, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoFieldOfView(this Camera self, float start, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetFieldOfView, UCoroutine.YieldTime(duration, easer));
        #endregion

        #region OrthographicSize
        public static IEnumerator CoOrthographicSize(this Camera self, float target)
            => UCoroutine.Yield(self.SetOrthographicSize, target);

        public static IEnumerator CoOrthographicSize(this Camera self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetOrthographicSize, target, self.SetOrthographicSize, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoOrthographicSize(this Camera self, float start, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetOrthographicSize, UCoroutine.YieldTime(duration, easer));
        #endregion

        #region PixelRect
        public static IEnumerator CoPixelRect(this Camera self, Rect target)
            => UCoroutine.Yield(self.SetPixelRect, target);

        public static IEnumerator CoPixelRect(this Camera self, Rect target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetPixelRect, target, self.SetPixelRect, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoPixelRect(this Camera self, Rect start, Rect target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetPixelRect, UCoroutine.YieldTime(duration, easer));
        #endregion

        #region Rect
        public static IEnumerator CoRect(this Camera self, Rect target)
            => UCoroutine.Yield(self.SetRect, target);

        public static IEnumerator CoRect(this Camera self, Rect target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetRect, target, self.SetRect, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoRect(this Camera self, Rect start, Rect target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetRect, UCoroutine.YieldTime(duration, easer));
        #endregion
    }

    internal static class InternalCameraExtensions
    {
        #region Aspect
        public static float GetAspect(this Camera self)
            => self.aspect;

        public static void SetAspect(this Camera self, float value)
            => self.aspect = value;
        #endregion

        #region Background color
        public static Color GetBackgroundColor(this Camera self)
            => self.backgroundColor;

        public static void SetBackgroundColor(this Camera self, Color value)
            => self.backgroundColor = value;
        #endregion

        #region Clip planes
        public static float GetNearClipPlane(this Camera self)
            => self.nearClipPlane;

        public static void SetNearClipPlane(this Camera self, float value)
            => self.nearClipPlane = value;

        public static float GetFarClipPlane(this Camera self)
            => self.farClipPlane;

        public static void SetFarClipPlane(this Camera self, float value)
            => self.farClipPlane = value;
        #endregion

        #region Field of view
        public static float GetFieldOfView(this Camera self)
            => self.fieldOfView;

        public static void SetFieldOfView(this Camera self, float value)
            => self.fieldOfView = value;
        #endregion

        #region Orthographic size
        public static float GetOrthographicSize(this Camera self)
            => self.orthographicSize;

        public static void SetOrthographicSize(this Camera self, float value)
            => self.orthographicSize = value;
        #endregion

        #region Pixel rect
        public static Rect GetPixelRect(this Camera self)
            => self.pixelRect;

        public static void SetPixelRect(this Camera self, Rect value)
            => self.pixelRect = value;
        #endregion

        #region Rect
        public static Rect GetRect(this Camera self)
            => self.rect;

        public static void SetRect(this Camera self, Rect value)
            => self.rect = value;
        #endregion
    }
}
