using UnityEngine;

namespace SoliderPrinciple.IterationFour
{ 
    public interface IterationFour_IWeapon
    {
        public float WeaponDamage { get; }
        public float AttackSpeed { get; }
        public float RuntimeAttackSpeed { get; }
        public GameObject BulletPrefab { get; }
        public ParticleSystem ShootingEffect { get; }
        public void GunShootEffect();
        public void ShootBullet();
        public void Attack();
        public bool CanAttack();
    }
}
