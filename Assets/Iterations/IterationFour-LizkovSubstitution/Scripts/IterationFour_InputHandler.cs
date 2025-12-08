using UnityEngine;

namespace SolidPrinciple.IterationFour
{
    public class IterationFour_InputHandler : MonoBehaviour
    {
        public bool IsClicking;
        public KeyCode ClickingKey;

        void Update()
        {
            IsClicking = Input.GetKey(ClickingKey);
        }
    }
}