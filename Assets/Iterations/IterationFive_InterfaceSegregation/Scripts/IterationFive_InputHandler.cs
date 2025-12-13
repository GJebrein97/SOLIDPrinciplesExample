using UnityEngine;

namespace SolidPrinciple.IterationFive
{
    public class IterationFive_InputHandler : MonoBehaviour
    {
        public bool IsAttacking;
        [SerializeField] protected KeyCode _attackingKey;

        void Update()
        {
            IsAttacking = Input.GetKey(_attackingKey);
        }
    }
}