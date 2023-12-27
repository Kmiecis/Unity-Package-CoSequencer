using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines.Segments
{
    [Serializable]
    public abstract class AudioSourceSegment<T> : TimedSegment
    {
        public AudioSource audio;
        public T target;
    }

    [SegmentMenu(nameof(AudioSource), "Pitch")]
    public sealed class AudioSourcePitchSegment : AudioSourceSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, -3.0f, 3.0f);

        public override IEnumerator CoExecute()
            => audio.CoPitch(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(AudioSource), "Volume")]
    public sealed class AudioSourceVolumeSegment : AudioSourceSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);
        
        public override IEnumerator CoExecute()
            => audio.CoVolume(target, duration, easer.Evaluate);
    }
}