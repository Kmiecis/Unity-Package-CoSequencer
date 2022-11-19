using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines
{
    public static class TrailRendererExtensions
    {
        public static Func<IEnumerator> CoStartColor(this TrailRenderer self, Color target, float duration, Func<float, float> easer = null)
            => () => UCoroutine.YieldValueTo(self.GetStartColor, self.SetStartColor, target, duration, easer);

        public static Func<IEnumerator> CoEndColor(this TrailRenderer self, Color target, float duration, Func<float, float> easer = null)
            => () => UCoroutine.YieldValueTo(self.GetEndColor, self.SetEndColor, target, duration, easer);

        public static Func<IEnumerator> CoTime(this TrailRenderer self, float target, float duration, Func<float, float> easer = null)
            => () => UCoroutine.YieldValueTo(self.GetTime, self.SetTime, target, duration, easer);

        public static Func<IEnumerator> CoStartWidth(this TrailRenderer self, float target, float duration, Func<float, float> easer = null)
            => () => UCoroutine.YieldValueTo(self.GetStartWidth, self.SetStartWidth, target, duration, easer);

        public static Func<IEnumerator> CoEndWidth(this TrailRenderer self, float target, float duration, Func<float, float> easer = null)
            => () => UCoroutine.YieldValueTo(self.GetEndWidth, self.SetEndWidth, target, duration, easer);
    }

    internal static class InternalTrailRendererExtensions
    {
        #region Color
        public static Color GetStartColor(this TrailRenderer self)
            => self.startColor;

        public static void SetStartColor(this TrailRenderer self, Color value)
            => self.startColor = value;

        public static Color GetEndColor(this TrailRenderer self)
            => self.endColor;

        public static void SetEndColor(this TrailRenderer self, Color value)
            => self.endColor = value;
        #endregion

        #region Time
        public static float GetTime(this TrailRenderer self)
            => self.time;

        public static void SetTime(this TrailRenderer self, float value)
            => self.time = value;
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
    }
}
