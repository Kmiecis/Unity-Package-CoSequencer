using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines
{
    [Serializable]
    public abstract class CameraSegment<T> : Segment
    {
        [SerializeField] protected Camera _camera;
        [SerializeField] protected T _target;
    }
    
    [SegmentMenu(nameof(Camera), "Aspect")]
    public sealed class CameraAspectSegment : CameraSegment<float>
    {
        public override IEnumerator CoExecute()
            => _camera.CoAspect(_target, _duration, _easer.Evaluate);
    }

    [SegmentMenu(nameof(Camera), "BackgroundColor")]
    public sealed class CameraBackgroundColorSegment : CameraSegment<Color>
    {
        public override IEnumerator CoExecute()
            => _camera.CoBackgroundColor(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Camera), "NearClipPlane")]
    public sealed class CameraNearClipPlaneSegment : CameraSegment<float>
    {
        public override void OnAdded()
            => _target = 0.3f;

        public override void OnValidate()
            => _target = Mathf.Max(_target, 1e-02f);
        
        public override IEnumerator CoExecute()
            => _camera.CoNearClipPlane(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Camera), "FarClipPlane")]
    public sealed class CameraFarClipPlaneSegment : CameraSegment<float>
    {
        public override IEnumerator CoExecute()
            => _camera.CoFarClipPlane(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Camera), "FieldOfView")]
    public sealed class CameraFieldOfViewSegment : CameraSegment<float>
    {
        public override void OnValidate()
            => _target = Mathf.Clamp(_target, 1e-05f, 180.0f - 1e-05f);

        public override IEnumerator CoExecute()
            => _camera.CoFieldOfView(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Camera), "OrthographicSize")]
    public sealed class CameraOrthographicSizeSegment : CameraSegment<float>
    {
        public override IEnumerator CoExecute()
            => _camera.CoOrthographicSize(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Camera), "Rect")]
    public sealed class CameraRectSegment : CameraSegment<Rect>
    {
        public override IEnumerator CoExecute()
            => _camera.CoRect(_target, _duration, _easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Camera), "PixelRect")]
    public sealed class CameraPixelRectSegment : CameraSegment<Rect>
    {
        public override IEnumerator CoExecute()
            => _camera.CoPixelRect(_target, _duration, _easer.Evaluate);
    }
}