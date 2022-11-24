using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines
{
    public static class SpriteRendererExtensions
    {
        public static IEnumerator CoColor(this SpriteRenderer self, Color target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetColor, self.SetColor, target, duration, easer);

        public static IEnumerator CoFade(this SpriteRenderer self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetColorA, self.SetColorA, target, duration, easer);

        public static IEnumerator CoGradient(this SpriteRenderer self, Gradient target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldAnyValueTo(target.Evaluate, self.SetColor, duration, easer);
    }

    internal static class InternalSpriteRendererExtensions
    {
        #region Color
        public static Color GetColor(this SpriteRenderer self)
            => self.color;

        public static void SetColor(this SpriteRenderer self, Color value)
            => self.color = value;

        public static float GetColorR(this SpriteRenderer self)
            => self.color.r;

        public static void SetColorR(this SpriteRenderer self, float value)
            => self.color = self.color.WithR(value);

        public static float GetColorG(this SpriteRenderer self)
            => self.color.g;

        public static void SetColorG(this SpriteRenderer self, float value)
            => self.color = self.color.WithG(value);

        public static float GetColorB(this SpriteRenderer self)
            => self.color.b;

        public static void SetColorB(this SpriteRenderer self, float value)
            => self.color = self.color.WithB(value);

        public static float GetColorA(this SpriteRenderer self)
            => self.color.a;

        public static void SetColorA(this SpriteRenderer self, float value)
            => self.color = self.color.WithA(value);
        #endregion
    }
}
