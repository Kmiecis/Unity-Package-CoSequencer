using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines.Segments
{
    #region Color
    [Serializable]
    [SegmentMenu("Set", SegmentPath.SpriteRendererColor, SegmentGroup.Core)]
    public sealed class SpriteRendererColorSetSegment : SetSegment<SpriteRenderer, Color>
    {
        public SpriteRendererColorSetSegment()
            => target = Color.white;

        public override IEnumerator Build()
            => component.CoColor(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.SpriteRendererColor, SegmentGroup.Core)]
    public sealed class SpriteRendererColorSegment : TowardsSegment<SpriteRenderer, Color>
    {
        public SpriteRendererColorSegment()
            => target = Color.white;

        public override IEnumerator Build()
            => component.CoColor(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.SpriteRendererColor, SegmentGroup.Core)]
    public sealed class SpriteRendererColorBetweenSegment : BetweenSegment<SpriteRenderer, Color>
    {
        public SpriteRendererColorBetweenSegment()
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
    [SegmentMenu("Set", SegmentPath.SpriteRendererFade, SegmentGroup.Core)]
    public sealed class SpriteRendererFadeSetSegment : SetSegment<SpriteRenderer, float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator Build()
            => component.CoFade(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.SpriteRendererFade, SegmentGroup.Core)]
    public sealed class SpriteRendererFadeSegment : TowardsSegment<SpriteRenderer, float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);
    
        public override IEnumerator Build()
            => component.CoFade(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.SpriteRendererFade, SegmentGroup.Core)]
    public sealed class SpriteRendererFadeBetweenSegment : BetweenSegment<SpriteRenderer, float>
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
    [SegmentMenu("Gradient", SegmentPath.SpriteRenderer, SegmentGroup.Core)]
    public sealed class SpriteRendererGradientSegment : TowardsSegment<SpriteRenderer, Gradient>
    {
        public override IEnumerator Build()
            => component.CoGradient(target, duration, easer.Evaluate);
    }
    #endregion

    #region Size
    [Serializable]
    [SegmentMenu("Set", SegmentPath.SpriteRendererSize, SegmentGroup.Core)]
    public sealed class SpriteRendererSizeSetSegment : SetSegment<SpriteRenderer, Vector2>
    {
        public override IEnumerator Build()
            => component.CoSize(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.SpriteRendererSize, SegmentGroup.Core)]
    public sealed class SpriteRendererSizeSegment : TowardsSegment<SpriteRenderer, Vector2>
    {
        public override IEnumerator Build()
            => component.CoSize(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Towards X", SegmentPath.SpriteRendererSize, SegmentGroup.Core)]
    public sealed class SpriteRendererSizeXSegment : TowardsSegment<SpriteRenderer, float>
    {
        public override IEnumerator Build()
            => component.CoSizeX(target, duration, easer.Evaluate);
    }
    
    [Serializable]
    [SegmentMenu("Towards Y", SegmentPath.SpriteRendererSize, SegmentGroup.Core)]
    public sealed class SpriteRendererSizeYSegment : TowardsSegment<SpriteRenderer, float>
    {
        public override IEnumerator Build()
            => component.CoSizeY(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.SpriteRendererSize, SegmentGroup.Core)]
    public sealed class SpriteRendererSizeBetweenSegment : BetweenSegment<SpriteRenderer, Vector2>
    {
        public override IEnumerator Build()
            => component.CoSize(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between X", SegmentPath.SpriteRendererSize, SegmentGroup.Core)]
    public sealed class SpriteRendererSizeXBetweenSegment : BetweenSegment<SpriteRenderer, float>
    {
        public override IEnumerator Build()
            => component.CoSizeX(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between Y", SegmentPath.SpriteRendererSize, SegmentGroup.Core)]
    public sealed class SpriteRendererSizeYBetweenSegment : BetweenSegment<SpriteRenderer, float>
    {
        public override IEnumerator Build()
            => component.CoSizeY(start, target, duration, easer.Evaluate);
    }
    #endregion
}