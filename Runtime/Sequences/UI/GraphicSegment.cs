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
    
    [SegmentMenu("Color", SegmentPath.Graphic, SegmentGroup.UI)]
    public sealed class GraphicColorSegment : GraphicSegment<Color>
    {
        public GraphicColorSegment()
            => target = Color.white;

        public override IEnumerator GetSequence()
            => graphic.CoColor(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("Fade", SegmentPath.Graphic, SegmentGroup.UI)]
    public sealed class GraphicFadeSegment : GraphicSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);
        
        public override IEnumerator GetSequence()
            => graphic.CoFade(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("Gradient", SegmentPath.Graphic, SegmentGroup.UI)]
    public sealed class GraphicGradientSegment : GraphicSegment<Gradient>
    {
        public override IEnumerator GetSequence()
            => graphic.CoGradient(target, duration, easer.Evaluate);
    }
}