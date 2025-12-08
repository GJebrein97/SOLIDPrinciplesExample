using UnityEngine;

namespace SolidPrinciple.IterationThree
{
    public class IterationThree_SwimmingBulletComponent : IterationThree_BaseBulletComponent
    {
        protected void Update()
        {
            if (IsShot)
            {
                var rotatedForward = Quaternion.Euler(0, Mathf.Sin(Time.time * 5) * 40, 0) * transform.forward;
                BulletRB.linearVelocity = rotatedForward * 100 * Time.fixedDeltaTime;
            }
        }

        public override void ShootBullet()
        {
            IsShot = true;
        }
    }
}
