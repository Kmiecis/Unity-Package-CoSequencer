using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Common.Coroutines
{
    public static class IEnumeratorExtensions
    {
        #region Then
        public static IEnumerator Then(this IEnumerator self, YieldInstruction yield)
        {
            return self.Then(Yield.Value(yield));
        }

        public static IEnumerator Then(this IEnumerator self, Coroutine coroutine)
        {
            return self.Then(Yield.Value(coroutine));
        }

        public static IEnumerator Then(this IEnumerator self, Action action)
        {
            return self.Then(Yield.Invoke(action));
        }

        public static IEnumerator Then(this IEnumerator self, UnityEvent action)
        {
            return self.Then(Yield.Invoke(action));
        }

        public static IEnumerator Then<T>(this IEnumerator self, Func<T> provider)
        {
            return self.Then(Yield.Value(provider));
        }

        public static IEnumerator<T> Then<T>(this IEnumerator<T> self, Func<T> provider)
        {
            return self.Then(Yield.Value(provider));
        }

        public static IEnumerator Then(this IEnumerator self, IEnumerator coroutine)
        {
            return Yield.Sequence(self, coroutine);
        }

        public static IEnumerator<T> Then<T>(this IEnumerator<T> self, IEnumerator<T> coroutine)
        {
            return Yield.Sequence(self, coroutine);
        }

        public static IEnumerator Then(this IEnumerator self, Func<IEnumerator> provider)
        {
            return self.Then(Yield.Coroutine(provider));
        }

        public static IEnumerator<T> Then<T>(this IEnumerator<T> self, Func<IEnumerator<T>> provider)
        {
            return self.Then(Yield.Coroutine(provider));
        }

        public static IEnumerator Then(this IEnumerator self, params IEnumerator[] coroutines)
        {
            return self.Then(Yield.Parallel(coroutines));
        }

        public static IEnumerator Then<T>(this IEnumerator self, params IEnumerator<T>[] coroutines)
        {
            return self.Then(Yield.Parallel(coroutines));
        }
        #endregion

        #region With
        public static IEnumerator With(this IEnumerator self, YieldInstruction yield)
        {
            return self.With(Yield.Value(yield));
        }

        public static IEnumerator With(this IEnumerator self, Coroutine coroutine)
        {
            return self.With(Yield.Value(coroutine));
        }

        public static IEnumerator With(this IEnumerator self, IEnumerator coroutine)
        {
            return Yield.Parallel(self, coroutine);
        }

        public static IEnumerator With(this IEnumerator self, Action action)
        {
            return Yield.Until(action, self);
        }

        public static IEnumerator With(this IEnumerator self, UnityEvent action)
        {
            return Yield.Until(action, self);
        }
        #endregion

        #region Into
        public static IEnumerator Into<T>(this IEnumerator<T> self, Action<T> consumer)
        {
            return Yield.Into(self, consumer);
        }

        public static IEnumerator Into<T>(this IEnumerator<T> self, UnityEvent<T> consumer)
        {
            return Yield.Into(self, consumer);
        }

        public static IEnumerator<U> Into<T, U>(this IEnumerator<T> self, Func<T, U> parser)
        {
            return Yield.Into(self, parser);
        }
        #endregion

        #region Wait
        public static IEnumerator WaitTime(this IEnumerator self, float duration)
        {
            return self.Then(Yield.Time(duration));
        }

        public static IEnumerator WaitRealtime(this IEnumerator self, float duration)
        {
            return self.Then(Yield.Realtime(duration));
        }

        public static IEnumerator WaitFrame(this IEnumerator self)
        {
            return self.Then(Yield.Empty());
        }

        public static IEnumerator WaitFrames(this IEnumerator self, int frames)
        {
            return self.Then(Yield.Frames(frames));
        }
        #endregion

        #region Await
        public static IEnumerator Await(this IEnumerator self, Func<bool> verifier)
        {
            return self.Then(Yield.Await(verifier));
        }

        public static IEnumerator Await(this IEnumerator self, YieldInstruction instruction)
        {
            return self.Then(Yield.Await(instruction));
        }

        public static IEnumerator Await(this IEnumerator self, Coroutine coroutine)
        {
            return self.Then(Yield.Await(coroutine));
        }
        #endregion

        #region If
        public static IEnumerator If(this IEnumerator self, Func<bool> verifier)
        {
            return Yield.If(self, verifier);
        }

        public static IEnumerator<T> If<T>(this IEnumerator<T> self, Func<bool> verifier)
        {
            return Yield.If(self, verifier);
        }
        #endregion

        #region While
        public static IEnumerator While(this IEnumerator self, Func<bool> verifier)
        {
            return Yield.While(self, verifier);
        }

        public static IEnumerator<T> While<T>(this IEnumerator<T> self, Func<bool> verifier)
        {
            return Yield.While(self, verifier);
        }
        #endregion

        #region Do while
        public static IEnumerator DoWhile(this IEnumerator self, Func<bool> verifier)
        {
            return Yield.DoWhile(self, verifier);
        }

        public static IEnumerator DoWhile<T>(this IEnumerator<T> self, Func<bool> verifier)
        {
            return Yield.DoWhile(self, verifier);
        }
        #endregion

        #region When
        public static IEnumerator When(this IEnumerator self, Func<bool> verifier)
        {
            return Yield.When(self, verifier);
        }
        #endregion

        #region Timer
        public static IEnumerator<float> Eased(this IEnumerator<float> self, Func<float, float> easer = null)
        {
            return Yield.Into(self, easer ?? Easers.SmoothStep);
        }

        public static IEnumerator<float> Flipped(this IEnumerator<float> self, float duration = 1.0f)
        {
            float Flip(float f) => duration - f;
            return Yield.Into(self, Flip);
        }
        #endregion

        public static Coroutine Start(this IEnumerator self, MonoBehaviour target)
        {
            return target.StartCoroutine(self);
        }

        public static Coroutine StartSafely(this IEnumerator self, MonoBehaviour target)
        {
            if (target.gameObject.activeInHierarchy)
            {
                return Start(self, target);
            }
            return null;
        }
    }
}
