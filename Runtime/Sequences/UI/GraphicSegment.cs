using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Common.Coroutines
{
    [Serializable]
    public abstract class GraphicSegment<T> : TimedSegment
    {
        [SerializeField] protected Graphic _graphic;
        [SerializeField] protected T _target;
    }
    
    [SegmentMenu(nameof(Graphic), "Color")]
    public sealed class GraphicColorSegment : GraphicSegment<Color>
    {
        public override void OnAdded()
            => _target = Color.white;

        public override IEnumerator CoExecute()
            => _graphic.CoColor(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Graphic), "Fade")]
    public sealed class GraphicFadeSegment : GraphicSegment<float>
    {
        public override void OnValidate()
            => _target = Mathf.Clamp(_target, 0.0f, 1.0f);
        
        public override IEnumerator CoExecute()
            => _graphic.CoFade(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Graphic), "Gradient")]
    public sealed class GraphicGradientSegment : GraphicSegment<Gradient>
    {
        public override IEnumerator CoExecute()
            => _graphic.CoGradient(_target, _duration, _easer.Evaluate);
    }
}