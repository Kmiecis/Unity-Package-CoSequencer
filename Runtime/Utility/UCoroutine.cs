using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Common.Coroutines
{
    public static class UCoroutine
    {
        #region Yield
        /// <summary> Yields once </summary>
        public static IEnumerator Yield()
        {
            yield return null;
        }
        
        /// <summary> Yields YieldInstruction </summary>
        public static IEnumerator Yield(YieldInstruction yield)
        {
            yield return yield;
        }

        /// <summary> Yields Coroutine </summary>
        public static IEnumerator Yield(Coroutine coroutine)
        {
            yield return coroutine;
        }

        /// <summary> Yields value once </summary>
        public static IEnumerator<T> Yield<T>(T value)
        {
            yield return value;
        }

        /// <summary> Yields values </summary>
        public static IEnumerator<T> Yield<T>(params T[] values)
        {
            for (int i = 0; i < values.Length; ++i)
            {
                yield return values[i];
            }
        }

        /// <summary> Executes action and yields once </summary>
        public static IEnumerator Yield(Action action)
        {
            action();
            yield return null;
        }

        /// <summary> Yields provided value once </summary>
        public static IEnumerator<T> Yield<T>(Func<T> provider)
        {
            yield return provider();
        }

        /// <summary> Executes coroutine until it finishes </summary>
        public static IEnumerator Yield(IEnumerator coroutine)
        {
            while (coroutine.MoveNext())
            {
                yield return coroutine.Current;
            }
        }

        /// <summary> Executes coroutine until it finishes </summary>
        public static IEnumerator<T> Yield<T>(IEnumerator<T> coroutine)
        {
            while (coroutine.MoveNext())
            {
                yield return coroutine.Current;
            }
        }

        /// <summary> Executes created coroutine until it finishes </summary>
        public static IEnumerator Yield(Func<IEnumerator> provider)
        {
            var coroutine = provider();
            while (coroutine.MoveNext())
            {
                yield return coroutine.Current;
            }
        }

        /// <summary> Executes created coroutine until it finishes </summary>
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
        /// <summary> Executes coroutine into consumer method </summary>
        public static IEnumerator YieldInto<T>(IEnumerator<T> coroutine, Action<T> consumer)
        {
            while (coroutine.MoveNext())
            {
                consumer(coroutine.Current);
                yield return null;
            }
        }

        /// <summary> Executes coroutine into parser method </summary>
        public static IEnumerator<U> YieldInto<T, U>(IEnumerator<T> coroutine, Func<T, U> parser)
        {
            while (coroutine.MoveNext())
            {
                yield return parser(coroutine.Current);
            }
        }

        /// <summary> Executes created coroutine into consumer method </summary>
        public static IEnumerator YieldInto<T>(Func<IEnumerator<T>> provider, Action<T> consumer)
        {
            var coroutine = provider();
            while (coroutine.MoveNext())
            {
                consumer(coroutine.Current);
                yield return null;
            }
        }

        /// <summary> Executes created coroutine into parser method </summary>
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
        /// <summary> Executes coroutine only if verifier evaluates to true </summary>
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

        /// <summary> Executes coroutine only if verifier evaluates to true </summary>
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

        /// <summary> Executes created coroutine only if verifier evaluates to true </summary>
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

        /// <summary> Executes created coroutine only if verifier evaluates to true </summary>
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
        public static IEnumerator YieldWhile(Action action, Func<bool> verifier)
        {
            while (verifier())
            {
                action();
                yield return null;
            }
        }

        public static IEnumerator<T> YieldWhile<T>(Func<T> provider, Func<bool> verifier)
        {
            while (verifier())
            {
                yield return provider();
            }
        }
        
        /// <summary> Executes coroutine only if and as long as verifier evaluates to true </summary>
        public static IEnumerator YieldWhile(IEnumerator coroutine, Func<bool> verifier)
        {
            while (verifier() && coroutine.MoveNext())
            {
                yield return coroutine.Current;
            }
        }

        /// <summary> Executes coroutine only if and as long as verifier evaluates to true </summary>
        public static IEnumerator<T> YieldWhile<T>(IEnumerator<T> coroutine, Func<bool> verifier)
        {
            while (verifier() && coroutine.MoveNext())
            {
                yield return coroutine.Current;
            }
        }

        /// <summary> Executes provided coroutine only if and as long as verifier evaluates to true </summary>
        public static IEnumerator YieldWhile(Func<IEnumerator> provider, Func<bool> verifier)
        {
            var coroutine = provider();
            while (verifier() && coroutine.MoveNext())
            {
                yield return coroutine.Current;
            }
        }

        /// <summary> Executes provided coroutine only if and as long as verifier evaluates to true </summary>
        public static IEnumerator<T> YieldWhile<T>(Func<IEnumerator<T>> provider, Func<bool> verifier)
        {
            var coroutine = provider();
            while (verifier() && coroutine.MoveNext())
            {
                yield return coroutine.Current;
            }
        }
        #endregion

        #region Yield until
        /// <summary> Executes action until coroutine finishes </summary>
        public static IEnumerator YieldUntil(Action action, IEnumerator coroutine)
        {
            while (coroutine.MoveNext())
            {
                action();
                yield return coroutine.Current;
            }
        }

        /// <summary> Executes action until coroutine finishes </summary>
        public static IEnumerator<T> YieldUntil<T>(Action action, IEnumerator<T> coroutine)
        {
            while (coroutine.MoveNext())
            {
                action();
                yield return coroutine.Current;
            }
        }

        /// <summary> Executes action until created coroutine finishes </summary>
        public static IEnumerator YieldUntil(Action action, Func<IEnumerator> provider)
        {
            var coroutine = provider();
            while (coroutine.MoveNext())
            {
                action();
                yield return coroutine.Current;
            }
        }

        /// <summary> Executes action until created coroutine finishes </summary>
        public static IEnumerator<T> YieldUntil<T>(Action action, Func<IEnumerator<T>> provider)
        {
            var coroutine = provider();
            while (coroutine.MoveNext())
            {
                action();
                yield return coroutine.Current;
            }
        }
        #endregion

        #region Yield repeat
        /// <summary> Executes created coroutine a number of times </summary>
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

        /// <summary> Executes created coroutine a number of times </summary>
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

        public static IEnumerator<float> YieldTimeEased(float duration, Func<float, float> easer = null)
        {
            return YieldTimeNormalized(duration)
                .Eased(easer);
        }

        public static IEnumerator<float> YieldRealtimeEased(float duration, Func<float, float> easer = null)
        {
            return YieldRealtimeNormalized(duration)
                .Eased(easer);
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

        public static IEnumerator YieldValueTo<T>(Func<float, T> evaluator, Action<T> setter, IEnumerator<float> timer)
        {
            return timer.Into(evaluator).Into(setter);
        }

        public static IEnumerator<T> YieldValue<T>(T start, T target, Func<T, T, float, T> parser, IEnumerator<float> timer)
        {
            T Evaluator(float t) => parser(start, target, t);
            return YieldValue(Evaluator, timer);
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
        #endregion

        #region Floats
        public static IEnumerator YieldValue(float start, float target, IEnumerator<float> timer)
            => YieldValue(start, target, UMath.Lerp, timer);

        public static IEnumerator YieldValueTo(Func<float> getter, Action<float> setter, float target, IEnumerator<float> timer)
            => YieldValueTo(getter, setter, target, UMath.Lerp, timer);

        public static IEnumerator YieldValueTo(Func<float> getter, Action<float> setter, Func<float> provider, IEnumerator<float> timer)
            => YieldValueTo(getter, setter, provider, UMath.Lerp, timer);
        #endregion

        #region Ints
        public static IEnumerator YieldValue(int start, int target, IEnumerator<float> timer)
            => YieldValue(start, target, UMath.Lerp, timer);

        public static IEnumerator YieldValueTo(Func<int> getter, Action<int> setter, int target, IEnumerator<float> timer)
            => YieldValueTo(getter, setter, target, UMath.Lerp, timer);

        public static IEnumerator YieldValueTo(Func<int> getter, Action<int> setter, Func<int> provider, IEnumerator<float> timer)
            => YieldValueTo(getter, setter, provider, UMath.Lerp, timer);
        #endregion

        #region Vector2s
        public static IEnumerator YieldValue(Vector2 start, Vector2 target, IEnumerator<float> timer)
            => YieldValue(start, target, UMath.Lerp, timer);

        public static IEnumerator YieldValueTo(Func<Vector2> getter, Action<Vector2> setter, Vector2 target, IEnumerator<float> timer)
            => YieldValueTo(getter, setter, target, UMath.Lerp, timer);

        public static IEnumerator YieldValueTo(Func<Vector2> getter, Action<Vector2> setter, Func<Vector2> provider, IEnumerator<float> timer)
            => YieldValueTo(getter, setter, provider, UMath.Lerp, timer);
        #endregion

        #region Vector2Ints
        public static IEnumerator YieldValue(Vector2Int start, Vector2Int target, IEnumerator<float> timer)
            => YieldValue(start, target, UMath.Lerp, timer);

        public static IEnumerator YieldValueTo(Func<Vector2Int> getter, Action<Vector2Int> setter, Vector2Int target, IEnumerator<float> timer)
            => YieldValueTo(getter, setter, target, UMath.Lerp, timer);

        public static IEnumerator YieldValueTo(Func<Vector2Int> getter, Action<Vector2Int> setter, Func<Vector2Int> provider, IEnumerator<float> timer)
            => YieldValueTo(getter, setter, provider, UMath.Lerp, timer);
        #endregion

        #region Vector3s
        public static IEnumerator YieldValue(Vector3 start, Vector3 target, IEnumerator<float> timer)
            => YieldValue(start, target, UMath.Lerp, timer);

        public static IEnumerator YieldValueTo(Func<Vector3> getter, Action<Vector3> setter, Vector3 target, IEnumerator<float> timer)
            => YieldValueTo(getter, setter, target, UMath.Lerp, timer);

        public static IEnumerator YieldValueTo(Func<Vector3> getter, Action<Vector3> setter, Func<Vector3> provider, IEnumerator<float> timer)
            => YieldValueTo(getter, setter, provider, UMath.Lerp, timer);
        #endregion

        #region Vector3Ints
        public static IEnumerator YieldValue(Vector3Int start, Vector3Int target, IEnumerator<float> timer)
            => YieldValue(start, target, UMath.Lerp, timer);

        public static IEnumerator YieldValueTo(Func<Vector3Int> getter, Action<Vector3Int> setter, Vector3Int target, IEnumerator<float> timer)
            => YieldValueTo(getter, setter, target, UMath.Lerp, timer);

        public static IEnumerator YieldValueTo(Func<Vector3Int> getter, Action<Vector3Int> setter, Func<Vector3Int> provider, IEnumerator<float> timer)
            => YieldValueTo(getter, setter, provider, UMath.Lerp, timer);
        #endregion

        #region Vector4s
        public static IEnumerator YieldValue(Vector4 start, Vector4 target, IEnumerator<float> timer)
            => YieldValue(start, target, UMath.Lerp, timer);

        public static IEnumerator YieldValueTo(Func<Vector4> getter, Action<Vector4> setter, Vector4 target, IEnumerator<float> timer)
            => YieldValueTo(getter, setter, target, UMath.Lerp, timer);

        public static IEnumerator YieldValueTo(Func<Vector4> getter, Action<Vector4> setter, Func<Vector4> provider, IEnumerator<float> timer)
            => YieldValueTo(getter, setter, provider, UMath.Lerp, timer);
        #endregion

        #region Quaternions
        public static IEnumerator YieldValue(Quaternion start, Quaternion target, IEnumerator<float> timer)
            => YieldValue(start, target, UMath.Lerp, timer);

        public static IEnumerator YieldValueTo(Func<Quaternion> getter, Action<Quaternion> setter, Quaternion target, IEnumerator<float> timer)
            => YieldValueTo(getter, setter, target, UMath.Lerp, timer);

        public static IEnumerator YieldValueTo(Func<Quaternion> getter, Action<Quaternion> setter, Func<Quaternion> provider, IEnumerator<float> timer)
            => YieldValueTo(getter, setter, provider, UMath.Lerp, timer);
        #endregion

        #region Colors
        public static IEnumerator YieldValue(Color start, Color target, IEnumerator<float> timer)
            => YieldValue(start, target, UMath.Lerp, timer);

        public static IEnumerator YieldValueTo(Func<Color> getter, Action<Color> setter, Color target, IEnumerator<float> timer)
            => YieldValueTo(getter, setter, target, UMath.Lerp, timer);

        public static IEnumerator YieldValueTo(Func<Color> getter, Action<Color> setter, Func<Color> provider, IEnumerator<float> timer)
            => YieldValueTo(getter, setter, provider, UMath.Lerp, timer);
        #endregion

        #region Rects
        public static IEnumerator YieldValue(Rect start, Rect target, IEnumerator<float> timer)
            => YieldValue(start, target, UMath.Lerp, timer);

        public static IEnumerator YieldValueTo(Func<Rect> getter, Action<Rect> setter, Rect target, IEnumerator<float> timer)
            => YieldValueTo(getter, setter, target, UMath.Lerp, timer);

        public static IEnumerator YieldValueTo(Func<Rect> getter, Action<Rect> setter, Func<Rect> provider, IEnumerator<float> timer)
            => YieldValueTo(getter, setter, provider, UMath.Lerp, timer);
        #endregion

        #region Time
        public static IEnumerator CoTimeScale(float target, float duration, Func<float, float> easer = null)
            => YieldValueTo(UTime.GetTimeScale, UTime.SetTimeScale, target, YieldRealtimeEased(duration, easer));

        public static IEnumerator CoFixedDeltaTime(float target, float duration, Func<float, float> easer = null)
            => YieldValueTo(UTime.GetFixedDeltaTime, UTime.SetFixedDeltaTime, target, YieldRealtimeEased(duration, easer));

        public static IEnumerator CoMaximumDeltaTime(float target, float duration, Func<float, float> easer = null)
            => YieldValueTo(UTime.GetMaximumDeltaTime, UTime.SetMaximumDeltaTime, target, YieldRealtimeEased(duration, easer));

        public static IEnumerator CoMaximumParticleDeltaTime(float target, float duration, Func<float, float> easer = null)
            => YieldValueTo(UTime.GetMaximumParticleDeltaTime, UTime.SetMaximumParticleDeltaTime, target, YieldRealtimeEased(duration, easer));
        #endregion
    }
}
