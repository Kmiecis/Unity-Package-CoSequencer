using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Common.Coroutines.Segments
{
    public abstract class SliderSegment<T> : Segment
    {
        public Slider slider;
        public T target;
    }

    public abstract class SliderTimerSegment<T> : TimedSegment
    {
        public Slider slider;
        public T target;
    }

    public abstract class SliderBetweenSegment<T> : TimedSegment
    {
        public Slider slider;
        public T start;
        public T target;
    }

    #region Value
    [Serializable]
    [SegmentMenu("Towards", SegmentPath.SliderValue, SegmentGroup.UI)]
    public sealed class SliderValueSegment : SliderTimerSegment<float>
    {
        public override IEnumerator Build()
            => slider.CoValue(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Set", SegmentPath.SliderValue, SegmentGroup.UI)]
    public sealed class SliderValueSetSegment : SliderSegment<float>
    {
        public override IEnumerator Build()
            => slider.CoValue(target);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.SliderValue, SegmentGroup.UI)]
    public sealed class SliderValueBetweenSegment : SliderBetweenSegment<float>
    {
        public override IEnumerator Build()
            => slider.CoValue(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region NormalizedValue
    [Serializable]
    [SegmentMenu("Towards", SegmentPath.SliderNormalizedValue, SegmentGroup.UI)]
    public sealed class SliderNormalizedValueSegment : SliderTimerSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);
        
        public override IEnumerator Build()
            => slider.CoNormalizedValue(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Set", SegmentPath.SliderNormalizedValue, SegmentGroup.UI)]
    public sealed class SliderNormalizedValueSetSegment : SliderSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator Build()
            => slider.CoNormalizedValue(target);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.SliderNormalizedValue, SegmentGroup.UI)]
    public sealed class SliderNormalizedValueBetweenSegment : SliderBetweenSegment<float>
    {
        public override void OnValidate()
        {
            start = Mathf.Clamp(start, 0.0f, 1.0f);
            target = Mathf.Clamp(target, 0.0f, 1.0f);
        }

        public override IEnumerator Build()
            => slider.CoNormalizedValue(start, target, duration, easer.Evaluate);
    }
    #endregion
}