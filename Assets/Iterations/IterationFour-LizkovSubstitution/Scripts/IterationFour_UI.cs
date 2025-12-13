using SolidPrinciple.IterationFour;

namespace SolidPrinciple.IterationFour_UI
{
    public class IterationFour_UI : Base_UI
    {
        public IterationFour_CharacterComponent _characterComponent;

        protected void Update()
        {
            var characterWeapon = _characterComponent.PlayerWeapon;

            if (characterWeapon != null)
            {
                if (characterWeapon is IterationFour_IGun)
                {
                    var reloadableComponent = (IterationFour_IGun)characterWeapon;
                    if (reloadableComponent.IsReloading)
                    {
                        _ammoAmountText.text = "RELOADING";
                    }
                    else
                    {
                        _ammoAmountText.text = reloadableComponent.RuntimeAmmoCount.ToString();
                    }
                }
            }
        }
    }
}