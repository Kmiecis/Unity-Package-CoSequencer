using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Common.Coroutines
{
    public static class ScrollRectExtensions
    {
        public static IEnumerator CoPosition(this ScrollRect self, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetNormalizedPosition, self.SetNormalizedPosition, target, UCoroutine.YieldTimeEased(duration, easer));
        
        public static IEnumerator CoHorizontalPosition(this ScrollRect self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetHorizontalNormalizedPosition, self.SetHorizontalNormalizedPosition, target, UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoVerticalPosition(this ScrollRect self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetVerticalNormalizedPosition, self.SetVerticalNormalizedPosition, target, UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoVelocity(this ScrollRect self, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetVelocity, self.SetVelocity, target, UCoroutine.YieldTimeEased(duration, easer));
        
        public static IEnumerator CoHorizontalVelocity(this ScrollRect self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetHorizontalVelocity, self.SetHorizontalVelocity, target, UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoVerticalVelocity(this ScrollRect self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetVerticalVelocity, self.SetVerticalVelocity, target, UCoroutine.YieldTimeEased(duration, easer));
    }

    internal static class InternalScrollRectExtensions
    {
        #region Normalized position
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
