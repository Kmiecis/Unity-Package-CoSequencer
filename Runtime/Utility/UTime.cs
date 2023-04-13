using UnityEngine;

namespace Common.Coroutines
{
    internal static class UTime
    {
        public static float GetTimeScale()
            => Time.timeScale;

        public static void SetTimeScale(float value)
            => Time.timeScale = value;

        public static float GetFixedDeltaTime()
            => Time.fixedDeltaTime;

        public static void SetFixedDeltaTime(float value)
            => Time.fixedDeltaTime = value;

        public static float GetMaximumDeltaTime()
            => Time.maximumDeltaTime;

        public static void SetMaximumDeltaTime(float value)
            => Time.maximumDeltaTime = value;

        public static float GetMaximumParticleDeltaTime()
            => Time.maximumParticleDeltaTime;

        public static void SetMaximumParticleDeltaTime(float value)
            => Time.maximumParticleDeltaTime = value;
    }
}