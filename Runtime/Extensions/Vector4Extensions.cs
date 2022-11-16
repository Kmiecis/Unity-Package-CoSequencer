using UnityEngine;

namespace Common.Coroutines
{
    internal static class Vector4Extensions
    {
        public static Vector4 WithX(this Vector4 self, float value)
            => new Vector4(value, self.y, self.z, self.w);

        public static Vector4 WithY(this Vector4 self, float value)
            => new Vector4(self.x, value, self.z, self.w);

        public static Vector4 WithZ(this Vector4 self, float value)
            => new Vector4(self.x, self.y, value, self.w);

        public static Vector4 WithW(this Vector4 self, float value)
            => new Vector4(self.x, self.y, self.z, value);
    }
}
