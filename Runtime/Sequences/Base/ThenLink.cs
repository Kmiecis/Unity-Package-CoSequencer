using System.Collections;

namespace Common.Coroutines
{
    internal sealed class ThenLink : ILink
    {
        private readonly ILink _prev;
        private readonly ILink _next;

        public ThenLink(ILink prev, ILink next)
        {
            _prev = prev;
            _next = next;
        }

        public IEnumerator Build()
        {
            return _prev.Build().Then(_next.Build);
        }
    }
}