using UnityEngine;
using DG.Tweening;

namespace DOTweenModular
{
    [AddComponentMenu("DOTween Modular/DO Shake Position")]
    public sealed class DOShakePosition : DOShakeBase
    {
        [Tooltip("If TRUE the tween will smoothly snap all values to integers")]
        public bool snapping;

        protected override void InitializeTween()
        {
            Tween = transform.DOShakePosition(duration, strength, vibrato, randomness, 
                                              snapping, fadeout, randomnessMode);
        }
    }
}