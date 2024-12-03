using UnityEngine;

namespace Common.Coroutines
{
    internal static class Vector2IntExtensions
    {
        public static Vector2Int WithX(this Vector2Int self, int value)
        {
            self.x = value;
            return self;
        }

        public static Vector2Int WithY(this Vector2Int self, int value)
        {
            self.y = value;
            return self;
        }
    }
}
