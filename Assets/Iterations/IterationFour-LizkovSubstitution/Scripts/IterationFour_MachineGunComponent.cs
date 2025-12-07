using System.Threading.Tasks;
using UnityEngine;

namespace SoliderPrinciple.IterationFour
{

    public class IterationFour_MachineGunComponent : MonoBehaviour, IterationFour_IWeapon, IterationFour_IReloadable
    {
        [field: SerializeField] public float WeaponDamage { get; protected set; }
        [field: SerializeField] public float AttackSpeed { get; protected set; }
        public float RuntimeAttackSpeed { get; protected set; }
        [field: SerializeField] public GameObject BulletPrefab { get; protected set; }
        [field: SerializeField] public ParticleSystem ShootingEffect { get; protected set; }
        [field: SerializeField] public bool IsReloading { get; protected set; }
        [field: SerializeField] public float ReloadTime { get; protected set; }
        [field: SerializeField] public int AmmoCount { get; protected set; }
        public int RuntimeAmmoCount { get; protected set; }


        protected void Start()
        {
            FillAmmo();
        }

        protected void Update()
        {
            RuntimeAttackSpeed += Time.deltaTime;
        }

        public bool CanAttack()
        {
            if (IsOutOfBullets()) Reload();

            return RuntimeAttackSpeed >= AttackSpeed && !IsReloading;
        }

        public void Attack()
        {
            GunShootEffect();
            ShootBullet();

            RuntimeAttackSpeed = 0;
            RuntimeAmmoCount--;
        }

        public void GunShootEffect()
        {
            if (ShootingEffect)
            {
                ShootingEffect.Play(true);
            }
        }

        public virtual void ShootBullet()
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