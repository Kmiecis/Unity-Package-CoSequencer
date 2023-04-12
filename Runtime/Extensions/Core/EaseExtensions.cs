using System;

namespace Common.Coroutines
{
    public static class EEaseTypeExtensions
    {
        public static Func<float, float> ToEaser(this EEaseType self)
        {
            switch (self)
            {
                case EEaseType.Step: return Easings.Step;
                case EEaseType.SmoothStep: return Easings.SmoothStep;
                case EEaseType.SmootherStep: return Easings.SmootherStep;
                case EEaseType.InSine: return Easings.InSine;
                case EEaseType.OutSine: return Easings.OutSine;
                case EEaseType.InOutSine: return Easings.InOutSine;
                case EEaseType.InQuad: return Easings.InQuad;
                case EEaseType.OutQuad: return Easings.OutQuad;
                case EEaseType.InOutQuad: return Easings.InOutQuad;
                case EEaseType.InCubic: return Easings.InCubic;
                case EEaseType.OutCubic: return Easings.OutCubic;
                case EEaseType.InOutCubic: return Easings.InOutCubic;
                case EEaseType.InQuart: return Easings.InQuart;
                case EEaseType.OutQuart: return Easings.OutQuart;
                case EEaseType.InOutQuart: return Easings.InOutQuart;
                case EEaseType.InQuint: return Easings.InQuint;
                case EEaseType.OutQuint: return Easings.OutQuint;
                case EEaseType.InOutQuint: return Easings.InOutQuint;
                case EEaseType.InExpo: return Easings.InExpo;
                case EEaseType.OutExpo: return Easings.OutExpo;
                case EEaseType.InOutExpo: return Easings.InOutExpo;
                case EEaseType.InCirc: return Easings.InCirc;
                case EEaseType.OutCirc: return Easings.OutCirc;
                case EEaseType.InOutCirc: return Easings.InOutCirc;
                case EEaseType.InBack: return Easings.InBack;
                case EEaseType.OutBack: return Easings.OutBack;
                case EEaseType.InOutBack: return Easings.InOutBack;
                case EEaseType.InElastic: return Easings.InElastic;
                case EEaseType.OutElastic: return Easings.OutElastic;
                case EEaseType.InOutElastic: return Easings.InOutElastic;
                case EEaseType.InBounce: return Easings.InBounce;
                case EEaseType.OutBounce: return Easings.OutBounce;
                case EEaseType.InOutBounce: return Easings.InOutBounce;
            }
            return Easings.Linear;
        }
    }
}
