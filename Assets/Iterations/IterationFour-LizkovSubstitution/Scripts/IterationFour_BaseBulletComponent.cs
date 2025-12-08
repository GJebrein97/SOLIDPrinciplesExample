using UnityEngine;

namespace SolidPrinciple.IterationFour
{
    public abstract class IterationFour_BaseBulletComponent : MonoBehaviour
    {
        public Rigidbody BulletRB;
        public bool IsShot;
        public abstract void ShootBullet();
    }

}