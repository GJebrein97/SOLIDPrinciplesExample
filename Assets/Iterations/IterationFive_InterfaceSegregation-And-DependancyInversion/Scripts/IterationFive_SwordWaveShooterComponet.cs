using System.Threading.Tasks;
using UnityEngine;

namespace SoliderPrinciple.IterationFive
{
    public class IterationFive_SwordWaveShooterComponet : MonoBehaviour, IWeapon, IAnimatedAttack, IShootable
    {
        [field: SerializeField] public float GunDamage { get; protected set; }
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
            if (Instantiate(BulletPrefab, ShootingEffect.transform.position, Quaternion.Euler(transform.forward)).TryGetComponent<IBullet>(out var bullet))
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