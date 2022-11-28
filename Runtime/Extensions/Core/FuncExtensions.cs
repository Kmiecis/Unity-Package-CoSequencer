using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Common.Coroutines
{
    public static class FuncExtensions
    {
        #region Then
        public static IEnumerator Then(this Func<IEnumerator> self, YieldInstruction yield)
        {
            return self.Then(UCoroutine.Yield(yield));
        }

        public static IEnumerator Then(this Func<IEnumerator> self, Coroutine coroutine)
        {
            return self.Then(UCoroutine.Yield(coroutine));
        }

        public static IEnumerator Then(this Func<IEnumerator> self, Action callback)
        {
            return self.Then(UCoroutine.Yield(callback));
        }

        public static IEnumerator<T> Then<T>(this Func<IEnumerator<T>> self, Func<T> provider)
        {
            return UCoroutine.Yield(self).Then(provider);
        }

        public static IEnumerator Then(this Func<IEnumerator> self, IEnumerator coroutine)
        {
            return UCoroutine.Yield(self).Then(coroutine);
        }

        public static IEnumerator<T> Then<T>(this Func<IEnumerator<T>> self, IEnumerator<T> coroutine)
        {
            return UCoroutine.Yield(self).Then(coroutine);
        }

        public static IEnumerator Then(this Func<IEnumerator> self, Func<IEnumerator> coroutine)
        {
            return UCoroutine.Yield(self).Then(coroutine);
        }

        public static IEnumerator<T> Then<T>(this Func<IEnumerator<T>> self, Func<IEnumerator<T>> coroutine)
        {
            return UCoroutine.Yield(self).Then(coroutine);
        }

        public static IEnumerator Then(this Func<IEnumerator> self, params IEnumerator[] coroutines)
        {
            return self.Then(UCoroutine.YieldParallel(coroutines));
        }
        #endregion

        #region With
        public static IEnumerator With(this Func<IEnumerator> self, YieldInstruction yield)
        {
            return self.With(UCoroutine.Yield(yield));
        }

        public static IEnumerator With(this Func<IEnumerator> self, Coroutine coroutine)
        {
            return self.With(UCoroutine.Yield(coroutine));
        }

        public static IEnumerator With(this Func<IEnumerator> self, Action callback)
        {
            return self.With(UCoroutine.Yield(callback));
        }

        public static IEnumerator With(this Func<IEnumerator> self, IEnumerator coroutine)
        {
            return UCoroutine.Yield(self).With(coroutine);
        }

        public static IEnumerator With(this Func<IEnumerator> self, Func<IEnumerator> provider)
        {
            return self.With(UCoroutine.Yield(provider));
        }
        #endregion

        #region Into
        public static IEnumerator Into<T>(this Func<IEnumerator<T>> self, Action<T> consumer)
        {
            return UCoroutine.YieldInto(self, consumer);
        }

        public static IEnumerator<U> Into<T, U>(this Func<IEnumerator<T>> self, Func<T, U> parser)
        {
            return UCoroutine.YieldInto(self, parser);
        }
        #endregion

        #region Wait
        public static IEnumerator WaitSeconds(this Func<IEnumerator> self, float duration)
        {
            return self.Then(UCoroutine.YieldTime(duration));
        }

        public static IEnumerator WaitSecondsRealtime(this Func<IEnumerator> self, float duration)
        {
            return self.Then(UCoroutine.YieldRealtime(duration));
        }

        public static IEnumerator WaitFrames(this Func<IEnumerator> self, int frames)
        {
            return self.Then(UCoroutine.YieldFrames(frames));
        }

        public static IEnumerator WaitTrue(this Func<IEnumerator> self, Func<bool> verifier)
        {
            return self.Then(UCoroutine.YieldAwait(verifier));
        }

        public static IEnumerator WaitFinish(this Func<IEnumerator> self, Coroutine coroutine)
        {
            return self.Then(UCoroutine.YieldAwait(coroutine));
        }
        #endregion

        #region Execute
        public static IEnumerator ExecuteIf(this Func<IEnumerator> self, Func<bool> verifier)
        {
            return UCoroutine.YieldIf(self, verifier);
        }

        public static IEnumerator<T> ExecuteIf<T>(this Func<IEnumerator<T>> self, Func<bool> verifier)
        {
            return UCoroutine.YieldIf(self, verifier);
        }

        public static IEnumerator ExecuteWhile(this Func<IEnumerator> self, Func<bool> verifier)
        {
            return UCoroutine.YieldWhile(self, verifier);
        }

        public static IEnumerator<T> ExecuteWhile<T>(this Func<IEnumerator<T>> self, Func<bool> verifier)
        {
            return UCoroutine.YieldWhile(self, verifier);
        }
        #endregion

        #region Repeat
        public static IEnumerator Repeat(this Func<IEnumerator> self, int repeats)
        {
            return UCoroutine.YieldRepeat(self, repeats);
        }

        public static IEnumerator<T> Repeat<T>(this Func<IEnumerator<T>> self, int repeats)
        {
            return UCoroutine.YieldRepeat(self, repeats);
        }
        #endregion

        public static Coroutine Start(this Func<IEnumerator> self, MonoBehaviour target)
        {
            if (target.isActiveAndEnabled)
                return target.StartCoroutine(self());
            return null;
        }
    }
}
