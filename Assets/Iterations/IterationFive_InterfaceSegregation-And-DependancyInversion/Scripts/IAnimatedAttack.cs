using UnityEngine;

namespace SolidPrinciple.IterationFive
{
    public interface IAnimatedAttack
    {
        public bool IsAttackAnimationRunning { get; }
        public Animator AttackAnimator { get; }
        public void OnAttackAnimationEnd();
    }
}
