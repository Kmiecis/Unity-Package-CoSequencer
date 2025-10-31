using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Common.Coroutines
{
    public static class GraphicExtensions
    {
        #region Color
        public static IEnumerator CoColor(this Graphic self, Color target)
            => Yield.Into(target, self.SetColor);

        public static IEnumerator CoColor(this Graphic self, Color target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetColor, target, self.SetColor, timer);

        public static IEnumerator CoColor(this Graphic self, Color start, Color target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetColor, timer);

        public static IEnumerator CoColor(this Graphic self, Color target, float duration, Func<float, float> easer = null)
            => self.CoColor(target, Yield.Time(duration, easer));

        public static IEnumerator CoColor(this Graphic self, Color start, Color target, float duration, Func<float, float> easer = null)
            => self.CoColor(start, target, Yield.Time(duration, easer));
        #endregion

        #region Fade
        public static IEnumerator CoFade(this Graphic self, float target)
            => Yield.Into(target, self.SetColorA);

        public static IEnumerator CoFade(this Graphic self, float target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetColorA, target, self.SetColorA, timer);

        public static IEnumerator CoFade(this Graphic self, float start, float target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetColorA, timer);

        public static IEnumerator CoFade(this Graphic self, float target, float duration, Func<float, float> easer = null)
            => self.CoFade(target, Yield.Time(duration, easer));

        public static IEnumerator CoFade(this Graphic self, float start, float target, float duration, Func<float, float> easer = null)
            => self.CoFade(start, target, Yield.Time(duration, easer));
        #endregion

        #region Gradient
        public static IEnumerator CoGradient(this Graphic self, Gradient target, IEnumerator<float> timer)
            => Yield.Value(target.Evaluate, timer).Into(self.SetColor);

        public static IEnumerator CoGradient(this Graphic self, Gradient target, float from, float to, IEnumerator<float> timer)
            => Yield.Value(time => target.Evaluate(Mathf.Lerp(from, to, time)), timer).Into(self.SetColor);

        public static IEnumerator CoGradient(this Graphic self, Gradient target, float duration, Func<float, float> easer = null)
            => self.CoGradient(target, Yield.Time(duration, easer));

        public static IEnumerator CoGradient(this Graphic self, Gradient target, float from, float to, float duration, Func<float, float> easer = null)
            => self.CoGradient(target, from, to, Yield.Time(duration, easer));
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
