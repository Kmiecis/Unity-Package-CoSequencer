using System;
using System.Collections;
using UnityEngine.UI;

namespace Common.Coroutines
{
    public static class SliderExtensions
    {
        public static IEnumerator CoValue(this Slider self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetValue, self.SetValue, target, UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoNormalizedValue(this Slider self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetNormalizedValue, self.SetNormalizedValue, target, UCoroutine.YieldTimeEased(duration, easer));
    }

    internal static class InternalSliderExtensions
    {
        #region Value
        public static float GetValue(this Slider self)
            => self.value;

        public static void SetValue(this Slider self, float value)
            => self.value = value;

        public static float GetNormalizedValue(this Slider self)
            => self.normalizedValue;

        public static void SetNormalizedValue(this Slider self, float value)
            => self.normalizedValue = value;
        #endregion
    }
}
