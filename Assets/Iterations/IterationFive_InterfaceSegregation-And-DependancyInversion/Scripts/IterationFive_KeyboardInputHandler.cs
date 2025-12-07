using UnityEngine;

namespace SoliderPrinciple.IterationFive
{

    public class IterationFive_KeyboardInputHandler : IInputHandler
    {
        [field: SerializeField] public bool IsAttacking { get; protected set; }

        [SerializeField] KeyCode AttackKey = KeyCode.Space;

        public void CheckInput()
        {
            IsAttacking = Input.GetKey(AttackKey);
        }
    }
}