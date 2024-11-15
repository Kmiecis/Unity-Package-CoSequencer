using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Common.Coroutines.Segments
{
    public abstract class GraphicSegment<T> : Segment
    {
        public Graphic graphic;
        public T target;
    }

    public abstract class GraphicTimedSegment<T> : TimedSegment
    {
        public Graphic graphic;
        public T target;
    }

    public abstract class GraphicBetweenSegment<T> : TimedSegment
    {
        public Graphic graphic;
        public T start;
        public T target;
    }

    #region Color
    [Serializable]
    [SegmentMenu("Towards", SegmentPath.GraphicColor, SegmentGroup.UI)]
    public sealed class GraphicColorSegment : GraphicTimedSegment<Color>
    {
        public GraphicColorSegment()
            => target = Color.white;

        public override IEnumerator Build()
            => graphic.CoColor(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Set", SegmentPath.GraphicColor, SegmentGroup.UI)]
    public sealed class GraphicColorSetSegment : GraphicSegment<Color>
    {
        public GraphicColorSetSegment()
            => target = Color.white;

        public override IEnumerator Build()
            => graphic.CoColor(target);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.GraphicColor, SegmentGroup.UI)]
    public sealed class GraphicColorBetweenSegment : GraphicBetweenSegment<Color>
    {
        public GraphicColorBetweenSegment()
        {
            start = Color.white;
            target = Color.white;
        }

        public override IEnumerator Build()
            => graphic.CoColor(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region Fade
    [Serializable]
    [SegmentMenu("Towards", SegmentPath.GraphicFade, SegmentGroup.UI)]
    public sealed class GraphicFadeSegment : GraphicTimedSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);
        
        public override IEnumerator Build()
            => graphic.CoFade(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Set", SegmentPath.GraphicFade, SegmentGroup.UI)]
    public sealed class GraphicFadeSetSegment : GraphicSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator Build()
            => graphic.CoFade(target);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.GraphicFade, SegmentGroup.UI)]
    public sealed class GraphicFadeBetweenSegment : GraphicBetweenSegment<float>
    {
        public override void OnValidate()
        {
            start = Mathf.Clamp(start, 0.0f, 1.0f);
            target = Mathf.Clamp(target, 0.0f, 1.0f);
        }

        public override IEnumerator Build()
            => graphic.CoFade(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region Gradient
    [Serializable]
    [SegmentMenu("Gradient", SegmentPath.Graphic, SegmentGroup.UI)]
    public sealed class GraphicGradientSegment : GraphicTimedSegment<Gradient>
    {
        public override IEnumerator Build()
            => graphic.CoGradient(target, duration, easer.Evaluate);
    }
    #endregion
}