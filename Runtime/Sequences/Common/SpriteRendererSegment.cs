using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines
{
    [Serializable]
    public abstract class SpriteRendererSegment<T> : Segment
    {
        [SerializeField] protected SpriteRenderer _renderer;
        [SerializeField] protected T _target;
    }
    
    [SegmentMenu(nameof(SpriteRenderer), "Color")]
    public sealed class SpriteRendererColorSegment : SpriteRendererSegment<Color>
    {
        public override IEnumerator CoExecute()
            => _renderer.CoColor(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(SpriteRenderer), "Fade")]
    public sealed class SpriteRendererFadeSegment : SpriteRendererSegment<float>
    {
        public override void OnValidate()
            => _target = Mathf.Clamp(_target, 0.0f, 1.0f);
    
        public override IEnumerator CoExecute()
            => _renderer.CoFade(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(SpriteRenderer), "Gradient")]
    public sealed class SpriteRendererGradientSegment : SpriteRendererSegment<Gradient>
    {
        public override IEnumerator CoExecute()
            => _renderer.CoGradient(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(SpriteRenderer), "Size")]
    public sealed class SpriteRendererSizeSegment : SpriteRendererSegment<Vector2>
    {
        public override IEnumerator CoExecute()
            => _renderer.CoSize(_target, _duration, _easer.Evaluate);
    }

    [SegmentMenu(nameof(SpriteRenderer), "SizeX")]
    public sealed class SpriteRendererSizeXSegment : SpriteRendererSegment<float>
    {
        public override IEnumerator CoExecute()
            => _renderer.CoSizeX(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(SpriteRenderer), "SizeY")]
    public sealed class SpriteRendererSizeYSegment : SpriteRendererSegment<float>
    {
        public override IEnumerator CoExecute()
            => _renderer.CoSizeY(_target, _duration, _easer.Evaluate);
    }
}