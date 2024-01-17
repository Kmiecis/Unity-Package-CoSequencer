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

    [SegmentMenu("Log", SegmentPath.Debug, SegmentGroup.Utility)]
    public class DebugLogSegment : DebugSegment
    {
        public override IEnumerator CoExecute()
        {
            Debug.Log(message);
            yield return null;
        }
    }

    [SegmentMenu("Warning", SegmentPath.Debug, SegmentGroup.Utility)]
    public class DebugWarningSegment : DebugSegment
    {
        public override IEnumerator CoExecute()
        {
            Debug.LogWarning(message);
            yield return null;
        }
    }

    [SegmentMenu("Error", SegmentPath.Debug, SegmentGroup.Utility)]
    public class DebugErrorSegment : DebugSegment
    {
        public override IEnumerator CoExecute()
        {
            Debug.LogError(message);
            yield return null;
        }
    }
}