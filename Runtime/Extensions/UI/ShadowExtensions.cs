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
            => Yield.Into(target, self.SetEffectColor);

        public static IEnumerator CoEffectColor(this Shadow self, Color target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(self.GetEffectColor, target, self.SetEffectColor, Yield.Time(duration, easer));

        public static IEnumerator CoEffectColor(this Shadow self, Color start, Color target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(start, target, self.SetEffectColor, Yield.Time(duration, easer));
        #endregion

        #region Fade
        public static IEnumerator CoEffectFade(this Shadow self, float target)
            => Yield.Into(target, self.SetEffectColorA);

        public static IEnumerator CoEffectFade(this Shadow self, float target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(self.GetEffectColorA, target, self.SetEffectColorA, Yield.Time(duration, easer));

        public static IEnumerator CoEffectFade(this Shadow self, float start, float target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(start, target, self.SetEffectColorA, Yield.Time(duration, easer));
        #endregion

        #region Gradient
        public static IEnumerator CoEffectGradient(this Shadow self, Gradient target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(target.Evaluate, self.SetEffectColor, Yield.Time(duration, easer));

        public static IEnumerator CoGradient(this Shadow self, Gradient target, float from, float to, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(time => target.Evaluate(Mathf.Lerp(from, to, time)), self.SetEffectColor, Yield.Time(duration, easer));
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
