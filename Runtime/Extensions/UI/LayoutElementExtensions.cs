using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Common.Coroutines
{
    public static class LayoutElementExtensions
    {
        #region FlexibleWidth
        public static IEnumerator CoFlexibleWidth(this LayoutElement self, float target)
            => Yield.Into(target, self.SetFlexibleWidth);

        public static IEnumerator CoFlexibleWidth(this LayoutElement self, float target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(self.GetFlexibleWidth, target, self.SetFlexibleWidth, Yield.Time(duration, easer));

        public static IEnumerator CoFlexibleWidth(this LayoutElement self, float start, float target, float duration, Func<float, float> easer = null)
           => Yield.ValueTo(start, target, self.SetFlexibleWidth, Yield.Time(duration, easer));
        #endregion

        #region FlexibleHeight
        public static IEnumerator CoFlexibleHeight(this LayoutElement self, float target)
            => Yield.Into(target, self.SetFlexibleHeight);

        public static IEnumerator CoFlexibleHeight(this LayoutElement self, float target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(self.GetFlexibleHeight, target, self.SetFlexibleHeight, Yield.Time(duration, easer));

        public static IEnumerator CoFlexibleHeight(this LayoutElement self, float start, float target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(start, target, self.SetFlexibleHeight, Yield.Time(duration, easer));
        #endregion

        #region FlexibleSize
        public static IEnumerator CoFlexibleSize(this LayoutElement self, Vector2 target)
            => Yield.Into(target, self.SetFlexibleSize);

        public static IEnumerator CoFlexibleSize(this LayoutElement self, Vector2 target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(self.GetFlexibleSize, target, self.SetFlexibleSize, Yield.Time(duration, easer));

        public static IEnumerator CoFlexibleSize(this LayoutElement self, Vector2 start, Vector2 target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(start, target, self.SetFlexibleSize, Yield.Time(duration, easer));
        #endregion

        #region MinWidth
        public static IEnumerator CoMinWidth(this LayoutElement self, float target)
            => Yield.Into(target, self.SetMinWidth);

        public static IEnumerator CoMinWidth(this LayoutElement self, float target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(self.GetMinWidth, target, self.SetMinWidth, Yield.Time(duration, easer));

        public static IEnumerator CoMinWidth(this LayoutElement self, float start, float target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(start, target, self.SetMinWidth, Yield.Time(duration, easer));
        #endregion

        #region MinHeight
        public static IEnumerator CoMinHeight(this LayoutElement self, float target)
            => Yield.Into(target, self.SetMinHeight);

        public static IEnumerator CoMinHeight(this LayoutElement self, float target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(self.GetMinHeight, target, self.SetMinHeight, Yield.Time(duration, easer));

        public static IEnumerator CoMinHeight(this LayoutElement self, float start, float target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(start, target, self.SetMinHeight, Yield.Time(duration, easer));
        #endregion

        #region MinSize
        public static IEnumerator CoMinSize(this LayoutElement self, Vector2 target)
            => Yield.Into(target, self.SetMinSize);

        public static IEnumerator CoMinSize(this LayoutElement self, Vector2 target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(self.GetMinSize, target, self.SetMinSize, Yield.Time(duration, easer));

        public static IEnumerator CoMinSize(this LayoutElement self, Vector2 start, Vector2 target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(start, target, self.SetMinSize, Yield.Time(duration, easer));
        #endregion

        #region PreferredWidth
        public static IEnumerator CoPreferredWidth(this LayoutElement self, float target)
            => Yield.Into(target, self.SetPreferredWidth);

        public static IEnumerator CoPreferredWidth(this LayoutElement self, float target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(self.GetPreferredWidth, target, self.SetPreferredWidth, Yield.Time(duration, easer));

        public static IEnumerator CoPreferredWidth(this LayoutElement self, float start, float target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(start, target, self.SetPreferredWidth, Yield.Time(duration, easer));
        #endregion

        #region PreferredHeight
        public static IEnumerator CoPreferredHeight(this LayoutElement self, float target)
            => Yield.Into(target, self.SetPreferredHeight);

        public static IEnumerator CoPreferredHeight(this LayoutElement self, float target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(self.GetPreferredHeight, target, self.SetPreferredHeight, Yield.Time(duration, easer));

        public static IEnumerator CoPreferredHeight(this LayoutElement self, float start, float target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(start, target, self.SetPreferredHeight, Yield.Time(duration, easer));
        #endregion

        #region PreferredSize
        public static IEnumerator CoPreferredSize(this LayoutElement self, Vector2 target)
            => Yield.Into(target, self.SetPreferredSize);

        public static IEnumerator CoPreferredSize(this LayoutElement self, Vector2 target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(self.GetPreferredSize, target, self.SetPreferredSize, Yield.Time(duration, easer));

        public static IEnumerator CoPreferredSize(this LayoutElement self, Vector2 start, Vector2 target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(start, target, self.SetPreferredSize, Yield.Time(duration, easer));
        #endregion
    }

    internal static class InternalLayoutElementExtensions
    {
        #region Flexible size
        public static float GetFlexibleWidth(this LayoutElement self)
            => self.flexibleWidth;

        public static void SetFlexibleWidth(this LayoutElement self, float value)
            => self.flexibleWidth = value;

        public static float GetFlexibleHeight(this LayoutElement self)
            => self.flexibleHeight;

        public static void SetFlexibleHeight(this LayoutElement self, float value)
            => self.flexibleHeight = value;

        public static Vector2 GetFlexibleSize(this LayoutElement self)
            => new Vector2(self.flexibleWidth, self.flexibleHeight);

        public static void SetFlexibleSize(this LayoutElement self, Vector2 value)
        {
            self.flexibleWidth = value.x;
            self.flexibleHeight = value.y;
        }
        #endregion

        #region Min size
        public static float GetMinWidth(this LayoutElement self)
            => self.minWidth;

        public static void SetMinWidth(this LayoutElement self, float value)
            => self.minWidth = value;

        public static float GetMinHeight(this LayoutElement self)
            => self.minHeight;

        public static void SetMinHeight(this LayoutElement self, float value)
            => self.minHeight = value;

        public static Vector2 GetMinSize(this LayoutElement self)
            => new Vector2(self.minWidth, self.minHeight);

        public static void SetMinSize(this LayoutElement self, Vector2 value)
        {
            self.minWidth = value.x;
            self.minHeight = value.y;
        }
        #endregion

        #region Preferred size
        public static float GetPreferredWidth(this LayoutElement self)
            => self.preferredWidth;

        public static void SetPreferredWidth(this LayoutElement self, float value)
            => self.preferredWidth = value;

        public static float GetPreferredHeight(this LayoutElement self)
            => self.preferredHeight;

        public static void SetPreferredHeight(this LayoutElement self, float value)
            => self.preferredHeight = value;

        public static Vector2 GetPreferredSize(this LayoutElement self)
            => new Vector2(self.preferredWidth, self.preferredHeight);

        public static void SetPreferredSize(this LayoutElement self, Vector2 value)
        {
            self.preferredWidth = value.x;
            self.preferredHeight = value.y;
        }
        #endregion
    }
}
