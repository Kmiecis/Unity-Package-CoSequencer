using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Common.Coroutines.Segments
{
    [Serializable]
    public abstract class SliderSegment<T> : TimedSegment
    {
        public Slider slider;
        public T target;
    }
    
    [SegmentMenu("Value", SegmentPath.Slider, SegmentGroup.UI)]
    public sealed class SliderValueSegment : SliderSegment<float>
    {
        public override IEnumerator GetSequence()
            => slider.CoValue(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("NormalizedValue", SegmentPath.Slider, SegmentGroup.UI)]
    public sealed class SliderNormalizedValueSegment : SliderSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);
        
        public override IEnumerator GetSequence()
            => slider.CoNormalizedValue(target, duration, easer.Evaluate);
    }
}