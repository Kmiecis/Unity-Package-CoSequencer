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

        public static IEnumerator<T> Then<T>(this IEnumerator<T> self, Func<T> provider)
        {
            return self.Then(UCoroutine.Yield(provider));
        }

        public static IEnumerator Then(this Func<IEnumerator> self, IEnumerator coroutine)
        {
            return UCoroutine.Yield(self).Then(coroutine);
        }

        public static IEnumerator Then(this Func<IEnumerator> self, Func<IEnumerator> coroutine)
        {
            return UCoroutine.Yield(self).Then(coroutine);
        }

        public static IEnumerator<T> Then<T>(this Func<IEnumerator<T>> self, IEnumerator<T> coroutine)
        {
            return UCoroutine.Yield(self).Then(coroutine);
        }

        public static IEnumerator<T> Then<T>(this Func<IEnumerator<T>> self, Func<IEnumerator<T>> coroutine)
        {
            return UCoroutine.Yield(self).Then(coroutine);
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

        public static IEnumerator With(this Func<IEnumerator> self, Func<IEnumerator> provider)
        {
            return self.With(UCoroutine.Yield(provider));
        }

        public static IEnumerator With(this Func<IEnumerator> self, IEnumerator coroutine)
        {
            return UCoroutine.Yield(self).With(coroutine);
        }
        #endregion

        #region Wait
        public static IEnumerator Wait(this Func<IEnumerator> self, float duration)
        {
            return self.Then(UCoroutine.YieldTime(duration));
        }

        public static IEnumerator WaitRealtime(this Func<IEnumerator> self, float duration)
        {
            return self.Then(UCoroutine.YieldRealtime(duration));
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

        public static Coroutine Start(this Func<IEnumerator> self, MonoBehaviour target)
        {
            return self().Start(target);
        }
    }
}
