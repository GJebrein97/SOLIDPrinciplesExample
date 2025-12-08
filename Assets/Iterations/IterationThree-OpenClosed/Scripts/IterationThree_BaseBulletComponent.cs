using UnityEngine;

namespace SolidPrinciple.IterationThree
{
    public abstract class IterationThree_BaseBulletComponent : MonoBehaviour
    {
        public Rigidbody BulletRB;
        public bool IsShot;
        public abstract void ShootBullet();
    }

}