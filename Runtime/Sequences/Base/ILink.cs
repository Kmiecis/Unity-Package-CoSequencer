using System.Collections;

namespace Common.Coroutines
{
    public interface ILink
    {
        IEnumerator Build();
    }
}