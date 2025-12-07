using System.Threading.Tasks;
using UnityEngine;

namespace SoliderPrinciple.IterationTwo
{
    public class IterationTwo_GunComponent : MonoBehaviour
    {
        public float BulletDamage = 20;
        public float FireRate = 0.1f;
        public float RuntimeFirerateTimer;
        public float ReloadTime;
        public int AmmoCount;
        public bool IsReloading;
        public int RuntimeAmmoCount;
        public GameObject BulletPrefab;
        public ParticleSystem BulletEffect;

        private void Start()
        {
            FillAmmo();
        }

        private void Update()
        {
            RuntimeFirerateTimer += Time.deltaTime;
        }

        public bool CanShoot()
        {
            return RuntimeFirerateTimer >= FireRate && !IsReloading;
        }

        public void Shoot()
        {
            RuntimeFirerateTimer = 0;
            
            BulletEffect.Play(true);
            
            ShootBullet();

            RuntimeAmmoCount--;
        }

        public void ShootBullet()
        {
            if (Instantiate(BulletPrefab, BulletEffect.transform).TryGetComponent<IterationTwo_BulletComponent>(out var bullet))
            {
                bullet.ShootBullet();
            }
        }

        public bool IsOutOfBullets()
        {
            return RuntimeAmmoCount <= 0;
        }

        public void FillAmmo()
        {
            RuntimeAmmoCount = AmmoCount;
        }

        public async void Reload()
        {
            if (IsReloading) return;

            IsReloading = true;
            await Task.Delay((int)(ReloadTime * 1000));
            FillAmmo();
            IsReloading = false;
        }

    }
}