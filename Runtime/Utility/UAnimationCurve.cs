using UnityEngine;

namespace Common.Coroutines
{
    public static class UAnimationCurve
    {
        public static AnimationCurve EaseInOutNormalized()
            => AnimationCurve.EaseInOut(0.0f, 0.0f, 1.0f, 1.0f);

        public static AnimationCurve LinearNormalized()
            => AnimationCurve.Linear(0.0f, 0.0f, 1.0f, 1.0f);

        public static AnimationCurve One()
            => AnimationCurve.Constant(0.0f, 1.0f, 1.0f);

        public static AnimationCurve Zero()
            => AnimationCurve.Constant(0.0f, 1.0f, 0.0f);
    }
}