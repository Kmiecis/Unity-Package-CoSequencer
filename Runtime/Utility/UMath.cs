using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Coroutines
{
    internal static class UMath
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Lerp(float a, float b, float t)
        {
            return a + (b - a) * t;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Lerp(int a, int b, float t)
        {
            return a + (int)Math.Round((b - a) * t);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Lerp(Vector2 a, Vector2 b, float t)
        {
            return a + (b - a) * t;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Lerp(Vector3 a, Vector3 b, float t)
        {
            return a + (b - a) * t;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Lerp(Vector4 a, Vector4 b, float t)
        {
            return a + (b - a) * t;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color Lerp(Color a, Color b, float t)
        {
            return a + (b - a) * t;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion Slerp(Quaternion a, Quaternion b, float t)
        {
            return Quaternion.SlerpUnclamped(a, b, t);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Rect Lerp(Rect a, Rect b, float t)
        {
            return new Rect(
                Lerp(a.x, b.x, t), Lerp(a.y, b.y, t),
                Lerp(a.width, b.width, t), Lerp(a.height, b.height, t)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Square(float f)
        {
            return f * f;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Cubic(float f)
        {
            return f * f * f;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Quart(float f)
        {
            return f * f * f * f;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Quint(float f)
        {
            return f * f * f * f * f;
        }
    }
}
