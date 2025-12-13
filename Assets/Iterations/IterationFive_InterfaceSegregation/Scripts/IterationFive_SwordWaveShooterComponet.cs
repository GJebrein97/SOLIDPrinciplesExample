using System.Threading.Tasks;
using UnityEngine;

namespace SolidPrinciple.IterationFive
{
    public class IterationFive_SwordWaveShooterComponet : IterationFive_BaseWeapon, IterationFive_IAnimatedAttack, IterationFive_IShootable
    {
        [field: SerializeField] public GameObject BulletPrefab { get; protected set; }
        [field: SerializeField] public ParticleSystem ShootingEffect { get; protected set; }
        [field: SerializeField] public bool IsAttackAnimationRunning { get; protected set; }
        [field: SerializeField] public Animator AttackAnimator { get; protected set; }

        public void GunShootEffect()
        {
            ShootingEffect.Play(true);
        }

        public void ShootBullet()
        {
            GunShootEffect();
            if (Instantiate(BulletPrefab, ShootingEffect.transform.position, Quaternion.Euler(transform.forward)).TryGetComponent<IterationFive_BaseBullet>(out var bullet))
            {
                bullet.ShootBullet();
            }
        }

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