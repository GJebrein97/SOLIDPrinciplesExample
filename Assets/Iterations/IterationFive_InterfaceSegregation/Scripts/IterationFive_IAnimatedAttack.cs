using UnityEngine;

namespace SolidPrinciple.IterationFive
{
    public interface IterationFive_IAnimatedAttack
    {
        public bool IsAttackAnimationRunning { get; }
        public Animator AttackAnimator { get; }
        public void OnAttackAnimationEnd();
    }
}
