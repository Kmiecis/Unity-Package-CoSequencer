using System.Collections.Generic;
using UnityEngine;

namespace Common.Coroutines
{
    public static partial class UCoroutine
    {
        public static IEnumerator<float> YieldTime(float duration)
        {
            float t = 0.0f;

            yield return 0.0f;

            while (t < duration)
            {
                t += Time.deltaTime;

                yield return t;
            }

            yield return duration;
        }

        public static IEnumerator<float> YieldRealtime(float duration)
        {
            float t = 0.0f;

            yield return 0.0f;

            while (t < duration)
            {
                t += Time.unscaledDeltaTime;

                yield return t;
            }

            yield return duration;
        }

        public static IEnumerator<float> YieldTimeNormalized(float duration)
        {
            float t = 0.0f;
            float n = 1.0f / duration;

            yield return 0.0f;

            while (t < 1.0f)
            {
                t += n * Time.deltaTime;

                yield return t;
            }

            yield return 1.0f;
        }

        public static IEnumerator<float> YieldRealtimeNormalized(float duration)
        {
            float t = 0.0f;
            float n = 1.0f / duration;

            yield return 0.0f;

            while (t < 1.0f)
            {
                t += n * Time.unscaledDeltaTime;

                yield return t;
            }

            yield return 1.0f;
        }
    }
}
