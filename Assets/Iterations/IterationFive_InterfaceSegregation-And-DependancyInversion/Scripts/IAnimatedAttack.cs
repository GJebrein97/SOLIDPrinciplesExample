using UnityEngine;

namespace SoliderPrinciple.IterationFive
{
    public interface IAnimatedAttack
    {
        public bool IsAttackAnimationRunning { get; }
        public Animator AttackAnimator { get; }
        public void OnAttackAnimationEnd();
    }
}
