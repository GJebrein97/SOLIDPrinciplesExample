namespace SolidPrinciple.IterationSix
{
    public class IterationSix_UI : Base_UI
    {
        public IterationSix_CharacterComponent _characterComponent;

        protected void Update()
        {
            var characterWeapon = _characterComponent.PlayerWeapon;

            if (characterWeapon != null)
            {
                if (characterWeapon is IterationSix_IReloadable)
                {
                    var reloadableComponent = (IterationSix_IReloadable)characterWeapon;
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