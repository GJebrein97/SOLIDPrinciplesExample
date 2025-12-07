using System.Threading.Tasks;
using UnityEngine;

namespace SoliderPrinciple.IterationOne
{
    public class IterationOne_GunComponent : MonoBehaviour
    {
        public float GunDamage = 20;
        public float ReloadTime = 2;
        public float FireRate = 0.1f;
        public float RuntimeFirerateTimer;
        public int AmmoCount = 40;
        public int RuntimeAmmoCount;
        public KeyCode ClickingKey = KeyCode.Space;
        public GameObject BulletPrefab;
        public ParticleSystem ShootingEffect;
        public bool IsReloading;

        private void Start()
        {
            RuntimeAmmoCount = AmmoCount;
        }

        private void Update()
        {
            RuntimeFirerateTimer += Time.deltaTime;

            if (Input.GetKey(ClickingKey))
            {
                if (RuntimeAmmoCount <= 0)
                {
                    Reload();
                }
                else
                {
                    Shoot();
                }
            }
        }

        private void Shoot()
        {
            if (RuntimeFirerateTimer < FireRate || IsReloading)
                return;

            RuntimeFirerateTimer = 0;
            RuntimeAmmoCount--;

            ShootingEffect.Play(true);

            SpawnBullet();
        }

        private async void Reload()
        {
            if (IsReloading) return;

            IsReloading = true;
            await Task.Delay((int)(ReloadTime * 1000));
            RuntimeAmmoCount = AmmoCount;
            IsReloading = false;
        }

        private void SpawnBullet()
        {
            var newBullet = Instantiate(BulletPrefab, ShootingEffect.transform);

            if (newBullet.TryGetComponent<Rigidbody>(out var bulletRB))
            {
                bulletRB.linearVelocity = newBullet.transform.forward * 1000 * Time.fixedDeltaTime;
            }

        }
    }
}
