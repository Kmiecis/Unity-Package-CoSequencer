using System;
using System.Collections;
using UnityEngine.UI;

namespace Common.Coroutines
{
    public static class ImageExtensions
    {
        public static IEnumerator CoFillAmount(this Image self, float target)
            => Yield.Into(target, self.SetFillAmount);

        public static IEnumerator CoFillAmount(this Image self, float target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(self.GetFillAmount, target, self.SetFillAmount, Yield.Time(duration, easer));

        public static IEnumerator CoFillAmount(this Image self, float start, float target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(start, target, self.SetFillAmount, Yield.Time(duration, easer));
    }
    
    internal static class InternalImageExtensions
    {
        #region Fill amount
        public static float GetFillAmount(this Image self)
            => self.fillAmount;

        public static void SetFillAmount(this Image self, float value)
            => self.fillAmount = value;
        #endregion
    }
}
