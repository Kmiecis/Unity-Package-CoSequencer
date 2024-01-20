using System;

namespace Common.Coroutines
{
    public static class EEaseTypeExtensions
    {
        public static Func<float, float> ToEaser(this EEaserType self)
        {
            switch (self)
            {
                case EEaserType.Step: return Easers.Step;
                case EEaserType.SmoothStep: return Easers.SmoothStep;
                case EEaserType.SmootherStep: return Easers.SmootherStep;
                case EEaserType.InSine: return Easers.InSine;
                case EEaserType.OutSine: return Easers.OutSine;
                case EEaserType.InOutSine: return Easers.InOutSine;
                case EEaserType.InQuad: return Easers.InQuad;
                case EEaserType.OutQuad: return Easers.OutQuad;
                case EEaserType.InOutQuad: return Easers.InOutQuad;
                case EEaserType.InCubic: return Easers.InCubic;
                case EEaserType.OutCubic: return Easers.OutCubic;
                case EEaserType.InOutCubic: return Easers.InOutCubic;
                case EEaserType.InQuart: return Easers.InQuart;
                case EEaserType.OutQuart: return Easers.OutQuart;
                case EEaserType.InOutQuart: return Easers.InOutQuart;
                case EEaserType.InQuint: return Easers.InQuint;
                case EEaserType.OutQuint: return Easers.OutQuint;
                case EEaserType.InOutQuint: return Easers.InOutQuint;
                case EEaserType.InExpo: return Easers.InExpo;
                case EEaserType.OutExpo: return Easers.OutExpo;
                case EEaserType.InOutExpo: return Easers.InOutExpo;
                case EEaserType.InCirc: return Easers.InCirc;
                case EEaserType.OutCirc: return Easers.OutCirc;
                case EEaserType.InOutCirc: return Easers.InOutCirc;
                case EEaserType.InBack: return Easers.InBack;
                case EEaserType.OutBack: return Easers.OutBack;
                case EEaserType.InOutBack: return Easers.InOutBack;
                case EEaserType.InElastic: return Easers.InElastic;
                case EEaserType.OutElastic: return Easers.OutElastic;
                case EEaserType.InOutElastic: return Easers.InOutElastic;
                case EEaserType.InBounce: return Easers.InBounce;
                case EEaserType.OutBounce: return Easers.OutBounce;
                case EEaserType.InOutBounce: return Easers.InOutBounce;
            }
            return Easers.Linear;
        }
    }
}
