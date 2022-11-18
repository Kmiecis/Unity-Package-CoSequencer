using UnityEngine;

namespace Common.Coroutines
{
    internal static class Vector2IntExtensions
    {
        public static Vector2Int WithX(this Vector2Int self, int value)
            => new Vector2Int(value, self.y);

        public static Vector2Int WithY(this Vector2Int self, int value)
            => new Vector2Int(self.x, value);
    }
}
