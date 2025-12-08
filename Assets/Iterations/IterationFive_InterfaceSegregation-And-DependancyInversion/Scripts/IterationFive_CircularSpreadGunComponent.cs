using System.Threading.Tasks;
using UnityEngine;

namespace SolidPrinciple.IterationFive
{
    public class IterationFive_CircularSpreadGunComponent : IterationFive_MachineGunComponent
    {
        [SerializeField] protected float bulletAmount;

        public override void ShootBullet()
        {
            float anglePerBullet = 360 / bulletAmount;
            for (int i = 0; i < bulletAmount; i++)
            {
                if (Instantiate(BulletPrefab, ShootingEffect.transform.position, Quaternion.Euler(0, anglePerBullet * i, 0), ShootingEffect.transform).TryGetComponent<IBullet>(out var bullet))
                {
                    bullet.InitializeBullet();
                }
            }
        }
    }
}