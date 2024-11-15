using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Common.Coroutines.Segments
{
    public abstract class OutlineSegment<T> : TimedSegment
    {
        public Outline outline;
        public T target;
    }

    public abstract class OutlineTimedSegment<T> : TimedSegment
    {
        public Outline outline;
        public T target;
    }

    public abstract class OutlineBetweenSegment<T> : TimedSegment
    {
        public Outline outline;
        public T start;
        public T target;
    }

    #region Shadow
    [Serializable]
    [SegmentMenu("Towards", SegmentPath.OutlineEffectColor, SegmentGroup.UI)]
    public sealed class OutlineEffectColorSegment : OutlineTimedSegment<Color>
    {
        public OutlineEffectColorSegment()
            => target = Color.white;

        public override IEnumerator Build()
            => outline.CoEffectColor(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Set", SegmentPath.OutlineEffectColor, SegmentGroup.UI)]
    public sealed class OutlineEffectColorSetSegment : OutlineSegment<Color>
    {
        public OutlineEffectColorSetSegment()
            => target = Color.white;

        public override IEnumerator Build()
            => outline.CoEffectColor(target);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.OutlineEffectColor, SegmentGroup.UI)]
    public sealed class OutlineEffectColorBetweenSegment : OutlineBetweenSegment<Color>
    {
        public OutlineEffectColorBetweenSegment()
        {
            start = Color.white;
            target = Color.white;
        }

        public override IEnumerator Build()
            => outline.CoEffectColor(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.OutlineEffectFade, SegmentGroup.UI)]
    public sealed class OutlineEffectFadeSegment : OutlineTimedSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator Build()
            => outline.CoEffectFade(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Set", SegmentPath.OutlineEffectFade, SegmentGroup.UI)]
    public sealed class OutlineEffectFadeSetSegment : OutlineSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 0.0f, 1.0f);

        public override IEnumerator Build()
            => outline.CoEffectFade(target);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.OutlineEffectFade, SegmentGroup.UI)]
    public sealed class OutlineEffectFadeBetweenSegment : OutlineBetweenSegment<float>
    {
        public override void OnValidate()
        {
            start = Mathf.Clamp(start, 0.0f, 1.0f);
            target = Mathf.Clamp(target, 0.0f, 1.0f);
        }

        public override IEnumerator Build()
            => outline.CoEffectFade(start, target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Effect Gradient", SegmentPath.Outline, SegmentGroup.UI)]
    public sealed class OutlineEffectGradientSegment : OutlineTimedSegment<Gradient>
    {
        public override IEnumerator Build()
            => outline.CoEffectGradient(target, duration, easer.Evaluate);
    }
    #endregion
}