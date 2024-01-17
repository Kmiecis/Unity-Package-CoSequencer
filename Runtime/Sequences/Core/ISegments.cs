using System.Collections.Generic;

namespace Common.Coroutines
{
    public interface ISegments
    {
        int SegmentCount { get; }

        void AddSegment(Segment item);

        void AddSegmentAt(int index, Segment item);

        void RemoveSegmentAt(int index);

        Segment GetLastSegment();

        void RemoveLastSegment();

        int IndexOf(Segment item);

        IEnumerable<Segment> GetSegments();
    }
}