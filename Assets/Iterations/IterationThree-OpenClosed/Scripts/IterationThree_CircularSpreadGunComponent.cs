using UnityEngine;

namespace SoliderPrinciple.IterationThree
{
    public class IterationThree_CircularSpreadGunComponent : IterationThree_MachineGunComponent
    {
        public float bulletAmount;

        public override void ShootBullet()
        {
            float anglePerBullet = 360 / bulletAmount;
            for (int i = 0; i < bulletAmount; i++)
            {
                if (Instantiate(BulletPrefab, GunMuzzleEffect.transform.position, Quaternion.Euler(0, anglePerBullet * i, 0), GunMuzzleEffect.transform).TryGetComponent<IterationThree_BaseBulletComponent>(out var bullet))
                {
                    bullet.ShootBullet();
                }
            }
        }

    }
}