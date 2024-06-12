using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines
{
    public static class TrailRendererExtensions
    {
        #region Color
        public static IEnumerator CoStartColor(this TrailRenderer self, Color target)
            => UCoroutine.Yield(self.SetStartColor, target);

        public static IEnumerator CoStartColor(this TrailRenderer self, Color target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetStartColor, target, self.SetStartColor, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoStartColor(this TrailRenderer self, Color start, Color target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetStartColor, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoEndColor(this TrailRenderer self, Color target)
            => UCoroutine.Yield(self.SetEndColor, target);

        public static IEnumerator CoEndColor(this TrailRenderer self, Color target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetEndColor, target, self.SetEndColor, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoEndColor(this TrailRenderer self, Color start, Color target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetEndColor, UCoroutine.YieldTime(duration, easer));
        #endregion

        #region Fade
        public static IEnumerator CoStartFade(this TrailRenderer self, float target)
            => UCoroutine.Yield(self.SetStartColorA, target);

        public static IEnumerator CoStartFade(this TrailRenderer self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetStartColorA, target, self.SetStartColorA, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoStartFade(this TrailRenderer self, float start, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetStartColorA, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoEndFade(this TrailRenderer self, float target)
            => UCoroutine.Yield(self.SetEndColorA, target);

        public static IEnumerator CoEndFade(this TrailRenderer self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetEndColorA, target, self.SetEndColorA, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoEndFade(this TrailRenderer self, float start, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetEndColorA, UCoroutine.YieldTime(duration, easer));
        #endregion

        #region Time
        public static IEnumerator CoTime(this TrailRenderer self, float target)
            => UCoroutine.Yield(self.SetTime, target);

        public static IEnumerator CoTime(this TrailRenderer self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetTime, target, self.SetTime, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoTime(this TrailRenderer self, float start, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetTime, UCoroutine.YieldTime(duration, easer));
        #endregion

        #region Width
        public static IEnumerator CoStartWidth(this TrailRenderer self, float target)
            => UCoroutine.Yield(self.SetStartWidth, target);

        public static IEnumerator CoStartWidth(this TrailRenderer self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetStartWidth, target, self.SetStartWidth, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoStartWidth(this TrailRenderer self, float start, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetStartWidth, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoEndWidth(this TrailRenderer self, float target)
            => UCoroutine.Yield(self.SetEndWidth, target);

        public static IEnumerator CoEndWidth(this TrailRenderer self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetEndWidth, target, self.SetEndWidth, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoEndWidth(this TrailRenderer self, float start, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetEndWidth, UCoroutine.YieldTime(duration, easer));
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
