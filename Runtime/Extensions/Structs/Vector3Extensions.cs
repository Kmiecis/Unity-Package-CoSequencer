using UnityEngine;

namespace Common.Coroutines
{
    internal static class Vector3Extensions
    {
        public static Vector2 XY(this Vector3 self)
            => new Vector2(self.x, self.y);

        public static Vector2 XZ(this Vector3 self)
            => new Vector2(self.x, self.z);

        public static Vector2 YZ(this Vector3 self)
            => new Vector2(self.y, self.z);

        public static Vector3 WithX(this Vector3 self, float value)
            => new Vector3(value, self.y, self.z);

        public static Vector3 WithY(this Vector3 self, float value)
            => new Vector3(self.x, value, self.z);

        public static Vector3 WithZ(this Vector3 self, float value)
            => new Vector3(self.x, self.y, value);

        public static Vector3 WithXY(this Vector3 self, Vector2 value)
            => new Vector3(value.x, value.y, self.z);

        public static Vector3 WithXZ(this Vector3 self, Vector2 value)
            => new Vector3(value.x, self.y, value.y);

        public static Vector3 WithYZ(this Vector3 self, Vector2 value)
            => new Vector3(self.x, value.x, value.y);
    }
}
