using UnityEngine;

namespace SoliderPrinciple.IterationFour
{
    public class IterationFour_CharacterComponent : MonoBehaviour
    {
        public IterationFour_InputHandler InputHandler;
        public GameObject WeaponPrefab;
        public IterationFour_IWeapon PlayerWeapon;

        private void Start()
        {
            UpdateWeaponReference();
        }

        private void Update()
        {
            if (InputHandler.IsClicking)
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
