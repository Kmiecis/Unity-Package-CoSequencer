using System.Collections;

namespace Common.Coroutines
{
    internal sealed class DecoratorLink : ILink
    {
        private readonly ILink _prev;
        private readonly IDecorator _decorator;

        public DecoratorLink(ILink prev, IDecorator decorator)
        {
            _prev = prev;
            _decorator = decorator;
        }

        public IEnumerator Build()
        {
            return _decorator.Build(_prev);
        }
    }
}