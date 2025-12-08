using UnityEngine;

namespace SolidPrinciple.IterationThree
{
    public abstract class IterationThree_BaseGunComponent : MonoBehaviour
    {
        public float GunDamage;
        public float ReloadTime;
        public float FireRate;
        public float RuntimeFirerateTimer;
        public int AmmoCount;
        public int RuntimeAmmoCount;
        public bool IsReloading;
        public GameObject BulletPrefab;
        public ParticleSystem GunMuzzleEffect;

        public abstract bool CanShoot();
        public abstract void Shoot();
        public abstract void ShootBullet();
        public abstract bool IsOutOfBullets();
        public abstract void FillAmmo();
        public abstract void Reload();
        
    }
}
