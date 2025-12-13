using UnityEngine;

namespace SolidPrinciple.IterationSix
{
    public interface IterationSix_IShootable
    {
        public GameObject BulletPrefab { get; }
        public ParticleSystem ShootingEffect { get; }
        public void GunShootEffect();
        public void ShootBullet();
    }
}
