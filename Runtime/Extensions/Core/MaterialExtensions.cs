using System;
using System.Collections;
using System.Collections.Generic;
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

        public static IEnumerator CoColor(this Material self, Color target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetColor, target, self.SetColor, timer);

        public static IEnumerator CoColor(this Material self, Color start, Color target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetColor, timer);

        public static IEnumerator CoColor(this Material self, int propertyId, Color target, IEnumerator<float> timer)
            => Yield.ValueTo(() => self.GetColor(propertyId), target, c => self.SetColor(propertyId, c), timer);

        public static IEnumerator CoColor(this Material self, int propertyId, Color start, Color target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, c => self.SetColor(propertyId, c), timer);

        public static IEnumerator CoColor(this Material self, Color target, float duration, Func<float, float> easer = null)
            => self.CoColor(target, Yield.Time(duration, easer));

        public static IEnumerator CoColor(this Material self, Color start, Color target, float duration, Func<float, float> easer = null)
            => self.CoColor(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoColor(this Material self, int propertyId, Color target, float duration, Func<float, float> easer = null)
            => self.CoColor(propertyId, target, Yield.Time(duration, easer));

        public static IEnumerator CoColor(this Material self, int propertyId, Color start, Color target, float duration, Func<float, float> easer = null)
            => self.CoColor(propertyId, start, target, Yield.Time(duration, easer));
        #endregion

        #region Fade
        public static IEnumerator CoFade(this Material self, float target)
            => Yield.Into(target, self.SetColorA);

        public static IEnumerator CoFade(this Material self, int propertyId, float target)
            => Yield.Into(target, v => self.SetColorA(propertyId, v));

        public static IEnumerator CoFade(this Material self, float target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetColorA, target, self.SetColorA, timer);

        public static IEnumerator CoFade(this Material self, float start, float target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetColorA, timer);

        public static IEnumerator CoFade(this Material self, int propertyId, float target, IEnumerator<float> timer)
            => Yield.ValueTo(() => self.GetColorA(propertyId), target, f => self.SetColorA(propertyId, f), timer);

        public static IEnumerator CoFade(this Material self, int propertyId, float start, float target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, f => self.SetColorA(propertyId, f), timer);

        public static IEnumerator CoFade(this Material self, float target, float duration, Func<float, float> easer = null)
            => self.CoFade(target, Yield.Time(duration, easer));

        public static IEnumerator CoFade(this Material self, float start, float target, float duration, Func<float, float> easer = null)
            => self.CoFade(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoFade(this Material self, int propertyId, float target, float duration, Func<float, float> easer = null)
            => self.CoFade(propertyId, target, Yield.Time(duration, easer));

        public static IEnumerator CoFade(this Material self, int propertyId, float start, float target, float duration, Func<float, float> easer = null)
            => self.CoFade(propertyId, start, target, Yield.Time(duration, easer));
        #endregion

        #region Gradient
        public static IEnumerator CoGradient(this Material self, Gradient target, IEnumerator<float> timer)
            => Yield.Value(target.Evaluate, timer).Into(self.SetColor);

        public static IEnumerator CoGradient(this Material self, Gradient target, float from, float to, IEnumerator<float> timer)
            => Yield.Value(time => target.Evaluate(UMath.Lerp(from, to, time)), timer).Into(self.SetColor);

        public static IEnumerator CoGradient(this Material self, int propertyId, Gradient target, IEnumerator<float> timer)
            => Yield.Value(target.Evaluate, timer).Into(c => self.SetColor(propertyId, c));

        public static IEnumerator CoGradient(this Material self, int propertyId, Gradient target, float from, float to, IEnumerator<float> timer)
            => Yield.Value(time => target.Evaluate(UMath.Lerp(from, to, time)), timer).Into(c => self.SetColor(propertyId, c));

        public static IEnumerator CoGradient(this Material self, Gradient target, float duration, Func<float, float> easer = null)
            => self.CoGradient(target, Yield.Time(duration, easer));

        public static IEnumerator CoGradient(this Material self, Gradient target, float from, float to, float duration, Func<float, float> easer = null)
            => self.CoGradient(target, from, to, Yield.Time(duration, easer));

        public static IEnumerator CoGradient(this Material self, int propertyId, Gradient target, float duration, Func<float, float> easer = null)
            => self.CoGradient(propertyId, target, Yield.Time(duration, easer));

        public static IEnumerator CoGradient(this Material self, int propertyId, Gradient target, float from, float to, float duration, Func<float, float> easer = null)
            => self.CoGradient(propertyId, target, from, to, Yield.Time(duration, easer));
        #endregion

        #region Float
        public static IEnumerator CoFloat(this Material self, int propertyId, float target)
            => Yield.Into(target, v => self.SetFloat(propertyId, v));

        public static IEnumerator CoFloat(this Material self, int propertyId, float target, IEnumerator<float> timer)
            => Yield.ValueTo(() => self.GetFloat(propertyId), target, f => self.SetFloat(propertyId, f), timer);

        public static IEnumerator CoFloat(this Material self, int propertyId, float start, float target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, f => self.SetFloat(propertyId, f), timer);

        public static IEnumerator CoFloat(this Material self, int propertyId, float target, float duration, Func<float, float> easer = null)
            => self.CoFloat(propertyId, target, Yield.Time(duration, easer));

        public static IEnumerator CoFloat(this Material self, int propertyId, float start, float target, float duration, Func<float, float> easer = null)
            => self.CoFloat(propertyId, start, target, Yield.Time(duration, easer));
        #endregion

        #region Tiling
        public static IEnumerator CoTiling(this Material self, Vector2 target)
            => Yield.Into(target, self.SetTextureScale);

        public static IEnumerator CoTiling(this Material self, int propertyId, Vector2 target)
            => Yield.Into(target, v => self.SetTextureScale(propertyId, v));

        public static IEnumerator CoTiling(this Material self, Vector2 target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetTextureScale, target, self.SetTextureScale, timer);

        public static IEnumerator CoTiling(this Material self, Vector2 start, Vector2 target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetTextureScale, timer);

        public static IEnumerator CoTiling(this Material self, int propertyId, Vector2 target, IEnumerator<float> timer)
            => Yield.ValueTo(() => self.GetTextureScale(propertyId), target, v => self.SetTextureScale(propertyId, v), timer);

        public static IEnumerator CoTiling(this Material self, int propertyId, Vector2 start, Vector2 target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, v => self.SetTextureScale(propertyId, v), timer);

        public static IEnumerator CoTiling(this Material self, Vector2 target, float duration, Func<float, float> easer = null)
            => self.CoTiling(target, Yield.Time(duration, easer));

        public static IEnumerator CoTiling(this Material self, Vector2 start, Vector2 target, float duration, Func<float, float> easer = null)
            => self.CoTiling(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoTiling(this Material self, int propertyId, Vector2 target, float duration, Func<float, float> easer = null)
            => self.CoTiling(propertyId, target, Yield.Time(duration, easer));

        public static IEnumerator CoTiling(this Material self, int propertyId, Vector2 start, Vector2 target, float duration, Func<float, float> easer = null)
            => self.CoTiling(propertyId, start, target, Yield.Time(duration, easer));
        #endregion

        #region Offset
        public static IEnumerator CoOffset(this Material self, Vector2 target)
            => Yield.Into(target, self.SetTextureOffset);

        public static IEnumerator CoOffset(this Material self, int propertyId, Vector2 target)
            => Yield.Into(target, v => self.SetTextureOffset(propertyId, v));

        public static IEnumerator CoOffset(this Material self, Vector2 target, IEnumerator<float> timer)
            => Yield.ValueTo(self.GetTextureOffset, target, self.SetTextureOffset, timer);

        public static IEnumerator CoOffset(this Material self, Vector2 start, Vector2 target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, self.SetTextureOffset, timer);

        public static IEnumerator CoOffset(this Material self, int propertyId, Vector2 target, IEnumerator<float> timer)
            => Yield.ValueTo(() => self.GetTextureOffset(propertyId), target, v => self.SetTextureOffset(propertyId, v), timer);

        public static IEnumerator CoOffset(this Material self, int propertyId, Vector2 start, Vector2 target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, v => self.SetTextureOffset(propertyId, v), timer);

        public static IEnumerator CoOffset(this Material self, Vector2 target, float duration, Func<float, float> easer = null)
            => self.CoOffset(target, Yield.Time(duration, easer));

        public static IEnumerator CoOffset(this Material self, Vector2 start, Vector2 target, float duration, Func<float, float> easer = null)
            => self.CoOffset(start, target, Yield.Time(duration, easer));

        public static IEnumerator CoOffset(this Material self, int propertyId, Vector2 target, float duration, Func<float, float> easer = null)
            => self.CoOffset(propertyId, target, Yield.Time(duration, easer));

        public static IEnumerator CoOffset(this Material self, int propertyId, Vector2 start, Vector2 target, float duration, Func<float, float> easer = null)
            => self.CoOffset(propertyId, start, target, Yield.Time(duration, easer));
        #endregion

        #region Vector
        public static IEnumerator CoVector(this Material self, int propertyId, Vector4 target)
            => Yield.Into(target, v => self.SetVector(propertyId, v));

        public static IEnumerator CoVector(this Material self, int propertyId, Vector4 target, IEnumerator<float> timer)
            => Yield.ValueTo(() => self.GetVector(propertyId), target, v => self.SetVector(propertyId, v), timer);

        public static IEnumerator CoVector(this Material self, int propertyId, Vector4 start, Vector4 target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, v => self.SetVector(propertyId, v), timer);

        public static IEnumerator CoVector(this Material self, int propertyId, Vector4 target, float duration, Func<float, float> easer = null)
            => self.CoVector(propertyId, target, Yield.Time(duration, easer));

        public static IEnumerator CoVector(this Material self, int propertyId, Vector4 start, Vector4 target, float duration, Func<float, float> easer = null)
            => self.CoVector(propertyId, start, target, Yield.Time(duration, easer));
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
