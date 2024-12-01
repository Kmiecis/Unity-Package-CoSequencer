using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Video;

namespace Common.Coroutines
{
    public static class VideoPlayerExtensions
    {
        #region Volume
        public static IEnumerator CoVolume(this VideoPlayer self, ushort trackIndex, float target)
            => Yield.Into(target, v => self.SetDirectAudioVolume(trackIndex, v));

        public static IEnumerator CoVolume(this VideoPlayer self, ushort trackIndex, float target, IEnumerator<float> timer)
            => Yield.ValueTo(() => self.GetDirectAudioVolume(trackIndex), target, v => self.SetDirectAudioVolume(trackIndex, v), timer);

        public static IEnumerator CoVolume(this VideoPlayer self, ushort trackIndex, float start, float target, IEnumerator<float> timer)
            => Yield.ValueTo(start, target, v => self.SetDirectAudioVolume(trackIndex, v), timer);

        public static IEnumerator CoVolume(this VideoPlayer self, ushort trackIndex, float target, float duration, Func<float, float> easer = null)
            => self.CoVolume(trackIndex, target, Yield.Time(duration, easer));

        public static IEnumerator CoVolume(this VideoPlayer self, ushort trackIndex, float start, float target, float duration, Func<float, float> easer = null)
            => self.CoVolume(trackIndex, start, target, Yield.Time(duration, easer));
        #endregion
    }
}