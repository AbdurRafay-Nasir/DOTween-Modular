using DG.Tweening;

namespace DOTweenModular
{
    [UnityEngine.AddComponentMenu("Tween Kit/DO Shake Scale")]
    public sealed class DOShakeScale : DOShakeBase
    {
        protected override void InitializeTween()
        {
            Tween = transform.DOShakeScale(duration, strength, vibrato, randomness, fadeout, randomnessMode);
        }
    }
}