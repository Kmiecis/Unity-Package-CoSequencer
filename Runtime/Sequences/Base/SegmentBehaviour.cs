using System.Collections;
using UnityEngine;

namespace Common.Coroutines
{
    public abstract class SegmentBehaviour : MonoBehaviour, ISegment
    {
        public abstract IEnumerator CoExecute();

        public virtual void OnAdded()
        {
        }

        public virtual void OnValidate()
        {
        }
    }
}