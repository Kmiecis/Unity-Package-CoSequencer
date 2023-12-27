using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines
{
    [Serializable]
    public abstract class MaterialSegment<T> : TimedSegment
    {
        [SerializeField] protected Material _material;
        [SerializeField] protected string _property;
        [SerializeField] protected T _target;
        [SerializeField][HideInInspector] protected int _propertyId;

        public override void OnValidate()
        {
            _propertyId = Shader.PropertyToID(_property);
        }
    }
    
    [SegmentMenu(nameof(Material), "Color")]
    public sealed class MaterialColorSegment : MaterialSegment<Color>
    {
        public override void OnAdded()
            => _target = Color.white;

        public override IEnumerator CoExecute()
            => _material.CoColor(_target, _propertyId, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Material), "Fade")]
    public sealed class MaterialFadeSegment : MaterialSegment<float>
    {
        public override void OnValidate()
            => _target = Mathf.Clamp(_target, 0.0f, 1.0f);

        public override IEnumerator CoExecute()
            => _material.CoFade(_target, _propertyId, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Material), "Gradient")]
    public sealed class MaterialGradientSegment : MaterialSegment<Gradient>
    {
        public override IEnumerator CoExecute()
            => _material.CoGradient(_target, _propertyId, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Material), "Float")]
    public sealed class MaterialFloatSegment : MaterialSegment<float>
    {
        public override IEnumerator CoExecute()
            => _material.CoFloat(_target, _propertyId, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Material), "Tiling")]
    public sealed class MaterialTilingSegment : MaterialSegment<Vector2>
    {
        public override IEnumerator CoExecute()
            => _material.CoTiling(_target, _propertyId, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Material), "Offset")]
    public sealed class MaterialOffsetSegment : MaterialSegment<Vector2>
    {
        public override IEnumerator CoExecute()
            => _material.CoOffset(_target, _propertyId, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Material), "Vector")]
    public sealed class MaterialVectorSegment : MaterialSegment<Vector4>
    {
        public override IEnumerator CoExecute()
            => _material.CoVector(_target, _propertyId, _duration, _easer.Evaluate);
    }
}