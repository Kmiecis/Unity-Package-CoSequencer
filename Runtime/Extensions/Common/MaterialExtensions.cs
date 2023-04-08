using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines
{
    public static class MaterialExtensions
    {
        public static IEnumerator CoColor(this Material self, Color target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetColor, self.SetColor, target, duration, easer);

        public static IEnumerator CoColor(this Material self, Color target, int propertyId, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(() => self.GetColor(propertyId), c => self.SetColor(propertyId, c), target, duration, easer);

        public static IEnumerator CoFade(this Material self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetFade, self.SetFade, target, duration, easer);

        public static IEnumerator CoFade(this Material self, float target, int propertyId, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(() => self.GetFade(propertyId), f => self.SetFade(propertyId, f), target, duration, easer);

        public static IEnumerator CoGradient(this Material self, Gradient target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(target.Evaluate, self.SetColor, duration, easer);

        public static IEnumerator CoGradient(this Material self, Gradient target, int propertyId, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(target.Evaluate, c => self.SetColor(propertyId, c), duration, easer);

        public static IEnumerator CoFloat(this Material self, float target, int propertyId, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(() => self.GetFloat(propertyId), f => self.SetFloat(propertyId, f), target, duration, easer);

        public static IEnumerator CoTiling(this Material self, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetTextureScale, self.SetTextureScale, target, duration, easer);

        public static IEnumerator CoTiling(this Material self, Vector2 target, int propertyId, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(() => self.GetTextureScale(propertyId), v => self.SetTextureScale(propertyId, v), target, duration, easer);

        public static IEnumerator CoOffset(this Material self, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetTextureOffset, self.SetTextureOffset, target, duration, easer);

        public static IEnumerator CoOffset(this Material self, Vector2 target, int propertyId, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(() => self.GetTextureOffset(propertyId), v => self.SetTextureOffset(propertyId, v), target, duration, easer);

        public static IEnumerator CoVector(this Material self, Vector4 target, int propertyId, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(() => self.GetVector(propertyId), v => self.SetVector(propertyId, v), target, duration, easer);
    }

    internal static class InternalMaterialExtensions
    {
        #region Color
        public static Color GetColor(this Material self)
            => self.color;

        public static void SetColor(this Material self, Color value)
            => self.color = value;

        public static float GetFade(this Material self)
            => self.color.a;

        public static void SetFade(this Material self, float value)
            => self.color = self.color.WithA(value);

        public static float GetFade(this Material self, int propertyId)
            => self.GetColor(propertyId).a;

        public static void SetFade(this Material self, int propertyId, float value)
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
