using UnityEngine;

namespace Common.Coroutines
{
    internal static class ColorExtensions
    {
        public static Color WithR(this Color self, float value)
        {
            self.r = value;
            return self;
        }

        public static Color WithG(this Color self, float value)
        {
            self.g = value;
            return self;
        }

        public static Color WithB(this Color self, float value)
        {
            self.b = value;
            return self;
        }

        public static Color WithA(this Color self, float value)
        {
            self.a = value;
            return self;
        }
    }
}
