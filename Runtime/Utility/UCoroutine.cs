using System.Collections;
using System.Collections.Generic;
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

        public static T SafeUpdate<T>(ref IEnumerator<T> coroutine)
        {
            if (coroutine != null)
            {
                if (coroutine.MoveNext())
                {
                    return coroutine.Current;
                }
                coroutine = null;
            }
            return default;
        }
    }
}