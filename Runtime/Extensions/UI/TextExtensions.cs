using System;
using System.Collections;
using UnityEngine.UI;

namespace Common.Coroutines
{
    public static class TextExtensions
    {
        public static IEnumerator CoFontSize(this Text self, int target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetFontSize, self.SetFontSize, target, UCoroutine.YieldTimeEased(duration, easer));
    }

    internal static class InternalTextExtensions
    {
        #region Font size
        public static int GetFontSize(this Text self)
            => self.fontSize;

        public static void SetFontSize(this Text self, int value)
            => self.fontSize = value;
        #endregion
    }
}