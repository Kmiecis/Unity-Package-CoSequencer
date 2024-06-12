using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Common.Coroutines
{
    public static class UCoroutine
    {
        #region Yield
        /// <summary> Yields nothing </summary>
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

        /// <summary> Yields values one by one each frame </summary>
        public static IEnumerator<T> Yield<T>(params T[] values)
        {
            for (int i = 0; i < values.Length; ++i)
            {
                yield return values[i];
            }
        }

        /// <summary> Executes 'action' method once </summary>
        public static IEnumerator Yield(Action action)
        {
            action();
            yield return null;
        }

        public static IEnumerator Yield<T>(Action<T> consumer, T value)
        {
            consumer(value);
            yield return null;
        }

        /// <summary> Executes 'action' uevent once </summary>
        public static IEnumerator Yield(UnityEvent action)
        {
            action.Invoke();
            yield return null;
        }

        /// <summary> Yields value once from 'provider' method </summary>
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

        /// <summary> Executes coroutine from 'provider' method until it finishes </summary>
        public static IEnumerator Yield(Func<IEnumerator> provider)
        {
            var coroutine = provider();
            while (coroutine.MoveNext())
            {
                yield return coroutine.Current;
            }
        }

        /// <summary> Executes coroutine from 'provider' method until it finishes </summary>
        public static IEnumerator<T> Yield<T>(Func<IEnumerator<T>> provider)
        {
            var coroutine = provider();
            while (coroutine.MoveNext())
            {
                yield return coroutine.Current;
            }
        }

        /// <summary> Yields break </summary>
        public static IEnumerator YieldBreak()
        {
            yield break;
        }
        #endregion

        #region Yield into
        /// <summary> Executes 'provider' method into 'consumer' method once </summary>
        public static IEnumerator YieldInto<T>(Func<T> provider, Action<T> consumer)
        {
            consumer(provider());
            yield return null;
        }

        /// <summary> Executes 'provider' method into 'consumer' event once </summary>
        public static IEnumerator YieldInto<T>(Func<T> provider, UnityEvent<T> consumer)
        {
            consumer.Invoke(provider());
            yield return null;
        }

        /// <summary> Executes coroutine into 'consumer' method </summary>
        public static IEnumerator YieldInto<T>(IEnumerator<T> coroutine, Action<T> consumer)
        {
            while (coroutine.MoveNext())
            {
                consumer(coroutine.Current);
                yield return null;
            }
        }

        /// <summary> Executes coroutine into 'consumer' event </summary>
        public static IEnumerator YieldInto<T>(IEnumerator<T> coroutine, UnityEvent<T> consumer)
        {
            while (coroutine.MoveNext())
            {
                consumer.Invoke(coroutine.Current);
                yield return null;
            }
        }

        /// <summary> Executes coroutine into 'parser' method </summary>
        public static IEnumerator<U> YieldInto<T, U>(IEnumerator<T> coroutine, Func<T, U> parser)
        {
            while (coroutine.MoveNext())
            {
                yield return parser(coroutine.Current);
            }
        }
        #endregion

        #region Yield await
        /// <summary> Awaits 'verifier' method evaluate to true before finishing </summary>
        public static IEnumerator YieldAwait(Func<bool> verifier)
        {
            while (!verifier())
            {
                yield return null;
            }
        }

        /// <summary> Awaits yield instruction finish </summary>
        public static IEnumerator YieldAwait(YieldInstruction yield)
        {
            yield return yield;
        }

        /// <summary> Awaits coroutine finish </summary>
        public static IEnumerator YieldAwait(Coroutine coroutine)
        {
            yield return coroutine;
        }
        #endregion

        #region Yield if
        /// <summary> Executes coroutine only if 'verifier' method evaluates to true </summary>
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

        /// <summary> Executes coroutine only if 'verifier' method evaluates to true </summary>
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
        #endregion

        #region Yield while
        /// <summary> Executes 'action' method while 'verifier' method evaluates to true </summary>
        public static IEnumerator YieldWhile(Action action, Func<bool> verifier)
        {
            while (verifier())
            {
                action();
                yield return null;
            }
        }

        /// <summary> Executes 'action' uevent while 'verifier' method evaluates to true </summary>
        public static IEnumerator YieldWhile(UnityEvent action, Func<bool> verifier)
        {
            while (verifier())
            {
                action.Invoke();
                yield return null;
            }
        }

        /// <summary> Yields value from 'provider' method while 'verifier' method evaluates to true </summary>
        public static IEnumerator<T> YieldWhile<T>(Func<T> provider, Func<bool> verifier)
        {
            while (verifier())
            {
                yield return provider();
            }
        }
        
        /// <summary> Executes coroutine while 'verifier' method evaluates to true </summary>
        public static IEnumerator YieldWhile(IEnumerator coroutine, Func<bool> verifier)
        {
            while (verifier() && coroutine.MoveNext())
            {
                yield return coroutine.Current;
            }
        }

        /// <summary> Executes coroutine while 'verifier' method evaluates to true </summary>
        public static IEnumerator<T> YieldWhile<T>(IEnumerator<T> coroutine, Func<bool> verifier)
        {
            while (verifier() && coroutine.MoveNext())
            {
                yield return coroutine.Current;
            }
        }
        #endregion

        #region Yield do while
        /// <summary> Executes 'action' method at least once and while 'verifier' method evaluates to true </summary>
        public static IEnumerator YieldDoWhile(Action action, Func<bool> verifier)
        {
            do
            {
                action();
                yield return null;
            }
            while (verifier());
        }

        /// <summary> Executes 'action' uevent at least once and while 'verifier' method evaluates to true </summary>
        public static IEnumerator YieldDoWhile(UnityEvent action, Func<bool> verifier)
        {
            do
            {
                action.Invoke();
                yield return null;
            }
            while (verifier());
        }

        /// <summary> Yields value from 'provider' method at least once and while 'verifier' method evaluates to true </summary>
        public static IEnumerator<T> YieldDoWhile<T>(Func<T> provider, Func<bool> verifier)
        {
            do
            {
                yield return provider();
            }
            while (verifier());
        }

        /// <summary> Executes coroutine at least once and while 'verifier' method evaluates to true </summary>
        public static IEnumerator YieldDoWhile(IEnumerator coroutine, Func<bool> verifier)
        {
            do
            {
                yield return coroutine.Current;
            }
            while (verifier() && coroutine.MoveNext());
        }

        /// <summary> Executes coroutine at least once and while 'verifier' method evaluates to true </summary>
        public static IEnumerator<T> YieldDoWhile<T>(IEnumerator<T> coroutine, Func<bool> verifier)
        {
            do
            {
                yield return coroutine.Current;
            }
            while (verifier() && coroutine.MoveNext());
        }
        #endregion

        #region Yield until
        /// <summary> Executes 'action' method until coroutine finishes </summary>
        public static IEnumerator YieldUntil(Action action, IEnumerator coroutine)
        {
            while (coroutine.MoveNext())
            {
                action();
                yield return coroutine.Current;
            }
        }

        /// <summary> Executes 'action' uevent until coroutine finishes </summary>
        public static IEnumerator YieldUntil(UnityEvent action, IEnumerator coroutine)
        {
            while (coroutine.MoveNext())
            {
                action.Invoke();
                yield return coroutine.Current;
            }
        }

        /// <summary> Executes 'action' method until coroutine finishes </summary>
        public static IEnumerator<T> YieldUntil<T>(Action action, IEnumerator<T> coroutine)
        {
            while (coroutine.MoveNext())
            {
                action();
                yield return coroutine.Current;
            }
        }

        /// <summary> Executes 'action' uevent until coroutine finishes </summary>
        public static IEnumerator<T> YieldUntil<T>(UnityEvent action, IEnumerator<T> coroutine)
        {
            while (coroutine.MoveNext())
            {
                action.Invoke();
                yield return coroutine.Current;
            }
        }
        #endregion

        #region Yield when
        /// <summary> Executes coroutine only when 'verifier' method evaluates to true, otherwise awaits </summary>
        public static IEnumerator YieldWhen(IEnumerator coroutine, Func<bool> verifier)
        {
            while (true)
            {
                if (verifier())
                {
                    if (coroutine.MoveNext())
                    {
                        yield return coroutine.Current;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
        #endregion

        #region Yield repeat
        /// <summary> Executes coroutine from 'provider' method a number of times </summary>
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

        /// <summary> Executes coroutine from 'provider' method a number of times </summary>
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
        /// <summary> Yields nothing infinitely </summary>
        public static IEnumerator YieldInfinitely()
        {
            while (true)
            {
                yield return null;
            }
        }

        /// <summary> Executes coroutine from 'provider' method infinite amount of times </summary>
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

        /// <summary> Executes coroutine from 'provider' method infinite amount of time </summary>
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

        #region Yield in sequence
        /// <summary> Executes two coroutines one after another </summary>
        public static IEnumerator YieldInSequence(IEnumerator first, IEnumerator second)
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

        /// <summary> Executes two coroutines one after another </summary>
        public static IEnumerator<T> YieldInSequence<T>(IEnumerator<T> first, IEnumerator<T> second)
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

        /// <summary> Executes an arbitrary amount of coroutines one after another </summary>
        public static IEnumerator YieldInSequence(params IEnumerator[] coroutines)
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

        /// <summary> Executes an arbitrary amount of coroutines one after another </summary>
        public static IEnumerator<T> YieldInSequence<T>(params IEnumerator<T>[] coroutines)
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

        #region Yield in parallel
        /// <summary> Executes two coroutines simultaenously </summary>
        public static IEnumerator YieldInParallel(IEnumerator first, IEnumerator second)
        {
            while (first.MoveNext() | second.MoveNext())
            {
                yield return null;
            }
        }

        /// <summary> Executes an arbitrary amount of coroutines simultaenously </summary>
        public static IEnumerator YieldInParallel(params IEnumerator[] coroutines)
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
        /// <summary> Yields delta time for a duration </summary>
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

        /// <summary> Yields unscaled delta time for a duration </summary>
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

        /// <summary> Yields time for a duration </summary>
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

        /// <summary> Yields unscaled time for a duration </summary>
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

        /// <summary> Yields normalized time for a duration </summary>
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

        /// <summary> Yields normalized unscaled time for a duration </summary>
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

        /// <summary> Yields normalized time, eased by 'easer' method </summary>
        public static IEnumerator<float> YieldTime(float duration, Func<float, float> easer = null)
        {
            return YieldTimeNormalized(duration)
                .Eased(easer);
        }

        /// <summary> Yields normalized unscaled time, eased by 'easer' method </summary>
        public static IEnumerator<float> YieldRealtime(float duration, Func<float, float> easer = null)
        {
            return YieldRealtimeNormalized(duration)
                .Eased(easer);
        }

        /// <summary> Yields delta time, eased by 'easer' method </summary>
        public static IEnumerator<float> YieldDeltaTime(float duration, Func<float, float> easer = null)
        {
            return YieldDeltaTime(duration)
                .Eased(easer);
        }

        /// <summary> Yields unscaled delta time, eased by 'easer' method </summary>
        public static IEnumerator<float> YieldDeltaRealtime(float duration, Func<float, float> easer = null)
        {
            return YieldDeltaRealtime(duration)
                .Eased(easer);
        }
        #endregion

        #region Yield frames
        /// <summary> Yields a frame </summary>
        public static IEnumerator YieldFrame()
        {
            yield return null;
        }

        /// <summary> Yields frames for a number of frames </summary>
        public static IEnumerator<int> YieldFrames(int frames)
        {
            yield return frames;
            while (frames > 0)
            {
                yield return --frames;
            }
        }
        #endregion

        #region Yield value
        /// <summary> Yields value from 'evaluator' method, fed by values from timer </summary>
        public static IEnumerator<T> YieldValue<T>(Func<float, T> evaluator, IEnumerator<float> timer)
        {
            return timer.Into(evaluator);
        }

        /// <summary> Yields value from 'evaluator' method, fed by values from timer, directly into 'setter' method </summary>
        public static IEnumerator YieldValueTo<T>(Func<float, T> evaluator, Action<T> setter, IEnumerator<float> timer)
        {
            return timer.Into(evaluator).Into(setter);
        }

        /// <summary> Yields value from 'parser' method, fed by start, target and timer values </summary>
        public static IEnumerator<T> YieldValue<T>(T start, T target, Func<T, T, float, T> parser, IEnumerator<float> timer)
        {
            while (timer.MoveNext())
            {
                var t = timer.Current;
                var v = parser(start, target, t);

                yield return v;
            }
        }

        /// <summary> Yields value from 'parser' method, fed by start, target and timer values, into 'setter' method </summary>
        public static IEnumerator YieldValueTo<T>(T start, T target, Action<T> setter, Func<T, T, float, T> parser, IEnumerator<float> timer)
        {
            while (timer.MoveNext())
            {
                var t = timer.Current;
                var v = parser(start, target, t);
                setter(v);

                yield return null;
            }
        }

        /// <summary> Yields value from 'parser' method, fed by values from timer, along with a start value from 'getter' method and target, into 'setter' method </summary>
        public static IEnumerator YieldValueTo<T>(Func<T> getter, T target, Action<T> setter, Func<T, T, float, T> parser, IEnumerator<float> timer)
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

        /// <summary> Yields value from 'parser' method, fed by start, target and timer values, into 'setter' method </summary>
        public static IEnumerator YieldValueTo<T>(T start, Func<T> provider, Action<T> setter, Func<T, T, float, T> parser, IEnumerator<float> timer)
        {
            var target = provider();
            while (timer.MoveNext())
            {
                var t = timer.Current;
                var v = parser(start, target, t);
                setter(v);

                yield return null;
            }
        }

        /// <summary> Yields value from 'parser' method, fed by values from timer, along with a start value from 'getter' method and target value from 'provider' method, into 'setter' method </summary>
        public static IEnumerator YieldValueTo<T>(Func<T> getter, Func<T> provider, Action<T> setter, Func<T, T, float, T> parser, IEnumerator<float> timer)
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
        public static IEnumerator<float> YieldValue(float start, float target, IEnumerator<float> timer)
            => YieldValue(start, target, UMath.Lerp, timer);

        public static IEnumerator YieldValueTo(float start, float target, Action<float> setter, IEnumerator<float> timer)
            => YieldValueTo(start, target, setter, UMath.Lerp, timer);

        public static IEnumerator YieldValueTo(Func<float> getter, float target, Action<float> setter, IEnumerator<float> timer)
            => YieldValueTo(getter, target, setter, UMath.Lerp, timer);

        public static IEnumerator YieldValueTo(float start, Func<float> provider, Action<float> setter, IEnumerator<float> timer)
            => YieldValueTo(start, provider, setter, UMath.Lerp, timer);

        public static IEnumerator YieldValueTo(Func<float> getter, Func<float> provider, Action<float> setter, IEnumerator<float> timer)
            => YieldValueTo(getter, provider, setter, UMath.Lerp, timer);
        #endregion

        #region Ints
        public static IEnumerator<int> YieldValue(int start, int target, IEnumerator<float> timer)
            => YieldValue(start, target, UMath.Lerp, timer);

        public static IEnumerator YieldValueTo(int start, int target, Action<int> setter, IEnumerator<float> timer)
            => YieldValueTo(start, target, setter, UMath.Lerp, timer);

        public static IEnumerator YieldValueTo(Func<int> getter, int target, Action<int> setter, IEnumerator<float> timer)
            => YieldValueTo(getter, target, setter, UMath.Lerp, timer);

        public static IEnumerator YieldValueTo(int start, Func<int> provider, Action<int> setter, IEnumerator<float> timer)
            => YieldValueTo(start, provider, setter, UMath.Lerp, timer);

        public static IEnumerator YieldValueTo(Func<int> getter, Func<int> provider, Action<int> setter, IEnumerator<float> timer)
            => YieldValueTo(getter, provider, setter, UMath.Lerp, timer);
        #endregion

        #region Vector2s
        public static IEnumerator<Vector2> YieldValue(Vector2 start, Vector2 target, IEnumerator<float> timer)
            => YieldValue(start, target, UMath.Lerp, timer);

        public static IEnumerator YieldValueTo(Vector2 start, Vector2 target, Action<Vector2> setter, IEnumerator<float> timer)
            => YieldValueTo(start, target, setter, UMath.Lerp, timer);

        public static IEnumerator YieldValueTo(Func<Vector2> getter, Vector2 target, Action<Vector2> setter, IEnumerator<float> timer)
            => YieldValueTo(getter, target, setter, UMath.Lerp, timer);

        public static IEnumerator YieldValueTo(Vector2 start, Func<Vector2> provider, Action<Vector2> setter, IEnumerator<float> timer)
            => YieldValueTo(start, provider, setter, UMath.Lerp, timer);

        public static IEnumerator YieldValueTo(Func<Vector2> getter, Func<Vector2> provider, Action<Vector2> setter, IEnumerator<float> timer)
            => YieldValueTo(getter, provider, setter, UMath.Lerp, timer);
        #endregion

        #region Vector2Ints
        public static IEnumerator<Vector2Int> YieldValue(Vector2Int start, Vector2Int target, IEnumerator<float> timer)
            => YieldValue(start, target, UMath.Lerp, timer);

        public static IEnumerator YieldValueTo(Vector2Int start, Vector2Int target, Action<Vector2Int> setter, IEnumerator<float> timer)
            => YieldValueTo(start, target, setter, UMath.Lerp, timer);

        public static IEnumerator YieldValueTo(Func<Vector2Int> getter, Vector2Int target, Action<Vector2Int> setter, IEnumerator<float> timer)
            => YieldValueTo(getter, target, setter, UMath.Lerp, timer);

        public static IEnumerator YieldValueTo(Vector2Int start, Func<Vector2Int> provider, Action<Vector2Int> setter, IEnumerator<float> timer)
            => YieldValueTo(start, provider, setter, UMath.Lerp, timer);

        public static IEnumerator YieldValueTo(Func<Vector2Int> getter, Func<Vector2Int> provider, Action<Vector2Int> setter, IEnumerator<float> timer)
            => YieldValueTo(getter, provider, setter, UMath.Lerp, timer);
        #endregion

        #region Vector3s
        public static IEnumerator<Vector3> YieldValue(Vector3 start, Vector3 target, IEnumerator<float> timer)
            => YieldValue(start, target, UMath.Lerp, timer);

        public static IEnumerator YieldValueTo(Vector3 start, Vector3 target, Action<Vector3> setter, IEnumerator<float> timer)
            => YieldValueTo(start, target, setter, UMath.Lerp, timer);

        public static IEnumerator YieldValueTo(Func<Vector3> getter, Vector3 target, Action<Vector3> setter, IEnumerator<float> timer)
            => YieldValueTo(getter, target, setter, UMath.Lerp, timer);

        public static IEnumerator YieldValueTo(Vector3 start, Func<Vector3> provider, Action<Vector3> setter, IEnumerator<float> timer)
            => YieldValueTo(start, provider, setter, UMath.Lerp, timer);

        public static IEnumerator YieldValueTo(Func<Vector3> getter, Func<Vector3> provider, Action<Vector3> setter, IEnumerator<float> timer)
            => YieldValueTo(getter, provider, setter, UMath.Lerp, timer);
        #endregion

        #region Vector3Ints
        public static IEnumerator<Vector3Int> YieldValue(Vector3Int start, Vector3Int target, IEnumerator<float> timer)
            => YieldValue(start, target, UMath.Lerp, timer);

        public static IEnumerator YieldValueTo(Vector3Int start, Vector3Int target, Action<Vector3Int> setter, IEnumerator<float> timer)
            => YieldValueTo(start, target, setter, UMath.Lerp, timer);

        public static IEnumerator YieldValueTo(Func<Vector3Int> getter, Vector3Int target, Action<Vector3Int> setter, IEnumerator<float> timer)
            => YieldValueTo(getter, target, setter, UMath.Lerp, timer);

        public static IEnumerator YieldValueTo(Vector3Int start, Func<Vector3Int> provider, Action<Vector3Int> setter, IEnumerator<float> timer)
            => YieldValueTo(start, provider, setter, UMath.Lerp, timer);

        public static IEnumerator YieldValueTo(Func<Vector3Int> getter, Func<Vector3Int> provider, Action<Vector3Int> setter, IEnumerator<float> timer)
            => YieldValueTo(getter, provider, setter, UMath.Lerp, timer);
        #endregion

        #region Vector4s
        public static IEnumerator<Vector4> YieldValue(Vector4 start, Vector4 target, IEnumerator<float> timer)
            => YieldValue(start, target, UMath.Lerp, timer);

        public static IEnumerator YieldValueTo(Vector4 start, Vector4 target, Action<Vector4> setter, IEnumerator<float> timer)
            => YieldValueTo(start, target, setter, UMath.Lerp, timer);

        public static IEnumerator YieldValueTo(Func<Vector4> getter, Vector4 target, Action<Vector4> setter, IEnumerator<float> timer)
            => YieldValueTo(getter, target, setter, UMath.Lerp, timer);

        public static IEnumerator YieldValueTo(Vector4 start, Func<Vector4> provider, Action<Vector4> setter, IEnumerator<float> timer)
            => YieldValueTo(start, provider, setter, UMath.Lerp, timer);

        public static IEnumerator YieldValueTo(Func<Vector4> getter, Func<Vector4> provider, Action<Vector4> setter, IEnumerator<float> timer)
            => YieldValueTo(getter, provider, setter, UMath.Lerp, timer);
        #endregion

        #region Quaternions
        public static IEnumerator<Quaternion> YieldValue(Quaternion start, Quaternion target, IEnumerator<float> timer)
            => YieldValue(start, target, UMath.Lerp, timer);

        public static IEnumerator YieldValueTo(Quaternion start, Quaternion target, Action<Quaternion> setter, IEnumerator<float> timer)
            => YieldValueTo(start, target, setter, UMath.Lerp, timer);

        public static IEnumerator YieldValueTo(Func<Quaternion> getter, Quaternion target, Action<Quaternion> setter, IEnumerator<float> timer)
            => YieldValueTo(getter, target, setter, UMath.Lerp, timer);

        public static IEnumerator YieldValueTo(Quaternion start, Func<Quaternion> provider, Action<Quaternion> setter, IEnumerator<float> timer)
            => YieldValueTo(start, provider, setter, UMath.Lerp, timer);

        public static IEnumerator YieldValueTo(Func<Quaternion> getter, Func<Quaternion> provider, Action<Quaternion> setter, IEnumerator<float> timer)
            => YieldValueTo(getter, provider, setter, UMath.Lerp, timer);
        #endregion

        #region Colors
        public static IEnumerator<Color> YieldValue(Color start, Color target, IEnumerator<float> timer)
            => YieldValue(start, target, UMath.Lerp, timer);

        public static IEnumerator YieldValueTo(Color start, Color target, Action<Color> setter, IEnumerator<float> timer)
            => YieldValueTo(start, target, setter, UMath.Lerp, timer);

        public static IEnumerator YieldValueTo(Func<Color> getter, Color target, Action<Color> setter, IEnumerator<float> timer)
            => YieldValueTo(getter, target, setter, UMath.Lerp, timer);

        public static IEnumerator YieldValueTo(Color start, Func<Color> provider, Action<Color> setter, IEnumerator<float> timer)
            => YieldValueTo(start, provider, setter, UMath.Lerp, timer);

        public static IEnumerator YieldValueTo(Func<Color> getter, Func<Color> provider, Action<Color> setter, IEnumerator<float> timer)
            => YieldValueTo(getter, provider, setter, UMath.Lerp, timer);
        #endregion

        #region Rects
        public static IEnumerator<Rect> YieldValue(Rect start, Rect target, IEnumerator<float> timer)
            => YieldValue(start, target, UMath.Lerp, timer);

        public static IEnumerator YieldValueTo(Rect start, Rect target, Action<Rect> setter, IEnumerator<float> timer)
            => YieldValueTo(start, target, setter, UMath.Lerp, timer);

        public static IEnumerator YieldValueTo(Func<Rect> getter, Rect target, Action<Rect> setter, IEnumerator<float> timer)
            => YieldValueTo(getter, target, setter, UMath.Lerp, timer);

        public static IEnumerator YieldValueTo(Rect start, Func<Rect> provider, Action<Rect> setter, IEnumerator<float> timer)
            => YieldValueTo(start, provider, setter, UMath.Lerp, timer);

        public static IEnumerator YieldValueTo(Func<Rect> getter, Func<Rect> provider, Action<Rect> setter, IEnumerator<float> timer)
            => YieldValueTo(getter, provider, setter, UMath.Lerp, timer);
        #endregion

        #region Time
        public static IEnumerator CoTimeScale(float target, float duration, Func<float, float> easer = null)
            => YieldValueTo(UTime.GetTimeScale, target, UTime.SetTimeScale, YieldRealtime(duration, easer));

        public static IEnumerator CoFixedDeltaTime(float target, float duration, Func<float, float> easer = null)
            => YieldValueTo(UTime.GetFixedDeltaTime, target, UTime.SetFixedDeltaTime, YieldRealtime(duration, easer));

        public static IEnumerator CoMaximumDeltaTime(float target, float duration, Func<float, float> easer = null)
            => YieldValueTo(UTime.GetMaximumDeltaTime, target, UTime.SetMaximumDeltaTime, YieldRealtime(duration, easer));

        public static IEnumerator CoMaximumParticleDeltaTime(float target, float duration, Func<float, float> easer = null)
            => YieldValueTo(UTime.GetMaximumParticleDeltaTime, target, UTime.SetMaximumParticleDeltaTime, YieldRealtime(duration, easer));
        #endregion

        #region Misc
        public static void SafeStop(ref Coroutine coroutine, MonoBehaviour target)
        {
            if (coroutine != null)
            {
                coroutine.Stop(target);
                coroutine = null;
            }
        }
        #endregion
    }
}
