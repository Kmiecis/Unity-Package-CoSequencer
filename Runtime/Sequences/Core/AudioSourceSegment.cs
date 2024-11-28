using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines.Segments
{
    #region Pitch
    [Serializable]
    [SegmentMenu("Set", SegmentPath.AudioSourcePitch, SegmentGroup.Core)]
    public sealed class AudioSourcePitchSetSegment : SetSegment<AudioSource, float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, -3.0f, 3.0f);

        public override IEnumerator Build()
            => component.CoPitch(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.AudioSourcePitch, SegmentGroup.Core)]
    public sealed class AudioSourcePitchSegment : TowardsSegment<AudioSource, float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, -3.0f, 3.0f);

        public override IEnumerator Build()
            => component.CoPitch(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.AudioSourcePitch, SegmentGroup.Core)]
    public sealed class AudioSourcePitchBetweenSegment : BetweenSegment<AudioSource, float>
    {
        public override void OnValidate()
        {
            start = Mathf.Clamp(target, -3.0f, 3.0f);
            target = Mathf.Clamp(target, -3.0f, 3.0f);
        }

        public override IEnumerator Build()
            => component.CoPitch(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region Volume
    [Serializable]
    [SegmentMenu("Set", SegmentPath.AudioSourceVolume, SegmentGroup.Core)]
    public sealed class AudioSourceVolumeSetSegment : SetSegment<AudioSource, float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator Build()
            => component.CoVolume(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.AudioSourceVolume, SegmentGroup.Core)]
    public sealed class AudioSourceVolumeSegment : TowardsSegment<AudioSource, float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);
        
        public override IEnumerator Build()
            => component.CoVolume(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.AudioSourceVolume, SegmentGroup.Core)]
    public sealed class AudioSourceVolumeBetweenSegment : BetweenSegment<AudioSource, float>
    {
        public override void OnValidate()
        {
            start = Mathf.Clamp(target, 0.0f, 1.0f);
            target = Mathf.Clamp(target, 0.0f, 1.0f);
        }

        public override IEnumerator Build()
            => component.CoVolume(target, duration, easer.Evaluate);
    }
    #endregion
}