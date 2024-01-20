using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Coroutines
{
    public static class Easers
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Linear(float f)
        {
            return f;
        }

        public static float Step(float f)
        {
            return f < 0.5f ? 0.0f : 1.0f;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float SmoothStep(float f)
        {
            return f * f * (3.0f - 2.0f * f);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float SmootherStep(float f)
        {
            return f * f * f * (f * (f * 6.0f - 15.0f) + 10.0f);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float InSine(float f)
        {
            return 1.0f - Mathf.Cos(f * Mathf.PI * 0.5f);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float OutSine(float f)
        {
            return Mathf.Sin(f * Mathf.PI * 0.5f);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float InOutSine(float f)
        {
            return -(Mathf.Cos(Mathf.PI * f) - 1) * 0.5f;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float InQuad(float f)
        {
            return f * f;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float OutQuad(float f)
        {
            return 1.0f - UMath.Square(1.0f - f);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float InOutQuad(float f)
        {
            return f < 0.5f
                ? (2.0f * f * f)
                : (1.0f - UMath.Square(-2.0f * f + 2.0f) * 0.5f);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float InCubic(float f)
        {
            return f * f * f;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float OutCubic(float f)
        {
            return 1.0f - UMath.Cubic(1.0f - f);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float InOutCubic(float f)
        {
            return f < 0.5f
                ? (4.0f * f * f * f)
                : (1.0f - UMath.Cubic(-2.0f * f + 2.0f) * 0.5f);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float InQuart(float f)
        {
            return f * f * f * f;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float OutQuart(float f)
        {
            return 1.0f - UMath.Quart(1.0f - f);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float InOutQuart(float f)
        {
            return f < 0.5f
                ? (8.0f * f * f * f * f)
                : (1.0f - UMath.Quart(-2.0f * f + 2.0f) * 0.5f);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float InQuint(float f)
        {
            return f * f * f * f * f;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float OutQuint(float f)
        {
            return 1.0f - UMath.Quint(1.0f - f);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float InOutQuint(float f)
        {
            return f < 0.5f
                ? (16.0f * f * f * f * f * f)
                : (1.0f - UMath.Quint(-2.0f * f + 2.0f) * 0.5f);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float InExpo(float f)
        {
            return f == 0.0f ? 0.0f : Mathf.Pow(2.0f, 10.0f * f - 10.0f);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float OutExpo(float f)
        {
            return f == 1.0f ? 1.0f : 1.0f - Mathf.Pow(2.0f, -10.0f * f);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float InOutExpo(float f)
        {
            return f < 0.5f
                ? f == 0.0f ? 0.0f : (Mathf.Pow(2.0f, 20.0f * f - 10.0f) * 0.5f)
                : f == 1.0f ? 1.0f : ((2.0f - Mathf.Pow(2.0f, -20.0f * f + 10.0f)) * 0.5f);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float InCirc(float f)
        {
            return 1.0f - Mathf.Sqrt(1.0f - f * f);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float OutCirc(float f)
        {
            return Mathf.Sqrt(1.0f - UMath.Square(f - 1.0f));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float InOutCirc(float f)
        {
            return f < 0.5f
                ? (1.0f - Mathf.Sqrt(1.0f - 4.0f * f * f)) * 0.5f
                : (Mathf.Sqrt(1.0f - UMath.Square(-2.0f * f + 2.0f)) + 1.0f) * 0.5f;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float InBack(float f)
        {
            const float C1 = 1.70158f;
            const float C2 = C1 + 1.0f;
            return C2 * f * f * f - C1 * f * f;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float OutBack(float f)
        {
            const float C1 = 1.70158f;
            const float C2 = C1 + 1.0f;
            return 1.0f + C2 * UMath.Cubic(f - 1.0f) + C1 * UMath.Square(f - 1.0f);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float InOutBack(float f)
        {
            const float C1 = 1.70158f;
            const float C2 = C1 * 1.525f;
            return f < 0.5f
                ? (4.0f * f * f * ((C2 + 1.0f) * 2.0f * f - C2)) * 0.5f
                : (UMath.Square(2.0f * f - 2.0f) * ((C2 + 1.0f) * (f * 2.0f - 2.0f) + C2) + 2.0f) * 0.5f;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float InElastic(float f)
        {
            const float C1 = (2.0f * Mathf.PI) * (1.0f / 3.0f);
            return f == 0.0f ? 0.0f
                : f == 1.0f ? 1.0f
                : -Mathf.Pow(2.0f, 10.0f * f - 10.0f) * Mathf.Sin((f * 10.0f - 10.75f) * C1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float OutElastic(float f)
        {
            const float C1 = (2.0f * Mathf.PI) * (1.0f / 3.0f);
            return f == 0.0f ? 0.0f
                : f == 1.0f ? 1.0f
                : Mathf.Pow(2.0f, -10.0f * f) * Mathf.Sin((f * 10.0f - 0.75f) * C1) + 1.0f;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float InOutElastic(float f)
        {
            const float C1 = (2.0f * Mathf.PI) * (1.0f / 4.5f);
            return f < 0.5f
                ? f == 0.0f ? 0.0f : -(Mathf.Pow(2.0f, 20.0f * f - 10.0f) * Mathf.Sin((20.0f * f - 11.125f) * C1)) * 0.5f
                : f == 1.0f ? 1.0f : (Mathf.Pow(2.0f, -20.0f * f + 10.0f) * Mathf.Sin((20.0f * f - 11.125f) * C1)) * 0.5f + 1.0f;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float InBounce(float f)
        {
            return 1.0f - OutBounce(1.0f - f);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float OutBounce(float f)
        {
            const float N1 = 7.5625f;
            const float D1 = 2.75f;
            if (f < 1.0f / D1)
                return N1 * f * f;
            if (f < 2.0f / D1)
                return N1 * (f -= 1.5f / D1) * f + 0.75f;
            if (f < 2.5f / D1)
                return N1 * (f -= 2.25f / D1) * f + 0.9375f;
            return N1 * (f -= 2.625f / D1) * f + 0.984375f;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float InOutBounce(float f)
        {
            return f < 0.5f
                ? (1.0f - OutBounce(1.0f - 2.0f * f)) * 0.5f
                : (1.0f + OutBounce(2.0f * f - 1.0f)) * 0.5f;
        }
    }
}
