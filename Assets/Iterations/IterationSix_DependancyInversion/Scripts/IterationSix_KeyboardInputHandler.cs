using UnityEngine;

namespace SolidPrinciple.IterationSix
{

    public class IterationSix_KeyboardInputHandler : IterationSix_IInputHandler
    {
        [field: SerializeField] public bool IsAttacking { get; protected set; }

        [SerializeField] KeyCode AttackKey = KeyCode.Space;

        public void CheckInput()
        {
            IsAttacking = Input.GetKey(AttackKey);
        }
    }
}