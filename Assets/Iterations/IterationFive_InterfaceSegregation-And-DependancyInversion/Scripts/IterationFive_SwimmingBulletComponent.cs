using UnityEngine;

namespace SoliderPrinciple.IterationFive
{

    public class IterationFive_SwimmingBulletComponent : MonoBehaviour, IBullet, IMovable
    {
        [field: SerializeField] public Rigidbody BulletRB { get; private set; }
        [field: SerializeField] public float MovementSpeed { get; private set; }
        [field: SerializeField] public bool IsShot { get; private set; }

        public void InitializeBullet()
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
