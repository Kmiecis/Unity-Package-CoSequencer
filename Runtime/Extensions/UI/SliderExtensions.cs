using System;
using System.Collections;
using UnityEngine.UI;

namespace Common.Coroutines
{
    public static class SliderExtensions
    {
        #region Value
        public static IEnumerator CoValue(this Slider self, float target)
            => UCoroutine.Yield(self.SetValue, target);

        public static IEnumerator CoValue(this Slider self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetValue, target, self.SetValue, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoValue(this Slider self, float start, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetValue, UCoroutine.YieldTime(duration, easer));
        #endregion

        #region NormalizedValue
        public static IEnumerator CoNormalizedValue(this Slider self, float target)
            => UCoroutine.Yield(self.SetNormalizedValue, target);

        public static IEnumerator CoNormalizedValue(this Slider self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetNormalizedValue, target, self.SetNormalizedValue, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoNormalizedValue(this Slider self, float start, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetNormalizedValue, UCoroutine.YieldTime(duration, easer));
        #endregion
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
