using System.Collections.Generic;
using UnityEngine;

namespace SolidPrinciple.IterationFive
{
    public class IterationFive_CharacterComponent : MonoBehaviour
    {
        public GameObject WeaponPrefab;
        public IWeapon PlayerWeapon;
        private IInputHandler _inputHandler;

        private void Start()
        {
            UpdateWeaponReference();

#if UNITY_ANDROID || UNITY_IOS
            _inputHandler = new IterationFive_TouchInputHandler();
#else
            _inputHandler = new IterationFive_KeyboardInputHandler();
#endif
        }

        private void Update()
        {
            _inputHandler.CheckInput();

            if (_inputHandler.IsAttacking)
            {
                if (PlayerWeapon.CanAttack())
                    PlayerWeapon.Attack();
            }
        }

        [ContextMenu("UpdateWeaponRef")]
        public void UpdateWeaponReference()
        {
            WeaponPrefab.TryGetComponent(out PlayerWeapon);
        }
    }
}
