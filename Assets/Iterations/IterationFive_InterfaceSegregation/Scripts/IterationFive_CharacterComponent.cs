using UnityEngine;

namespace SolidPrinciple.IterationFive
{
    public class IterationFive_CharacterComponent : MonoBehaviour
    {
        [SerializeField] private IterationFive_BaseWeapon _playerWeapon;
        [SerializeField] private IterationFive_InputHandler _inputHandler;


        private void Update()
        {
            if (_inputHandler.IsAttacking)
            {
                if (_playerWeapon.CanAttack())
                    _playerWeapon.Attack();
            }
        }

        public IterationFive_BaseWeapon GetCurrentWeapon()
        {
            return _playerWeapon;
        }
    }
}
