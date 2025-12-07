using UnityEngine;

namespace SoliderPrinciple.IterationFive
{

    public class IterationFive_MachineGunBulletComponent : MonoBehaviour, IBullet
    {
        [field: SerializeField] public Rigidbody BulletRB { get; set; }
        [field: SerializeField] public bool IsShot { get; private set; }

        public void InitializeBullet()
        {
            BulletRB.linearVelocity = transform.forward * 750 * Time.fixedDeltaTime;
            IsShot = true;
        }

    }
}