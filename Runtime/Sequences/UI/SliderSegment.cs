using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Common.Coroutines
{
    [Serializable]
    public abstract class SliderSegment<T> : Segment
    {
        [SerializeField] protected Slider _slider;
        [SerializeField] protected T _target;
    }
    
    [SegmentMenu(nameof(Slider), "Value")]
    public sealed class SliderValueSegment : SliderSegment<float>
    {
        public override IEnumerator CoExecute()
            => _slider.CoValue(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Slider), "NormalizedValue")]
    public sealed class SliderNormalizedValueSegment : SliderSegment<float>
    {
        public override void OnValidate()
            => _target = Mathf.Clamp(_target, 0.0f, 1.0f);
        
        public override IEnumerator CoExecute()
            => _slider.CoNormalizedValue(_target, _duration, _easer.Evaluate);
    }
}