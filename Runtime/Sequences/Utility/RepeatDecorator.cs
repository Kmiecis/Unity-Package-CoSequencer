using System;
using System.Collections;

namespace Common.Coroutines
{
    [Serializable]
    [SegmentMenu("Repeat", SegmentPath.Utility, SegmentGroup.Utility)]
    public class RepeatDecorator : Decorator
    {
        public int repeats;

        public override IEnumerator Build(ILink previous)
            => UCoroutine.YieldRepeat(previous.Build, repeats);
    }

    [SegmentMenu("Repeat Infinitely", SegmentPath.Utility, SegmentGroup.Utility)]
    public class RepeatInfinitelyDecorator : Decorator
    {
        public override IEnumerator Build(ILink previous)
            => UCoroutine.YieldInfinitely(previous.Build);
    }
}