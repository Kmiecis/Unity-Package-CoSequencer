using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines
{
    public static class LightExtensions
    {
        public static IEnumerator CoColor(this Light self, Color target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetColor, self.SetColor, target, UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoIntensity(this Light self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetIntensity, self.SetIntensity, target, UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoRange(this Light self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetRange, self.SetRange, target, UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoShadowStrength(this Light self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetShadowStrength, self.SetShadowStrength, target, UCoroutine.YieldTimeEased(duration, easer));
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
