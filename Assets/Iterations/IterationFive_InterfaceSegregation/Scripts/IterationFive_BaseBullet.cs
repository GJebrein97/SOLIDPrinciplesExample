using UnityEngine;

namespace SolidPrinciple.IterationFive
{ 
    public abstract class IterationFive_BaseBullet : MonoBehaviour
    {
        [SerializeField] protected Rigidbody BulletRB;
        [SerializeField] protected bool IsShot;
        public abstract void ShootBullet();
    }
}
