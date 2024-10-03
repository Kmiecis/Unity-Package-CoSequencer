using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines
{
    public static class MaterialExtensions
    {
        #region Color
        public static IEnumerator CoColor(this Material self, Color target)
            => Yield.Into(target, self.SetColor);

        public static IEnumerator CoColor(this Material self, int propertyId, Color target)
            => Yield.Into(target, v => self.SetColor(propertyId, v));

        public static IEnumerator CoColor(this Material self, Color target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(self.GetColor, target, self.SetColor, Yield.Time(duration, easer));

        public static IEnumerator CoColor(this Material self, Color start, Color target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(start, target, self.SetColor, Yield.Time(duration, easer));

        public static IEnumerator CoColor(this Material self, int propertyId, Color target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(() => self.GetColor(propertyId), target, c => self.SetColor(propertyId, c), Yield.Time(duration, easer));

        public static IEnumerator CoColor(this Material self, int propertyId, Color start, Color target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(start, target, c => self.SetColor(propertyId, c), Yield.Time(duration, easer));
        #endregion

        #region Fade
        public static IEnumerator CoFade(this Material self, float target)
            => Yield.Into(target, self.SetColorA);

        public static IEnumerator CoFade(this Material self, int propertyId, float target)
            => Yield.Into(target, v => self.SetColorA(propertyId, v));

        public static IEnumerator CoFade(this Material self, float target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(self.GetColorA, target, self.SetColorA, Yield.Time(duration, easer));

        public static IEnumerator CoFade(this Material self, float start, float target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(start, target, self.SetColorA, Yield.Time(duration, easer));

        public static IEnumerator CoFade(this Material self, int propertyId, float target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(() => self.GetColorA(propertyId), target, f => self.SetColorA(propertyId, f), Yield.Time(duration, easer));

        public static IEnumerator CoFade(this Material self, int propertyId, float start, float target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(start, target, f => self.SetColorA(propertyId, f), Yield.Time(duration, easer));
        #endregion

        #region Gradient
        public static IEnumerator CoGradient(this Material self, Gradient target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(target.Evaluate, self.SetColor, Yield.Time(duration, easer));

        public static IEnumerator CoGradient(this Material self, Gradient target, float from, float to, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(time => target.Evaluate(UMath.Lerp(from, to, time)), self.SetColor, Yield.Time(duration, easer));

        public static IEnumerator CoGradient(this Material self, int propertyId, Gradient target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(target.Evaluate, c => self.SetColor(propertyId, c), Yield.Time(duration, easer));

        public static IEnumerator CoGradient(this Material self, int propertyId, Gradient target, float from, float to, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(time => target.Evaluate(UMath.Lerp(from, to, time)), c => self.SetColor(propertyId, c), Yield.Time(duration, easer));
        #endregion

        #region Float
        public static IEnumerator CoFloat(this Material self, int propertyId, float target)
            => Yield.Into(target, v => self.SetFloat(propertyId, v));

        public static IEnumerator CoFloat(this Material self, int propertyId, float target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(() => self.GetFloat(propertyId), target, f => self.SetFloat(propertyId, f), Yield.Time(duration, easer));

        public static IEnumerator CoFloat(this Material self, int propertyId, float start, float target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(start, target, f => self.SetFloat(propertyId, f), Yield.Time(duration, easer));
        #endregion

        #region Tiling
        public static IEnumerator CoTiling(this Material self, Vector2 target)
            => Yield.Into(target, self.SetTextureScale);

        public static IEnumerator CoTiling(this Material self, int propertyId, Vector2 target)
            => Yield.Into(target, v => self.SetTextureScale(propertyId, v));

        public static IEnumerator CoTiling(this Material self, Vector2 target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(self.GetTextureScale, target, self.SetTextureScale, Yield.Time(duration, easer));

        public static IEnumerator CoTiling(this Material self, Vector2 start, Vector2 target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(start, target, self.SetTextureScale, Yield.Time(duration, easer));

        public static IEnumerator CoTiling(this Material self, int propertyId, Vector2 target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(() => self.GetTextureScale(propertyId), target, v => self.SetTextureScale(propertyId, v), Yield.Time(duration, easer));

        public static IEnumerator CoTiling(this Material self, int propertyId, Vector2 start, Vector2 target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(start, target, v => self.SetTextureScale(propertyId, v), Yield.Time(duration, easer));
        #endregion

        #region Offset
        public static IEnumerator CoOffset(this Material self, Vector2 target)
            => Yield.Into(target, self.SetTextureOffset);

        public static IEnumerator CoOffset(this Material self, int propertyId, Vector2 target)
            => Yield.Into(target, v => self.SetTextureOffset(propertyId, v));

        public static IEnumerator CoOffset(this Material self, Vector2 target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(self.GetTextureOffset, target, self.SetTextureOffset, Yield.Time(duration, easer));

        public static IEnumerator CoOffset(this Material self, Vector2 start, Vector2 target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(start, target, self.SetTextureOffset, Yield.Time(duration, easer));

        public static IEnumerator CoOffset(this Material self, int propertyId, Vector2 target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(() => self.GetTextureOffset(propertyId), target, v => self.SetTextureOffset(propertyId, v), Yield.Time(duration, easer));

        public static IEnumerator CoOffset(this Material self, int propertyId, Vector2 start, Vector2 target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(start, target, v => self.SetTextureOffset(propertyId, v), Yield.Time(duration, easer));
        #endregion

        #region Vector
        public static IEnumerator CoVector(this Material self, int propertyId, Vector4 target)
            => Yield.Into(target, v => self.SetVector(propertyId, v));

        public static IEnumerator CoVector(this Material self, int propertyId, Vector4 target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(() => self.GetVector(propertyId), target, v => self.SetVector(propertyId, v), Yield.Time(duration, easer));

        public static IEnumerator CoVector(this Material self, int propertyId, Vector4 start, Vector4 target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(start, target, v => self.SetVector(propertyId, v), Yield.Time(duration, easer));
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
