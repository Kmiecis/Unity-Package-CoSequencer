using System.Collections.Generic;

namespace Common.Coroutines
{
    public interface ISegments
    {
        int SegmentCount { get; }

        void AddSegment(ISegment item);

        void AddSegmentAt(int index, ISegment item);

        void RemoveSegmentAt(int index);

        ISegment GetLastSegment();

        void RemoveLastSegment();

        int IndexOf(ISegment item);

        IEnumerable<ISegment> GetSegments();
    }
}