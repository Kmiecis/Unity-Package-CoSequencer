using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines
{
    public static class MaterialExtensions
    {
        #region Color
        public static IEnumerator CoColor(this Material self, Color target)
            => UCoroutine.Yield(self.SetColor, target);

        public static IEnumerator CoColor(this Material self, int propertyId, Color target)
            => UCoroutine.Yield(v => self.SetColor(propertyId, v), target);

        public static IEnumerator CoColor(this Material self, Color target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetColor, target, self.SetColor, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoColor(this Material self, Color start, Color target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetColor, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoColor(this Material self, int propertyId, Color target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(() => self.GetColor(propertyId), target, c => self.SetColor(propertyId, c), UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoColor(this Material self, int propertyId, Color start, Color target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, c => self.SetColor(propertyId, c), UCoroutine.YieldTime(duration, easer));
        #endregion

        #region Fade
        public static IEnumerator CoFade(this Material self, float target)
            => UCoroutine.Yield(self.SetColorA, target);

        public static IEnumerator CoFade(this Material self, int propertyId, float target)
            => UCoroutine.Yield(v => self.SetColorA(propertyId, v), target);

        public static IEnumerator CoFade(this Material self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetColorA, target, self.SetColorA, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoFade(this Material self, float start, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetColorA, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoFade(this Material self, int propertyId, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(() => self.GetColorA(propertyId), target, f => self.SetColorA(propertyId, f), UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoFade(this Material self, int propertyId, float start, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, f => self.SetColorA(propertyId, f), UCoroutine.YieldTime(duration, easer));
        #endregion

        #region Gradient
        public static IEnumerator CoGradient(this Material self, Gradient target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(target.Evaluate, self.SetColor, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoGradient(this Material self, Gradient target, float from, float to, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(time => target.Evaluate(UMath.Lerp(from, to, time)), self.SetColor, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoGradient(this Material self, int propertyId, Gradient target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(target.Evaluate, c => self.SetColor(propertyId, c), UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoGradient(this Material self, int propertyId, Gradient target, float from, float to, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(time => target.Evaluate(UMath.Lerp(from, to, time)), c => self.SetColor(propertyId, c), UCoroutine.YieldTime(duration, easer));
        #endregion

        #region Float
        public static IEnumerator CoFloat(this Material self, int propertyId, float target)
            => UCoroutine.Yield(v => self.SetFloat(propertyId, v), target);

        public static IEnumerator CoFloat(this Material self, int propertyId, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(() => self.GetFloat(propertyId), target, f => self.SetFloat(propertyId, f), UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoFloat(this Material self, int propertyId, float start, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, f => self.SetFloat(propertyId, f), UCoroutine.YieldTime(duration, easer));
        #endregion

        #region Tiling
        public static IEnumerator CoTiling(this Material self, Vector2 target)
            => UCoroutine.Yield(self.SetTextureScale, target);

        public static IEnumerator CoTiling(this Material self, int propertyId, Vector2 target)
            => UCoroutine.Yield(v => self.SetTextureScale(propertyId, v), target);

        public static IEnumerator CoTiling(this Material self, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetTextureScale, target, self.SetTextureScale, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoTiling(this Material self, Vector2 start, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetTextureScale, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoTiling(this Material self, int propertyId, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(() => self.GetTextureScale(propertyId), target, v => self.SetTextureScale(propertyId, v), UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoTiling(this Material self, int propertyId, Vector2 start, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, v => self.SetTextureScale(propertyId, v), UCoroutine.YieldTime(duration, easer));
        #endregion

        #region Offset
        public static IEnumerator CoOffset(this Material self, Vector2 target)
            => UCoroutine.Yield(self.SetTextureOffset, target);

        public static IEnumerator CoOffset(this Material self, int propertyId, Vector2 target)
            => UCoroutine.Yield(v => self.SetTextureOffset(propertyId, v), target);

        public static IEnumerator CoOffset(this Material self, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetTextureOffset, target, self.SetTextureOffset, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoOffset(this Material self, Vector2 start, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, self.SetTextureOffset, UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoOffset(this Material self, int propertyId, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(() => self.GetTextureOffset(propertyId), target, v => self.SetTextureOffset(propertyId, v), UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoOffset(this Material self, int propertyId, Vector2 start, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, v => self.SetTextureOffset(propertyId, v), UCoroutine.YieldTime(duration, easer));
        #endregion

        #region Vector
        public static IEnumerator CoVector(this Material self, int propertyId, Vector4 target)
            => UCoroutine.Yield(v => self.SetVector(propertyId, v), target);

        public static IEnumerator CoVector(this Material self, int propertyId, Vector4 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(() => self.GetVector(propertyId), target, v => self.SetVector(propertyId, v), UCoroutine.YieldTime(duration, easer));

        public static IEnumerator CoVector(this Material self, int propertyId, Vector4 start, Vector4 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(start, target, v => self.SetVector(propertyId, v), UCoroutine.YieldTime(duration, easer));
        #endregion
    }

    internal static class InternalMaterialExtensions
    {
        #region Color
        public static Color GetColor(this Material self)
            => self.color;

        public static void SetColor(this Material self, Color value)
            => self.color = value;

        public static float GetColorA(this Material self)
            => self.color.a;

        public static void SetColorA(this Material self, float value)
            => self.color = self.color.WithA(value);

        public static float GetColorA(this Material self, int propertyId)
            => self.GetColor(propertyId).a;

        public static void SetColorA(this Material self, int propertyId, float value)
            => self.SetColor(propertyId, self.GetColor(propertyId).WithA(value));
        #endregion

        #region Tiling and Offset
        public static Vector2 GetTextureScale(this Material self)
            => self.mainTextureScale;

        public static void SetTextureScale(this Material self, Vector2 value)
            => self.mainTextureScale = value;

        public static Vector2 GetTextureOffset(this Material self)
            => self.mainTextureOffset;

        public static void SetTextureOffset(this Material self, Vector2 value)
            => self.mainTextureOffset = value;
        #endregion
    }
}
