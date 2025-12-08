using UnityEngine;

namespace SolidPrinciple.IterationThree
{

    public class IterationThree_MachineGunBulletComponent : IterationThree_BaseBulletComponent
    {
        public override void ShootBullet()
        {
            BulletRB.linearVelocity = transform.forward * 750 * Time.fixedDeltaTime;
            IsShot = true;
        }
    }
}