using System.Collections;

namespace Common.Coroutines
{
    public interface ISegment
    {
        IEnumerator GetSequence();

        void OnValidate();
    }
}