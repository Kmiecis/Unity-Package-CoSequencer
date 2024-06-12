using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines
{
    public static class LineRendererExtensions
    {
        #region Color
        public static IEnumerator CoStartColor(this LineRenderer self, Color target)
            => UCoroutine.Yield(self.SetStartColor, target);

        public static IEnumerator CoStartColor(this LineRenderer self, Color target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetStartColor, target, self.SetStartColor, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoStartColor(this LineRenderer self, Color start, Color target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetStartColor, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoEndColor(this LineRenderer self, Color target)
            => UCoroutine.Yield(self.SetEndColor, target);

        public static IEnumerator CoEndColor(this LineRenderer self, Color target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetEndColor, target, self.SetEndColor, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoEndColor(this LineRenderer self, Color start, Color target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetEndColor, UCoroutine.YieldTime(duration, easer));
        #endregion

        #region Fade
        public static IEnumerator CoStartFade(this LineRenderer self, float target)
            => UCoroutine.Yield(self.SetStartColorA, target);

        public static IEnumerator CoStartFade(this LineRenderer self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetStartColorA, target, self.SetStartColorA, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoStartFade(this LineRenderer self, float start, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetStartColorA, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoEndFade(this LineRenderer self, float target)
            => UCoroutine.Yield(self.SetEndColorA, target);

        public static IEnumerator CoEndFade(this LineRenderer self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetEndColorA, target, self.SetEndColorA, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoEndFade(this LineRenderer self, float start, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetEndColorA, UCoroutine.YieldTime(duration, easer));
        #endregion

        #region Width
        public static IEnumerator CoStartWidth(this LineRenderer self, float target)
            => UCoroutine.Yield(self.SetStartWidth, target);

        public static IEnumerator CoStartWidth(this LineRenderer self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetStartWidth, target, self.SetStartWidth, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoStartWidth(this LineRenderer self, float start, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetStartWidth, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoEndWidth(this LineRenderer self, float target)
            => UCoroutine.Yield(self.SetEndWidth, target);

        public static IEnumerator CoEndWidth(this LineRenderer self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetEndWidth, target, self.SetEndWidth, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoEndWidth(this LineRenderer self, float start, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetEndWidth, UCoroutine.YieldTime(duration, easer));
        #endregion
    }

    internal static class InternalLineRendererExtensions
    {
        #region Color
        public static Color GetStartColor(this LineRenderer self)
            => self.startColor;

        public static void SetStartColor(this LineRenderer self, Color value)
            => self.startColor = value;

        public static float GetStartColorA(this LineRenderer self)
            => self.startColor.a;

        public static void SetStartColorA(this LineRenderer self, float value)
            => self.startColor = self.startColor.WithA(value);

        public static Color GetEndColor(this LineRenderer self)
            => self.endColor;

        public static void SetEndColor(this LineRenderer self, Color value)
            => self.endColor = value;

        public static float GetEndColorA(this LineRenderer self)
            => self.endColor.a;

        public static void SetEndColorA(this LineRenderer self, float value)
            => self.endColor = self.endColor.WithA(value);
        #endregion

        #region Width
        public static float GetStartWidth(this LineRenderer self)
            => self.startWidth;

        public static void SetStartWidth(this LineRenderer self, float value)
            => self.startWidth = value;

        public static float GetEndWidth(this LineRenderer self)
            => self.endWidth;

        public static void SetEndWidth(this LineRenderer self, float value)
            => self.endWidth = value;
        #endregion
    }
}
