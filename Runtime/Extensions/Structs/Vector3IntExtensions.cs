using UnityEngine;

namespace Common.Coroutines
{
    internal static class Vector3IntExtensions
    {
        public static Vector3Int WithX(this Vector3Int self, int value)
            => new Vector3Int(value, self.y, self.z);

        public static Vector3Int WithY(this Vector3Int self, int value)
            => new Vector3Int(self.x, value, self.z);

        public static Vector3Int WithZ(this Vector3Int self, int value)
            => new Vector3Int(self.x, self.y, value);
    }
}
