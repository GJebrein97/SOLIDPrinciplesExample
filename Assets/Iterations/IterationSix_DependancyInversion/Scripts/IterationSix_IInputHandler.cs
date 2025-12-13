using UnityEngine;

namespace SolidPrinciple.IterationSix
{

    public interface IterationSix_IInputHandler
    {
        public bool IsAttacking { get; }
        public void CheckInput();
    }
}