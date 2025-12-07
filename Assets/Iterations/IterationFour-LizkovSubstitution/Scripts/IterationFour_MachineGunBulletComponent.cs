using UnityEngine;

namespace SoliderPrinciple.IterationFour
{
    public class IterationFour_MachineGunBulletComponent : IterationFour_BaseBulletComponent
    {
        public override void ShootBullet()
        {
            BulletRB.linearVelocity = transform.forward * 750 * Time.fixedDeltaTime;
            IsShot = true;
        }
    }
}