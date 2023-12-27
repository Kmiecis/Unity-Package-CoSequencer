using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines.Segments
{
    [Serializable]
    public abstract class CameraSegment<T> : TimedSegment
    {
        public Camera camera;
        public T target;
    }
    
    [SegmentMenu(nameof(Camera), "Aspect")]
    public sealed class CameraAspectSegment : CameraSegment<float>
    {
        public override IEnumerator CoExecute()
            => camera.CoAspect(target, duration, easer.Evaluate);
    }

    [SegmentMenu(nameof(Camera), "BackgroundColor")]
    public sealed class CameraBackgroundColorSegment : CameraSegment<Color>
    {
        public override void OnAdded()
            => target = Color.white;

        public override IEnumerator CoExecute()
            => camera.CoBackgroundColor(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Camera), "NearClipPlane")]
    public sealed class CameraNearClipPlaneSegment : CameraSegment<float>
    {
        public override void OnAdded()
            => target = 0.3f;

        public override void OnValidate()
            => target = Mathf.Max(target, 1e-02f);
        
        public override IEnumerator CoExecute()
            => camera.CoNearClipPlane(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Camera), "FarClipPlane")]
    public sealed class CameraFarClipPlaneSegment : CameraSegment<float>
    {
        public override IEnumerator CoExecute()
            => camera.CoFarClipPlane(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Camera), "FieldOfView")]
    public sealed class CameraFieldOfViewSegment : CameraSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 1e-05f, 180.0f - 1e-05f);

        public override IEnumerator CoExecute()
            => camera.CoFieldOfView(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Camera), "OrthographicSize")]
    public sealed class CameraOrthographicSizeSegment : CameraSegment<float>
    {
        public override IEnumerator CoExecute()
            => camera.CoOrthographicSize(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Camera), "Rect")]
    public sealed class CameraRectSegment : CameraSegment<Rect>
    {
        public override void OnAdded()
            => target = new Rect(0.0f, 0.0f, 1.0f, 1.0f);

        public override IEnumerator CoExecute()
            => camera.CoRect(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu(nameof(Camera), "PixelRect")]
    public sealed class CameraPixelRectSegment : CameraSegment<Rect>
    {
        public override void OnAdded()
            => target = new Rect(0.0f, 0.0f, 1.0f, 1.0f);

        public override IEnumerator CoExecute()
            => camera.CoPixelRect(target, duration, easer.Evaluate);
    }
}