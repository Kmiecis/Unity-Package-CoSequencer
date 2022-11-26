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
            return a + Mathf.RoundToInt((b - a) * t);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Lerp(Vector2 a, Vector2 b, float t)
        {
            return new Vector2(
                Lerp(a.x, b.x, t),
                Lerp(a.y, b.y, t)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Lerp(Vector2Int a, Vector2Int b, float t)
        {
            return new Vector2Int(
                Lerp(a.x, b.x, t),
                Lerp(a.y, b.y, t)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Lerp(Vector3 a, Vector3 b, float t)
        {
            return new Vector3(
                Lerp(a.x, b.x, t),
                Lerp(a.y, b.y, t),
                Lerp(a.z, b.z, t)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Lerp(Vector3Int a, Vector3Int b, float t)
        {
            return new Vector3Int(
                Lerp(a.x, b.x, t),
                Lerp(a.y, b.y, t),
                Lerp(a.z, b.z, t)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Lerp(Vector4 a, Vector4 b, float t)
        {
            return new Vector4(
                Lerp(a.x, b.x, t),
                Lerp(a.y, b.y, t),
                Lerp(a.z, b.z, t),
                Lerp(a.w, b.w, t)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color Lerp(Color a, Color b, float t)
        {
            return new Color(
                Lerp(a.r, b.r, t),
                Lerp(a.g, b.g, t),
                Lerp(a.b, b.b, t),
                Lerp(a.a, b.a, t)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion Lerp(Quaternion a, Quaternion b, float t)
        {
            return Quaternion.SlerpUnclamped(a, b, t);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Rect Lerp(Rect a, Rect b, float t)
        {
            return new Rect(
                Lerp(a.x, b.x, t),
                Lerp(a.y, b.y, t),
                Lerp(a.width, b.width, t),
                Lerp(a.height, b.height, t)
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
