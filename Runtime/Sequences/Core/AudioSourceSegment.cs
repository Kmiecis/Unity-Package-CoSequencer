using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines.Segments
{
    [Serializable]
    public abstract class AudioSourceSegment<T> : Segment
    {
        public AudioSource audio;
        public T target;
    }

    [Serializable]
    public abstract class AudioSourceTimedSegment<T> : TimedSegment
    {
        public AudioSource audio;
        public T target;
    }

    [Serializable]
    public abstract class AudioSourceBetweenSegment<T> : TimedSegment
    {
        public AudioSource audio;
        public T start;
        public T target;
    }

    #region Pitch
    [SegmentMenu("Towards", SegmentPath.AudioSourcePitch, SegmentGroup.Core)]
    public sealed class AudioSourcePitchSegment : AudioSourceTimedSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, -3.0f, 3.0f);

        public override IEnumerator Build()
            => audio.CoPitch(target, duration, easer.Evaluate);
    }

    [SegmentMenu("Set", SegmentPath.AudioSourcePitch, SegmentGroup.Core)]
    public sealed class AudioSourcePitchSetSegment : AudioSourceSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, -3.0f, 3.0f);

        public override IEnumerator Build()
            => audio.CoPitch(target);
    }

    [SegmentMenu("Between", SegmentPath.AudioSourcePitch, SegmentGroup.Core)]
    public sealed class AudioSourcePitchBetweenSegment : AudioSourceBetweenSegment<float>
    {
        public override void OnValidate()
        {
            start = Mathf.Clamp(target, -3.0f, 3.0f);
            target = Mathf.Clamp(target, -3.0f, 3.0f);
        }

        public override IEnumerator Build()
            => audio.CoPitch(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region Volume
    [SegmentMenu("Towards", SegmentPath.AudioSourceVolume, SegmentGroup.Core)]
    public sealed class AudioSourceVolumeSegment : AudioSourceTimedSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);
        
        public override IEnumerator Build()
            => audio.CoVolume(target, duration, easer.Evaluate);
    }

    [SegmentMenu("Set", SegmentPath.AudioSourceVolume, SegmentGroup.Core)]
    public sealed class AudioSourceVolumeSetSegment : AudioSourceSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator Build()
            => audio.CoVolume(target);
    }

    [SegmentMenu("Between", SegmentPath.AudioSourceVolume, SegmentGroup.Core)]
    public sealed class AudioSourceVolumeBetweenSegment : AudioSourceBetweenSegment<float>
    {
        public override void OnValidate()
        {
            start = Mathf.Clamp(target, 0.0f, 1.0f);
            target = Mathf.Clamp(target, 0.0f, 1.0f);
        }

        public override IEnumerator Build()
            => audio.CoVolume(target, duration, easer.Evaluate);
    }
    #endregion
}