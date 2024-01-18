using System.Collections;

namespace Common.Coroutines
{
    public interface ISegment
    {
        IEnumerator CoExecute();

        void OnAdded();

        void OnValidate();
    }
}