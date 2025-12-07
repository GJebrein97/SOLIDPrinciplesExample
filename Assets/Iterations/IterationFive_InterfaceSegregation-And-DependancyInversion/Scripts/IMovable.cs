using UnityEngine;

namespace SoliderPrinciple.IterationFive
{
    public interface IMovable
    {
        public float MovementSpeed { get; }
        public void Move();
    }
}
