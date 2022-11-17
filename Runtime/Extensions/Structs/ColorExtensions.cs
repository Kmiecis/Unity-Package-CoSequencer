using UnityEngine;

namespace Common.Coroutines
{
    internal static class ColorExtensions
    {
        public static Color WithR(this Color self, float value)
            => new Color(value, self.g, self.b, self.a);

        public static Color WithG(this Color self, float value)
            => new Color(self.r, value, self.b, self.a);

        public static Color WithB(this Color self, float value)
            => new Color(self.r, self.g, value, self.a);

        public static Color WithA(this Color self, float value)
            => new Color(self.r, self.g, self.b, value);
    }
}
