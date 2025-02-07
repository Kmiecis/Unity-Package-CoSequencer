using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Common.Coroutines
{
    public static class Yield
    {
        /// <summary> Convenient starting point when theres none </summary>
        public static IEnumerator Begin()
        {
            yield return null;
        }

        #region Yield
        /// <summary> Yields nothing </summary>
        public static IEnumerator Empty()
        {
            yield return null;
        }

        /// <summary> Yields break </summary>
        public static IEnumerator Break()
        {
            yield break;
        }
        #endregion

        #region Yield frames
        /// <summary> Yields a single frame</summary>
        public static IEnumerator Frame()
        {
            yield return null;
        }

        /// <summary> Yields frames for a number of frames </summary>
        public static IEnumerator<int> Frames(int frames)
        {
            yield return frames;
            while (frames > 0)
            {
                yield return --frames;
            }
        }
        #endregion

        #region Yield invoke
        /// <summary> Executes 'action' method once </summary>
        public static IEnumerator Invoke(Action action)
        {
            action();
            yield return null;
        }

        /// <summary> Executes 'action' uevent once </summary>
        public static IEnumerator Invoke(UnityEvent action)
        {
            action.Invoke();
            yield return null;
        }
        #endregion

        #region Yield coroutine
        /// <summary> Executes coroutine until it finishes </summary>
        public static IEnumerator Coroutine(IEnumerator coroutine)
        {
            while (coroutine.MoveNext())
            {
                yield return coroutine.Current;
            }
        }

        /// <summary> Executes coroutine until it finishes </summary>
        public static IEnumerator<T> Coroutine<T>(IEnumerator<T> coroutine)
        {
            while (coroutine.MoveNext())
            {
                yield return coroutine.Current;
            }
        }

        /// <summary> Executes coroutine from 'provider' method until it finishes </summary>
        public static IEnumerator Coroutine(Func<IEnumerator> provider)
        {
            var coroutine = provider();
            while (coroutine.MoveNext())
            {
                yield return coroutine.Current;
            }
        }

        /// <summary> Executes coroutine from 'provider' method until it finishes </summary>
        public static IEnumerator<T> Coroutine<T>(Func<IEnumerator<T>> provider)
        {
            var coroutine = provider();
            while (coroutine.MoveNext())
            {
                yield return coroutine.Current;
            }
        }
        #endregion

        #region Yield into
        /// <summary> Executes 'value' into 'consumer' method once </summary>
        public static IEnumerator Into<T>(T value, Action<T> consumer)
        {
            consumer(value);
            yield return null;
        }

        /// <summary> Executes 'value' into 'consumer' method once </summary>
        public static IEnumerator Into<T>(T value, UnityEvent<T> consumer)
        {
            consumer.Invoke(value);
            yield return null;
        }

        /// <summary> Executes 'provider' method into 'consumer' method once </summary>
        public static IEnumerator Into<T>(Func<T> provider, Action<T> consumer)
        {
            consumer(provider());
            yield return null;
        }

        /// <summary> Executes 'provider' method into 'consumer' event once </summary>
        public static IEnumerator Into<T>(Func<T> provider, UnityEvent<T> consumer)
        {
            consumer.Invoke(provider());
            yield return null;
        }

        /// <summary> Executes coroutine into 'consumer' method </summary>
        public static IEnumerator Into<T>(IEnumerator<T> coroutine, Action<T> consumer)
        {
            while (coroutine.MoveNext())
            {
                consumer(coroutine.Current);
                yield return null;
            }
        }

        /// <summary> Executes coroutine into 'consumer' event </summary>
        public static IEnumerator Into<T>(IEnumerator<T> coroutine, UnityEvent<T> consumer)
        {
            while (coroutine.MoveNext())
            {
                consumer.Invoke(coroutine.Current);
                yield return null;
            }
        }

        /// <summary> Executes coroutine from 'provider' into 'consumer' method </summary>
        public static IEnumerator Into<T>(Func<IEnumerator<T>> provider, Action<T> consumer)
        {
            var coroutine = provider();
            while (coroutine.MoveNext())
            {
                consumer(coroutine.Current);
                yield return null;
            }
        }

        /// <summary> Executes coroutine from 'provider' into 'consumer' event </summary>
        public static IEnumerator Into<T>(Func<IEnumerator<T>> provider, UnityEvent<T> consumer)
        {
            var coroutine = provider();
            while (coroutine.MoveNext())
            {
                consumer.Invoke(coroutine.Current);
                yield return null;
            }
        }

        /// <summary> Executes coroutine into 'parser' method </summary>
        public static IEnumerator<U> Into<T, U>(IEnumerator<T> coroutine, Func<T, U> parser)
        {
            while (coroutine.MoveNext())
            {
                yield return parser(coroutine.Current);
            }
        }

        /// <summary> Executes coroutine from 'provider' into 'parser' method </summary>
        public static IEnumerator<U> Into<T, U>(Func<IEnumerator<T>> provider, Func<T, U> parser)
        {
            var coroutine = provider();
            while (coroutine.MoveNext())
            {
                yield return parser(coroutine.Current);
            }
        }
        #endregion

        #region Yield await
        /// <summary> Awaits 'verifier' method evaluate to true before finishing </summary>
        public static IEnumerator Await(Func<bool> verifier)
        {
            while (!verifier())
            {
                yield return null;
            }
        }

        /// <summary> Awaits yield instruction finish </summary>
        public static IEnumerator Await(YieldInstruction yield)
        {
            yield return yield;
        }

        /// <summary> Awaits coroutine finish </summary>
        public static IEnumerator Await(Coroutine coroutine)
        {
            yield return coroutine;
        }
        #endregion

        #region Yield if
        /// <summary> Executes coroutine only if 'verifier' method evaluates to true </summary>
        public static IEnumerator If(IEnumerator coroutine, Func<bool> verifier)
        {
            if (verifier())
            {
                while (coroutine.MoveNext())
                {
                    yield return coroutine.Current;
                }
            }
        }

        /// <summary> Executes coroutine from 'provider' only if 'verifier' method evaluates to true </summary>
        public static IEnumerator If(Func<IEnumerator> provider, Func<bool> verifier)
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

        /// <summary> Executes coroutine only if 'verifier' method evaluates to true </summary>
        public static IEnumerator<T> If<T>(IEnumerator<T> coroutine, Func<bool> verifier)
        {
            if (verifier())
            {
                while (coroutine.MoveNext())
                {
                    yield return coroutine.Current;
                }
            }
        }

        /// <summary> Executes coroutine from 'provider' only if 'verifier' method evaluates to true </summary>
        public static IEnumerator<T> If<T>(Func<IEnumerator<T>> provider, Func<bool> verifier)
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
        /// <summary> Executes 'action' method while 'verifier' method evaluates to true </summary>
        public static IEnumerator While(Action action, Func<bool> verifier)
        {
            while (verifier())
            {
                action();
                yield return null;
            }
        }

        /// <summary> Executes 'action' uevent while 'verifier' method evaluates to true </summary>
        public static IEnumerator While(UnityEvent action, Func<bool> verifier)
        {
            while (verifier())
            {
                action.Invoke();
                yield return null;
            }
        }

        /// <summary> Yields value from 'provider' method while 'verifier' method evaluates to true </summary>
        public static IEnumerator<T> While<T>(Func<T> provider, Func<bool> verifier)
        {
            while (verifier())
            {
                yield return provider();
            }
        }
        
        /// <summary> Executes coroutine while 'verifier' method evaluates to true </summary>
        public static IEnumerator While(IEnumerator coroutine, Func<bool> verifier)
        {
            while (verifier() && coroutine.MoveNext())
            {
                yield return coroutine.Current;
            }
        }

        /// <summary> Executes coroutine from 'provider' while 'verifier' method evaluates to true </summary>
        public static IEnumerator While(Func<IEnumerator> provider, Func<bool> verifier)
        {
            var coroutine = provider();
            while (verifier() && coroutine.MoveNext())
            {
                yield return coroutine.Current;
            }
        }

        /// <summary> Executes coroutine while 'verifier' method evaluates to true </summary>
        public static IEnumerator<T> While<T>(IEnumerator<T> coroutine, Func<bool> verifier)
        {
            while (verifier() && coroutine.MoveNext())
            {
                yield return coroutine.Current;
            }
        }

        /// <summary> Executes coroutine from 'provider' while 'verifier' method evaluates to true </summary>
        public static IEnumerator<T> While<T>(Func<IEnumerator<T>> provider, Func<bool> verifier)
        {
            var coroutine = provider();
            while (verifier() && coroutine.MoveNext())
            {
                yield return coroutine.Current;
            }
        }
        #endregion

        #region Yield do while
        /// <summary> Executes 'action' method at least once and while 'verifier' method evaluates to true </summary>
        public static IEnumerator DoWhile(Action action, Func<bool> verifier)
        {
            do
            {
                action();
                yield return null;
            }
            while (verifier());
        }

        /// <summary> Executes 'action' uevent at least once and while 'verifier' method evaluates to true </summary>
        public static IEnumerator DoWhile(UnityEvent action, Func<bool> verifier)
        {
            do
            {
                action.Invoke();
                yield return null;
            }
            while (verifier());
        }

        /// <summary> Yields value from 'provider' method at least once and while 'verifier' method evaluates to true </summary>
        public static IEnumerator<T> DoWhile<T>(Func<T> provider, Func<bool> verifier)
        {
            do
            {
                yield return provider();
            }
            while (verifier());
        }

        /// <summary> Executes coroutine at least once and while 'verifier' method evaluates to true </summary>
        public static IEnumerator DoWhile(IEnumerator coroutine, Func<bool> verifier)
        {
            do
            {
                yield return coroutine.Current;
            }
            while (verifier() && coroutine.MoveNext());
        }

        /// <summary> Executes coroutine from 'provider' at least once and while 'verifier' method evaluates to true </summary>
        public static IEnumerator DoWhile(Func<IEnumerator> provider, Func<bool> verifier)
        {
            var coroutine = provider();
            do
            {
                yield return coroutine.Current;
            }
            while (verifier() && coroutine.MoveNext());
        }

        /// <summary> Executes coroutine at least once and while 'verifier' method evaluates to true </summary>
        public static IEnumerator<T> DoWhile<T>(IEnumerator<T> coroutine, Func<bool> verifier)
        {
            do
            {
                yield return coroutine.Current;
            }
            while (verifier() && coroutine.MoveNext());
        }

        /// <summary> Executes coroutine from 'provider' at least once and while 'verifier' method evaluates to true </summary>
        public static IEnumerator<T> DoWhile<T>(Func<IEnumerator<T>> provider, Func<bool> verifier)
        {
            var coroutine = provider();
            do
            {
                yield return coroutine.Current;
            }
            while (verifier() && coroutine.MoveNext());
        }
        #endregion

        #region Yield until
        /// <summary> Executes 'action' method until coroutine finishes </summary>
        public static IEnumerator Until(Action action, IEnumerator coroutine)
        {
            while (coroutine.MoveNext())
            {
                action();
                yield return coroutine.Current;
            }
        }

        /// <summary> Executes 'action' uevent until coroutine finishes </summary>
        public static IEnumerator Until(UnityEvent action, IEnumerator coroutine)
        {
            while (coroutine.MoveNext())
            {
                action.Invoke();
                yield return coroutine.Current;
            }
        }

        /// <summary> Executes 'action' method until coroutine finishes </summary>
        public static IEnumerator<T> Until<T>(Action action, IEnumerator<T> coroutine)
        {
            while (coroutine.MoveNext())
            {
                action();
                yield return coroutine.Current;
            }
        }

        /// <summary> Executes 'action' uevent until coroutine finishes </summary>
        public static IEnumerator<T> Until<T>(UnityEvent action, IEnumerator<T> coroutine)
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
        public static IEnumerator When(IEnumerator coroutine, Func<bool> verifier)
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
        public static IEnumerator Repeat(Func<IEnumerator> provider, int repeats)
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
        public static IEnumerator<T> Repeat<T>(Func<IEnumerator<T>> provider, int repeats)
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
        public static IEnumerator Infinitely()
        {
            while (true)
            {
                yield return null;
            }
        }

        /// <summary> Executes coroutine from 'provider' method infinite amount of times </summary>
        public static IEnumerator Infinitely(Func<IEnumerator> provider)
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
        public static IEnumerator<T> Infinitely<T>(Func<IEnumerator<T>> provider)
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
        public static IEnumerator Sequence(IEnumerator first, IEnumerator second)
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

        /// <summary> Executes two coroutines from providers one after another </summary>
        public static IEnumerator Sequence(Func<IEnumerator> first, Func<IEnumerator> second)
        {
            var coroutine = first();
            while (coroutine.MoveNext())
            {
                yield return coroutine.Current;
            }
            coroutine = second();
            while (coroutine.MoveNext())
            {
                yield return coroutine.Current;
            }
        }

        /// <summary> Executes two coroutines one after another </summary>
        public static IEnumerator<T> Sequence<T>(IEnumerator<T> first, IEnumerator<T> second)
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

        /// <summary> Executes two coroutines from providers one after another </summary>
        public static IEnumerator<T> Sequence<T>(Func<IEnumerator<T>> first, Func<IEnumerator<T>> second)
        {
            var coroutine = first();
            while (coroutine.MoveNext())
            {
                yield return coroutine.Current;
            }
            coroutine = second();
            while (coroutine.MoveNext())
            {
                yield return coroutine.Current;
            }
        }

        /// <summary> Executes an arbitrary amount of coroutines one after another </summary>
        public static IEnumerator Sequence(params IEnumerator[] coroutines)
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

        /// <summary> Executes an arbitrary amount of coroutines from providers one after another </summary>
        public static IEnumerator Sequence(params Func<IEnumerator>[] providers)
        {
            for (int i = 0; i < providers.Length; ++i)
            {
                var provider = providers[i];
                var coroutine = provider();
                while (coroutine.MoveNext())
                {
                    yield return coroutine.Current;
                }
            }
        }

        /// <summary> Executes an arbitrary amount of coroutines from providers one after another </summary>
        public static IEnumerator<T> Sequence<T>(params Func<IEnumerator<T>>[] providers)
        {
            for (int i = 0; i < providers.Length; ++i)
            {
                var provider = providers[i];
                var coroutine = provider();
                while (coroutine.MoveNext())
                {
                    yield return coroutine.Current;
                }
            }
        }
        #endregion

        #region Yield in parallel
        /// <summary> Executes two coroutines simultaenously </summary>
        public static IEnumerator Parallel(IEnumerator first, IEnumerator second)
        {
            while (first.MoveNext() | second.MoveNext())
            {
                yield return null;
            }
        }

        /// <summary> Executes two coroutines from providers simultaenously </summary>
        public static IEnumerator Parallel(Func<IEnumerator> first, Func<IEnumerator> second)
        {
            var firstCoroutine = first();
            var secondCoroutine = second();
            while (firstCoroutine.MoveNext() | secondCoroutine.MoveNext())
            {
                yield return null;
            }
        }

        /// <summary> Executes an arbitrary amount of coroutines simultaenously </summary>
        public static IEnumerator Parallel(params IEnumerator[] coroutines)
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
        /// <summary> Yields dynamically invoked delta time for a duration </summary>
        public static IEnumerator<float> DeltaTime(float duration, Func<float> deltaTimer)
        {
            var dt = deltaTimer();

            while (duration > dt)
            {
                yield return dt;

                duration -= dt;
                dt = deltaTimer();
            }

            yield return duration;
        }

        /// <summary> Yields delta time for a duration </summary>
        public static IEnumerator<float> DeltaTime(float duration)
        {
            var dt = UnityEngine.Time.deltaTime;

            while (duration > dt)
            {
                yield return dt;

                duration -= dt;
                dt = UnityEngine.Time.deltaTime;
            }

            yield return duration;
        }

        /// <summary> Yields unscaled delta time for a duration </summary>
        public static IEnumerator<float> DeltaRealtime(float duration)
        {
            var dt = UnityEngine.Time.unscaledDeltaTime;

            while (duration > dt)
            {
                yield return dt;

                duration -= dt;
                dt = UnityEngine.Time.unscaledDeltaTime;
            }

            yield return duration;
        }

        /// <summary> Yields dynamically invoked time for a duration </summary>
        public static IEnumerator<float> Time(float duration, Func<float> deltaTimer)
        {
            float t = deltaTimer();

            while (t < duration)
            {
                yield return t;

                t += deltaTimer();
            }

            yield return duration;
        }

        /// <summary> Yields time for a duration </summary>
        public static IEnumerator<float> Time(float duration)
        {
            float t = UnityEngine.Time.deltaTime;

            while (t < duration)
            {
                yield return t;

                t += UnityEngine.Time.deltaTime;
            }

            yield return duration;
        }

        /// <summary> Yields unscaled time for a duration </summary>
        public static IEnumerator<float> Realtime(float duration)
        {
            float t = UnityEngine.Time.unscaledDeltaTime;

            while (t < duration)
            {
                yield return t;

                t += UnityEngine.Time.unscaledDeltaTime;
            }

            yield return duration;
        }

        /// <summary> Yields normalized dynamically invoked time for a duration </summary>
        public static IEnumerator<float> TimeNormalized(float duration, Func<float> deltaTimer)
        {
            float n = 1.0f / duration;
            float t = n * deltaTimer();

            while (t < 1.0f)
            {
                yield return t;

                t += n * deltaTimer();
            }

            yield return 1.0f;
        }

        /// <summary> Yields normalized time for a duration </summary>
        public static IEnumerator<float> TimeNormalized(float duration)
        {
            float n = 1.0f / duration;
            float t = n * UnityEngine.Time.deltaTime;

            while (t < 1.0f)
            {
                yield return t;

                t += n * UnityEngine.Time.deltaTime;
            }

            yield return 1.0f;
        }

        /// <summary> Yields normalized unscaled time for a duration </summary>
        public static IEnumerator<float> RealtimeNormalized(float duration)
        {
            float n = 1.0f / duration;
            float t = n * UnityEngine.Time.unscaledDeltaTime;

            while (t < 1.0f)
            {
                yield return t;

                t += n * UnityEngine.Time.unscaledDeltaTime;
            }

            yield return 1.0f;
        }

        /// <summary> Yields dynamically invoked delta time, eased by 'easer' method </summary>
        public static IEnumerator<float> DeltaTime(float duration, Func<float> deltaTimer, Func<float, float> easer = null)
        {
            return DeltaTime(duration, deltaTimer)
                .Eased(easer);
        }

        /// <summary> Yields delta time, eased by 'easer' method </summary>
        public static IEnumerator<float> DeltaTime(float duration, Func<float, float> easer = null)
        {
            return DeltaTime(duration)
                .Eased(easer);
        }

        /// <summary> Yields unscaled delta time, eased by 'easer' method </summary>
        public static IEnumerator<float> DeltaRealtime(float duration, Func<float, float> easer = null)
        {
            return DeltaRealtime(duration)
                .Eased(easer);
        }

        /// <summary> Yields normalized dynamically invoked time, eased by 'easer' method </summary>
        public static IEnumerator<float> Time(float duration, Func<float> deltaTimer, Func<float, float> easer = null)
        {
            return TimeNormalized(duration, deltaTimer)
                .Eased(easer);
        }

        /// <summary> Yields normalized time, eased by 'easer' method </summary>
        public static IEnumerator<float> Time(float duration, Func<float, float> easer = null)
        {
            return TimeNormalized(duration)
                .Eased(easer);
        }

        /// <summary> Yields normalized unscaled time, eased by 'easer' method </summary>
        public static IEnumerator<float> Realtime(float duration, Func<float, float> easer = null)
        {
            return RealtimeNormalized(duration)
                .Eased(easer);
        }
        #endregion

        #region Yield value
        /// <summary> Yields value once </summary>
        public static IEnumerator<T> Value<T>(T value)
        {
            yield return value;
        }

        /// <summary> Yields values one by one each frame </summary>
        public static IEnumerator<T> Values<T>(params T[] values)
        {
            for (int i = 0; i < values.Length; ++i)
            {
                yield return values[i];
            }
        }

        /// <summary> Yields value once from 'provider' method </summary>
        public static IEnumerator<T> Value<T>(Func<T> provider)
        {
            yield return provider();
        }

        /// <summary> Yields value from 'evaluator' method, fed by values from timer </summary>
        public static IEnumerator<T> Value<T>(Func<float, T> evaluator, IEnumerator<float> timer)
        {
            return timer.Into(evaluator);
        }

        /// <summary> Yields value from 'parser' method, fed by start, target and timer values </summary>
        public static IEnumerator<T> Value<T>(T start, T target, Func<T, T, float, T> parser, IEnumerator<float> timer)
        {
            while (timer.MoveNext())
            {
                var t = timer.Current;
                var v = parser(start, target, t);

                yield return v;
            }
        }

        /// <summary> Yields value from 'evaluator' method, fed by values from timer, directly into 'setter' method </summary>
        public static IEnumerator ValueTo<T>(Func<float, T> evaluator, Action<T> setter, IEnumerator<float> timer)
        {
            return timer.Into(evaluator).Into(setter);
        }

        /// <summary> Yields value from 'parser' method, fed by start, target and timer values, into 'setter' method </summary>
        public static IEnumerator ValueTo<T>(T start, T target, Action<T> setter, Func<T, T, float, T> parser, IEnumerator<float> timer)
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
        public static IEnumerator ValueTo<T>(Func<T> getter, T target, Action<T> setter, Func<T, T, float, T> parser, IEnumerator<float> timer)
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
        public static IEnumerator ValueTo<T>(T start, Func<T> provider, Action<T> setter, Func<T, T, float, T> parser, IEnumerator<float> timer)
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
        public static IEnumerator ValueTo<T>(Func<T> getter, Func<T> provider, Action<T> setter, Func<T, T, float, T> parser, IEnumerator<float> timer)
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
        public static IEnumerator<float> Value(float start, float target, IEnumerator<float> timer)
            => Value(start, target, UMath.Lerp, timer);

        public static IEnumerator ValueTo(float start, float target, Action<float> setter, IEnumerator<float> timer)
            => ValueTo(start, target, setter, UMath.Lerp, timer);

        public static IEnumerator ValueTo(Func<float> getter, float target, Action<float> setter, IEnumerator<float> timer)
            => ValueTo(getter, target, setter, UMath.Lerp, timer);

        public static IEnumerator ValueTo(float start, Func<float> provider, Action<float> setter, IEnumerator<float> timer)
            => ValueTo(start, provider, setter, UMath.Lerp, timer);

        public static IEnumerator ValueTo(Func<float> getter, Func<float> provider, Action<float> setter, IEnumerator<float> timer)
            => ValueTo(getter, provider, setter, UMath.Lerp, timer);
        #endregion

        #region Ints
        public static IEnumerator<int> Value(int start, int target, IEnumerator<float> timer)
            => Value(start, target, UMath.Lerp, timer);

        public static IEnumerator ValueTo(int start, int target, Action<int> setter, IEnumerator<float> timer)
            => ValueTo(start, target, setter, UMath.Lerp, timer);

        public static IEnumerator ValueTo(Func<int> getter, int target, Action<int> setter, IEnumerator<float> timer)
            => ValueTo(getter, target, setter, UMath.Lerp, timer);

        public static IEnumerator ValueTo(int start, Func<int> provider, Action<int> setter, IEnumerator<float> timer)
            => ValueTo(start, provider, setter, UMath.Lerp, timer);

        public static IEnumerator ValueTo(Func<int> getter, Func<int> provider, Action<int> setter, IEnumerator<float> timer)
            => ValueTo(getter, provider, setter, UMath.Lerp, timer);
        #endregion

        #region Vector2s
        public static IEnumerator<Vector2> Value(Vector2 start, Vector2 target, IEnumerator<float> timer)
            => Value(start, target, UMath.Lerp, timer);

        public static IEnumerator ValueTo(Vector2 start, Vector2 target, Action<Vector2> setter, IEnumerator<float> timer)
            => ValueTo(start, target, setter, UMath.Lerp, timer);

        public static IEnumerator ValueTo(Func<Vector2> getter, Vector2 target, Action<Vector2> setter, IEnumerator<float> timer)
            => ValueTo(getter, target, setter, UMath.Lerp, timer);

        public static IEnumerator ValueTo(Vector2 start, Func<Vector2> provider, Action<Vector2> setter, IEnumerator<float> timer)
            => ValueTo(start, provider, setter, UMath.Lerp, timer);

        public static IEnumerator ValueTo(Func<Vector2> getter, Func<Vector2> provider, Action<Vector2> setter, IEnumerator<float> timer)
            => ValueTo(getter, provider, setter, UMath.Lerp, timer);
        #endregion

        #region Vector2Ints
        public static IEnumerator<Vector2Int> Value(Vector2Int start, Vector2Int target, IEnumerator<float> timer)
            => Value(start, target, UMath.Lerp, timer);

        public static IEnumerator ValueTo(Vector2Int start, Vector2Int target, Action<Vector2Int> setter, IEnumerator<float> timer)
            => ValueTo(start, target, setter, UMath.Lerp, timer);

        public static IEnumerator ValueTo(Func<Vector2Int> getter, Vector2Int target, Action<Vector2Int> setter, IEnumerator<float> timer)
            => ValueTo(getter, target, setter, UMath.Lerp, timer);

        public static IEnumerator ValueTo(Vector2Int start, Func<Vector2Int> provider, Action<Vector2Int> setter, IEnumerator<float> timer)
            => ValueTo(start, provider, setter, UMath.Lerp, timer);

        public static IEnumerator ValueTo(Func<Vector2Int> getter, Func<Vector2Int> provider, Action<Vector2Int> setter, IEnumerator<float> timer)
            => ValueTo(getter, provider, setter, UMath.Lerp, timer);
        #endregion

        #region Vector3s
        public static IEnumerator<Vector3> Value(Vector3 start, Vector3 target, IEnumerator<float> timer)
            => Value(start, target, UMath.Lerp, timer);

        public static IEnumerator ValueTo(Vector3 start, Vector3 target, Action<Vector3> setter, IEnumerator<float> timer)
            => ValueTo(start, target, setter, UMath.Lerp, timer);

        public static IEnumerator ValueTo(Func<Vector3> getter, Vector3 target, Action<Vector3> setter, IEnumerator<float> timer)
            => ValueTo(getter, target, setter, UMath.Lerp, timer);

        public static IEnumerator ValueTo(Vector3 start, Func<Vector3> provider, Action<Vector3> setter, IEnumerator<float> timer)
            => ValueTo(start, provider, setter, UMath.Lerp, timer);

        public static IEnumerator ValueTo(Func<Vector3> getter, Func<Vector3> provider, Action<Vector3> setter, IEnumerator<float> timer)
            => ValueTo(getter, provider, setter, UMath.Lerp, timer);
        #endregion

        #region Vector3Ints
        public static IEnumerator<Vector3Int> Value(Vector3Int start, Vector3Int target, IEnumerator<float> timer)
            => Value(start, target, UMath.Lerp, timer);

        public static IEnumerator ValueTo(Vector3Int start, Vector3Int target, Action<Vector3Int> setter, IEnumerator<float> timer)
            => ValueTo(start, target, setter, UMath.Lerp, timer);

        public static IEnumerator ValueTo(Func<Vector3Int> getter, Vector3Int target, Action<Vector3Int> setter, IEnumerator<float> timer)
            => ValueTo(getter, target, setter, UMath.Lerp, timer);

        public static IEnumerator ValueTo(Vector3Int start, Func<Vector3Int> provider, Action<Vector3Int> setter, IEnumerator<float> timer)
            => ValueTo(start, provider, setter, UMath.Lerp, timer);

        public static IEnumerator ValueTo(Func<Vector3Int> getter, Func<Vector3Int> provider, Action<Vector3Int> setter, IEnumerator<float> timer)
            => ValueTo(getter, provider, setter, UMath.Lerp, timer);
        #endregion

        #region Vector4s
        public static IEnumerator<Vector4> Value(Vector4 start, Vector4 target, IEnumerator<float> timer)
            => Value(start, target, UMath.Lerp, timer);

        public static IEnumerator ValueTo(Vector4 start, Vector4 target, Action<Vector4> setter, IEnumerator<float> timer)
            => ValueTo(start, target, setter, UMath.Lerp, timer);

        public static IEnumerator ValueTo(Func<Vector4> getter, Vector4 target, Action<Vector4> setter, IEnumerator<float> timer)
            => ValueTo(getter, target, setter, UMath.Lerp, timer);

        public static IEnumerator ValueTo(Vector4 start, Func<Vector4> provider, Action<Vector4> setter, IEnumerator<float> timer)
            => ValueTo(start, provider, setter, UMath.Lerp, timer);

        public static IEnumerator ValueTo(Func<Vector4> getter, Func<Vector4> provider, Action<Vector4> setter, IEnumerator<float> timer)
            => ValueTo(getter, provider, setter, UMath.Lerp, timer);
        #endregion

        #region Quaternions
        public static IEnumerator<Quaternion> Value(Quaternion start, Quaternion target, IEnumerator<float> timer)
            => Value(start, target, UMath.Lerp, timer);

        public static IEnumerator ValueTo(Quaternion start, Quaternion target, Action<Quaternion> setter, IEnumerator<float> timer)
            => ValueTo(start, target, setter, UMath.Lerp, timer);

        public static IEnumerator ValueTo(Func<Quaternion> getter, Quaternion target, Action<Quaternion> setter, IEnumerator<float> timer)
            => ValueTo(getter, target, setter, UMath.Lerp, timer);

        public static IEnumerator ValueTo(Quaternion start, Func<Quaternion> provider, Action<Quaternion> setter, IEnumerator<float> timer)
            => ValueTo(start, provider, setter, UMath.Lerp, timer);

        public static IEnumerator ValueTo(Func<Quaternion> getter, Func<Quaternion> provider, Action<Quaternion> setter, IEnumerator<float> timer)
            => ValueTo(getter, provider, setter, UMath.Lerp, timer);
        #endregion

        #region Colors
        public static IEnumerator<Color> Value(Color start, Color target, IEnumerator<float> timer)
            => Value(start, target, UMath.Lerp, timer);

        public static IEnumerator ValueTo(Color start, Color target, Action<Color> setter, IEnumerator<float> timer)
            => ValueTo(start, target, setter, UMath.Lerp, timer);

        public static IEnumerator ValueTo(Func<Color> getter, Color target, Action<Color> setter, IEnumerator<float> timer)
            => ValueTo(getter, target, setter, UMath.Lerp, timer);

        public static IEnumerator ValueTo(Color start, Func<Color> provider, Action<Color> setter, IEnumerator<float> timer)
            => ValueTo(start, provider, setter, UMath.Lerp, timer);

        public static IEnumerator ValueTo(Func<Color> getter, Func<Color> provider, Action<Color> setter, IEnumerator<float> timer)
            => ValueTo(getter, provider, setter, UMath.Lerp, timer);
        #endregion

        #region Rects
        public static IEnumerator<Rect> Value(Rect start, Rect target, IEnumerator<float> timer)
            => Value(start, target, UMath.Lerp, timer);

        public static IEnumerator ValueTo(Rect start, Rect target, Action<Rect> setter, IEnumerator<float> timer)
            => ValueTo(start, target, setter, UMath.Lerp, timer);

        public static IEnumerator ValueTo(Func<Rect> getter, Rect target, Action<Rect> setter, IEnumerator<float> timer)
            => ValueTo(getter, target, setter, UMath.Lerp, timer);

        public static IEnumerator ValueTo(Rect start, Func<Rect> provider, Action<Rect> setter, IEnumerator<float> timer)
            => ValueTo(start, provider, setter, UMath.Lerp, timer);

        public static IEnumerator ValueTo(Func<Rect> getter, Func<Rect> provider, Action<Rect> setter, IEnumerator<float> timer)
            => ValueTo(getter, provider, setter, UMath.Lerp, timer);
        #endregion

        #region Time
        public static IEnumerator TimeScale(float target, float duration, Func<float, float> easer = null)
            => ValueTo(UTime.GetTimeScale, target, UTime.SetTimeScale, Realtime(duration, easer));

        public static IEnumerator FixedDeltaTime(float target, float duration, Func<float, float> easer = null)
            => ValueTo(UTime.GetFixedDeltaTime, target, UTime.SetFixedDeltaTime, Realtime(duration, easer));

        public static IEnumerator MaximumDeltaTime(float target, float duration, Func<float, float> easer = null)
            => ValueTo(UTime.GetMaximumDeltaTime, target, UTime.SetMaximumDeltaTime, Realtime(duration, easer));

        public static IEnumerator MaximumParticleDeltaTime(float target, float duration, Func<float, float> easer = null)
            => ValueTo(UTime.GetMaximumParticleDeltaTime, target, UTime.SetMaximumParticleDeltaTime, Realtime(duration, easer));
        #endregion
    }
}
