using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines.Segments
{
    [Serializable]
    public abstract class SpriteRendererSegment<T> : TimedSegment
    {
        public SpriteRenderer renderer;
        public T target;
    }
    
    [SegmentMenu(nameof(SpriteRenderer), "Color")]
    public sealed class SpriteRendererColorSegment : SpriteRendererSegment<Color>
    {
        public override void OnAdded()
            => target = Color.white;

        public override IEnumerator CoExecute()
            => renderer.CoColor(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(SpriteRenderer), "Fade")]
    public sealed class SpriteRendererFadeSegment : SpriteRendererSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);
    
        public override IEnumerator CoExecute()
            => renderer.CoFade(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(SpriteRenderer), "Gradient")]
    public sealed class SpriteRendererGradientSegment : SpriteRendererSegment<Gradient>
    {
        public override IEnumerator CoExecute()
            => renderer.CoGradient(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(SpriteRenderer), "Size")]
    public sealed class SpriteRendererSizeSegment : SpriteRendererSegment<Vector2>
    {
        public override IEnumerator CoExecute()
            => renderer.CoSize(target, duration, easer.Evaluate);
    }

    [SegmentMenu(nameof(SpriteRenderer), "SizeX")]
    public sealed class SpriteRendererSizeXSegment : SpriteRendererSegment<float>
    {
        public override IEnumerator CoExecute()
            => renderer.CoSizeX(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(SpriteRenderer), "SizeY")]
    public sealed class SpriteRendererSizeYSegment : SpriteRendererSegment<float>
    {
        public override IEnumerator CoExecute()
            => renderer.CoSizeY(target, duration, easer.Evaluate);
    }
}