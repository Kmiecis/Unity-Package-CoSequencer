using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Common.Coroutines
{
    public static class ShadowExtensions
    {
        #region Color
        public static IEnumerator CoEffectColor(this Shadow self, Color target)
            => UCoroutine.Yield(self.SetEffectColor, target);

        public static IEnumerator CoEffectColor(this Shadow self, Color target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetEffectColor, target, self.SetEffectColor, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoEffectColor(this Shadow self, Color start, Color target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetEffectColor, UCoroutine.YieldTime(duration, easer));
        #endregion

        #region Fade
        public static IEnumerator CoEffectFade(this Shadow self, float target)
            => UCoroutine.Yield(self.SetEffectColorA, target);

        public static IEnumerator CoEffectFade(this Shadow self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetEffectColorA, target, self.SetEffectColorA, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoEffectFade(this Shadow self, float start, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetEffectColorA, UCoroutine.YieldTime(duration, easer));
        #endregion

        #region Gradient
        public static IEnumerator CoEffectGradient(this Shadow self, Gradient target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(target.Evaluate, self.SetEffectColor, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoGradient(this Shadow self, Gradient target, float from, float to, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(time => target.Evaluate(Mathf.Lerp(from, to, time)), self.SetEffectColor, UCoroutine.YieldTime(duration, easer));
        #endregion
    }

    internal static class InternalShadowExtensions
    {
        #region Effect color
        public static Color GetEffectColor(this Shadow self)
            => self.effectColor;

        public static void SetEffectColor(this Shadow self, Color value)
            => self.effectColor = value;

        public static float GetEffectColorR(this Shadow self)
            => self.effectColor.r;

        public static void SetEffectColorR(this Shadow self, float value)
            => self.effectColor = self.effectColor.WithR(value);

        public static float GetEffectColorG(this Shadow self)
            => self.effectColor.g;

        public static void SetEffectColorG(this Shadow self, float value)
            => self.effectColor = self.effectColor.WithG(value);

        public static float GetEffectColorB(this Shadow self)
            => self.effectColor.b;

        public static void SetEffectColorB(this Shadow self, float value)
            => self.effectColor = self.effectColor.WithB(value);

        public static float GetEffectColorA(this Shadow self)
            => self.effectColor.a;

        public static void SetEffectColorA(this Shadow self, float value)
            => self.effectColor = self.effectColor.WithA(value);
        #endregion
    }
}
