using UnityEngine;

namespace SolidPrinciple.IterationSix
{ 
    public interface IterationSix_IBullet
    {
        public Rigidbody BulletRB { get; }
        public bool IsShot { get; }
        public void InitializeBullet();
    }
}
