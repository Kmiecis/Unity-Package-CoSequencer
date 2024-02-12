using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines.Segments
{
    [Serializable]
    public abstract class MaterialSegment<T> : TimedSegment
    {
        public Material material;
        [SerializeField] protected string _property;
        public T target;
        [SerializeField][HideInInspector] protected int _propertyId;

        public string property
        {
            get => _property;
            set => SetProperty(value);
        }

        private void SetProperty(string value)
        {
            _property = value;
            RecreatePropertyId();
        }

        public override void OnValidate()
        {
            RecreatePropertyId();
        }

        private void RecreatePropertyId()
        {
            _propertyId = Shader.PropertyToID(_property);
        }
    }
    
    [SegmentMenu("Color", SegmentPath.Material, SegmentGroup.Core)]
    public sealed class MaterialColorSegment : MaterialSegment<Color>
    {
        public MaterialColorSegment()
            => target = Color.white;

        public override IEnumerator GetSequence()
            => material.CoColor(target, _propertyId, duration, easer.Evaluate);
    }
    
    [SegmentMenu("Fade", SegmentPath.Material, SegmentGroup.Core)]
    public sealed class MaterialFadeSegment : MaterialSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator GetSequence()
            => material.CoFade(target, _propertyId, duration, easer.Evaluate);
    }
    
    [SegmentMenu("Gradient", SegmentPath.Material, SegmentGroup.Core)]
    public sealed class MaterialGradientSegment : MaterialSegment<Gradient>
    {
        public override IEnumerator GetSequence()
            => material.CoGradient(target, _propertyId, duration, easer.Evaluate);
    }
    
    [SegmentMenu("Float", SegmentPath.Material, SegmentGroup.Core)]
    public sealed class MaterialFloatSegment : MaterialSegment<float>
    {
        public override IEnumerator GetSequence()
            => material.CoFloat(target, _propertyId, duration, easer.Evaluate);
    }
    
    [SegmentMenu("Tiling", SegmentPath.Material, SegmentGroup.Core)]
    public sealed class MaterialTilingSegment : MaterialSegment<Vector2>
    {
        public override IEnumerator GetSequence()
            => material.CoTiling(target, _propertyId, duration, easer.Evaluate);
    }
    
    [SegmentMenu("Offset", SegmentPath.Material, SegmentGroup.Core)]
    public sealed class MaterialOffsetSegment : MaterialSegment<Vector2>
    {
        public override IEnumerator GetSequence()
            => material.CoOffset(target, _propertyId, duration, easer.Evaluate);
    }
    
    [SegmentMenu("Vector", SegmentPath.Material, SegmentGroup.Core)]
    public sealed class MaterialVectorSegment : MaterialSegment<Vector4>
    {
        public override IEnumerator GetSequence()
            => material.CoVector(target, _propertyId, duration, easer.Evaluate);
    }
}