using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Common.Coroutines
{
    public static class TrailRendererExtensions
    {
        #region Color
        public static IEnumerator CoStartColor(this TrailRenderer self, Color target)
            => Yield.Into(target, self.SetStartColor);

        public static IEnumerator CoStartColor(this TrailRenderer self, Color target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetStartColor, target, self.SetStartColor, timer);

        public static IEnumerator CoStartColor(this TrailRenderer self, Color start, Color target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetStartColor, timer);

        public static IEnumerator CoStartColor(this TrailRenderer self, Color target, float duration, Func<float, float> easer = null)
            => self.CoStartColor(target, Yield.Time(duration, easer));

        public static IEnumerator CoStartColor(this TrailRenderer self, Color start, Color target, float duration, Func<float, float> easer = null)
            => self.CoStartColor(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoEndColor(this TrailRenderer self, Color target)
            => Yield.Into(target, self.SetEndColor);

        public static IEnumerator CoEndColor(this TrailRenderer self, Color target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetEndColor, target, self.SetEndColor, timer);

        public static IEnumerator CoEndColor(this TrailRenderer self, Color start, Color target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetEndColor, timer);

        public static IEnumerator CoEndColor(this TrailRenderer self, Color target, float duration, Func<float, float> easer = null)
            => self.CoEndColor(target, Yield.Time(duration, easer));

        public static IEnumerator CoEndColor(this TrailRenderer self, Color start, Color target, float duration, Func<float, float> easer = null)
            => self.CoEndColor(start, target, Yield.Time(duration, easer));
        #endregion

        #region Fade
        public static IEnumerator CoStartFade(this TrailRenderer self, float target)
            => Yield.Into(target, self.SetStartColorA);

        public static IEnumerator CoStartFade(this TrailRenderer self, float target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetStartColorA, target, self.SetStartColorA, timer);

        public static IEnumerator CoStartFade(this TrailRenderer self, float start, float target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetStartColorA, timer);

        public static IEnumerator CoStartFade(this TrailRenderer self, float target, float duration, Func<float, float> easer = null)
            => self.CoStartFade(target, Yield.Time(duration, easer));

        public static IEnumerator CoStartFade(this TrailRenderer self, float start, float target, float duration, Func<float, float> easer = null)
            => self.CoStartFade(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoEndFade(this TrailRenderer self, float target)
            => Yield.Into(target, self.SetEndColorA);

        public static IEnumerator CoEndFade(this TrailRenderer self, float target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetEndColorA, target, self.SetEndColorA, timer);

        public static IEnumerator CoEndFade(this TrailRenderer self, float start, float target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetEndColorA, timer);

        public static IEnumerator CoEndFade(this TrailRenderer self, float target, float duration, Func<float, float> easer = null)
            => self.CoEndFade(target, Yield.Time(duration, easer));

        public static IEnumerator CoEndFade(this TrailRenderer self, float start, float target, float duration, Func<float, float> easer = null)
            => self.CoEndFade(start, target, Yield.Time(duration, easer));
        #endregion

        #region Time
        public static IEnumerator CoTime(this TrailRenderer self, float target)
            => Yield.Into(target, self.SetTime);

        public static IEnumerator CoTime(this TrailRenderer self, float target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetTime, target, self.SetTime, timer);

        public static IEnumerator CoTime(this TrailRenderer self, float start, float target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetTime, timer);

        public static IEnumerator CoTime(this TrailRenderer self, float target, float duration, Func<float, float> easer = null)
            => self.CoTime(target, Yield.Time(duration, easer));

        public static IEnumerator CoTime(this TrailRenderer self, float start, float target, float duration, Func<float, float> easer = null)
            => self.CoTime(start, target, Yield.Time(duration, easer));
        #endregion

        #region Width
        public static IEnumerator CoStartWidth(this TrailRenderer self, float target)
            => Yield.Into(target, self.SetStartWidth);

        public static IEnumerator CoStartWidth(this TrailRenderer self, float target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetStartWidth, target, self.SetStartWidth, timer);

        public static IEnumerator CoStartWidth(this TrailRenderer self, float start, float target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetStartWidth, timer);

        public static IEnumerator CoStartWidth(this TrailRenderer self, float target, float duration, Func<float, float> easer = null)
            => self.CoStartWidth(target, Yield.Time(duration, easer));

        public static IEnumerator CoStartWidth(this TrailRenderer self, float start, float target, float duration, Func<float, float> easer = null)
            => self.CoStartWidth(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoEndWidth(this TrailRenderer self, float target)
            => Yield.Into(target, self.SetEndWidth);

        public static IEnumerator CoEndWidth(this TrailRenderer self, float target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetEndWidth, target, self.SetEndWidth, timer);

        public static IEnumerator CoEndWidth(this TrailRenderer self, float start, float target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetEndWidth, timer);

        public static IEnumerator CoEndWidth(this TrailRenderer self, float target, float duration, Func<float, float> easer = null)
            => self.CoEndWidth(target, Yield.Time(duration, easer));

        public static IEnumerator CoEndWidth(this TrailRenderer self, float start, float target, float duration, Func<float, float> easer = null)
            => self.CoEndWidth(start, target, Yield.Time(duration, easer));
        #endregion
    }

    internal static class InternalTrailRendererExtensions
    {
        #region Color
        public static Color GetStartColor(this TrailRenderer self)
            => self.startColor;

        public static void SetStartColor(this TrailRenderer self, Color value)
            => self.startColor = value;

        public static float GetStartColorA(this TrailRenderer self)
            => self.startColor.a;

        public static void SetStartColorA(this TrailRenderer self, float value)
            => self.startColor = self.startColor.WithA(value);

        public static Color GetEndColor(this TrailRenderer self)
            => self.endColor;

        public static void SetEndColor(this TrailRenderer self, Color value)
            => self.endColor = value;

        public static float GetEndColorA(this TrailRenderer self)
            => self.endColor.a;

        public static void SetEndColorA(this TrailRenderer self, float value)
            => self.endColor = self.endColor.WithA(value);
        #endregion

        #region Width
        public static float GetStartWidth(this TrailRenderer self)
            => self.startWidth;

        public static void SetStartWidth(this TrailRenderer self, float value)
            => self.startWidth = value;

        public static float GetEndWidth(this TrailRenderer self)
            => self.endWidth;

        public static void SetEndWidth(this TrailRenderer self, float value)
            => self.endWidth = value;
        #endregion

        #region Time
        public static float GetTime(this TrailRenderer self)
            => self.time;

        public static void SetTime(this TrailRenderer self, float value)
            => self.time = value;
        #endregion
    }
}
