using UnityEngine;

namespace SolidPrinciple.IterationFour
{
    public abstract class IterationFour_BaseBulletComponent : MonoBehaviour
    {
        [SerializeField] protected Rigidbody BulletRB;
        [SerializeField] protected bool IsShot;
        public abstract void ShootBullet();
    }

}