using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines
{
    [Serializable]
    public abstract class LineRendererSegment<T> : Segment
    {
        [SerializeField] protected LineRenderer _renderer;
        [SerializeField] protected T _target;
    }
    
    [SegmentMenu(nameof(LineRenderer), "StartColor")]
    public sealed class LineRendererStartColorSegment : LineRendererSegment<Color>
    {
        public override IEnumerator CoExecute()
            => _renderer.CoStartColor(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(LineRenderer), "EndColor")]
    public sealed class LineRendererEndColorSegment : LineRendererSegment<Color>
    {
        public override IEnumerator CoExecute()
            => _renderer.CoEndColor(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(LineRenderer), "StartWidth")]
    public sealed class LineRendererStartWidthSegment : LineRendererSegment<float>
    {
        public override IEnumerator CoExecute()
            => _renderer.CoStartWidth(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(LineRenderer), "EndWidth")]
    public sealed class LineRendererEndWidthSegment : LineRendererSegment<float>
    {
        public override IEnumerator CoExecute()
            => _renderer.CoEndWidth(_target, _duration, _easer.Evaluate);
    }
}