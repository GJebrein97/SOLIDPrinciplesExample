namespace SoliderPrinciple.IterationTwo
{
    public class IterationTwo_UI : Base_UI
    {
        public IterationTwo_CharacterComponent _characterComponent;

        private void Update()
        {
            if (_characterComponent.GunComponent.IsReloading)
            {
                _ammoAmountText.text = "RELOADING";
            }
            else
            {
                _ammoAmountText.text = _characterComponent.GunComponent.RuntimeAmmoCount.ToString();
            }
        }
    }
}