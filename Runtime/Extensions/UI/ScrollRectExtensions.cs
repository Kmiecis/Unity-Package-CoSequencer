using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Common.Coroutines
{
    public static class ScrollRectExtensions
    {
        #region Position
        public static IEnumerator CoPosition(this ScrollRect self, Vector2 target)
            => Yield.Into(target, self.SetNormalizedPosition);

        public static IEnumerator CoPosition(this ScrollRect self, Vector2 target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(self.GetNormalizedPosition, target, self.SetNormalizedPosition, Yield.Time(duration, easer));

        public static IEnumerator CoPosition(this ScrollRect self, Vector2 start, Vector2 target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(start, target, self.SetNormalizedPosition, Yield.Time(duration, easer));
        #endregion

        #region HorizontalPosition
        public static IEnumerator CoHorizontalPosition(this ScrollRect self, float target)
            => Yield.Into(target, self.SetHorizontalNormalizedPosition);

        public static IEnumerator CoHorizontalPosition(this ScrollRect self, float target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(self.GetHorizontalNormalizedPosition, target, self.SetHorizontalNormalizedPosition, Yield.Time(duration, easer));

        public static IEnumerator CoHorizontalPosition(this ScrollRect self, float start, float target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(start, target, self.SetHorizontalNormalizedPosition, Yield.Time(duration, easer));
        #endregion

        #region VerticalPosition
        public static IEnumerator CoVerticalPosition(this ScrollRect self, float target)
            => Yield.Into(target, self.SetVerticalNormalizedPosition);

        public static IEnumerator CoVerticalPosition(this ScrollRect self, float target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(self.GetVerticalNormalizedPosition, target, self.SetVerticalNormalizedPosition, Yield.Time(duration, easer));

        public static IEnumerator CoVerticalPosition(this ScrollRect self, float start, float target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(start, target, self.SetVerticalNormalizedPosition, Yield.Time(duration, easer));
        #endregion

        #region Velocity
        public static IEnumerator CoVelocity(this ScrollRect self, Vector2 target)
            => Yield.Into(target, self.SetVelocity);

        public static IEnumerator CoVelocity(this ScrollRect self, Vector2 target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(self.GetVelocity, target, self.SetVelocity, Yield.Time(duration, easer));

        public static IEnumerator CoVelocity(this ScrollRect self, Vector2 start, Vector2 target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(start, target, self.SetVelocity, Yield.Time(duration, easer));
        #endregion

        #region HorizontalVelocity
        public static IEnumerator CoHorizontalVelocity(this ScrollRect self, float target)
            => Yield.Into(target, self.SetHorizontalVelocity);

        public static IEnumerator CoHorizontalVelocity(this ScrollRect self, float target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(self.GetHorizontalVelocity, target, self.SetHorizontalVelocity, Yield.Time(duration, easer));

        public static IEnumerator CoHorizontalVelocity(this ScrollRect self, float start, float target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(start, target, self.SetHorizontalVelocity, Yield.Time(duration, easer));
        #endregion

        #region VerticalVelocity
        public static IEnumerator CoVerticalVelocity(this ScrollRect self, float target)
            => Yield.Into(target, self.SetVerticalVelocity);

        public static IEnumerator CoVerticalVelocity(this ScrollRect self, float target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(self.GetVerticalVelocity, target, self.SetVerticalVelocity, Yield.Time(duration, easer));

        public static IEnumerator CoVerticalVelocity(this ScrollRect self, float start, float target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(start, target, self.SetVerticalVelocity, Yield.Time(duration, easer));
        #endregion
    }

    internal static class InternalScrollRectExtensions
    {
        #region NormalizedPosition
        public static float GetHorizontalNormalizedPosition(this ScrollRect self)
            => self.horizontalNormalizedPosition;

        public static void SetHorizontalNormalizedPosition(this ScrollRect self, float value)
            => self.horizontalNormalizedPosition = value;

        public static float GetVerticalNormalizedPosition(this ScrollRect self)
            => self.verticalNormalizedPosition;

        public static void SetVerticalNormalizedPosition(this ScrollRect self, float value)
            => self.verticalNormalizedPosition = value;

        public static Vector2 GetNormalizedPosition(this ScrollRect self)
            => self.normalizedPosition;

        public static void SetNormalizedPosition(this ScrollRect self, Vector2 value)
            => self.normalizedPosition = value;
        #endregion

        #region Velocity
        public static Vector2 GetVelocity(this ScrollRect self)
            => self.velocity;

        public static void SetVelocity(this ScrollRect self, Vector2 value)
            => self.velocity = value;

        public static float GetHorizontalVelocity(this ScrollRect self)
            => self.velocity.x;

        public static void SetHorizontalVelocity(this ScrollRect self, float value)
            => self.velocity = self.velocity.WithX(value);

        public static float GetVerticalVelocity(this ScrollRect self)
            => self.velocity.y;

        public static void SetVerticalVelocity(this ScrollRect self, float value)
            => self.velocity = self.velocity.WithY(value);
        #endregion
    }
}
