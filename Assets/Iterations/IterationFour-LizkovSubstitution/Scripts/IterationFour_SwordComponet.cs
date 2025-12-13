using UnityEditor;
using UnityEngine;

namespace SolidPrinciple.IterationFour
{
    public class IterationFour_SwordComponet : IterationFour_BaseWeapon
    {
        [SerializeField] protected Animator AttackAnimator;

        public override void Attack()
        {
            RuntimeAttackSpeed = 1;
            AttackAnimator.SetBool("IsAttackAnimationRunning", true);
        }

        public override bool CanAttack()
        {
            return RuntimeAttackSpeed <= 0;
        }

        public void OnAttackAnimationEnd()
        {
            RuntimeAttackSpeed = 0;
            AttackAnimator.SetBool("IsAttackAnimationRunning", false);
        }

        protected override void GunShootEffect()
        {
            ShootingEffect.Play(true);
        }

        protected override void ShootBullet()
        {
            GunShootEffect();
            if (Instantiate(BulletPrefab, ShootingEffect.transform.position, Quaternion.Euler(transform.forward)).TryGetComponent<IterationFour_BaseBulletComponent>(out var bullet))
            {
                bullet.ShootBullet();
            }
        }

    }
}