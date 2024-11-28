using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines.Segments
{
    public abstract class MaterialSetSegment<T> : SetSegment<Material, T>
    {
        [SerializeField] protected string _property;
        [SerializeField][HideInInspector] protected int _propertyId;

        public override void OnValidate()
            => _propertyId = Shader.PropertyToID(_property);
    }

    public abstract class MaterialTowardsSegment<T> : TowardsSegment<Material, T>
    {
        [SerializeField] protected string _property;
        [SerializeField][HideInInspector] protected int _propertyId;

        public override void OnValidate()
            => _propertyId = Shader.PropertyToID(_property);
    }

    public abstract class MaterialBetweenSegment<T> : BetweenSegment<Material, T>
    {
        [SerializeField] protected string _property;
        [SerializeField][HideInInspector] protected int _propertyId;

        public override void OnValidate()
            => _propertyId = Shader.PropertyToID(_property);
    }

    #region Color
    [Serializable]
    [SegmentMenu("Set", SegmentPath.MaterialColor, SegmentGroup.Core)]
    public sealed class MaterialColorSetSegment : MaterialSetSegment<Color>
    {
        public MaterialColorSetSegment()
            => target = Color.white;

        public override IEnumerator Build()
            => component.CoColor(_propertyId, target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.MaterialColor, SegmentGroup.Core)]
    public sealed class MaterialColorSegment : MaterialTowardsSegment<Color>
    {
        public MaterialColorSegment()
            => target = Color.white;

        public override IEnumerator Build()
            => component.CoColor(_propertyId, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.MaterialColor, SegmentGroup.Core)]
    public sealed class MaterialColorBetweenSegment : MaterialBetweenSegment<Color>
    {
        public MaterialColorBetweenSegment()
        {
            start = Color.white;
            target = Color.white;
        }

        public override IEnumerator Build()
            => component.CoColor(_propertyId, start, target, duration, easer.Evaluate);
    }
    #endregion

    #region Fade
    [Serializable]
    [SegmentMenu("Set", SegmentPath.MaterialFade, SegmentGroup.Core)]
    public sealed class MaterialFadeSetSegment : MaterialSetSegment<float>
    {
        public override void OnValidate()
        {
            base.OnValidate();

            target = Mathf.Clamp(target, 0.0f, 1.0f);
        }

        public override IEnumerator Build()
            => component.CoFade(_propertyId, target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.MaterialFade, SegmentGroup.Core)]
    public sealed class MaterialFadeSegment : MaterialTowardsSegment<float>
    {
        public override void OnValidate()
        {
            base.OnValidate();

            target = Mathf.Clamp(target, 0.0f, 1.0f);
        }

        public override IEnumerator Build()
            => component.CoFade(_propertyId, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.MaterialFade, SegmentGroup.Core)]
    public sealed class MaterialFadeBetweenSegment : MaterialBetweenSegment<float>
    {
        public override void OnValidate()
        {
            base.OnValidate();

            start = Mathf.Clamp(start, 0.0f, 1.0f);
            target = Mathf.Clamp(target, 0.0f, 1.0f);
        }

        public override IEnumerator Build()
            => component.CoFade(_propertyId, start, target, duration, easer.Evaluate);
    }
    #endregion

    #region Gradient
    [Serializable]
    [SegmentMenu("Gradient", SegmentPath.Material, SegmentGroup.Core)]
    public sealed class MaterialGradientSegment : MaterialTowardsSegment<Gradient>
    {
        public override IEnumerator Build()
            => component.CoGradient(_propertyId, target, duration, easer.Evaluate);
    }
    #endregion

    #region Float
    [Serializable]
    [SegmentMenu("Set", SegmentPath.MaterialFloat, SegmentGroup.Core)]
    public sealed class MaterialFloatSetSegment : MaterialSetSegment<float>
    {
        public override IEnumerator Build()
            => component.CoFloat(_propertyId, target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.MaterialFloat, SegmentGroup.Core)]
    public sealed class MaterialFloatSegment : MaterialTowardsSegment<float>
    {
        public override IEnumerator Build()
            => component.CoFloat(_propertyId, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.MaterialFloat, SegmentGroup.Core)]
    public sealed class MaterialFloatBetweenSegment : MaterialBetweenSegment<float>
    {
        public override IEnumerator Build()
            => component.CoFloat(_propertyId, start, target, duration, easer.Evaluate);
    }
    #endregion

    #region Tiling
    [Serializable]
    [SegmentMenu("Set", SegmentPath.MaterialTiling, SegmentGroup.Core)]
    public sealed class MaterialTilingSetSegment : MaterialSetSegment<Vector2>
    {
        public override IEnumerator Build()
            => component.CoTiling(_propertyId, target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.MaterialTiling, SegmentGroup.Core)]
    public sealed class MaterialTilingSegment : MaterialTowardsSegment<Vector2>
    {
        public override IEnumerator Build()
            => component.CoTiling(_propertyId, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.MaterialTiling, SegmentGroup.Core)]
    public sealed class MaterialTilingBetweenSegment : MaterialBetweenSegment<Vector2>
    {
        public override IEnumerator Build()
            => component.CoTiling(_propertyId, start, target, duration, easer.Evaluate);
    }
    #endregion

    #region Offset
    [Serializable]
    [SegmentMenu("Set", SegmentPath.MaterialOffset, SegmentGroup.Core)]
    public sealed class MaterialOffsetSetSegment : MaterialSetSegment<Vector2>
    {
        public override IEnumerator Build()
            => component.CoOffset(_propertyId, target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.MaterialOffset, SegmentGroup.Core)]
    public sealed class MaterialOffsetSegment : MaterialTowardsSegment<Vector2>
    {
        public override IEnumerator Build()
            => component.CoOffset(_propertyId, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.MaterialOffset, SegmentGroup.Core)]
    public sealed class MaterialOffsetBetweenSegment : MaterialBetweenSegment<Vector2>
    {
        public override IEnumerator Build()
            => component.CoOffset(_propertyId, start, target, duration, easer.Evaluate);
    }
    #endregion

    #region Vector
    [Serializable]
    [SegmentMenu("Set", SegmentPath.MaterialVector, SegmentGroup.Core)]
    public sealed class MaterialVectorSetSegment : MaterialSetSegment<Vector4>
    {
        public override IEnumerator Build()
            => component.CoVector(_propertyId, target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.MaterialVector, SegmentGroup.Core)]
    public sealed class MaterialVectorSegment : MaterialTowardsSegment<Vector4>
    {
        public override IEnumerator Build()
            => component.CoVector(_propertyId, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.MaterialVector, SegmentGroup.Core)]
    public sealed class MaterialVectorBetweenSegment : MaterialBetweenSegment<Vector4>
    {
        public override IEnumerator Build()
            => component.CoVector(_propertyId, start, target, duration, easer.Evaluate);
    }
    #endregion
}