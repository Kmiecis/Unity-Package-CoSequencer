using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines
{
    public static class CanvasGroupExtensions
    {
        public static IEnumerator CoFade(this CanvasGroup self, float target)
            => UCoroutine.Yield(self.SetAlpha, target);

        public static IEnumerator CoFade(this CanvasGroup self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetAlpha, target, self.SetAlpha, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoFade(this CanvasGroup self, float start, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetAlpha, UCoroutine.YieldTime(duration, easer));
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
