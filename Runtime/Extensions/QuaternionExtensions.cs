using UnityEngine;

namespace Common.Coroutines
{
    internal static class QuaternionExtensions
    {
        public static Quaternion WithAngleX(this Quaternion self, float value)
            => Quaternion.Euler(self.eulerAngles.WithX(value));

        public static Quaternion WithAngleY(this Quaternion self, float value)
            => Quaternion.Euler(self.eulerAngles.WithY(value));

        public static Quaternion WithAngleZ(this Quaternion self, float value)
            => Quaternion.Euler(self.eulerAngles.WithZ(value));
    }
}
