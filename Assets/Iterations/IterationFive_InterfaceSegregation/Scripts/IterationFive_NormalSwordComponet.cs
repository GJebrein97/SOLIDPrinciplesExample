using UnityEngine;

namespace SolidPrinciple.IterationFive
{
    public class IterationFive_NormalSwordComponet : IterationFive_BaseWeapon, IterationFive_IAnimatedAttack
    {
        [field: SerializeField] public bool IsAttackAnimationRunning { get; protected set; }
        [field: SerializeField] public Animator AttackAnimator { get; protected set; }

        public override void Attack()
        {
            IsAttackAnimationRunning = true;
            AttackAnimator.SetBool(nameof(IsAttackAnimationRunning), IsAttackAnimationRunning);
        }

        public override bool CanAttack()
        {
            return !IsAttackAnimationRunning;
        }
        public void OnAttackAnimationEnd()
        {
            IsAttackAnimationRunning = false;
            AttackAnimator.SetBool(nameof(IsAttackAnimationRunning), IsAttackAnimationRunning);
        }
    }
}