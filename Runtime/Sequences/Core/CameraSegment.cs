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
    
    [SegmentMenu("Aspect", SegmentPath.Camera, SegmentGroup.Core)]
    public sealed class CameraAspectSegment : CameraSegment<float>
    {
        public override IEnumerator GetSequence()
            => camera.CoAspect(target, duration, easer.Evaluate);
    }

    [SegmentMenu("BackgroundColor", SegmentPath.Camera, SegmentGroup.Core)]
    public sealed class CameraBackgroundColorSegment : CameraSegment<Color>
    {
        public CameraBackgroundColorSegment()
            => target = Color.white;

        public override IEnumerator GetSequence()
            => camera.CoBackgroundColor(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("NearClipPlane", SegmentPath.Camera, SegmentGroup.Core)]
    public sealed class CameraNearClipPlaneSegment : CameraSegment<float>
    {
        public CameraNearClipPlaneSegment()
            => target = 0.3f;

        public override void OnValidate()
            => target = Mathf.Max(target, 1e-02f);
        
        public override IEnumerator GetSequence()
            => camera.CoNearClipPlane(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("FarClipPlane", SegmentPath.Camera, SegmentGroup.Core)]
    public sealed class CameraFarClipPlaneSegment : CameraSegment<float>
    {
        public override IEnumerator GetSequence()
            => camera.CoFarClipPlane(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("FieldOfView", SegmentPath.Camera, SegmentGroup.Core)]
    public sealed class CameraFieldOfViewSegment : CameraSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 1e-05f, 180.0f - 1e-05f);

        public override IEnumerator GetSequence()
            => camera.CoFieldOfView(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("OrthographicSize", SegmentPath.Camera, SegmentGroup.Core)]
    public sealed class CameraOrthographicSizeSegment : CameraSegment<float>
    {
        public override IEnumerator GetSequence()
            => camera.CoOrthographicSize(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("Rect", SegmentPath.Camera, SegmentGroup.Core)]
    public sealed class CameraRectSegment : CameraSegment<Rect>
    {
        public CameraRectSegment()
            => target = new Rect(0.0f, 0.0f, 1.0f, 1.0f);

        public override IEnumerator GetSequence()
            => camera.CoRect(target, duration, easer.Evaluate);
    }
    
    [SegmentMenu("PixelRect", SegmentPath.Camera, SegmentGroup.Core)]
    public sealed class CameraPixelRectSegment : CameraSegment<Rect>
    {
        public CameraPixelRectSegment()
            => target = new Rect(0.0f, 0.0f, 1.0f, 1.0f);

        public override IEnumerator GetSequence()
            => camera.CoPixelRect(target, duration, easer.Evaluate);
    }
}