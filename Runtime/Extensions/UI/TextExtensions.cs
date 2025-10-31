using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

namespace Common.Coroutines
{
    public static class TextExtensions
    {
        #region FontSize
        public static IEnumerator CoFontSize(this Text self, int target)
            => Yield.Into(target, self.SetFontSize);

        public static IEnumerator CoFontSize(this Text self, int target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetFontSize, target, self.SetFontSize, timer);

        public static IEnumerator CoFontSize(this Text self, int start, int target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetFontSize, timer);

        public static IEnumerator CoFontSize(this Text self, int target, float duration, Func<float, float> easer = null)
            => self.CoFontSize(target, Yield.Time(duration, easer));

        public static IEnumerator CoFontSize(this Text self, int start, int target, float duration, Func<float, float> easer = null)
            => self.CoFontSize(start, target, Yield.Time(duration, easer));
        #endregion

        #region Text
        public static IEnumerator CoText(this Text self, string target)
            => Yield.Into(target, self.SetText);

        public static IEnumerator CoText(this Text self, string target, IEnumerator<float> timer)
            => Yield.Value(t => target.Substring(t), timer).Into(self.SetText);

        public static IEnumerator CoText(this Text self, string target, float duration, Func<float, float> easer = null)
            => self.CoText(target, Yield.Time(duration, easer));
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