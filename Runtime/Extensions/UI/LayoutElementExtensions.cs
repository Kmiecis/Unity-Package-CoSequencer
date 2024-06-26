﻿using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Common.Coroutines
{
    public static class LayoutElementExtensions
    {
        #region FlexibleWidth
        public static IEnumerator CoFlexibleWidth(this LayoutElement self, float target)
            => UCoroutine.Yield(self.SetFlexibleWidth, target);

        public static IEnumerator CoFlexibleWidth(this LayoutElement self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetFlexibleWidth, target, self.SetFlexibleWidth, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoFlexibleWidth(this LayoutElement self, float start, float target, float duration, Func<float, float> easer = null)
           => UCoroutine.YieldValueTo(start, target, self.SetFlexibleWidth, UCoroutine.YieldTime(duration, easer));
        #endregion

        #region FlexibleHeight
        public static IEnumerator CoFlexibleHeight(this LayoutElement self, float target)
            => UCoroutine.Yield(self.SetFlexibleHeight, target);

        public static IEnumerator CoFlexibleHeight(this LayoutElement self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetFlexibleHeight, target, self.SetFlexibleHeight, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoFlexibleHeight(this LayoutElement self, float start, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetFlexibleHeight, UCoroutine.YieldTime(duration, easer));
        #endregion

        #region FlexibleSize
        public static IEnumerator CoFlexibleSize(this LayoutElement self, Vector2 target)
            => UCoroutine.Yield(self.SetFlexibleSize, target);

        public static IEnumerator CoFlexibleSize(this LayoutElement self, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetFlexibleSize, target, self.SetFlexibleSize, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoFlexibleSize(this LayoutElement self, Vector2 start, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetFlexibleSize, UCoroutine.YieldTime(duration, easer));
        #endregion

        #region MinWidth
        public static IEnumerator CoMinWidth(this LayoutElement self, float target)
            => UCoroutine.Yield(self.SetMinWidth, target);

        public static IEnumerator CoMinWidth(this LayoutElement self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetMinWidth, target, self.SetMinWidth, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoMinWidth(this LayoutElement self, float start, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetMinWidth, UCoroutine.YieldTime(duration, easer));
        #endregion

        #region MinHeight
        public static IEnumerator CoMinHeight(this LayoutElement self, float target)
            => UCoroutine.Yield(self.SetMinHeight, target);

        public static IEnumerator CoMinHeight(this LayoutElement self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetMinHeight, target, self.SetMinHeight, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoMinHeight(this LayoutElement self, float start, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetMinHeight, UCoroutine.YieldTime(duration, easer));
        #endregion

        #region MinSize
        public static IEnumerator CoMinSize(this LayoutElement self, Vector2 target)
            => UCoroutine.Yield(self.SetMinSize, target);

        public static IEnumerator CoMinSize(this LayoutElement self, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetMinSize, target, self.SetMinSize, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoMinSize(this LayoutElement self, Vector2 start, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetMinSize, UCoroutine.YieldTime(duration, easer));
        #endregion

        #region PreferredWidth
        public static IEnumerator CoPreferredWidth(this LayoutElement self, float target)
            => UCoroutine.Yield(self.SetPreferredWidth, target);

        public static IEnumerator CoPreferredWidth(this LayoutElement self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetPreferredWidth, target, self.SetPreferredWidth, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoPreferredWidth(this LayoutElement self, float start, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetPreferredWidth, UCoroutine.YieldTime(duration, easer));
        #endregion

        #region PreferredHeight
        public static IEnumerator CoPreferredHeight(this LayoutElement self, float target)
            => UCoroutine.Yield(self.SetPreferredHeight, target);

        public static IEnumerator CoPreferredHeight(this LayoutElement self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetPreferredHeight, target, self.SetPreferredHeight, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoPreferredHeight(this LayoutElement self, float start, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetPreferredHeight, UCoroutine.YieldTime(duration, easer));
        #endregion

        #region PreferredSize
        public static IEnumerator CoPreferredSize(this LayoutElement self, Vector2 target)
            => UCoroutine.Yield(self.SetPreferredSize, target);

        public static IEnumerator CoPreferredSize(this LayoutElement self, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetPreferredSize, target, self.SetPreferredSize, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoPreferredSize(this LayoutElement self, Vector2 start, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetPreferredSize, UCoroutine.YieldTime(duration, easer));
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
