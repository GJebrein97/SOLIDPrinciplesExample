using UnityEngine;

namespace SolidPrinciple.IterationFour
{
    public class IterationFour_CharacterComponent : MonoBehaviour
    {
        public IterationFour_InputHandler InputHandler;
        public IterationFour_BaseWeapon PlayerWeapon;

        private void Update()
        {
            if (InputHandler.IsClicking)
            {
                if (PlayerWeapon.CanAttack())
                    PlayerWeapon.Attack();
            }
        }
    }
}
