using UnityEngine;

namespace SoliderPrinciple.IterationTwo
{
    public class IterationTwo_BulletComponent : MonoBehaviour
    {
        public Rigidbody BulletRB;

        public void ShootBullet()
        {
            BulletRB.linearVelocity = transform.forward * 750 * Time.fixedDeltaTime;
        }
    }
}