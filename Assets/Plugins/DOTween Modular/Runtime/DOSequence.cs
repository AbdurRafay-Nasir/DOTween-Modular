using UnityEngine;
using DG.Tweening;

namespace DOTweenModular
{
    public sealed class DOSequence : DOBase
    {
        public SequenceTweens[] sequenceTweens;

        public override Tween CreateTween()
        {
            Sequence sequence = DOTween.Sequence();

            for (int i = 0; i < sequenceTweens.Length; i++)
            {
                DOBase currentTween = sequenceTweens[i].tweenObject;

                if (sequenceTweens[i].join)
                    sequence.Join(currentTween.CreateTween());
                else
                    sequence.Append(currentTween.CreateTween());
            }

            if (tweenType == Enums.TweenType.Looped)
                sequence.SetLoops(loops, loopType);

            Tween = sequence;
            TweenCreated();

            return Tween;
        }
    }

    [System.Serializable]
    public struct SequenceTweens
    {
        [Tooltip("If TRUE, this Tween Object will play with previous Tween Object, has no effect if this is first Tween Object")]
        public bool join;

        [Tooltip("Tween to play")]
        public DOBase tweenObject;
    }
}