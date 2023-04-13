using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines
{
    public static class CameraExtensions
    {
        public static IEnumerator CoAspect(this Camera self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetAspect, self.SetAspect, target, UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoBackgroundColor(this Camera self, Color target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetBackgroundColor, self.SetBackgroundColor, target, UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoNearClipPlane(this Camera self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetNearClipPlane, self.SetNearClipPlane, target, UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoFarClipPlane(this Camera self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetFarClipPlane, self.SetFarClipPlane, target, UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoFieldOfView(this Camera self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetFieldOfView, self.SetFieldOfView, target, UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoOrthographicSize(this Camera self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetOrthographicSize, self.SetOrthographicSize, target, UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoPixelRect(this Camera self, Rect target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetPixelRect, self.SetPixelRect, target, UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoRect(this Camera self, Rect target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetRect, self.SetRect, target, UCoroutine.YieldTimeEased(duration, easer));
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
