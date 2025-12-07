using UnityEngine;

namespace SoliderPrinciple.IterationTwo
{
    public class IterationTwo_InputHandler : MonoBehaviour
    {
        public bool IsClicking;
        public KeyCode ClickingKey;
        
        private void Update()
        {
            IsClicking = Input.GetKey(ClickingKey);
        }
    }
}