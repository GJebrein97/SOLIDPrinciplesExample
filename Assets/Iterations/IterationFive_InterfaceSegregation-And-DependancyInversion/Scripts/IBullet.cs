using UnityEngine;

namespace SoliderPrinciple.IterationFive
{ 
    public interface IBullet
    {
        public Rigidbody BulletRB { get; }
        public bool IsShot { get; }
        public void InitializeBullet();
    }
}
