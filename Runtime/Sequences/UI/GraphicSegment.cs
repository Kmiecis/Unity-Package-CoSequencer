using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Common.Coroutines.Segments
{
    #region Color
    [Serializable]
    [SegmentMenu("Set", SegmentPath.GraphicColor, SegmentGroup.UI)]
    public sealed class GraphicColorSetSegment : SetSegment<Graphic, Color>
    {
        public GraphicColorSetSegment()
            => target = Color.white;

        public override IEnumerator Build()
            => component.CoColor(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.GraphicColor, SegmentGroup.UI)]
    public sealed class GraphicColorSegment : TowardsSegment<Graphic, Color>
    {
        public GraphicColorSegment()
            => target = Color.white;

        public override IEnumerator Build()
            => component.CoColor(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.GraphicColor, SegmentGroup.UI)]
    public sealed class GraphicColorBetweenSegment : BetweenSegment<Graphic, Color>
    {
        public GraphicColorBetweenSegment()
        {
            start = Color.white;
            target = Color.white;
        }

        public override IEnumerator Build()
            => component.CoColor(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region Fade
    [Serializable]
    [SegmentMenu("Set", SegmentPath.GraphicFade, SegmentGroup.UI)]
    public sealed class GraphicFadeSetSegment : SetSegment<Graphic, float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator Build()
            => component.CoFade(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.GraphicFade, SegmentGroup.UI)]
    public sealed class GraphicFadeSegment : TowardsSegment<Graphic, float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);
        
        public override IEnumerator Build()
            => component.CoFade(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.GraphicFade, SegmentGroup.UI)]
    public sealed class GraphicFadeBetweenSegment : BetweenSegment<Graphic, float>
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

    #region Gradient
    [Serializable]
    [SegmentMenu("Gradient", SegmentPath.Graphic, SegmentGroup.UI)]
    public sealed class GraphicGradientSegment : TowardsSegment<Graphic, Gradient>
    {
        public override IEnumerator Build()
            => component.CoGradient(target, duration, easer.Evaluate);
    }
    #endregion
}