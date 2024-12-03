using UnityEngine;

namespace Common.Coroutines
{
    internal static class Vector3IntExtensions
    {
        public static Vector3Int WithX(this Vector3Int self, int value)
        {
            self.x = value;
            return self;
        }

        public static Vector3Int WithY(this Vector3Int self, int value)
        {
            self.y = value;
            return self;
        }

        public static Vector3Int WithZ(this Vector3Int self, int value)
        {
            self.z = value;
            return self;
        }
    }
}
