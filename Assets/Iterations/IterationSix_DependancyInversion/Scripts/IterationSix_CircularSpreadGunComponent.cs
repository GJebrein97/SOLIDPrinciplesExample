using UnityEngine;

namespace SolidPrinciple.IterationSix
{
    public class IterationSix_CircularSpreadGunComponent : IterationSix_MachineGunComponent
    {
        [SerializeField] protected float bulletAmount;

        public override void ShootBullet()
        {
            float anglePerBullet = 360 / bulletAmount;
            for (int i = 0; i < bulletAmount; i++)
            {
                if (Instantiate(BulletPrefab, ShootingEffect.transform.position, Quaternion.Euler(0, anglePerBullet * i, 0), ShootingEffect.transform).TryGetComponent<IterationSix_IBullet>(out var bullet))
                {
                    bullet.InitializeBullet();
                }
            }
        }
    }
}