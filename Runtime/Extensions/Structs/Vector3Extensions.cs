using UnityEngine;

namespace Common.Coroutines
{
    internal static class Vector3Extensions
    {
        public static Vector3 WithX(this Vector3 self, float value)
            => new Vector3(value, self.y, self.z);

        public static Vector3 WithY(this Vector3 self, float value)
            => new Vector3(self.x, value, self.z);

        public static Vector3 WithZ(this Vector3 self, float value)
            => new Vector3(self.x, self.y, value);
    }
}
