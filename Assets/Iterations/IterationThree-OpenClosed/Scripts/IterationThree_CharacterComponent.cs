using UnityEngine;

namespace SolidPrinciple.IterationThree
{
    public class IterationThree_CharacterComponent : MonoBehaviour
    {
        public IterationThree_InputHandler InputHandler;
        public IterationThree_BaseGunComponent PlayerGun;

        private void Update()
        {
            if (InputHandler.IsClicking)
            {
                if (PlayerGun.IsOutOfBullets())
                {
                    PlayerGun.Reload();
                }
                else
                {
                    if (PlayerGun.CanShoot())
                        PlayerGun.Shoot();
                }
            }
        }
    }
}
