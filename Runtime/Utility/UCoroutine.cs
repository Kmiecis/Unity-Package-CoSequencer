using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Common.Coroutines
{
    public static partial class UCoroutine
    {
        #region Core
        public static IEnumerator Yield()
        {
            yield return null;
        }

        public static IEnumerator Yield(YieldInstruction yield)
        {
            yield return yield;
        }

        public static IEnumerator Yield(Coroutine coroutine)
        {
            yield return coroutine;
        }

        public static IEnumerator Yield(Action callback)
        {
            callback();
            yield return null;
        }

        public static IEnumerator<T> Yield<T>(Func<T> provider)
        {
            yield return provider();
        }

        public static IEnumerator Yield(Func<IEnumerator> provider)
        {
            var coroutine = provider();
            while (coroutine.MoveNext())
            {
                yield return coroutine.Current;
            }
        }

        public static IEnumerator<T> Yield<T>(Func<IEnumerator<T>> provider)
        {
            var coroutine = provider();
            while (coroutine.MoveNext())
            {
                yield return coroutine.Current;
            }
        }

        public static IEnumerator YieldInto<T>(IEnumerator<T> coroutine, Action<T> consumer)
        {
            while (coroutine.MoveNext())
            {
                consumer(coroutine.Current);
                yield return null;
            }
        }

        public static IEnumerator YieldInto<T>(Func<IEnumerator<T>> provider, Action<T> consumer)
        {
            var coroutine = provider();
            while (coroutine.MoveNext())
            {
                consumer(coroutine.Current);
                yield return null;
            }
        }

        public static IEnumerator<U> YieldInto<T, U>(IEnumerator<T> coroutine, Func<T, U> parser)
        {
            while (coroutine.MoveNext())
            {
                yield return parser(coroutine.Current);
            }
        }

        public static IEnumerator<U> YieldInto<T, U>(Func<IEnumerator<T>> provider, Func<T, U> parser)
        {
            var coroutine = provider();
            while (coroutine.MoveNext())
            {
                yield return parser(coroutine.Current);
            }
        }

        public static IEnumerator YieldInfinitely(Func<IEnumerator> provider)
        {
            while (true)
            {
                var coroutine = provider();
                while (coroutine.MoveNext())
                {
                    yield return coroutine.Current;
                }
            }
        }

        public static IEnumerator<T> YieldInfinitely<T>(Func<IEnumerator<T>> provider)
        {
            while (true)
            {
                var coroutine = provider();
                while (coroutine.MoveNext())
                {
                    yield return coroutine.Current;
                }
            }
        }

        public static IEnumerator YieldSequentially(IEnumerator first, IEnumerator second)
        {
            while (first.MoveNext())
            {
                yield return first.Current;
            }
            while (second.MoveNext())
            {
                yield return second.Current;
            }
        }

        public static IEnumerator<T> YieldSequentially<T>(IEnumerator<T> first, IEnumerator<T> second)
        {
            while (first.MoveNext())
            {
                yield return first.Current;
            }
            while (second.MoveNext())
            {
                yield return second.Current;
            }
        }

        public static IEnumerator YieldSequentially(params IEnumerator[] coroutines)
        {
            for (int i = 0; i < coroutines.Length; ++i)
            {
                var coroutine = coroutines[i];
                while (coroutine.MoveNext())
                {
                    yield return coroutine.Current;
                }
            }
        }

        public static IEnumerator<T> YieldSequentially<T>(params IEnumerator<T>[] coroutines)
        {
            for (int i = 0; i < coroutines.Length; ++i)
            {
                var coroutine = coroutines[i];
                while (coroutine.MoveNext())
                {
                    yield return coroutine.Current;
                }
            }
        }

        public static IEnumerator YieldParallel(IEnumerator first, IEnumerator second)
        {
            while (first.MoveNext() | second.MoveNext())
            {
                yield return null;
            }
        }

        public static IEnumerator YieldParallel(params IEnumerator[] coroutines)
        {
            bool running;
            do
            {
                running = false;

                for (int i = 0; i < coroutines.Length; ++i)
                {
                    var coroutine = coroutines[i];
                    running |= coroutine.MoveNext();
                }

                yield return null;
            }
            while (running);
        }
        #endregion

        #region Operations
        public static IEnumerator<float> YieldDeltaTime(float duration)
        {
            var deltaTime = Time.deltaTime;

            while (duration > deltaTime)
            {
                yield return deltaTime;

                duration -= deltaTime;
                deltaTime = Time.deltaTime;
            }

            yield return duration;
        }

        public static IEnumerator<float> YieldDeltaRealtime(float duration)
        {
            var deltaTime = Time.unscaledDeltaTime;

            while (duration > deltaTime)
            {
                yield return deltaTime;

                duration -= deltaTime;
                deltaTime = Time.unscaledDeltaTime;
            }

            yield return duration;
        }

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
        #endregion

        #region Ints
        public static IEnumerator<int> YieldValue(int start, int target, float duration, Func<float, float> easer = null)
        {
            return YieldAnyValue(start, target, duration, UMath.Lerp, easer ?? EaseMath.Linear);
        }

        public static IEnumerator<int> YieldValue(int start, int target, float duration, EEase ease)
        {
            return YieldValue(start, target, duration, ease.ToEaser());
        }

        public static IEnumerator<int> YieldValue(int start, int target, float duration, AnimationCurve curve)
        {
            return YieldValue(start, target, duration, curve.Evaluate);
        }

        public static IEnumerator YieldValueTo(Func<int> getter, Action<int> setter, int target, float duration, Func<float, float> easer = null)
        {
            return YieldAnyValueTo(getter, setter, target, duration, UMath.Lerp, easer ?? EaseMath.Linear);
        }

        public static IEnumerator YieldValueTo(Func<int> getter, Action<int> setter, int target, float duration, EEase ease)
        {
            return YieldValueTo(getter, setter, target, duration, ease.ToEaser());
        }

        public static IEnumerator YieldValueTo(Func<int> getter, Action<int> setter, int target, float duration, AnimationCurve curve)
        {
            return YieldValueTo(getter, setter, target, duration, curve.Evaluate);
        }
        #endregion

        #region Floats
        public static IEnumerator<float> YieldValue(float start, float target, float duration, Func<float, float> easer = null)
        {
            return YieldAnyValue(start, target, duration, UMath.Lerp, easer ?? EaseMath.Linear);
        }

        public static IEnumerator<float> YieldValue(float start, float target, float duration, EEase ease)
        {
            return YieldValue(start, target, duration, ease.ToEaser());
        }

        public static IEnumerator<float> YieldValue(float start, float target, float duration, AnimationCurve curve)
        {
            return YieldValue(start, target, duration, curve.Evaluate);
        }

        public static IEnumerator YieldValueTo(Func<float> getter, Action<float> setter, float target, float duration, Func<float, float> easer = null)
        {
            return YieldAnyValueTo(getter, setter, target, duration, UMath.Lerp, easer ?? EaseMath.Linear);
        }

        public static IEnumerator YieldValueTo(Func<float> getter, Action<float> setter, float target, float duration, EEase ease)
        {
            return YieldValueTo(getter, setter, target, duration, ease.ToEaser());
        }

        public static IEnumerator YieldValueTo(Func<float> getter, Action<float> setter, float target, float duration, AnimationCurve curve)
        {
            return YieldValueTo(getter, setter, target, duration, curve.Evaluate);
        }
        #endregion

        #region Vector2s
        public static IEnumerator<Vector2> YieldValue(Vector2 start, Vector2 target, float duration, Func<float, float> easer = null)
        {
            return YieldAnyValue(start, target, duration, UMath.Lerp, easer ?? EaseMath.Linear);
        }

        public static IEnumerator<Vector2> YieldValue(Vector2 start, Vector2 target, float duration, EEase ease)
        {
            return YieldValue(start, target, duration, ease.ToEaser());
        }

        public static IEnumerator<Vector2> YieldValue(Vector2 start, Vector2 target, float duration, AnimationCurve curve)
        {
            return YieldValue(start, target, duration, curve.Evaluate);
        }

        public static IEnumerator YieldValueTo(Func<Vector2> getter, Action<Vector2> setter, Vector2 target, float duration, Func<float, float> easer = null)
        {
            return YieldAnyValueTo(getter, setter, target, duration, UMath.Lerp, easer ?? EaseMath.Linear);
        }

        public static IEnumerator YieldValueTo(Func<Vector2> getter, Action<Vector2> setter, Vector2 target, float duration, EEase ease)
        {
            return YieldValueTo(getter, setter, target, duration, ease.ToEaser());
        }

        public static IEnumerator YieldValueTo(Func<Vector2> getter, Action<Vector2> setter, Vector2 target, float duration, AnimationCurve curve)
        {
            return YieldValueTo(getter, setter, target, duration, curve.Evaluate);
        }
        #endregion

        #region Vector3s
        public static IEnumerator<Vector3> YieldValue(Vector3 start, Vector3 target, float duration, Func<float, float> easer = null)
        {
            return YieldAnyValue(start, target, duration, UMath.Lerp, easer ?? EaseMath.Linear);
        }

        public static IEnumerator<Vector3> YieldValue(Vector3 start, Vector3 target, float duration, EEase ease)
        {
            return YieldValue(start, target, duration, ease.ToEaser());
        }

        public static IEnumerator<Vector3> YieldValue(Vector3 start, Vector3 target, float duration, AnimationCurve curve)
        {
            return YieldValue(start, target, duration, curve.Evaluate);
        }

        public static IEnumerator YieldValueTo(Func<Vector3> getter, Action<Vector3> setter, Vector3 target, float duration, Func<float, float> easer = null)
        {
            return YieldAnyValueTo(getter, setter, target, duration, UMath.Lerp, easer ?? EaseMath.Linear);
        }

        public static IEnumerator YieldValueTo(Func<Vector3> getter, Action<Vector3> setter, Vector3 target, float duration, EEase ease)
        {
            return YieldValueTo(getter, setter, target, duration, ease.ToEaser());
        }

        public static IEnumerator YieldValueTo(Func<Vector3> getter, Action<Vector3> setter, Vector3 target, float duration, AnimationCurve curve)
        {
            return YieldValueTo(getter, setter, target, duration, curve.Evaluate);
        }
        #endregion

        #region Vector4s
        public static IEnumerator<Vector4> YieldValue(Vector4 start, Vector4 target, float duration, Func<float, float> easer = null)
        {
            return YieldAnyValue(start, target, duration, UMath.Lerp, easer ?? EaseMath.Linear);
        }

        public static IEnumerator<Vector4> YieldValue(Vector4 start, Vector4 target, float duration, EEase ease)
        {
            return YieldValue(start, target, duration, ease.ToEaser());
        }

        public static IEnumerator<Vector4> YieldValue(Vector4 start, Vector4 target, float duration, AnimationCurve curve)
        {
            return YieldValue(start, target, duration, curve.Evaluate);
        }

        public static IEnumerator YieldValueTo(Func<Vector4> getter, Action<Vector4> setter, Vector4 target, float duration, Func<float, float> easer = null)
        {
            return YieldAnyValueTo(getter, setter, target, duration, UMath.Lerp, easer ?? EaseMath.Linear);
        }

        public static IEnumerator YieldValueTo(Func<Vector4> getter, Action<Vector4> setter, Vector4 target, float duration, EEase ease)
        {
            return YieldValueTo(getter, setter, target, duration, ease.ToEaser());
        }

        public static IEnumerator YieldValueTo(Func<Vector4> getter, Action<Vector4> setter, Vector4 target, float duration, AnimationCurve curve)
        {
            return YieldValueTo(getter, setter, target, duration, curve.Evaluate);
        }
        #endregion

        #region Quaternions
        public static IEnumerator<Quaternion> YieldValue(Quaternion start, Quaternion target, float duration, Func<float, float> easer = null)
        {
            return YieldAnyValue(start, target, duration, UMath.Slerp, easer ?? EaseMath.Linear);
        }

        public static IEnumerator<Quaternion> YieldValue(Quaternion start, Quaternion target, float duration, EEase ease)
        {
            return YieldValue(start, target, duration, ease.ToEaser());
        }

        public static IEnumerator<Quaternion> YieldValue(Quaternion start, Quaternion target, float duration, AnimationCurve curve)
        {
            return YieldValue(start, target, duration, curve.Evaluate);
        }

        public static IEnumerator YieldValueTo(Func<Quaternion> getter, Action<Quaternion> setter, Quaternion target, float duration, Func<float, float> easer = null)
        {
            return YieldAnyValueTo(getter, setter, target, duration, UMath.Slerp, easer ?? EaseMath.Linear);
        }

        public static IEnumerator YieldValueTo(Func<Quaternion> getter, Action<Quaternion> setter, Quaternion target, float duration, EEase ease)
        {
            return YieldValueTo(getter, setter, target, duration, ease.ToEaser());
        }

        public static IEnumerator YieldValueTo(Func<Quaternion> getter, Action<Quaternion> setter, Quaternion target, float duration, AnimationCurve curve)
        {
            return YieldValueTo(getter, setter, target, duration, curve.Evaluate);
        }
        #endregion

        #region Colors
        public static IEnumerator<Color> YieldValue(Color start, Color target, float duration, Func<float, float> easer = null)
        {
            return YieldAnyValue(start, target, duration, UMath.Lerp, easer ?? EaseMath.Linear);
        }

        public static IEnumerator<Color> YieldValue(Color start, Color target, float duration, EEase ease)
        {
            return YieldValue(start, target, duration, ease.ToEaser());
        }

        public static IEnumerator<Color> YieldValue(Color start, Color target, float duration, AnimationCurve curve)
        {
            return YieldValue(start, target, duration, curve.Evaluate);
        }

        public static IEnumerator YieldValueTo(Func<Color> getter, Action<Color> setter, Color target, float duration, Func<float, float> easer = null)
        {
            return YieldAnyValueTo(getter, setter, target, duration, UMath.Lerp, easer ?? EaseMath.Linear);
        }

        public static IEnumerator YieldValueTo(Func<Color> getter, Action<Color> setter, Color target, float duration, EEase ease)
        {
            return YieldValueTo(getter, setter, target, duration, ease.ToEaser());
        }

        public static IEnumerator YieldValueTo(Func<Color> getter, Action<Color> setter, Color target, float duration, AnimationCurve curve)
        {
            return YieldValueTo(getter, setter, target, duration, curve.Evaluate);
        }
        #endregion
    }
}
