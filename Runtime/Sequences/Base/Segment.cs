using System;
using System.Collections;
using System.Reflection;
using UnityEngine;
using UnityEngine.Serialization;

namespace Common.Coroutines
{
    [Serializable]
    public abstract class Segment : ISegment
    {
#if UNITY_EDITOR
        [SerializeField, HideInInspector] private string _name;
#endif

        public Segment()
        {
#if UNITY_EDITOR
            _name = ReadName();
#endif
        }

#if UNITY_EDITOR
        private string ReadName()
        {
            var type = GetType();
            var attribute = type.GetCustomAttribute<SegmentMenuAttribute>();
            var menuPath = attribute.GetMenuPathOrDefault(SegmentPath.Custom);
            var fileName = attribute.GetFileNameOrDefault(type.Name);

            menuPath = menuPath.Replace("/", " - ");
            return $"{menuPath} - {fileName}";
        }
#endif

        public abstract IEnumerator Build();

        public virtual void OnValidate()
        {
        }
    }

    public abstract class TimedSegment : Segment
    {
        public float duration = 1.0f;
        public AnimationCurve easer = UAnimationCurve.EaseInOutNormalized();
    }

    public abstract class SetSegment<TComponent, TValue> : Segment
    {
        [FormerlySerializedAs("animator"), FormerlySerializedAs("audio"), FormerlySerializedAs("camera"),
        FormerlySerializedAs("light"), FormerlySerializedAs("renderer"), FormerlySerializedAs("material"),
        FormerlySerializedAs("rigidbody"), FormerlySerializedAs("transform"),
        FormerlySerializedAs("canvas"), FormerlySerializedAs("graphic"), FormerlySerializedAs("image"),
        FormerlySerializedAs("element"), FormerlySerializedAs("outline"), FormerlySerializedAs("scroll"),
        FormerlySerializedAs("shadow"), FormerlySerializedAs("slider"), FormerlySerializedAs("text")]
        public TComponent component;
        public TValue target;
    }

    public abstract class TowardsSegment<TComponent, TValue> : Segment
    {
        [FormerlySerializedAs("animator"), FormerlySerializedAs("audio"), FormerlySerializedAs("camera"),
        FormerlySerializedAs("light"), FormerlySerializedAs("renderer"), FormerlySerializedAs("material"),
        FormerlySerializedAs("rigidbody"), FormerlySerializedAs("transform"),
        FormerlySerializedAs("canvas"), FormerlySerializedAs("graphic"), FormerlySerializedAs("image"),
        FormerlySerializedAs("element"), FormerlySerializedAs("outline"), FormerlySerializedAs("scroll"),
        FormerlySerializedAs("shadow"), FormerlySerializedAs("slider"), FormerlySerializedAs("text")]
        public TComponent component;
        public TValue target;
        public float duration = 1.0f;
        public AnimationCurve easer = UAnimationCurve.EaseInOutNormalized();
    }

    public abstract class BetweenSegment<TComponent, TValue> : Segment
    {
        [FormerlySerializedAs("animator"), FormerlySerializedAs("audio"), FormerlySerializedAs("camera"),
        FormerlySerializedAs("light"), FormerlySerializedAs("renderer"), FormerlySerializedAs("material"),
        FormerlySerializedAs("rigidbody"), FormerlySerializedAs("transform"),
        FormerlySerializedAs("canvas"), FormerlySerializedAs("graphic"), FormerlySerializedAs("image"),
        FormerlySerializedAs("element"), FormerlySerializedAs("outline"), FormerlySerializedAs("scroll"),
        FormerlySerializedAs("shadow"), FormerlySerializedAs("slider"), FormerlySerializedAs("text")]
        public TComponent component;
        public TValue start;
        public TValue target;
        public float duration = 1.0f;
        public AnimationCurve easer = UAnimationCurve.EaseInOutNormalized();
    }
}