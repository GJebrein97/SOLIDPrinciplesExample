namespace SoliderPrinciple.IterationThree
{
    public class IterationThree_UI : Base_UI
    {
        public IterationThree_CharacterComponent CharacterComponent;

        protected void Update()
        {
            if (CharacterComponent.PlayerGun.IsReloading)
            {
                _ammoAmountText.text = "RELOADING";
            }
            else
            {
                _ammoAmountText.text = CharacterComponent.PlayerGun.RuntimeAmmoCount.ToString();
            }
        }
    }
}