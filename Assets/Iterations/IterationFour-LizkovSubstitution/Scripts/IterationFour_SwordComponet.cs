using UnityEngine;

namespace SoliderPrinciple.IterationFour
{
    public class IterationFour_SwordComponet : MonoBehaviour, IterationFour_IWeapon
    {
        [field: SerializeField] public float WeaponDamage { get; protected set; }
        [field: SerializeField] public float AttackSpeed { get; protected set; }
        public float RuntimeAttackSpeed { get; protected set; }
        [field: SerializeField] public GameObject BulletPrefab { get; protected set; }
        [field: SerializeField] public ParticleSystem ShootingEffect { get; protected set; }
        public Animator AttackAnimator;

        public void Attack()
        {
            RuntimeAttackSpeed = 0;
            AttackAnimator.SetBool("IsAttackAnimationRunning", true);
        }

        public bool CanAttack()
        {
            return RuntimeAttackSpeed >= AttackSpeed;
        }

        public void OnAttackAnimationEnd()
        {
            RuntimeAttackSpeed = AttackSpeed;
            AttackAnimator.SetBool("IsAttackAnimationRunning", false);
        }

        public void GunShootEffect()
        {
            ShootingEffect.Play(true);
        }

        public virtual void ShootBullet()
        {
            GunShootEffect();
            if (Instantiate(BulletPrefab, ShootingEffect.transform).TryGetComponent<IterationFour_BaseBulletComponent>(out var bullet))
            {
                bullet.ShootBullet();
            }
        }

    }
}