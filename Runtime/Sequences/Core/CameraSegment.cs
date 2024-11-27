using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines.Segments
{
    public abstract class CameraSegment<T> : Segment
    {
        public Camera camera;
        public T target;
    }

    public abstract class CameraTimedSegment<T> : TimedSegment
    {
        public Camera camera;
        public T target;
    }

    public abstract class CameraBetweenSegment<T> : TimedSegment
    {
        public Camera camera;
        public T start;
        public T target;
    }

    #region Aspect
    [Serializable]
    [SegmentMenu("Set", SegmentPath.CameraAspect, SegmentGroup.Core)]
    public sealed class CameraAspectSetSegment : CameraSegment<float>
    {
        public override IEnumerator Build()
            => camera.CoAspect(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.CameraAspect, SegmentGroup.Core)]
    public sealed class CameraAspectSegment : CameraTimedSegment<float>
    {
        public override IEnumerator Build()
            => camera.CoAspect(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.CameraAspect, SegmentGroup.Core)]
    public sealed class CameraAspectBetweenSegment : CameraBetweenSegment<float>
    {
        public override IEnumerator Build()
            => camera.CoAspect(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region Color
    [Serializable]
    [SegmentMenu("Set", SegmentPath.CameraBackgroundColor, SegmentGroup.Core)]
    public sealed class CameraBackgroundColorSetSegment : CameraSegment<Color>
    {
        public CameraBackgroundColorSetSegment()
            => target = Color.white;

        public override IEnumerator Build()
            => camera.CoBackgroundColor(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.CameraBackgroundColor, SegmentGroup.Core)]
    public sealed class CameraBackgroundColorSegment : CameraTimedSegment<Color>
    {
        public CameraBackgroundColorSegment()
            => target = Color.white;

        public override IEnumerator Build()
            => camera.CoBackgroundColor(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.CameraBackgroundColor, SegmentGroup.Core)]
    public sealed class CameraBackgroundColorBetweenSegment : CameraBetweenSegment<Color>
    {
        public CameraBackgroundColorBetweenSegment()
        {
            start = Color.white;
            target = Color.white;
        }

        public override IEnumerator Build()
            => camera.CoBackgroundColor(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region ClipPlane
    [Serializable]
    [SegmentMenu("Set", SegmentPath.CameraNearClipPlane, SegmentGroup.Core)]
    public sealed class CameraNearClipPlaneSetSegment : CameraSegment<float>
    {
        public CameraNearClipPlaneSetSegment()
            => target = 0.3f;

        public override void OnValidate()
            => target = Mathf.Max(target, 1e-02f);

        public override IEnumerator Build()
            => camera.CoNearClipPlane(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.CameraNearClipPlane, SegmentGroup.Core)]
    public sealed class CameraNearClipPlaneSegment : CameraTimedSegment<float>
    {
        public CameraNearClipPlaneSegment()
            => target = 0.3f;

        public override void OnValidate()
            => target = Mathf.Max(target, 1e-02f);
        
        public override IEnumerator Build()
            => camera.CoNearClipPlane(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.CameraNearClipPlane, SegmentGroup.Core)]
    public sealed class CameraNearClipPlaneBetweenSegment : CameraBetweenSegment<float>
    {
        public CameraNearClipPlaneBetweenSegment()
            => target = 0.3f;

        public override void OnValidate()
            => target = Mathf.Max(target, 1e-02f);

        public override IEnumerator Build()
            => camera.CoNearClipPlane(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region FarClipPlane
    [Serializable]
    [SegmentMenu("Set", SegmentPath.CameraFarClipPlane, SegmentGroup.Core)]
    public sealed class CameraFarClipPlaneSetSegment : CameraSegment<float>
    {
        public override IEnumerator Build()
            => camera.CoFarClipPlane(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.CameraFarClipPlane, SegmentGroup.Core)]
    public sealed class CameraFarClipPlaneSegment : CameraTimedSegment<float>
    {
        public override IEnumerator Build()
            => camera.CoFarClipPlane(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.CameraFarClipPlane, SegmentGroup.Core)]
    public sealed class CameraFarClipPlaneBetweenSegment : CameraBetweenSegment<float>
    {
        public override IEnumerator Build()
            => camera.CoFarClipPlane(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region FieldOfView
    [Serializable]
    [SegmentMenu("Set", SegmentPath.CameraFieldOfView, SegmentGroup.Core)]
    public sealed class CameraFieldOfViewSetSegment : CameraSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 1e-05f, 180.0f - 1e-05f);

        public override IEnumerator Build()
            => camera.CoFieldOfView(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.CameraFieldOfView, SegmentGroup.Core)]
    public sealed class CameraFieldOfViewSegment : CameraTimedSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 1e-05f, 180.0f - 1e-05f);

        public override IEnumerator Build()
            => camera.CoFieldOfView(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.CameraFieldOfView, SegmentGroup.Core)]
    public sealed class CameraFieldOfViewBetweenSegment : CameraBetweenSegment<float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 1e-05f, 180.0f - 1e-05f);

        public override IEnumerator Build()
            => camera.CoFieldOfView(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region OrthographicSize
    [Serializable]
    [SegmentMenu("Set", SegmentPath.CameraOrthographicSize, SegmentGroup.Core)]
    public sealed class CameraOrthographicSizeSetSegment : CameraSegment<float>
    {
        public override IEnumerator Build()
            => camera.CoOrthographicSize(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.CameraOrthographicSize, SegmentGroup.Core)]
    public sealed class CameraOrthographicSizeSegment : CameraTimedSegment<float>
    {
        public override IEnumerator Build()
            => camera.CoOrthographicSize(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.CameraOrthographicSize, SegmentGroup.Core)]
    public sealed class CameraOrthographicSizeBetweenSegment : CameraBetweenSegment<float>
    {
        public override IEnumerator Build()
            => camera.CoOrthographicSize(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region PixelRect
    [Serializable]
    [SegmentMenu("Set", SegmentPath.CameraPixelRect, SegmentGroup.Core)]
    public sealed class CameraPixelRectSetSegment : CameraSegment<Rect>
    {
        public CameraPixelRectSetSegment()
            => target = new Rect(0.0f, 0.0f, 1.0f, 1.0f);

        public override IEnumerator Build()
            => camera.CoPixelRect(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.CameraPixelRect, SegmentGroup.Core)]
    public sealed class CameraPixelRectSegment : CameraTimedSegment<Rect>
    {
        public CameraPixelRectSegment()
            => target = new Rect(0.0f, 0.0f, 1.0f, 1.0f);

        public override IEnumerator Build()
            => camera.CoPixelRect(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.CameraPixelRect, SegmentGroup.Core)]
    public sealed class CameraPixelRectBetweenSegment : CameraBetweenSegment<Rect>
    {
        public CameraPixelRectBetweenSegment()
            => target = new Rect(0.0f, 0.0f, 1.0f, 1.0f);

        public override IEnumerator Build()
            => camera.CoPixelRect(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region Rect
    [Serializable]
    [SegmentMenu("Set", SegmentPath.CameraRect, SegmentGroup.Core)]
    public sealed class CameraRectSetSegment : CameraSegment<Rect>
    {
        public CameraRectSetSegment()
            => target = new Rect(0.0f, 0.0f, 1.0f, 1.0f);

        public override IEnumerator Build()
            => camera.CoRect(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.CameraRect, SegmentGroup.Core)]
    public sealed class CameraRectSegment : CameraTimedSegment<Rect>
    {
        public CameraRectSegment()
            => target = new Rect(0.0f, 0.0f, 1.0f, 1.0f);

        public override IEnumerator Build()
            => camera.CoRect(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.CameraRect, SegmentGroup.Core)]
    public sealed class CameraRectBetweenSegment : CameraBetweenSegment<Rect>
    {
        public CameraRectBetweenSegment()
            => target = new Rect(0.0f, 0.0f, 1.0f, 1.0f);

        public override IEnumerator Build()
            => camera.CoRect(start, target, duration, easer.Evaluate);
    }
    #endregion
}