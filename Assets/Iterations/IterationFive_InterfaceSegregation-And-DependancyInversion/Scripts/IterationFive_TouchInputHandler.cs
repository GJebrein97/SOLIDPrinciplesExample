using UnityEngine;

namespace SoliderPrinciple.IterationFive
{
    public class IterationFive_TouchInputHandler : IInputHandler
    {
        [field: SerializeField] public bool IsAttacking { get; protected set; }

        public void CheckInput()
        {
            IsAttacking = Input.touchCount > 0;
        }
    }
}