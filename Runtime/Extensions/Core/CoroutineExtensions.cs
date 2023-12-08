using UnityEngine;

namespace Common.Coroutines
{
    public static class CoroutineExtensions
    {
        public static void Stop(this Coroutine self, MonoBehaviour target)
        {
            if (self != null)
            {
                target.StopCoroutine(self);
            }
        }
    }
}
