using System;
using System.Collections;
using System.Reflection;
using UnityEngine;

namespace Common.Coroutines
{
    [Serializable]
    public abstract class Segment : ISegment
    {
        // Exists only for Editor purposes
        [SerializeField][HideInInspector] private string _name;

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