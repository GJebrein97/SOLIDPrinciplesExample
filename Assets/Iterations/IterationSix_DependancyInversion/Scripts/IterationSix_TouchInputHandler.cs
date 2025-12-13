using UnityEngine;

namespace SolidPrinciple.IterationSix
{
    public class IterationSix_TouchInputHandler : IterationSix_IInputHandler
    {
        [field: SerializeField] public bool IsAttacking { get; protected set; }

        public void CheckInput()
        {
            IsAttacking = Input.touchCount > 0;
        }
    }
}