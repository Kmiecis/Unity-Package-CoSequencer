using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Common.Coroutines
{
    public static class OutlineExtensions
    {
        public static Func<IEnumerator> CoEffectColor(this Outline self, Color target, float duration, Func<float, float> easer = null)
            => () => UCoroutine.YieldValueTo(self.GetEffectColor, self.SetEffectColor, target, duration, easer);

        public static Func<IEnumerator> CoEffectFade(this Outline self, float target, float duration, Func<float, float> easer = null)
            => () => UCoroutine.YieldValueTo(self.GetEffectColorA, self.SetEffectColorA, target, duration, easer);

        public static Func<IEnumerator> CoEffectGradient(this Outline self, Gradient target, float duration, Func<float, float> easer = null)
            => () => UCoroutine.YieldAnyValueTo(target.Evaluate, self.SetEffectColor, duration, easer);
    }

    internal static class InternalOutlineExtensions
    {
        #region Effect color
        public static Color GetEffectColor(this Outline self)
            => self.effectColor;

        public static void SetEffectColor(this Outline self, Color value)
            => self.effectColor = value;

        public static float GetEffectColorR(this Outline self)
            => self.effectColor.r;

        public static void SetEffectColorR(this Outline self, float value)
            => self.effectColor = self.effectColor.WithR(value);

        public static float GetEffectColorG(this Outline self)
            => self.effectColor.g;

        public static void SetEffectColorG(this Outline self, float value)
            => self.effectColor = self.effectColor.WithG(value);

        public static float GetEffectColorB(this Outline self)
            => self.effectColor.b;

        public static void SetEffectColorB(this Outline self, float value)
            => self.effectColor = self.effectColor.WithB(value);

        public static float GetEffectColorA(this Outline self)
            => self.effectColor.a;

        public static void SetEffectColorA(this Outline self, float value)
            => self.effectColor = self.effectColor.WithA(value);
        #endregion
    }
}
