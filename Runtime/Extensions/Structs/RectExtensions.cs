using UnityEngine;

namespace Common.Coroutines
{
    internal static class RectExtensions
    {
        public static Rect WithX(this Rect self, float value)
        {
            self.x = value;
            return self;
        }

        public static Rect WithY(this Rect self, float value)
        {
            self.y = value;
            return self;
        }

        public static Rect WithWidth(this Rect self, float value)
        {
            self.width = value;
            return self;
        }

        public static Rect WithHeight(this Rect self, float value)
        {
            self.height = value;
            return self;
        }
    }
}
