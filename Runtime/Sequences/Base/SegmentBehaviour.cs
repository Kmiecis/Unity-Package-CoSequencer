using System.Collections;
using UnityEngine;

namespace Common.Coroutines
{
    public abstract class SegmentBehaviour : MonoBehaviour, ISegment
    {
        public abstract IEnumerator Build();

        public virtual void OnValidate()
        {
        }
    }
}