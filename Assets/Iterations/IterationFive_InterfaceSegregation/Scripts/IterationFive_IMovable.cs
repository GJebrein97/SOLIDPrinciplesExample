using UnityEngine;

namespace SolidPrinciple.IterationFive
{
    public interface IterationFive_IMovable
    {
        public float MovementSpeed { get; }
        public void Move();
    }
}
