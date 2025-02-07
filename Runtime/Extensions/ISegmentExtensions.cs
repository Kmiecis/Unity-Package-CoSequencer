using UnityEngine;

namespace Common.Coroutines
{
    public static class ISegmentExtensions
    {
        public static Coroutine Start(this ISegment self, MonoBehaviour target)
        {
            return target.StartCoroutine(self.Build());
        }

        public static Coroutine SafeStart(this ISegment self, MonoBehaviour target)
        {
            if (target.gameObject.activeInHierarchy)
            {
                return Start(self, target);
            }
            return null;
        }
    }
}