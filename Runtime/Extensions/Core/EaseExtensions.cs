using System;

namespace Common.Coroutines
{
    public static class EEaseExtensions
    {
        public static Func<float, float> ToEaser(this EEase ease)
        {
            switch (ease)
            {
                case EEase.Step: return EaseMath.Step;
                case EEase.SmoothStep: return EaseMath.SmoothStep;
                case EEase.SmootherStep: return EaseMath.SmootherStep;
                case EEase.InSine: return EaseMath.InSine;
                case EEase.OutSine: return EaseMath.OutSine;
                case EEase.InOutSine: return EaseMath.InOutSine;
                case EEase.InQuad: return EaseMath.InQuad;
                case EEase.OutQuad: return EaseMath.OutQuad;
                case EEase.InOutQuad: return EaseMath.InOutQuad;
                case EEase.InCubic: return EaseMath.InCubic;
                case EEase.OutCubic: return EaseMath.OutCubic;
                case EEase.InOutCubic: return EaseMath.InOutCubic;
                case EEase.InQuart: return EaseMath.InQuart;
                case EEase.OutQuart: return EaseMath.OutQuart;
                case EEase.InOutQuart: return EaseMath.InOutQuart;
                case EEase.InQuint: return EaseMath.InQuint;
                case EEase.OutQuint: return EaseMath.OutQuint;
                case EEase.InOutQuint: return EaseMath.InOutQuint;
                case EEase.InExpo: return EaseMath.InExpo;
                case EEase.OutExpo: return EaseMath.OutExpo;
                case EEase.InOutExpo: return EaseMath.InOutExpo;
                case EEase.InCirc: return EaseMath.InCirc;
                case EEase.OutCirc: return EaseMath.OutCirc;
                case EEase.InOutCirc: return EaseMath.InOutCirc;
                case EEase.InBack: return EaseMath.InBack;
                case EEase.OutBack: return EaseMath.OutBack;
                case EEase.InOutBack: return EaseMath.InOutBack;
                case EEase.InElastic: return EaseMath.InElastic;
                case EEase.OutElastic: return EaseMath.OutElastic;
                case EEase.InOutElastic: return EaseMath.InOutElastic;
                case EEase.InBounce: return EaseMath.InBounce;
                case EEase.OutBounce: return EaseMath.OutBounce;
                case EEase.InOutBounce: return EaseMath.InOutBounce;
            }
            return EaseMath.Linear;
        }
    }
}
