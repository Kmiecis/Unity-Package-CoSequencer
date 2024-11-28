using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines.Segments
{
    #region Fade
    [Serializable]
    [SegmentMenu("Set", SegmentPath.CanvasGroupFade, SegmentGroup.UI)]
    public sealed class CanvasGroupFadeSetSegment : SetSegment<CanvasGroup, float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator Build()
            => component.CoFade(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.CanvasGroupFade, SegmentGroup.UI)]
    public sealed class CanvasGroupFadeSegment : TowardsSegment<CanvasGroup, float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);
        
        public override IEnumerator Build()
            => component.CoFade(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.CanvasGroupFade, SegmentGroup.UI)]
    public sealed class CanvasGroupFadeBetweenSegment : BetweenSegment<CanvasGroup, float>
    {
        public override void OnValidate()
        {
            start = Mathf.Clamp(start, 0.0f, 1.0f);
            target = Mathf.Clamp(target, 0.0f, 1.0f);
        }

        public override IEnumerator Build()
            => component.CoFade(start, target, duration, easer.Evaluate);
    }
    #endregion
}