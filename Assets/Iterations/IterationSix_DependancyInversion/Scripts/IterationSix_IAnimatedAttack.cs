using UnityEngine;

namespace SolidPrinciple.IterationSix
{
    public interface IterationSix_IAnimatedAttack
    {
        public bool IsAttackAnimationRunning { get; }
        public Animator AttackAnimator { get; }
        public void OnAttackAnimationEnd();
    }
}
