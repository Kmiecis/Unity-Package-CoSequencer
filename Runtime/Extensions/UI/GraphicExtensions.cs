using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Common.Coroutines
{
    public static class GraphicExtensions
    {
        public static IEnumerator CoColor(this Graphic self, Color target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetColor, self.SetColor, target, UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoFade(this Graphic self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetColorA, self.SetColorA, target, UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoGradient(this Graphic self, Gradient target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(target.Evaluate, self.SetColor, UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoGradient(this Graphic self, Gradient target, float from, float to, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(time => target.Evaluate(Mathf.Lerp(from, to, time)), self.SetColor, UCoroutine.YieldTimeEased(duration, easer));
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
