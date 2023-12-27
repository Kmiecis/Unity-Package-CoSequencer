using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Common.Coroutines.Segments
{
    [Serializable]
    public abstract class GraphicSegment<T> : TimedSegment
    {
        public Graphic graphic;
        public T target;
    }
    
    [SegmentMenu(nameof(Graphic), "Color")]
    public sealed class GraphicColorSegment : GraphicSegment<Color>
    {
        public override void OnAdded()
            => target = Color.white;

        public override IEnumerator CoExecute()
            => graphic.CoColor(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Graphic), "Fade")]
    public sealed class GraphicFadeSegment : GraphicSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);
        
        public override IEnumerator CoExecute()
            => graphic.CoFade(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Graphic), "Gradient")]
    public sealed class GraphicGradientSegment : GraphicSegment<Gradient>
    {
        public override IEnumerator CoExecute()
            => graphic.CoGradient(target, duration, easer.Evaluate);
    }
}