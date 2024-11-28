using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines.Segments
{
    #region Aspect
    [Serializable]
    [SegmentMenu("Set", SegmentPath.CameraAspect, SegmentGroup.Core)]
    public sealed class CameraAspectSetSegment : SetSegment<Camera, float>
    {
        public override IEnumerator Build()
            => component.CoAspect(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.CameraAspect, SegmentGroup.Core)]
    public sealed class CameraAspectSegment : TowardsSegment<Camera, float>
    {
        public override IEnumerator Build()
            => component.CoAspect(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.CameraAspect, SegmentGroup.Core)]
    public sealed class CameraAspectBetweenSegment : BetweenSegment<Camera, float>
    {
        public override IEnumerator Build()
            => component.CoAspect(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region Color
    [Serializable]
    [SegmentMenu("Set", SegmentPath.CameraBackgroundColor, SegmentGroup.Core)]
    public sealed class CameraBackgroundColorSetSegment : SetSegment<Camera, Color>
    {
        public CameraBackgroundColorSetSegment()
            => target = Color.white;

        public override IEnumerator Build()
            => component.CoBackgroundColor(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.CameraBackgroundColor, SegmentGroup.Core)]
    public sealed class CameraBackgroundColorSegment : TowardsSegment<Camera, Color>
    {
        public CameraBackgroundColorSegment()
            => target = Color.white;

        public override IEnumerator Build()
            => component.CoBackgroundColor(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.CameraBackgroundColor, SegmentGroup.Core)]
    public sealed class CameraBackgroundColorBetweenSegment : BetweenSegment<Camera, Color>
    {
        public CameraBackgroundColorBetweenSegment()
        {
            start = Color.white;
            target = Color.white;
        }

        public override IEnumerator Build()
            => component.CoBackgroundColor(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region ClipPlane
    [Serializable]
    [SegmentMenu("Set", SegmentPath.CameraNearClipPlane, SegmentGroup.Core)]
    public sealed class CameraNearClipPlaneSetSegment : SetSegment<Camera, float>
    {
        public CameraNearClipPlaneSetSegment()
            => target = 0.3f;

        public override void OnValidate()
            => target = Mathf.Max(target, 1e-02f);

        public override IEnumerator Build()
            => component.CoNearClipPlane(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.CameraNearClipPlane, SegmentGroup.Core)]
    public sealed class CameraNearClipPlaneSegment : TowardsSegment<Camera, float>
    {
        public CameraNearClipPlaneSegment()
            => target = 0.3f;

        public override void OnValidate()
            => target = Mathf.Max(target, 1e-02f);
        
        public override IEnumerator Build()
            => component.CoNearClipPlane(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.CameraNearClipPlane, SegmentGroup.Core)]
    public sealed class CameraNearClipPlaneBetweenSegment : BetweenSegment<Camera, float>
    {
        public CameraNearClipPlaneBetweenSegment()
            => target = 0.3f;

        public override void OnValidate()
            => target = Mathf.Max(target, 1e-02f);

        public override IEnumerator Build()
            => component.CoNearClipPlane(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region FarClipPlane
    [Serializable]
    [SegmentMenu("Set", SegmentPath.CameraFarClipPlane, SegmentGroup.Core)]
    public sealed class CameraFarClipPlaneSetSegment : SetSegment<Camera, float>
    {
        public override IEnumerator Build()
            => component.CoFarClipPlane(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.CameraFarClipPlane, SegmentGroup.Core)]
    public sealed class CameraFarClipPlaneSegment : TowardsSegment<Camera, float>
    {
        public override IEnumerator Build()
            => component.CoFarClipPlane(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.CameraFarClipPlane, SegmentGroup.Core)]
    public sealed class CameraFarClipPlaneBetweenSegment : BetweenSegment<Camera, float>
    {
        public override IEnumerator Build()
            => component.CoFarClipPlane(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region FieldOfView
    [Serializable]
    [SegmentMenu("Set", SegmentPath.CameraFieldOfView, SegmentGroup.Core)]
    public sealed class CameraFieldOfViewSetSegment : SetSegment<Camera, float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 1e-05f, 180.0f - 1e-05f);

        public override IEnumerator Build()
            => component.CoFieldOfView(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.CameraFieldOfView, SegmentGroup.Core)]
    public sealed class CameraFieldOfViewSegment : TowardsSegment<Camera, float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 1e-05f, 180.0f - 1e-05f);

        public override IEnumerator Build()
            => component.CoFieldOfView(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.CameraFieldOfView, SegmentGroup.Core)]
    public sealed class CameraFieldOfViewBetweenSegment : BetweenSegment<Camera, float>
    {
        public override void OnValidate()
            => target = Mathf.Clamp(target, 1e-05f, 180.0f - 1e-05f);

        public override IEnumerator Build()
            => component.CoFieldOfView(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region OrthographicSize
    [Serializable]
    [SegmentMenu("Set", SegmentPath.CameraOrthographicSize, SegmentGroup.Core)]
    public sealed class CameraOrthographicSizeSetSegment : SetSegment<Camera, float>
    {
        public override IEnumerator Build()
            => component.CoOrthographicSize(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.CameraOrthographicSize, SegmentGroup.Core)]
    public sealed class CameraOrthographicSizeSegment : TowardsSegment<Camera, float>
    {
        public override IEnumerator Build()
            => component.CoOrthographicSize(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.CameraOrthographicSize, SegmentGroup.Core)]
    public sealed class CameraOrthographicSizeBetweenSegment : BetweenSegment<Camera, float>
    {
        public override IEnumerator Build()
            => component.CoOrthographicSize(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region PixelRect
    [Serializable]
    [SegmentMenu("Set", SegmentPath.CameraPixelRect, SegmentGroup.Core)]
    public sealed class CameraPixelRectSetSegment : SetSegment<Camera, Rect>
    {
        public CameraPixelRectSetSegment()
            => target = new Rect(0.0f, 0.0f, 1.0f, 1.0f);

        public override IEnumerator Build()
            => component.CoPixelRect(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.CameraPixelRect, SegmentGroup.Core)]
    public sealed class CameraPixelRectSegment : TowardsSegment<Camera, Rect>
    {
        public CameraPixelRectSegment()
            => target = new Rect(0.0f, 0.0f, 1.0f, 1.0f);

        public override IEnumerator Build()
            => component.CoPixelRect(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.CameraPixelRect, SegmentGroup.Core)]
    public sealed class CameraPixelRectBetweenSegment : BetweenSegment<Camera, Rect>
    {
        public CameraPixelRectBetweenSegment()
            => target = new Rect(0.0f, 0.0f, 1.0f, 1.0f);

        public override IEnumerator Build()
            => component.CoPixelRect(start, target, duration, easer.Evaluate);
    }
    #endregion

    #region Rect
    [Serializable]
    [SegmentMenu("Set", SegmentPath.CameraRect, SegmentGroup.Core)]
    public sealed class CameraRectSetSegment : SetSegment<Camera, Rect>
    {
        public CameraRectSetSegment()
            => target = new Rect(0.0f, 0.0f, 1.0f, 1.0f);

        public override IEnumerator Build()
            => component.CoRect(target);
    }

    [Serializable]
    [SegmentMenu("Towards", SegmentPath.CameraRect, SegmentGroup.Core)]
    public sealed class CameraRectSegment : TowardsSegment<Camera, Rect>
    {
        public CameraRectSegment()
            => target = new Rect(0.0f, 0.0f, 1.0f, 1.0f);

        public override IEnumerator Build()
            => component.CoRect(target, duration, easer.Evaluate);
    }

    [Serializable]
    [SegmentMenu("Between", SegmentPath.CameraRect, SegmentGroup.Core)]
    public sealed class CameraRectBetweenSegment : BetweenSegment<Camera, Rect>
    {
        public CameraRectBetweenSegment()
            => target = new Rect(0.0f, 0.0f, 1.0f, 1.0f);

        public override IEnumerator Build()
            => component.CoRect(start, target, duration, easer.Evaluate);
    }
    #endregion
}