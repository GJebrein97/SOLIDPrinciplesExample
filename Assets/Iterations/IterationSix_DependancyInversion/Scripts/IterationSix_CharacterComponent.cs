using UnityEngine;

namespace SolidPrinciple.IterationSix
{
    public class IterationSix_CharacterComponent : MonoBehaviour
    {
        public GameObject WeaponPrefab;
        public IterationSix_IWeapon PlayerWeapon;
        private IterationSix_IInputHandler _inputHandler;

        private void Start()
        {
            UpdateWeaponReference();

#if UNITY_ANDROID || UNITY_IOS
            _inputHandler = new IterationFive_TouchInputHandler();
#else
            _inputHandler = new IterationSix_KeyboardInputHandler();
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
