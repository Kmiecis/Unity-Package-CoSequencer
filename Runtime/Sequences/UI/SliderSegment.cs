using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Common.Coroutines.Segments
{
    #region Value
    [Serializable]
    [SegmentMenu("Set", SegmentPath.SliderValue, SegmentGroup.UI)]
    public sealed class SliderValueSetSegment : SetSegment<Slider, float>
    {
        public override IEnumerator Build()
            => component.CoValue(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.SliderValue, SegmentGroup.UI)]
    public sealed class SliderValueSegment : TowardsSegment<Slider, float>
    {
        public override IEnumerator Build()
            => component.CoValue(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.SliderValue, SegmentGroup.UI)]
    public sealed class SliderValueBetweenSegment : BetweenSegment<Slider, float>
    {
        public override IEnumerator Build()
            => component.CoValue(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region NormalizedValue
    [Serializable]
    [SegmentMenu("Set", SegmentPath.SliderNormalizedValue, SegmentGroup.UI)]
    public sealed class SliderNormalizedValueSetSegment : SetSegment<Slider, float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator Build()
            => component.CoNormalizedValue(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.SliderNormalizedValue, SegmentGroup.UI)]
    public sealed class SliderNormalizedValueSegment : TowardsSegment<Slider, float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);
        
        public override IEnumerator Build()
            => component.CoNormalizedValue(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.SliderNormalizedValue, SegmentGroup.UI)]
    public sealed class SliderNormalizedValueBetweenSegment : BetweenSegment<Slider, float>
    {
        public override void OnValidate()
        {
            start = Mathf.Clamp(start, 0.0f, 1.0f);
            target = Mathf.Clamp(target, 0.0f, 1.0f);
        }

        public override IEnumerator Build()
            => component.CoNormalizedValue(start, target, duration, easer.Evaluate);
    }
    #endregion
}