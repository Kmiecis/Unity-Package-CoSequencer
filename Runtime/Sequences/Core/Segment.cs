using System;
using System.Collections;
using System.Reflection;
using UnityEngine;

namespace Common.Coroutines
{
    [Serializable]
    public abstract class Segment
    {
        [SerializeField][HideInInspector] private string _name;
        [SerializeField] protected AnimationCurve _easer = AnimationCurve.EaseInOut(0.0f, 0.0f, 1.0f, 1.0f);
        [SerializeField] protected float _duration = 1.0f;

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
            var menuPath = attribute.GetMenuPathOrDefault("Custom");
            var fileName = attribute.GetFileNameOrDefault(type.Name);

            return $"{menuPath} - {fileName}";
        }
#endif

        public abstract IEnumerator CoExecute();

        public virtual void OnAdded()
        {
        }

        public virtual void OnValidate()
        {
        }
    }
}