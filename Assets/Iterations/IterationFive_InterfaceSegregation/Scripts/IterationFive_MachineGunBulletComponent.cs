using UnityEngine;

namespace SolidPrinciple.IterationFive
{

    public class IterationFive_MachineGunBulletComponent : IterationFive_BaseBullet
    {
        public override void ShootBullet()
        {
            BulletRB.linearVelocity = transform.forward * 750 * Time.fixedDeltaTime;
            IsShot = true;
        }

    }
}