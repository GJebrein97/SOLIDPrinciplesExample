using UnityEngine;

namespace SolidPrinciple.IterationFour
{
    public interface IterationFour_IGun
    {
        public bool IsReloading { get; }
        public float ReloadTime { get; }
        public int AmmoCount { get; }
        public int RuntimeAmmoCount { get; }
        public float AttackSpeed { get; }
        public float RuntimeAttackSpeed { get; }
        public GameObject BulletPrefab { get; }
        public ParticleSystem ShootingEffect { get; }
        public void GunShootEffect();
        public void ShootBullet();
        public void Reload();
        public void FillAmmo();
        public bool IsOutOfBullets();
    }
}
