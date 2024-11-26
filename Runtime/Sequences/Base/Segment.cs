using System;
using System.Collections;
using System.Reflection;
using UnityEngine;

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
}