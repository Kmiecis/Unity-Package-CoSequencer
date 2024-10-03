using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines
{
    public static class LightExtensions
    {
        #region Color
        public static IEnumerator CoColor(this Light self, Color target)
            => Yield.Into(target, self.SetColor);

        public static IEnumerator CoColor(this Light self, Color target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(self.GetColor, target, self.SetColor, Yield.Time(duration, easer));

        public static IEnumerator CoColor(this Light self, Color start, Color target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(start, target, self.SetColor, Yield.Time(duration, easer));
        #endregion

        #region Intensity
        public static IEnumerator CoIntensity(this Light self, float target)
            => Yield.Into(target, self.SetIntensity);

        public static IEnumerator CoIntensity(this Light self, float target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(self.GetIntensity, target, self.SetIntensity, Yield.Time(duration, easer));

        public static IEnumerator CoIntensity(this Light self, float start, float target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(start, target, self.SetIntensity, Yield.Time(duration, easer));
        #endregion

        #region Range
        public static IEnumerator CoRange(this Light self, float target)
            => Yield.Into(target, self.SetRange);

        public static IEnumerator CoRange(this Light self, float target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(self.GetRange, target, self.SetRange, Yield.Time(duration, easer));

        public static IEnumerator CoRange(this Light self, float start, float target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(start, target, self.SetRange, Yield.Time(duration, easer));
        #endregion

        #region Shadow
        public static IEnumerator CoShadowStrength(this Light self, float target)
            => Yield.Into(target, self.SetShadowStrength);

        public static IEnumerator CoShadowStrength(this Light self, float target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(self.GetShadowStrength, target, self.SetShadowStrength, Yield.Time(duration, easer));

        public static IEnumerator CoShadowStrength(this Light self, float start, float target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(start, target, self.SetShadowStrength, Yield.Time(duration, easer));
        #endregion
    }

    internal static class InternalLightExtensions
    {
        #region Color
        public static Color GetColor(this Light self)
            => self.color;

        public static void SetColor(this Light self, Color value)
            => self.color = value;
        #endregion

        #region Intensity
        public static float GetIntensity(this Light self)
            => self.intensity;

        public static void SetIntensity(this Light self, float value)
            => self.intensity = value;
        #endregion

        #region Range
        public static float GetRange(this Light self)
            => self.range;

        public static void SetRange(this Light self, float value)
            => self.range = value;
        #endregion

        #region Shadow strength
        public static float GetShadowStrength(this Light self)
            => self.shadowStrength;

        public static void SetShadowStrength(this Light self, float value)
            => self.range = value;
        #endregion
    }
}
