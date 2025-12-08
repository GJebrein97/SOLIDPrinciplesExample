using UnityEngine;

namespace SolidPrinciple.IterationFive
{
    public interface IShootable
    {
        public GameObject BulletPrefab { get; }
        public ParticleSystem ShootingEffect { get; }
        public void GunShootEffect();
        public void ShootBullet();
    }
}
