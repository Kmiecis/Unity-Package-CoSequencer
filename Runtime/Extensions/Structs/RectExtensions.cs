using UnityEngine;

namespace Common.Coroutines
{
    internal static class RectExtensions
    {
        public static Rect WithX(this Rect self, float value)
            => new Rect(value, self.y, self.width, self.height);

        public static Rect WithY(this Rect self, float value)
            => new Rect(self.x, value, self.width, self.height);

        public static Rect WithWidth(this Rect self, float value)
            => new Rect(self.x, self.y, value, self.height);

        public static Rect WithHeight(this Rect self, float value)
            => new Rect(self.x, self.y, self.width, value);
    }
}
