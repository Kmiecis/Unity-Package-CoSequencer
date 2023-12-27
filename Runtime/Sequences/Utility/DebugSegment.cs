using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines.Segments
{
    [Serializable]
    public abstract class DebugSegment : Segment
    {
        public string message;
    }

    [SegmentMenu(nameof(Debug), "Log")]
    public class DebugLogSegment : DebugSegment
    {
        public override IEnumerator CoExecute()
        {
            Debug.Log(message);
            yield return null;
        }
    }

    [SegmentMenu(nameof(Debug), "Warning")]
    public class DebugWarningSegment : DebugSegment
    {
        public override IEnumerator CoExecute()
        {
            Debug.LogWarning(message);
            yield return null;
        }
    }

    [SegmentMenu(nameof(Debug), "Error")]
    public class DebugErrorSegment : DebugSegment
    {
        public override IEnumerator CoExecute()
        {
            Debug.LogError(message);
            yield return null;
        }
    }
}