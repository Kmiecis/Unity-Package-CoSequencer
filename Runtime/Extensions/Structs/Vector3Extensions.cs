using UnityEngine;

namespace Common.Coroutines
{
    internal static class Vector3Extensions
    {
        public static Vector2 XY(this Vector3 self)
        {
            Vector2 r;
            r.x = self.x;
            r.y = self.y;
            return r;
        }

        public static Vector2 XZ(this Vector3 self)
        {
            Vector2 r;
            r.x = self.x;
            r.y = self.z;
            return r;
        }

        public static Vector2 YZ(this Vector3 self)
        {
            Vector2 r;
            r.x = self.y;
            r.y = self.z;
            return r;
        }

        public static Vector3 WithX(this Vector3 self, float value)
        {
            self.x = value;
            return self;
        }

        public static Vector3 WithY(this Vector3 self, float value)
        {
            self.y = value;
            return self;
        }

        public static Vector3 WithZ(this Vector3 self, float value)
        {
            self.z = value;
            return self;
        }

        public static Vector3 WithXY(this Vector3 self, Vector2 value)
        {
            self.x = value.x;
            self.y = value.y;
            return self;
        }

        public static Vector3 WithXZ(this Vector3 self, Vector2 value)
        {
            self.x = value.x;
            self.z = value.y;
            return self;
        }

        public static Vector3 WithYZ(this Vector3 self, Vector2 value)
        {
            self.y = value.x;
            self.z = value.y;
            return self;
        }
    }
}
