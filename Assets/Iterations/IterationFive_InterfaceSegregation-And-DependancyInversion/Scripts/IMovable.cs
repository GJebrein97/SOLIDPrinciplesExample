using UnityEngine;

namespace SolidPrinciple.IterationFive
{
    public interface IMovable
    {
        public float MovementSpeed { get; }
        public void Move();
    }
}
