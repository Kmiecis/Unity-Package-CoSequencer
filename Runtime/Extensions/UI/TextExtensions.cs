using System;
using System.Collections;
using UnityEngine.UI;

namespace Common.Coroutines
{
    public static class TextExtensions
    {
        #region FontSize
        public static IEnumerator CoFontSize(this Text self, int target)
            => UCoroutine.Yield(self.SetFontSize, target);

        public static IEnumerator CoFontSize(this Text self, int target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetFontSize, target, self.SetFontSize, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoFontSize(this Text self, int start, int target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetFontSize, UCoroutine.YieldTime(duration, easer));
        #endregion

        #region Text
        public static IEnumerator CoText(this Text self, string target)
            => UCoroutine.Yield(self.SetText, target);

        public static IEnumerator CoText(this Text self, string target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(t => target.Substring(t), self.SetText, UCoroutine.YieldTime(duration, easer));
        #endregion
    }

    internal static class InternalTextExtensions
    {
        #region Font size
        public static int GetFontSize(this Text self)
            => self.fontSize;

        public static void SetFontSize(this Text self, int value)
            => self.fontSize = value;
        #endregion

        #region Text
        public static string GetText(this Text self)
            => self.text;

        public static void SetText(this Text self, string value)
            => self.text = value;
        #endregion
    }
}