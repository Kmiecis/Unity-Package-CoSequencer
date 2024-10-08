﻿using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Common.Coroutines
{
    public static class GraphicExtensions
    {
        #region Color
        public static IEnumerator CoColor(this Graphic self, Color target)
            => Yield.Into(target, self.SetColor);

        public static IEnumerator CoColor(this Graphic self, Color target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(self.GetColor, target, self.SetColor, Yield.Time(duration, easer));

        public static IEnumerator CoColor(this Graphic self, Color start, Color target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(start, target, self.SetColor, Yield.Time(duration, easer));
        #endregion

        #region Fade
        public static IEnumerator CoFade(this Graphic self, float target)
            => Yield.Into(target, self.SetColorA);

        public static IEnumerator CoFade(this Graphic self, float target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(self.GetColorA, target, self.SetColorA, Yield.Time(duration, easer));

        public static IEnumerator CoFade(this Graphic self, float start, float target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(start, target, self.SetColorA, Yield.Time(duration, easer));
        #endregion

        #region Gradient
        public static IEnumerator CoGradient(this Graphic self, Gradient target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(target.Evaluate, self.SetColor, Yield.Time(duration, easer));

        public static IEnumerator CoGradient(this Graphic self, Gradient target, float from, float to, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(time => target.Evaluate(Mathf.Lerp(from, to, time)), self.SetColor, Yield.Time(duration, easer));
        #endregion
    }

    internal static class InternalGraphicExtensions
    {
        #region Color
        public static Color GetColor(this Graphic self)
            => self.color;

        public static void SetColor(this Graphic self, Color value)
            => self.color = value;

        public static float GetColorR(this Graphic self)
            => self.color.r;

        public static void SetColorR(this Graphic self, float value)
            => self.color = self.color.WithR(value);

        public static float GetColorG(this Graphic self)
            => self.color.g;

        public static void SetColorG(this Graphic self, float value)
            => self.color = self.color.WithG(value);

        public static float GetColorB(this Graphic self)
            => self.color.b;

        public static void SetColorB(this Graphic self, float value)
            => self.color = self.color.WithB(value);

        public static float GetColorA(this Graphic self)
            => self.color.a;

        public static void SetColorA(this Graphic self, float value)
            => self.color = self.color.WithA(value);
        #endregion
    }
}
