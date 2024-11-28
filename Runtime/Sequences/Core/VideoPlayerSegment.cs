using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Video;

namespace Common.Coroutines.Segments
{
    public abstract class VideoPlayerWithTrackIndexSetSegment<T> : SetSegment<VideoPlayer, T>
    {
        public ushort trackIndex;
    }

    public abstract class VideoPlayerWithTrackIndexTowardsSegment<T> : TowardsSegment<VideoPlayer, T>
    {
        public ushort trackIndex;
    }

    public abstract class VideoPlayerWithTrackIndexBetweenSegment<T> : BetweenSegment<VideoPlayer, T>
    {
        public ushort trackIndex;
    }

    #region Volume
    [Serializable]
    [SegmentMenu("Set", SegmentPath.VideoPlayerVolume, SegmentGroup.Core)]
    public sealed class VideoPlayerVolumeSetSegment : VideoPlayerWithTrackIndexSetSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator Build()
            => component.CoVolume(trackIndex, target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.VideoPlayerVolume, SegmentGroup.Core)]
    public sealed class VideoPlayerVolumeSegment : VideoPlayerWithTrackIndexTowardsSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator Build()
            => component.CoVolume(trackIndex, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.VideoPlayerVolume, SegmentGroup.Core)]
    public sealed class VideoPlayerVolumeBetweenSegment : VideoPlayerWithTrackIndexBetweenSegment<float>
    {
        public override void OnValidate()
        {
            start = Mathf.Clamp(target, 0.0f, 1.0f);
            target = Mathf.Clamp(target, 0.0f, 1.0f);
        }

        public override IEnumerator Build()
            => component.CoVolume(trackIndex, target, duration, easer.Evaluate);
    }
    #endregion
}