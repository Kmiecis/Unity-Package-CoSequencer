namespace Common.Coroutines
{
    public static class SegmentPath
    {
        public const string Custom = "Custom";
        public const string Utility = "Utility";
        public const string Wait = "Wait";

        public const string Debug = nameof(UnityEngine.Debug);

        public const string AudioSource = nameof(UnityEngine.AudioSource);
        public const string AudioSourcePitch = AudioSource + "/Pitch";
        public const string AudioSourceVolume = AudioSource + "/Volume";

        public const string Camera = nameof(UnityEngine.Camera);
        public const string CameraAspect = Camera + "/Aspect";
        public const string CameraBackgroundColor = Camera + "/Background Color";
        public const string CameraNearClipPlane = Camera + "/Near Clip Plane";
        public const string CameraFarClipPlane = Camera + "/Far Clip Plane";
        public const string CameraFieldOfView = Camera + "/Field Of View";
        public const string CameraOrthographicSize = Camera + "/Orthographic Size";
        public const string CameraPixelRect = Camera + "/Pixel Rect";
        public const string CameraRect = Camera + "/Rect";

        public const string Light = nameof(UnityEngine.Light);
        public const string LightColor = Light + "/Color";
        public const string LightIntensity = Light + "/Intensity";
        public const string LightRange = Light + "/Range";
        public const string LightShadowStrength = Light + "/Shadow Strength";

        public const string LineRenderer = nameof(UnityEngine.LineRenderer);
        public const string LineRendererStartColor = LineRenderer + "/Start Color";
        public const string LineRendererEndColor = LineRenderer + "/End Color";
        public const string LineRendererStartFade = LineRenderer + "/Start Fade";
        public const string LineRendererEndFade = LineRenderer + "/End Fade";
        public const string LineRendererStartWidth = LineRenderer + "/Start Width";
        public const string LineRendererEndWidth = LineRenderer + "/End Width";

        public const string Material = nameof(UnityEngine.Material);
        public const string MaterialColor = Material + "/Color";
        public const string MaterialFade = Material + "/Fade";
        public const string MaterialFloat = Material + "/Float";
        public const string MaterialTiling = Material + "/Tiling";
        public const string MaterialOffset = Material + "/Offset";
        public const string MaterialVector = Material + "/Vector";

        public const string Rigidbody2D = nameof(UnityEngine.Rigidbody2D);
        public const string Rigidbody2DMove = Rigidbody2D + "/Move";
        public const string Rigidbody2DRotate = Rigidbody2D + "/Rotate";

        public const string Rigidbody = nameof(UnityEngine.Rigidbody);
        public const string RigidbodyMove = Rigidbody + "/Move";
        public const string RigidbodyRotate = Rigidbody + "/Rotate";

        public const string SpriteRenderer = nameof(UnityEngine.SpriteRenderer);
        public const string SpriteRendererColor = SpriteRenderer + "/Color";
        public const string SpriteRendererFade = SpriteRenderer + "/Fade";
        public const string SpriteRendererSize = SpriteRenderer + "/Size";

        public const string TrailRenderer = nameof(UnityEngine.TrailRenderer);
        public const string TrailRendererStartColor = TrailRenderer + "/Start Color";
        public const string TrailRendererEndColor = TrailRenderer + "/End Color";
        public const string TrailRendererStartFade = TrailRenderer + "/Start Fade";
        public const string TrailRendererEndFade = TrailRenderer + "/End Fade";
        public const string TrailRendererTime = TrailRenderer + "/Time";
        public const string TrailRendererStartWidth = TrailRenderer + "/Start Width";
        public const string TrailRendererEndWidth = TrailRenderer + "/End Width";

        public const string Transform = nameof(UnityEngine.Transform);
        public const string TransformMove = Transform + "/Move";
        public const string TransformRotate = Transform + "/Rotate";
        public const string TransformLocalMove = Transform + "/Local Move";
        public const string TransformLocalRotate = Transform + "/Local Rotate";
        public const string TransformLocalScale = Transform + "/Local Scale";
        public const string TransformLookAt = Transform + "/Look At";

        public const string CanvasGroup = nameof(UnityEngine.CanvasGroup);
        public const string CanvasGroupFade = CanvasGroup + "/Fade";

        public const string Graphic = nameof(UnityEngine.UI.Graphic);
        public const string GraphicColor = Graphic + "/Color";
        public const string GraphicFade = Graphic + "/Fade";

        public const string Image = nameof(UnityEngine.UI.Image);
        public const string ImageFillAmount = Image + "/Fill Amount";
        public const string ImageColor = Image + "/Color";
        public const string ImageFade = Image + "/Fade";

        public const string LayoutElement = nameof(UnityEngine.UI.LayoutElement);
        public const string LayoutElementFlexibleWidth = LayoutElement + "/Flexible Width";
        public const string LayoutElementFlexibleHeight = LayoutElement + "/Flexible Height";
        public const string LayoutElementFlexibleSize = LayoutElement + "/Flexible Size";
        public const string LayoutElementMinWidth = LayoutElement + "/Min Width";
        public const string LayoutElementMinHeight = LayoutElement + "/Min Height";
        public const string LayoutElementMinSize = LayoutElement + "/Min Size";
        public const string LayoutElementPreferredWidth = LayoutElement + "/Preferred Width";
        public const string LayoutElementPreferredHeight = LayoutElement + "/Preferred Height";
        public const string LayoutElementPreferredSize = LayoutElement + "/Preferred Size";

        public const string Outline = nameof(UnityEngine.UI.Outline);
        public const string OutlineEffectColor = Outline + "/Effect Color";
        public const string OutlineEffectFade = Outline + "/Effect Fade";

        public const string RectTransform = nameof(UnityEngine.RectTransform);
        public const string RectTransformAnchorMin = RectTransform + "/Anchor Min";
        public const string RectTransformAnchorMax = RectTransform + "/Anchor Max";
        public const string RectTransformAnchorMove = RectTransform + "/Anchor Move";
        public const string RectTransformOffsetMin = RectTransform + "/Offset Min";
        public const string RectTransformOffsetMax = RectTransform + "/Offset Max";
        public const string RectTransformPivot = RectTransform + "/Pivot";
        public const string RectTransformSizeDelta = RectTransform + "/Size Delta";

        public const string ScrollRect = nameof(UnityEngine.UI.ScrollRect);
        public const string ScrollRectPosition = ScrollRect + "/Position";
        public const string ScrollRectHorizontalPosition = ScrollRect + "/Horizontal Position";
        public const string ScrollRectVerticalPosition = ScrollRect + "/Vertical Position";
        public const string ScrollRectVelocity = ScrollRect + "/Velocity";
        public const string ScrollRectHorizontalVelocity = ScrollRect + "/Horizontal Velocity";
        public const string ScrollRectVerticalVelocity = ScrollRect + "/Vertical Velocity";

        public const string Shadow = nameof(UnityEngine.UI.Shadow);
        public const string ShadowEffectColor = Shadow + "/Effect Color";
        public const string ShadowEffectFade = Shadow + "/Effect Fade";

        public const string Slider = nameof(UnityEngine.UI.Slider);
        public const string SliderValue = Slider + "/Value";
        public const string SliderNormalizedValue = Slider + "/Normalized Value";

        public const string Text = nameof(UnityEngine.UI.Text);
        public const string TextFontSize = Text + "/Font Size";
        public const string TextText = Text + "/Text";
        public const string TextColor = Text + "/Color";
        public const string TextFade = Text + "/Fade";

        public const string Time = nameof(UnityEngine.Time);
    }
}