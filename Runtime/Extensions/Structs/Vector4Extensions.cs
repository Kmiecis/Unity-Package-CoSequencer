using UnityEngine;

namespace Common.Coroutines
{
    internal static class Vector4Extensions
    {
        public static Vector4 WithX(this Vector4 self, float value)
        {
            self.x = value;
            return self;
        }

        public static Vector4 WithY(this Vector4 self, float value)
        {
            self.y = value;
            return self;
        }

        public static Vector4 WithZ(this Vector4 self, float value)
        {
            self.z = value;
            return self;
        }

        public static Vector4 WithW(this Vector4 self, float value)
        {
            self.w = value;
            return self;
        }
    }
}
