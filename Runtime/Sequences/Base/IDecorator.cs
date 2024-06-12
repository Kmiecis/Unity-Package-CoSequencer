using System.Collections;

namespace Common.Coroutines
{
    public interface IDecorator : ISegment
    {
        IEnumerator Build(ILink previous);
    }
}