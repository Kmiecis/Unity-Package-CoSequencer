using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines.Segments
{
    [Serializable]
    public abstract class MaterialSegmentBase<T> : Segment
    {
        public Material material;
        [SerializeField] protected string _property;
        [SerializeField][HideInInspector] protected int _propertyId;

        public override void OnValidate()
        {
            _propertyId = Shader.PropertyToID(_property);
        }
    }

    [Serializable]
    public abstract class MaterialSegment<T> : MaterialSegmentBase<T>
    {
        public T target;
    }

    [Serializable]
    public abstract class MaterialTimedSegment<T> : MaterialSegmentBase<T>
    {
        public T target;
        public float duration = 1.0f;
        public AnimationCurve easer = UAnimationCurve.EaseInOutNormalized();
    }

    [Serializable]
    public abstract class MaterialBetweenSegment<T> : MaterialSegmentBase<T>
    {
        public T start;
        public T target;
        public float duration = 1.0f;
        public AnimationCurve easer = UAnimationCurve.EaseInOutNormalized();
    }

    #region Color
    [SegmentMenu("Towards", SegmentPath.MaterialColor, SegmentGroup.Core)]
    public sealed class MaterialColorSegment : MaterialTimedSegment<Color>
    {
        public MaterialColorSegment()
            => target = Color.white;

        public override IEnumerator Build()
            => material.CoColor(_propertyId, target, duration, easer.Evaluate);
    }

    [SegmentMenu("Set", SegmentPath.MaterialColor, SegmentGroup.Core)]
    public sealed class MaterialColorSetSegment : MaterialSegment<Color>
    {
        public MaterialColorSetSegment()
            => target = Color.white;

        public override IEnumerator Build()
            => material.CoColor(_propertyId, target);
    }

    [SegmentMenu("Between", SegmentPath.MaterialColor, SegmentGroup.Core)]
    public sealed class MaterialColorBetweenSegment : MaterialBetweenSegment<Color>
    {
        public MaterialColorBetweenSegment()
        {
            start = Color.white;
            target = Color.white;
        }

        public override IEnumerator Build()
            => material.CoColor(_propertyId, start, target, duration, easer.Evaluate);
    }
    #endregion

    #region Fade
    [SegmentMenu("Towards", SegmentPath.MaterialFade, SegmentGroup.Core)]
    public sealed class MaterialFadeSegment : MaterialTimedSegment<float>
    {
        public override void OnValidate()
        {
            base.OnValidate();

            target = Mathf.Clamp(target, 0.0f, 1.0f);
        }

        public override IEnumerator Build()
            => material.CoFade(_propertyId, target, duration, easer.Evaluate);
    }

    [SegmentMenu("Set", SegmentPath.MaterialFade, SegmentGroup.Core)]
    public sealed class MaterialFadeSetSegment : MaterialSegment<float>
    {
        public override void OnValidate()
        {
            base.OnValidate();

            target = Mathf.Clamp(target, 0.0f, 1.0f);
        }

        public override IEnumerator Build()
            => material.CoFade(_propertyId, target);
    }

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
            => material.CoFade(_propertyId, start, target, duration, easer.Evaluate);
    }
    #endregion

    #region Gradient
    [SegmentMenu("Gradient", SegmentPath.Material, SegmentGroup.Core)]
    public sealed class MaterialGradientSegment : MaterialTimedSegment<Gradient>
    {
        public override IEnumerator Build()
            => material.CoGradient(_propertyId, target, duration, easer.Evaluate);
    }
    #endregion

    #region Float
    [SegmentMenu("Towards", SegmentPath.MaterialFloat, SegmentGroup.Core)]
    public sealed class MaterialFloatSegment : MaterialTimedSegment<float>
    {
        public override IEnumerator Build()
            => material.CoFloat(_propertyId, target, duration, easer.Evaluate);
    }

    [SegmentMenu("Set", SegmentPath.MaterialFloat, SegmentGroup.Core)]
    public sealed class MaterialFloatSetSegment : MaterialSegment<float>
    {
        public override IEnumerator Build()
            => material.CoFloat(_propertyId, target);
    }

    [SegmentMenu("Between", SegmentPath.MaterialFloat, SegmentGroup.Core)]
    public sealed class MaterialFloatBetweenSegment : MaterialBetweenSegment<float>
    {
        public override IEnumerator Build()
            => material.CoFloat(_propertyId, start, target, duration, easer.Evaluate);
    }
    #endregion

    #region Tiling
    [SegmentMenu("Towards", SegmentPath.MaterialTiling, SegmentGroup.Core)]
    public sealed class MaterialTilingSegment : MaterialTimedSegment<Vector2>
    {
        public override IEnumerator Build()
            => material.CoTiling(_propertyId, target, duration, easer.Evaluate);
    }

    [SegmentMenu("Set", SegmentPath.MaterialTiling, SegmentGroup.Core)]
    public sealed class MaterialTilingSetSegment : MaterialSegment<Vector2>
    {
        public override IEnumerator Build()
            => material.CoTiling(_propertyId, target);
    }

    [SegmentMenu("Between", SegmentPath.MaterialTiling, SegmentGroup.Core)]
    public sealed class MaterialTilingBetweenSegment : MaterialBetweenSegment<Vector2>
    {
        public override IEnumerator Build()
            => material.CoTiling(_propertyId, start, target, duration, easer.Evaluate);
    }
    #endregion

    #region Offset
    [SegmentMenu("Towards", SegmentPath.MaterialOffset, SegmentGroup.Core)]
    public sealed class MaterialOffsetSegment : MaterialTimedSegment<Vector2>
    {
        public override IEnumerator Build()
            => material.CoOffset(_propertyId, target, duration, easer.Evaluate);
    }

    [SegmentMenu("Set", SegmentPath.MaterialOffset, SegmentGroup.Core)]
    public sealed class MaterialOffsetSetSegment : MaterialSegment<Vector2>
    {
        public override IEnumerator Build()
            => material.CoOffset(_propertyId, target);
    }

    [SegmentMenu("Between", SegmentPath.MaterialOffset, SegmentGroup.Core)]
    public sealed class MaterialOffsetBetweenSegment : MaterialBetweenSegment<Vector2>
    {
        public override IEnumerator Build()
            => material.CoOffset(_propertyId, start, target, duration, easer.Evaluate);
    }
    #endregion

    #region Vector
    [SegmentMenu("Towards", SegmentPath.MaterialVector, SegmentGroup.Core)]
    public sealed class MaterialVectorSegment : MaterialTimedSegment<Vector4>
    {
        public override IEnumerator Build()
            => material.CoVector(_propertyId, target, duration, easer.Evaluate);
    }

    [SegmentMenu("Set", SegmentPath.MaterialVector, SegmentGroup.Core)]
    public sealed class MaterialVectorSetSegment : MaterialSegment<Vector4>
    {
        public override IEnumerator Build()
            => material.CoVector(_propertyId, target);
    }

    [SegmentMenu("Between", SegmentPath.MaterialVector, SegmentGroup.Core)]
    public sealed class MaterialVectorBetweenSegment : MaterialBetweenSegment<Vector4>
    {
        public override IEnumerator Build()
            => material.CoVector(_propertyId, start, target, duration, easer.Evaluate);
    }
    #endregion
}