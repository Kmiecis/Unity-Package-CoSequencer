using System.Collections;
using UnityEngine;

namespace Common.Coroutines
{
    public static class UCoroutine
    {
        public static void SafeStop(ref Coroutine coroutine, MonoBehaviour target)
        {
            if (coroutine != null)
            {
                coroutine.Stop(target);
                coroutine = null;
            }
        }

        public static void SafeUpdate(ref IEnumerator coroutine)
        {
            if (coroutine != null && !coroutine.MoveNext())
            {
                coroutine = null;
            }
        }
    }
}