using UnityEngine;

namespace SolidPrinciple.IterationThree
{
    public class IterationThree_InputHandler : MonoBehaviour
    {
        public bool IsClicking;
        public KeyCode ClickingKey;

        void Update()
        {
            IsClicking = Input.GetKey(ClickingKey);
        }
    }
}