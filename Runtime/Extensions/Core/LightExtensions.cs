using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines
{
    public static class LightExtensions
    {
        #region Color
        public static IEnumerator CoColor(this Light self, Color target)
            => UCoroutine.Yield(self.SetColor, target);

        public static IEnumerator CoColor(this Light self, Color target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetColor, target, self.SetColor, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoColor(this Light self, Color start, Color target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetColor, UCoroutine.YieldTime(duration, easer));
        #endregion

        #region Intensity
        public static IEnumerator CoIntensity(this Light self, float target)
            => UCoroutine.Yield(self.SetIntensity, target);

        public static IEnumerator CoIntensity(this Light self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetIntensity, target, self.SetIntensity, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoIntensity(this Light self, float start, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetIntensity, UCoroutine.YieldTime(duration, easer));
        #endregion

        #region Range
        public static IEnumerator CoRange(this Light self, float target)
            => UCoroutine.Yield(self.SetRange, target);

        public static IEnumerator CoRange(this Light self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetRange, target, self.SetRange, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoRange(this Light self, float start, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetRange, UCoroutine.YieldTime(duration, easer));
        #endregion

        #region Shadow
        public static IEnumerator CoShadowStrength(this Light self, float target)
            => UCoroutine.Yield(self.SetShadowStrength, target);

        public static IEnumerator CoShadowStrength(this Light self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetShadowStrength, target, self.SetShadowStrength, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoShadowStrength(this Light self, float start, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetShadowStrength, UCoroutine.YieldTime(duration, easer));
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
