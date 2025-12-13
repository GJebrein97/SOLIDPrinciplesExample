using UnityEngine;

namespace SolidPrinciple.IterationSix
{
    public class IterationSix_SwordWaveShooterComponet : MonoBehaviour, IterationSix_IWeapon, IterationSix_IAnimatedAttack, IterationSix_IShootable
    {
        [field: SerializeField] public float WeaponDamage { get; protected set; }
        [field: SerializeField] public GameObject BulletPrefab { get; protected set; }
        [field: SerializeField] public ParticleSystem ShootingEffect { get; protected set; }
        [field: SerializeField] public bool IsAttackAnimationRunning { get; protected set; }
        [field: SerializeField] public Animator AttackAnimator { get; protected set; }

        public void GunShootEffect()
        {
            ShootingEffect.Play(true);
        }

        public virtual void ShootBullet()
        {
            GunShootEffect();
            if (Instantiate(BulletPrefab, ShootingEffect.transform.position, Quaternion.Euler(transform.forward)).TryGetComponent<IterationSix_IBullet>(out var bullet))
            {
                bullet.InitializeBullet();
            }
        }

        public void Attack()
        {
            IsAttackAnimationRunning = true;
            AttackAnimator.SetBool(nameof(IsAttackAnimationRunning), IsAttackAnimationRunning);
        }

        public bool CanAttack()
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