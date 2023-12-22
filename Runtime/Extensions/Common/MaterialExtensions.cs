using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines
{
    public static class MaterialExtensions
    {
        public static IEnumerator CoColor(this Material self, Color target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetColor, self.SetColor, target, UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoColor(this Material self, Color target, int propertyId, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(() => self.GetColor(propertyId), c => self.SetColor(propertyId, c), target, UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoFade(this Material self, float target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetColorA, self.SetColorA, target, UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoFade(this Material self, float target, int propertyId, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(() => self.GetColorA(propertyId), f => self.SetColorA(propertyId, f), target, UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoGradient(this Material self, Gradient target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(target.Evaluate, self.SetColor, UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoGradient(this Material self, Gradient target, float from, float to, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(time => target.Evaluate(Mathf.Lerp(from, to, time)), self.SetColor, UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoGradient(this Material self, Gradient target, int propertyId, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(target.Evaluate, c => self.SetColor(propertyId, c), UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoGradient(this Material self, Gradient target, int propertyId, float from, float to, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(time => target.Evaluate(Mathf.Lerp(from, to, time)), c => self.SetColor(propertyId, c), UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoFloat(this Material self, float target, int propertyId, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(() => self.GetFloat(propertyId), f => self.SetFloat(propertyId, f), target, UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoTiling(this Material self, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetTextureScale, self.SetTextureScale, target, UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoTiling(this Material self, Vector2 target, int propertyId, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(() => self.GetTextureScale(propertyId), v => self.SetTextureScale(propertyId, v), target, UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoOffset(this Material self, Vector2 target, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(self.GetTextureOffset, self.SetTextureOffset, target, UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoOffset(this Material self, Vector2 target, int propertyId, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(() => self.GetTextureOffset(propertyId), v => self.SetTextureOffset(propertyId, v), target, UCoroutine.YieldTimeEased(duration, easer));

        public static IEnumerator CoVector(this Material self, Vector4 target, int propertyId, float duration, Func<float, float> easer = null)
            => UCoroutine.YieldValueTo(() => self.GetVector(propertyId), v => self.SetVector(propertyId, v), target, UCoroutine.YieldTimeEased(duration, easer));
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
