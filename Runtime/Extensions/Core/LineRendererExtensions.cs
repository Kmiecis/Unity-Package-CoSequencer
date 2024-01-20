using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines
{
    public static class LineRendererExtensions
    {
        public static IEnumerator CoStartColor(this LineRenderer self, Color target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetStartColor, self.SetStartColor, target, UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoStartFade(this LineRenderer self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetStartColorA, self.SetStartColorA, target, UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoEndColor(this LineRenderer self, Color target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetEndColor, self.SetEndColor, target, UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoEndFade(this LineRenderer self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetEndColorA, self.SetEndColorA, target, UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoStartWidth(this LineRenderer self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetStartWidth, self.SetStartWidth, target, UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoEndWidth(this LineRenderer self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetEndWidth, self.SetEndWidth, target, UCoroutine.YieldTimeEased(duration, easer));
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
