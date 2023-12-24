using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines
{
    [Serializable]
    public abstract class AudioSourceSegment<T> : TimedSegment
    {
        [SerializeField] protected AudioSource _audio;
        [SerializeField] protected T _target;
    }

    [SegmentMenu(nameof(AudioSource), "Pitch")]
    public sealed class AudioSourcePitchSegment : AudioSourceSegment<float>
    {
        public override void OnValidate()
            => _target = Mathf.Clamp(_target, -3.0f, 3.0f);

        public override IEnumerator CoExecute()
            => _audio.CoPitch(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(AudioSource), "Volume")]
    public sealed class AudioSourceVolumeSegment : AudioSourceSegment<float>
    {
        public override void OnValidate()
            => _target = Mathf.Clamp(_target, 0.0f, 1.0f);
        
        public override IEnumerator CoExecute()
            => _audio.CoVolume(_target, _duration, _easer.Evaluate);
    }
}