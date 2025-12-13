using UnityEngine;

namespace SolidPrinciple.IterationFive
{

    public class IterationFive_SwimmingBulletComponent : IterationFive_BaseBullet, IterationFive_IMovable
    {
        [field: SerializeField] public float MovementSpeed { get; private set; }

        public override void ShootBullet()
        {
            IsShot = true;
        }

        protected void Update()
        {
            if (IsShot)
            {
                Move();
            }
        }

        public void Move()
        {
            var rotatedForward = Quaternion.Euler(0, Mathf.Sin(Time.time * 5) * 40, 0) * transform.forward;
            BulletRB.linearVelocity = rotatedForward * MovementSpeed * Time.fixedDeltaTime;
        }
    }
}
