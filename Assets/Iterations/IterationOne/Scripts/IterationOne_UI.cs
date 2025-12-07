using UnityEngine;

namespace SoliderPrinciple.IterationOne
{
    public class IterationOne_UI : Base_UI
    {
        public IterationOne_GunComponent GunComponent;

        void Update()
        {
            if (GunComponent.IsReloading)
            {
                _ammoAmountText.text = "RELOADING";
            }
            else
            {
                _ammoAmountText.text = GunComponent.RuntimeAmmoCount.ToString();
            }
        }
    }
}