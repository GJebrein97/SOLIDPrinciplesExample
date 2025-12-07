using System.Threading.Tasks;
using UnityEngine;

namespace SoliderPrinciple.IterationTwo
{
    public class IterationTwo_CharacterComponent : MonoBehaviour
    {
        public IterationTwo_InputHandler InputHandler;
        public IterationTwo_GunComponent GunComponent;

        private void Update()
        {
            if (InputHandler.IsClicking)
            {
                if (GunComponent.IsOutOfBullets())
                {
                    GunComponent.Reload();
                }
                else
                {
                    if (GunComponent.CanShoot())
                        GunComponent.Shoot();
                }
            }
        }
    }
}
