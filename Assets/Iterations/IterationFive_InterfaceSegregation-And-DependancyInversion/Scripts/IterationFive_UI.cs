namespace SolidPrinciple.IterationFive
{
    public class IterationFive_UI : Base_UI
    {
        public IterationFive_CharacterComponent _characterComponent;

        protected void Update()
        {
            var characterWeapon = _characterComponent.PlayerWeapon;

            if (characterWeapon != null)
            {
                if (characterWeapon is IReloadable)
                {
                    var reloadableComponent = (IReloadable)characterWeapon;
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