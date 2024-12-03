using UnityEngine;

namespace Common.Coroutines
{
    internal static class Vector2Extensions
    {
        public static Vector2 WithX(this Vector2 self, float value)
        {
            self.x = value;
            return self;
        }

        public static Vector2 WithY(this Vector2 self, float value)
        {
            self.y = value;
            return self;
        }
    }
}
