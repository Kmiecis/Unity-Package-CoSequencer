using System;
using System.Collections;
using UnityEngine;

namespace Common.Coroutines.Segments
{
    [Serializable]
    public abstract class ChoiceSegment : Segment
    {
        [SerializeReference] ISegment _segment;

        public override IEnumerator Build()
            => _segment.Build();
    }
}