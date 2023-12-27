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
    
    [SegmentMenu(nameof(Slider), "Value")]
    public sealed class SliderValueSegment : SliderSegment<float>
    {
        public override IEnumerator CoExecute()
            => slider.CoValue(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Slider), "NormalizedValue")]
    public sealed class SliderNormalizedValueSegment : SliderSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);
        
        public override IEnumerator CoExecute()
            => slider.CoNormalizedValue(target, duration, easer.Evaluate);
    }
}