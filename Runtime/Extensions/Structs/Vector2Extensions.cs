using UnityEngine;

namespace Common.Coroutines
{
    internal static class Vector2Extensions
    {
        public static Vector2 WithX(this Vector2 self, float value)
            => new Vector2(value, self.y);

        public static Vector2 WithY(this Vector2 self, float value)
            => new Vector2(self.x, value);
    }
}
