using UnityEngine;

namespace Common.Coroutines
{
    internal static class StringExtensions
    {
        public static string Substring(this string self, float t)
            => self.Substring(0, Mathf.CeilToInt(self.Length * t));
    }
}