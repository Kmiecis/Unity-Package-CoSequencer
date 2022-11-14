using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Common.Coroutines
{
    public static partial class UCoroutine
    {
        private static float DefaultEaser(float t) => t;

        public static IEnumerator<float> YieldTime(float duration)
        {
            float t = 0.0f;

            while (t < duration)
            {
                yield return t;

                t += Time.deltaTime;
            }

            yield return duration;
        }

        public static IEnumerator<float> YieldRealtime(float duration)
        {
            float t = 0.0f;

            while (t < duration)
            {
                yield return t;

                t += Time.unscaledDeltaTime;
            }

            yield return duration;
        }

        public static IEnumerator<float> YieldTimeNormalized(float duration)
        {
            float t = 0.0f;
            float n = 1.0f / duration;

            while (t < 1.0f)
            {
                yield return t;

                t += n * Time.deltaTime;
            }

            yield return 1.0f;
        }

        public static IEnumerator<float> YieldRealtimeNormalized(float duration)
        {
            float t = 0.0f;
            float n = 1.0f / duration;

            while (t < 1.0f)
            {
                yield return t;

                t += n * Time.unscaledDeltaTime;
            }

            yield return 1.0f;
        }

        public static IEnumerator<float> YieldTimeEased(float duration, Func<float, float> easer)
        {
            return YieldTimeNormalized(duration)
                .Into(easer);
        }

        public static IEnumerator<float> YieldRealtimeEased(float duration, Func<float, float> easer)
        {
            return YieldRealtimeNormalized(duration)
                .Into(easer);
        }

        public static IEnumerator<T> YieldAnyValue<T>(T start, T target, float duration, Func<T, T, float, T> parser, Func<float, float> easer)
            where T : struct
        {
            return YieldTimeEased(duration, easer)
                .Into(t => parser(start, target, t));
        }

        public static IEnumerator<T> YieldAnyValue<T>(T start, T target, float duration, Func<T, T, float, T> parser)
            where T : struct
        {
            return YieldTimeNormalized(duration)
                .Into(t => parser(start, target, t));
        }

        public static IEnumerator<int> YieldValue(int start, int target, float duration, Func<float, float> easer = null)
        {
            return YieldAnyValue(start, target, duration, UMath.Lerp, easer ?? DefaultEaser);
        }

        public static IEnumerator<float> YieldValue(float start, float target, float duration, Func<float, float> easer = null)
        {
            return YieldAnyValue(start, target, duration, Mathf.Lerp, easer ?? DefaultEaser);
        }

        public static IEnumerator<Vector2> YieldValue(Vector2 start, Vector2 target, float duration, Func<float, float> easer = null)
        {
            return YieldAnyValue(start, target, duration, Vector2.Lerp, easer ?? DefaultEaser);
        }

        public static IEnumerator<Vector3> YieldValue(Vector3 start, Vector3 target, float duration, Func<float, float> easer = null)
        {
            return YieldAnyValue(start, target, duration, Vector3.Lerp, easer ?? DefaultEaser);
        }

        public static IEnumerator<Vector4> YieldValue(Vector4 start, Vector4 target, float duration, Func<float, float> easer = null)
        {
            return YieldAnyValue(start, target, duration, Vector4.Lerp, easer ?? DefaultEaser);
        }

        public static IEnumerator<Quaternion> YieldValue(Quaternion start, Quaternion target, float duration, Func<float, float> easer = null)
        {
            return YieldAnyValue(start, target, duration, Quaternion.Slerp, easer ?? DefaultEaser);
        }

        public static IEnumerator YieldAnyValueTo<T>(Func<T> getter, Action<T> setter, T target, float duration, Func<T, T, float, T> parser, Func<float, float> easer)
            where T : struct
        {
            var coroutine = YieldAnyValue(getter(), target, duration, parser, easer);
            while (coroutine.MoveNext())
            {
                setter(coroutine.Current);
                yield return null;
            }
        }

        public static IEnumerator YieldAnyValueTo<T>(Func<T> getter, Action<T> setter, T target, float duration, Func<T, T, float, T> parser)
            where T : struct
        {
            var coroutine = YieldAnyValue(getter(), target, duration, parser);
            while (coroutine.MoveNext())
            {
                setter(coroutine.Current);
                yield return null;
            }
        }

        public static IEnumerator YieldValueTo(Func<int> getter, Action<int> setter, int target, float duration, Func<float, float> easer = null)
        {
            return YieldAnyValueTo(getter, setter, target, duration, UMath.Lerp, easer ?? DefaultEaser);
        }

        public static IEnumerator YieldValueTo(Func<float> getter, Action<float> setter, float target, float duration, Func<float, float> easer = null)
        {
            return YieldAnyValueTo(getter, setter, target, duration, Mathf.Lerp, easer ?? DefaultEaser);
        }

        public static IEnumerator YieldValueTo(Func<Vector2> getter, Action<Vector2> setter, Vector2 target, float duration, Func<float, float> easer = null)
        {
            return YieldAnyValueTo(getter, setter, target, duration, Vector2.Lerp, easer ?? DefaultEaser);
        }

        public static IEnumerator YieldValueTo(Func<Vector3> getter, Action<Vector3> setter, Vector3 target, float duration, Func<float, float> easer = null)
        {
            return YieldAnyValueTo(getter, setter, target, duration, Vector3.Lerp, easer ?? DefaultEaser);
        }

        public static IEnumerator YieldValueTo(Func<Vector4> getter, Action<Vector4> setter, Vector4 target, float duration, Func<float, float> easer = null)
        {
            return YieldAnyValueTo(getter, setter, target, duration, Vector4.Lerp, easer ?? DefaultEaser);
        }

        public static IEnumerator YieldValueTo(Func<Quaternion> getter, Action<Quaternion> setter, Quaternion target, float duration, Func<float, float> easer = null)
        {
            return YieldAnyValueTo(getter, setter, target, duration, Quaternion.Slerp, easer ?? DefaultEaser);
        }
    }
}
