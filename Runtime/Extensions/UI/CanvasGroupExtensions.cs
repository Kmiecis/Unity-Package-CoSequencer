using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines
{
    public static class CanvasGroupExtensions
    {
        public static IEnumerator CoFade(this CanvasGroup self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetAlpha, self.SetAlpha, target, UCoroutine.YieldTimeEased(duration, easer));
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
