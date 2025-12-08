using UnityEngine;

namespace SolidPrinciple.IterationThree
{
    public class IterationThree_SwordComponet : IterationThree_MachineGunComponent
    {
        [field: SerializeField] public bool IsAttackAnimationRunning { get; protected set; }
        [field: SerializeField] public Animator AttackAnimator { get; protected set; }


        public override bool CanShoot()
        {
            return !IsAttackAnimationRunning;
        }

        public override void ShootBullet()
        {
            GunMuzzleEffect.Play(true);
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