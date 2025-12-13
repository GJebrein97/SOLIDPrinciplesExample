using System.Threading.Tasks;
using UnityEngine;

namespace SolidPrinciple.IterationFour
{

    public class IterationFour_MachineGunComponent : IterationFour_BaseWeapon, IterationFour_IReloadable
    {
        [field: SerializeField] public bool IsReloading { get; protected set; }
        [field: SerializeField] public float ReloadTime { get; protected set; }
        [field: SerializeField] public int AmmoCount { get; protected set; }
        [field: SerializeField] public int RuntimeAmmoCount { get; protected set; }


        protected void Start()
        {
            FillAmmo();
        }

        protected void Update()
        {
            RuntimeAttackSpeed += Time.deltaTime;
        }

        public override bool CanAttack()
        {
            if (IsOutOfBullets()) Reload();

            return RuntimeAttackSpeed >= AttackSpeed && !IsReloading;
        }

        public override void Attack()
        {
            GunShootEffect();
            ShootBullet();

            RuntimeAttackSpeed = 0;
            RuntimeAmmoCount--;
        }

        protected override void GunShootEffect()
        {
            if (ShootingEffect)
            {
                ShootingEffect.Play(true);
            }
        }

        protected override void ShootBullet()
        {
            if (BulletPrefab)
            {
                if (Instantiate(BulletPrefab, ShootingEffect.transform).TryGetComponent<IterationFour_BaseBulletComponent>(out var bullet))
                {
                    bullet.ShootBullet();
                }
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