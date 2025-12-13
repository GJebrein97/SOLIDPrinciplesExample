using UnityEngine;

namespace SolidPrinciple.IterationSix
{

    public class IterationSix_MachineGunBulletComponent : MonoBehaviour, IterationSix_IBullet
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