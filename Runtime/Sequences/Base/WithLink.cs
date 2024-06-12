using System.Collections;

namespace Common.Coroutines
{
    internal sealed class WithLink : ILink
    {
        private readonly ILink _prev;
        private readonly ILink _next;

        public WithLink(ILink prev, ILink next)
        {
            _prev = prev;
            _next = next;
        }

        public IEnumerator Build()
        {
            var prev = _prev.Build();
            var next = _next.Build();
            return prev.With(next);
        }
    }
}