namespace Common.Coroutines
{
    public interface ISegment : ILink
    {
        void OnValidate();
    }
}