using UnityEngine;

namespace SolidPrinciple.IterationFour
{ 
    public abstract class IterationFour_BaseWeapon : MonoBehaviour
    {
        [SerializeField] protected float WeaponDamage;
        [SerializeField] protected float AttackSpeed;
        [SerializeField] protected float RuntimeAttackSpeed;
        [SerializeField] protected GameObject BulletPrefab;
        [SerializeField] protected ParticleSystem ShootingEffect;
        protected abstract void GunShootEffect();
        protected abstract void ShootBullet();
        public abstract void Attack();
        public abstract bool CanAttack();
    }
}
