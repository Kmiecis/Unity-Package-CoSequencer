using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines
{
    [Serializable]
    public abstract class DebugSegment : Segment
    {
        [SerializeField] protected string _message;
    }

    [SegmentMenu(nameof(Debug), "Log")]
    public class DebugLogSegment : DebugSegment
    {
        public override IEnumerator CoExecute()
        {
            Debug.Log(_message);
            yield return null;
        }
    }

    [SegmentMenu(nameof(Debug), "Warning")]
    public class DebugWarningSegment : DebugSegment
    {
        public override IEnumerator CoExecute()
        {
            Debug.LogWarning(_message);
            yield return null;
        }
    }

    [SegmentMenu(nameof(Debug), "Error")]
    public class DebugErrorSegment : DebugSegment
    {
        public override IEnumerator CoExecute()
        {
            Debug.LogError(_message);
            yield return null;
        }
    }
}