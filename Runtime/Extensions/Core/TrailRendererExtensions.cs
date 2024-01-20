using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines
{
    public static class TrailRendererExtensions
    {
        public static IEnumerator CoStartColor(this TrailRenderer self, Color target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetStartColor, self.SetStartColor, target, UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoStartFade(this TrailRenderer self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetStartColorA, self.SetStartColorA, target, UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoEndColor(this TrailRenderer self, Color target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetEndColor, self.SetEndColor, target, UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoEndFade(this TrailRenderer self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetEndColorA, self.SetEndColorA, target, UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoTime(this TrailRenderer self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetTime, self.SetTime, target, UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoStartWidth(this TrailRenderer self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetStartWidth, self.SetStartWidth, target, UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoEndWidth(this TrailRenderer self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetEndWidth, self.SetEndWidth, target, UCoroutine.YieldTimeEased(duration, easer));
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
