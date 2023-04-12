using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Common.Coroutines
{
    public static class UCoroutine
    {
        #region Yield
        public static IEnumerator Yield()
        {
            yield return null;
        }

        public static IEnumerator<T> Yield<T>(T value)
        {
            yield return value;
        }

        public static IEnumerator<T> Yield<T>(params T[] values)
        {
            for (int i = 0; i < values.Length; ++i)
            {
                yield return values[i];
            }
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

        public static IEnumerator Yield(IEnumerator coroutine)
        {
            while (coroutine.MoveNext())
            {
                yield return coroutine.Current;
            }
        }

        public static IEnumerator<T> Yield<T>(IEnumerator<T> coroutine)
        {
            while (coroutine.MoveNext())
            {
                yield return coroutine.Current;
            }
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
        #endregion

        #region Yield into
        public static IEnumerator YieldInto<T>(IEnumerator<T> coroutine, Action<T> consumer)
        {
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

        public static IEnumerator YieldInto<T>(Func<IEnumerator<T>> provider, Action<T> consumer)
        {
            var coroutine = provider();
            while (coroutine.MoveNext())
            {
                consumer(coroutine.Current);
                yield return null;
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
        #endregion

        #region Yield await
        /// <summary> Suspends next coroutine execution until verifier evaluates to true </summary>
        public static IEnumerator YieldAwait(Func<bool> verifier)
        {
            while (!verifier())
            {
                yield return null;
            }
        }

        /// <summary> Suspends next coroutine execution until yield instruction finishes </summary>
        public static IEnumerator YieldAwait(YieldInstruction yield)
        {
            yield return yield;
        }

        /// <summary> Suspends next coroutine execution until coroutine finishes </summary>
        public static IEnumerator YieldAwait(Coroutine coroutine)
        {
            yield return coroutine;
        }
        #endregion

        #region Yield if
        public static IEnumerator YieldIf(IEnumerator coroutine, Func<bool> verifier)
        {
            if (verifier())
            {
                while (coroutine.MoveNext())
                {
                    yield return coroutine.Current;
                }
            }
        }

        public static IEnumerator<T> YieldIf<T>(IEnumerator<T> coroutine, Func<bool> verifier)
        {
            if (verifier())
            {
                while (coroutine.MoveNext())
                {
                    yield return coroutine.Current;
                }
            }
        }

        public static IEnumerator YieldIf(Func<IEnumerator> provider, Func<bool> verifier)
        {
            if (verifier())
            {
                var coroutine = provider();
                while (coroutine.MoveNext())
                {
                    yield return coroutine.Current;
                }
            }
        }

        public static IEnumerator<T> YieldIf<T>(Func<IEnumerator<T>> provider, Func<bool> verifier)
        {
            if (verifier())
            {
                var coroutine = provider();
                while (coroutine.MoveNext())
                {
                    yield return coroutine.Current;
                }
            }
        }
        #endregion

        #region Yield while
        /// <summary> Executes coroutine only if and as long as verifier evaluates to true </summary>
        public static IEnumerator YieldWhile(IEnumerator coroutine, Func<bool> verifier)
        {
            while (verifier() && coroutine.MoveNext())
            {
                yield return coroutine.Current;
            }
        }

        public static IEnumerator<T> YieldWhile<T>(IEnumerator<T> coroutine, Func<bool> verifier)
        {
            while (verifier() && coroutine.MoveNext())
            {
                yield return coroutine.Current;
            }
        }

        public static IEnumerator YieldWhile(Func<IEnumerator> provider, Func<bool> verifier)
        {
            var coroutine = provider();
            while (verifier() && coroutine.MoveNext())
            {
                yield return coroutine.Current;
            }
        }

        public static IEnumerator<T> YieldWhile<T>(Func<IEnumerator<T>> provider, Func<bool> verifier)
        {
            var coroutine = provider();
            while (verifier() && coroutine.MoveNext())
            {
                yield return coroutine.Current;
            }
        }
        #endregion

        #region Yield repeat
        public static IEnumerator YieldRepeat(Func<IEnumerator> provider, int repeats)
        {
            while (repeats > 0)
            {
                var coroutine = provider();
                while (coroutine.MoveNext())
                {
                    yield return coroutine.Current;
                }
                --repeats;
            }
        }

        public static IEnumerator<T> YieldRepeat<T>(Func<IEnumerator<T>> provider, int repeats)
        {
            while (repeats > 0)
            {
                var coroutine = provider();
                while (coroutine.MoveNext())
                {
                    yield return coroutine.Current;
                }
                --repeats;
            }
        }
        #endregion

        #region Yield infinitely
        public static IEnumerator YieldInfinitely()
        {
            while (true)
            {
                yield return null;
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
        #endregion

        #region Yield sequentially
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
        #endregion

        #region Yield parallel
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

        #region Yield time
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
            float t = Time.deltaTime;

            while (t < duration)
            {
                yield return t;

                t += Time.deltaTime;
            }

            yield return duration;
        }

        public static IEnumerator<float> YieldRealtime(float duration)
        {
            float t = Time.unscaledDeltaTime;

            while (t < duration)
            {
                yield return t;

                t += Time.unscaledDeltaTime;
            }

            yield return duration;
        }

        public static IEnumerator<float> YieldTimeNormalized(float duration)
        {
            float n = 1.0f / duration;
            float t = n * Time.deltaTime;

            while (t < 1.0f)
            {
                yield return t;

                t += n * Time.deltaTime;
            }

            yield return 1.0f;
        }

        public static IEnumerator<float> YieldRealtimeNormalized(float duration)
        {
            float n = 1.0f / duration;
            float t = n * Time.unscaledDeltaTime;

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
        #endregion

        #region Yield frames
        public static IEnumerator YieldFrames(int frames)
        {
            while (frames > 0)
            {
                --frames;
                yield return null;
            }
        }
        #endregion

        #region Yield value
        public static IEnumerator<T> YieldValue<T>(Func<float, T> evaluator, IEnumerator<float> timer)
        {
            return timer.Into(evaluator);
        }

        public static IEnumerator<T> YieldValue<T>(Func<float, T> evaluator, float duration)
        {
            return YieldValue(evaluator, YieldTimeNormalized(duration));
        }

        public static IEnumerator<T> YieldValue<T>(Func<float, T> evaluator, float duration, Func<float, float> easer = null)
        {
            return YieldValue(evaluator, YieldTimeEased(duration, easer ?? Easings.SmoothStep));
        }

        public static IEnumerator YieldValueTo<T>(Func<float, T> evaluator, Action<T> setter, IEnumerator<float> timer)
        {
            return timer.Into(evaluator)
                .Into(setter);
        }

        public static IEnumerator YieldValueTo<T>(Func<float, T> evaluator, Action<T> setter, float duration)
        {
            return YieldValueTo(evaluator, setter, YieldTimeNormalized(duration));
        }

        public static IEnumerator YieldValueTo<T>(Func<float, T> evaluator, Action<T> setter, float duration, Func<float, float> easer = null)
        {
            return YieldValueTo(evaluator, setter, YieldTimeEased(duration, easer ?? Easings.SmoothStep));
        }

        public static IEnumerator<T> YieldValue<T>(T start, T target, Func<T, T, float, T> parser, IEnumerator<float> timer)
        {
            T Evaluator(float t) => parser(start, target, t);
            return YieldValue(Evaluator, timer);
        }

        public static IEnumerator<T> YieldValue<T>(T start, T target, Func<T, T, float, T> parser, float duration)
        {
            return YieldValue(start, target, parser, YieldTimeNormalized(duration));
        }

        public static IEnumerator<T> YieldValue<T>(T start, T target, Func<T, T, float, T> parser, float duration, Func<float, float> easer = null)
        {
            return YieldValue(start, target, parser, YieldTimeEased(duration, easer ?? Easings.SmoothStep));
        }
        
        public static IEnumerator YieldValueTo<T>(Func<T> getter, Action<T> setter, T target, Func<T, T, float, T> parser, IEnumerator<float> timer)
        {
            var start = getter();
            while (timer.MoveNext())
            {
                var t = timer.Current;
                var v = parser(start, target, t);
                setter(v);

                yield return null;
            }
        }

        public static IEnumerator YieldValueTo<T>(Func<T> getter, Action<T> setter, T target, Func<T, T, float, T> parser, float duration)
        {
            return YieldValueTo(getter, setter, target, parser, YieldTimeNormalized(duration));
        }

        public static IEnumerator YieldValueTo<T>(Func<T> getter, Action<T> setter, T target, Func<T, T, float, T> parser, float duration, Func<float, float> easer = null)
        {
            return YieldValueTo(getter, setter, target, parser, YieldTimeEased(duration, easer ?? Easings.SmoothStep));
        }

        public static IEnumerator YieldValueTo<T>(Func<T> getter, Action<T> setter, Func<T> provider, Func<T, T, float, T> parser, IEnumerator<float> timer)
        {
            var start = getter();
            var target = provider();
            while (timer.MoveNext())
            {
                var t = timer.Current;
                var v = parser(start, target, t);
                setter(v);

                yield return null;
            }
        }

        public static IEnumerator YieldValueTo<T>(Func<T> getter, Action<T> setter, Func<T> provider, Func<T, T, float, T> parser, float duration)
        {
            return YieldValueTo(getter, setter, provider, parser, YieldTimeNormalized(duration));
        }

        public static IEnumerator YieldValueTo<T>(Func<T> getter, Action<T> setter, Func<T> provider, Func<T, T, float, T> parser, float duration, Func<float, float> easer = null)
        {
            return YieldValueTo(getter, setter, provider, parser, YieldTimeEased(duration, easer ?? Easings.SmoothStep));
        }
        #endregion

        #region Floats
        public static IEnumerator<float> YieldValue(float start, float target, float duration, Func<float, float> easer = null)
        {
            return YieldValue(start, target, UMath.Lerp, duration, easer);
        }

        public static IEnumerator YieldValueTo(Func<float> getter, Action<float> setter, float target, float duration, Func<float, float> easer = null)
        {
            return YieldValueTo(getter, setter, target, UMath.Lerp, duration, easer);
        }

        public static IEnumerator YieldValueTo(Func<float> getter, Action<float> setter, Func<float> provider, float duration, Func<float, float> easer = null)
        {
            return YieldValueTo(getter, setter, provider, UMath.Lerp, duration, easer);
        }
        #endregion

        #region Ints
        public static IEnumerator<int> YieldValue(int start, int target, float duration, Func<float, float> easer = null)
        {
            return YieldValue(start, target, UMath.Lerp, duration, easer);
        }

        public static IEnumerator YieldValueTo(Func<int> getter, Action<int> setter, int target, float duration, Func<float, float> easer = null)
        {
            return YieldValueTo(getter, setter, target, UMath.Lerp, duration, easer);
        }

        public static IEnumerator YieldValueTo(Func<int> getter, Action<int> setter, Func<int> provider, float duration, Func<float, float> easer = null)
        {
            return YieldValueTo(getter, setter, provider, UMath.Lerp, duration, easer);
        }
        #endregion

        #region Vector2s
        public static IEnumerator<Vector2> YieldValue(Vector2 start, Vector2 target, float duration, Func<float, float> easer = null)
        {
            return YieldValue(start, target, UMath.Lerp, duration, easer);
        }

        public static IEnumerator YieldValueTo(Func<Vector2> getter, Action<Vector2> setter, Vector2 target, float duration, Func<float, float> easer = null)
        {
            return YieldValueTo(getter, setter, target, UMath.Lerp, duration, easer);
        }

        public static IEnumerator YieldValueTo(Func<Vector2> getter, Action<Vector2> setter, Func<Vector2> provider, float duration, Func<float, float> easer = null)
        {
            return YieldValueTo(getter, setter, provider, UMath.Lerp, duration, easer);
        }
        #endregion

        #region Vector2Ints
        public static IEnumerator<Vector2Int> YieldValue(Vector2Int start, Vector2Int target, float duration, Func<float, float> easer = null)
        {
            return YieldValue(start, target, UMath.Lerp, duration, easer);
        }

        public static IEnumerator YieldValueTo(Func<Vector2Int> getter, Action<Vector2Int> setter, Vector2Int target, float duration, Func<float, float> easer = null)
        {
            return YieldValueTo(getter, setter, target, UMath.Lerp, duration, easer);
        }

        public static IEnumerator YieldValueTo(Func<Vector2Int> getter, Action<Vector2Int> setter, Func<Vector2Int> provider, float duration, Func<float, float> easer = null)
        {
            return YieldValueTo(getter, setter, provider, UMath.Lerp, duration, easer);
        }
        #endregion

        #region Vector3s
        public static IEnumerator<Vector3> YieldValue(Vector3 start, Vector3 target, float duration, Func<float, float> easer = null)
        {
            return YieldValue(start, target, UMath.Lerp, duration, easer);
        }

        public static IEnumerator YieldValueTo(Func<Vector3> getter, Action<Vector3> setter, Vector3 target, float duration, Func<float, float> easer = null)
        {
            return YieldValueTo(getter, setter, target, UMath.Lerp, duration, easer);
        }

        public static IEnumerator YieldValueTo(Func<Vector3> getter, Action<Vector3> setter, Func<Vector3> provider, float duration, Func<float, float> easer = null)
        {
            return YieldValueTo(getter, setter, provider, UMath.Lerp, duration, easer);
        }
        #endregion

        #region Vector3Ints
        public static IEnumerator<Vector3Int> YieldValue(Vector3Int start, Vector3Int target, float duration, Func<float, float> easer = null)
        {
            return YieldValue(start, target, UMath.Lerp, duration, easer);
        }

        public static IEnumerator YieldValueTo(Func<Vector3Int> getter, Action<Vector3Int> setter, Vector3Int target, float duration, Func<float, float> easer = null)
        {
            return YieldValueTo(getter, setter, target, UMath.Lerp, duration, easer);
        }

        public static IEnumerator YieldValueTo(Func<Vector3Int> getter, Action<Vector3Int> setter, Func<Vector3Int> provider, float duration, Func<float, float> easer = null)
        {
            return YieldValueTo(getter, setter, provider, UMath.Lerp, duration, easer);
        }
        #endregion

        #region Vector4s
        public static IEnumerator<Vector4> YieldValue(Vector4 start, Vector4 target, float duration, Func<float, float> easer = null)
        {
            return YieldValue(start, target, UMath.Lerp, duration, easer);
        }

        public static IEnumerator YieldValueTo(Func<Vector4> getter, Action<Vector4> setter, Vector4 target, float duration, Func<float, float> easer = null)
        {
            return YieldValueTo(getter, setter, target, UMath.Lerp, duration, easer);
        }

        public static IEnumerator YieldValueTo(Func<Vector4> getter, Action<Vector4> setter, Func<Vector4> provider, float duration, Func<float, float> easer = null)
        {
            return YieldValueTo(getter, setter, provider, UMath.Lerp, duration, easer);
        }
        #endregion

        #region Quaternions
        public static IEnumerator<Quaternion> YieldValue(Quaternion start, Quaternion target, float duration, Func<float, float> easer = null)
        {
            return YieldValue(start, target, UMath.Lerp, duration, easer);
        }

        public static IEnumerator YieldValueTo(Func<Quaternion> getter, Action<Quaternion> setter, Quaternion target, float duration, Func<float, float> easer = null)
        {
            return YieldValueTo(getter, setter, target, UMath.Lerp, duration, easer);
        }

        public static IEnumerator YieldValueTo(Func<Quaternion> getter, Action<Quaternion> setter, Func<Quaternion> provider, float duration, Func<float, float> easer = null)
        {
            return YieldValueTo(getter, setter, provider, UMath.Lerp, duration, easer);
        }
        #endregion

        #region Colors
        public static IEnumerator<Color> YieldValue(Color start, Color target, float duration, Func<float, float> easer = null)
        {
            return YieldValue(start, target, UMath.Lerp, duration, easer);
        }

        public static IEnumerator YieldValueTo(Func<Color> getter, Action<Color> setter, Color target, float duration, Func<float, float> easer = null)
        {
            return YieldValueTo(getter, setter, target, UMath.Lerp, duration, easer);
        }

        public static IEnumerator YieldValueTo(Func<Color> getter, Action<Color> setter, Func<Color> provider, float duration, Func<float, float> easer = null)
        {
            return YieldValueTo(getter, setter, provider, UMath.Lerp, duration, easer);
        }
        #endregion

        #region Rects
        public static IEnumerator<Rect> YieldValue(Rect start, Rect target, float duration, Func<float, float> easer = null)
        {
            return YieldValue(start, target, UMath.Lerp, duration, easer);
        }

        public static IEnumerator YieldValueTo(Func<Rect> getter, Action<Rect> setter, Rect target, float duration, Func<float, float> easer = null)
        {
            return YieldValueTo(getter, setter, target, UMath.Lerp, duration, easer);
        }

        public static IEnumerator YieldValueTo(Func<Rect> getter, Action<Rect> setter, Func<Rect> provider, float duration, Func<float, float> easer = null)
        {
            return YieldValueTo(getter, setter, provider, UMath.Lerp, duration, easer);
        }
        #endregion
    }
}
