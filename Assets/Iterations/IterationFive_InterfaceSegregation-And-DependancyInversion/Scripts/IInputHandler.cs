using UnityEngine;

namespace SolidPrinciple.IterationFive
{

    public interface IInputHandler
    {
        public bool IsAttacking { get; }
        public void CheckInput();
    }
}