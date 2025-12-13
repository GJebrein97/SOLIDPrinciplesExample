using UnityEngine;

namespace SolidPrinciple.IterationThree
{
    public class IterationThree_SwordComponet : IterationThree_MachineGunComponent
    {
        [SerializeField] protected bool IsAttackAnimationRunning;
        [SerializeField] public Animator AttackAnimator;


        public override bool CanShoot()
        {
            return !IsAttackAnimationRunning;
        }
        public override void Shoot()
        {
            IsAttackAnimationRunning = true;
            AttackAnimator.SetBool(nameof(IsAttackAnimationRunning), IsAttackAnimationRunning);
        }


        public void OnAttackAnimationEnd()
        {
            IsAttackAnimationRunning = false;
            AttackAnimator.SetBool(nameof(IsAttackAnimationRunning), IsAttackAnimationRunning);
        }
    }
}