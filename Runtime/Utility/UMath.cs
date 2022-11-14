using System;

namespace Common.Coroutines
{
    public static class UMath
    {
        public static int Lerp(int a, int b, float t)
        {
            return a + (int)Math.Round((b - a) * t);
        }
    }
}
