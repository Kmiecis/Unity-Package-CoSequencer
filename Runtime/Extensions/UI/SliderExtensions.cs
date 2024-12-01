using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

namespace Common.Coroutines
{
    public static class SliderExtensions
    {
        #region Value
        public static IEnumerator CoValue(this Slider self, float target)
            => Yield.Into(target, self.SetValue);

        public static IEnumerator CoValue(this Slider self, float target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetValue, target, self.SetValue, timer);

        public static IEnumerator CoValue(this Slider self, float start, float target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetValue, timer);

        public static IEnumerator CoValue(this Slider self, float target, float duration, Func<float, float> easer = null)
            => self.CoValue(target, Yield.Time(duration, easer));

        public static IEnumerator CoValue(this Slider self, float start, float target, float duration, Func<float, float> easer = null)
            => self.CoValue(start, target, Yield.Time(duration, easer));
        #endregion

        #region NormalizedValue
        public static IEnumerator CoNormalizedValue(this Slider self, float target)
            => Yield.Into(target, self.SetNormalizedValue);

        public static IEnumerator CoNormalizedValue(this Slider self, float target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetNormalizedValue, target, self.SetNormalizedValue, timer);

        public static IEnumerator CoNormalizedValue(this Slider self, float start, float target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetNormalizedValue, timer);

        public static IEnumerator CoNormalizedValue(this Slider self, float target, float duration, Func<float, float> easer = null)
            => self.CoNormalizedValue(target, Yield.Time(duration, easer));

        public static IEnumerator CoNormalizedValue(this Slider self, float start, float target, float duration, Func<float, float> easer = null)
            => self.CoNormalizedValue(start, target, Yield.Time(duration, easer));
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
