﻿using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines
{
    public static class SpriteRendererExtensions
    {
        #region Color
        public static IEnumerator CoColor(this SpriteRenderer self, Color target)
           => UCoroutine.Yield(self.SetColor, target);

        public static IEnumerator CoColor(this SpriteRenderer self, Color target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetColor, target, self.SetColor, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoColor(this SpriteRenderer self, Color start, Color target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetColor, UCoroutine.YieldTime(duration, easer));
        #endregion

        #region Fade
        public static IEnumerator CoFade(this SpriteRenderer self, float target)
            => UCoroutine.Yield(self.SetColorA, target);

        public static IEnumerator CoFade(this SpriteRenderer self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetColorA, target, self.SetColorA, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoFade(this SpriteRenderer self, float start, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetColorA, UCoroutine.YieldTime(duration, easer));
        #endregion

        #region Gradient
        public static IEnumerator CoGradient(this SpriteRenderer self, Gradient target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(target.Evaluate, self.SetColor, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoGradient(this SpriteRenderer self, Gradient target, float from, float to, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(time => target.Evaluate(Mathf.Lerp(from, to, time)), self.SetColor, UCoroutine.YieldTime(duration, easer));
        #endregion

        #region Size
        public static IEnumerator CoSize(this SpriteRenderer self, Vector2 target)
            => UCoroutine.Yield(self.SetSize, target);

        public static IEnumerator CoSize(this SpriteRenderer self, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetSize, target, self.SetSize, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoSize(this SpriteRenderer self, Vector2 start, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetSize, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoSizeX(this SpriteRenderer self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetSizeX, target, self.SetSizeX, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoSizeX(this SpriteRenderer self, float start, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetSizeX, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoSizeY(this SpriteRenderer self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetSizeY, target, self.SetSizeY, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoSizeY(this SpriteRenderer self, float start, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetSizeY, UCoroutine.YieldTime(duration, easer));
        #endregion
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

        #region Size
        public static Vector2 GetSize(this SpriteRenderer self)
            => self.size;

        public static void SetSize(this SpriteRenderer self, Vector2 value)
            => self.size = value;

        public static float GetSizeX(this SpriteRenderer self)
            => self.size.x;

        public static void SetSizeX(this SpriteRenderer self, float value)
            => self.size = self.size.WithX(value);

        public static float GetSizeY(this SpriteRenderer self)
            => self.size.y;

        public static void SetSizeY(this SpriteRenderer self, float value)
            => self.size = self.size.WithY(value);
        #endregion
    }
}
