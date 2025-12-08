using System.Threading.Tasks;
using UnityEngine;

namespace SolidPrinciple.IterationThree
{
    public class IterationThree_MachineGunComponent : IterationThree_BaseGunComponent
    {
        private void Start()
        {
            FillAmmo();
        }

        protected void Update()
        {
            RuntimeFirerateTimer += Time.deltaTime;
        }

        public override bool CanShoot()
        {
            return RuntimeFirerateTimer >= FireRate && !IsReloading;
        }

        public override void Shoot()
        {
            ShootBullet();

            RuntimeFirerateTimer = 0;
            RuntimeAmmoCount--;
        }

        public override void ShootBullet()
        {
            GunMuzzleEffect.Play(true);

            if (Instantiate(BulletPrefab, GunMuzzleEffect.transform).TryGetComponent<IterationThree_BaseBulletComponent>(out var bullet))
            {
                bullet.ShootBullet();
            }
        }

        public override bool IsOutOfBullets()
        {
            return RuntimeAmmoCount <= 0;
        }

        public override void FillAmmo()
        {
            RuntimeAmmoCount = AmmoCount;
        }

        public override async void Reload()
        {
            if (IsReloading) return;

            IsReloading = true;
            await Task.Delay((int)(ReloadTime * 1000));
            FillAmmo();
            IsReloading = false;
        }
    }
}