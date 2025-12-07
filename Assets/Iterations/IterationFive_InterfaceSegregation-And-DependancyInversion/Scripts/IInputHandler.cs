using UnityEngine;

namespace SoliderPrinciple.IterationFive
{

    public interface IInputHandler
    {
        public bool IsAttacking { get; }
        public void CheckInput();
    }
}