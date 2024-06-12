using System;
using System.Collections;

namespace Common.Coroutines
{
    [Serializable]
    public abstract class Decorator : Segment, IDecorator
    {
        public abstract IEnumerator Build(ILink previous);

        public override IEnumerator Build()
            => throw new NotImplementedException(nameof(Build));
    }
}