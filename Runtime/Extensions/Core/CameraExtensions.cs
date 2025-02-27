﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Common.Coroutines
{
    public static class CameraExtensions
    {
        #region Aspect
        public static IEnumerator CoAspect(this Camera self, float target)
            => Yield.Into(target, self.SetAspect);

        public static IEnumerator CoAspect(this Camera self, float target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetAspect, target, self.SetAspect, timer);

        public static IEnumerator CoAspect(this Camera self, float start, float target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetAspect, timer);

        public static IEnumerator CoAspect(this Camera self, float target, float duration, Func<float, float> easer = null)
            => self.CoAspect(target, Yield.Time(duration, easer));

        public static IEnumerator CoAspect(this Camera self, float start, float target, float duration, Func<float, float> easer = null)
            => self.CoAspect(start, target, Yield.Time(duration, easer));
        #endregion

        #region BackgroundColor
        public static IEnumerator CoBackgroundColor(this Camera self, Color target)
            => Yield.Into(target, self.SetBackgroundColor);

        public static IEnumerator CoBackgroundColor(this Camera self, Color target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetBackgroundColor, target, self.SetBackgroundColor, timer);

        public static IEnumerator CoBackgroundColor(this Camera self, Color start, Color target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetBackgroundColor, timer);

        public static IEnumerator CoBackgroundColor(this Camera self, Color target, float duration, Func<float, float> easer = null)
            => self.CoBackgroundColor(target, Yield.Time(duration, easer));

        public static IEnumerator CoBackgroundColor(this Camera self, Color start, Color target, float duration, Func<float, float> easer = null)
            => self.CoBackgroundColor(start, target, Yield.Time(duration, easer));
        #endregion

        #region NearClipPlane
        public static IEnumerator CoNearClipPlane(this Camera self, float target)
            => Yield.Into(target, self.SetNearClipPlane);

        public static IEnumerator CoNearClipPlane(this Camera self, float target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetNearClipPlane, target, self.SetNearClipPlane, timer);

        public static IEnumerator CoNearClipPlane(this Camera self, float start, float target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetNearClipPlane, timer);

        public static IEnumerator CoNearClipPlane(this Camera self, float target, float duration, Func<float, float> easer = null)
            => self.CoNearClipPlane(target, Yield.Time(duration, easer));

        public static IEnumerator CoNearClipPlane(this Camera self, float start, float target, float duration, Func<float, float> easer = null)
            => self.CoNearClipPlane(start, target, Yield.Time(duration, easer));
        #endregion

        #region FarClipPlane
        public static IEnumerator CoFarClipPlane(this Camera self, float target)
            => Yield.Into(target, self.SetFarClipPlane);

        public static IEnumerator CoFarClipPlane(this Camera self, float target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetFarClipPlane, target, self.SetFarClipPlane, timer);

        public static IEnumerator CoFarClipPlane(this Camera self, float start, float target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetFarClipPlane, timer);

        public static IEnumerator CoFarClipPlane(this Camera self, float target, float duration, Func<float, float> easer = null)
            => self.CoFarClipPlane(target, Yield.Time(duration, easer));

        public static IEnumerator CoFarClipPlane(this Camera self, float start, float target, float duration, Func<float, float> easer = null)
            => self.CoFarClipPlane(start, target, Yield.Time(duration, easer));
        #endregion

        #region FieldOfView
        public static IEnumerator CoFieldOfView(this Camera self, float target)
            => Yield.Into(target, self.SetFieldOfView);

        public static IEnumerator CoFieldOfView(this Camera self, float target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetFieldOfView, target, self.SetFieldOfView, timer);

        public static IEnumerator CoFieldOfView(this Camera self, float start, float target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetFieldOfView, timer);

        public static IEnumerator CoFieldOfView(this Camera self, float target, float duration, Func<float, float> easer = null)
            => self.CoFieldOfView(target, Yield.Time(duration, easer));

        public static IEnumerator CoFieldOfView(this Camera self, float start, float target, float duration, Func<float, float> easer = null)
            => self.CoFieldOfView(start, target, Yield.Time(duration, easer));
        #endregion

        #region OrthographicSize
        public static IEnumerator CoOrthographicSize(this Camera self, float target)
            => Yield.Into(target, self.SetOrthographicSize);

        public static IEnumerator CoOrthographicSize(this Camera self, float target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetOrthographicSize, target, self.SetOrthographicSize, timer);

        public static IEnumerator CoOrthographicSize(this Camera self, float start, float target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetOrthographicSize, timer);

        public static IEnumerator CoOrthographicSize(this Camera self, float target, float duration, Func<float, float> easer = null)
            => self.CoOrthographicSize(target, Yield.Time(duration, easer));

        public static IEnumerator CoOrthographicSize(this Camera self, float start, float target, float duration, Func<float, float> easer = null)
            => self.CoOrthographicSize(start, target, Yield.Time(duration, easer));
        #endregion

        #region PixelRect
        public static IEnumerator CoPixelRect(this Camera self, Rect target)
            => Yield.Into(target, self.SetPixelRect);

        public static IEnumerator CoPixelRect(this Camera self, Rect target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetPixelRect, target, self.SetPixelRect, timer);

        public static IEnumerator CoPixelRect(this Camera self, Rect start, Rect target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetPixelRect, timer);

        public static IEnumerator CoPixelRect(this Camera self, Rect target, float duration, Func<float, float> easer = null)
            => self.CoPixelRect(target, Yield.Time(duration, easer));

        public static IEnumerator CoPixelRect(this Camera self, Rect start, Rect target, float duration, Func<float, float> easer = null)
            => self.CoPixelRect(start, target, Yield.Time(duration, easer));
        #endregion

        #region Rect
        public static IEnumerator CoRect(this Camera self, Rect target)
            => Yield.Into(target, self.SetRect);

        public static IEnumerator CoRect(this Camera self, Rect target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetRect, target, self.SetRect, timer);

        public static IEnumerator CoRect(this Camera self, Rect start, Rect target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetRect, timer);

        public static IEnumerator CoRect(this Camera self, Rect target, float duration, Func<float, float> easer = null)
            => self.CoRect(target, Yield.Time(duration, easer));

        public static IEnumerator CoRect(this Camera self, Rect start, Rect target, float duration, Func<float, float> easer = null)
            => self.CoRect(start, target, Yield.Time(duration, easer));
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
