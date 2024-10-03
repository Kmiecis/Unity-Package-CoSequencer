using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines
{
    public static class CanvasGroupExtensions
    {
        public static IEnumerator CoFade(this CanvasGroup self, float target)
            => Yield.Into(target, self.SetAlpha);

        public static IEnumerator CoFade(this CanvasGroup self, float target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(self.GetAlpha, target, self.SetAlpha, Yield.Time(duration, easer));

        public static IEnumerator CoFade(this CanvasGroup self, float start, float target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(start, target, self.SetAlpha, Yield.Time(duration, easer));
    }

    internal static class InternalCanvasGroupExtensions
    {
        #region Alpha
        public static float GetAlpha(this CanvasGroup self)
            => self.alpha;

        public static void SetAlpha(this CanvasGroup self, float value)
            => self.alpha = value;
        #endregion
    }
}
