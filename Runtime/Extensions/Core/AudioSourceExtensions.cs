using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines
{
    public static class AudioSourceExtensions
    {
        #region Pitch
        public static IEnumerator CoPitch(this AudioSource self, float target)
            => Yield.Into(target, self.SetPitch);

        public static IEnumerator CoPitch(this AudioSource self, float target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(self.GetPitch, target, self.SetPitch, Yield.Time(duration, easer));

        public static IEnumerator CoPitch(this AudioSource self, float start, float target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(start, target, self.SetPitch, Yield.Time(duration, easer));
        #endregion

        #region Volume
        public static IEnumerator CoVolume(this AudioSource self, float target)
            => Yield.Into(target, self.SetVolume);

        public static IEnumerator CoVolume(this AudioSource self, float target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(self.GetVolume, target, self.SetVolume, Yield.Time(duration, easer));

        public static IEnumerator CoVolume(this AudioSource self, float start, float target, float duration, Func<float, float> easer = null)
            => Yield.ValueTo(start, target, self.SetVolume, Yield.Time(duration, easer));
        #endregion
    }

    internal static class InternalAudioSourceExtensions
    {
        #region Pitch
        public static float GetPitch(this AudioSource self)
            => self.pitch;

        public static void SetPitch(this AudioSource self, float value)
            => self.pitch = value;
        #endregion

        #region Volume
        public static float GetVolume(this AudioSource self)
            => self.volume;

        public static void SetVolume(this AudioSource self, float value)
            => self.volume = value;
        #endregion
    }
}
