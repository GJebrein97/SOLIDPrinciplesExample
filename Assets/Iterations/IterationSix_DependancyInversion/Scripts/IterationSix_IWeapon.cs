namespace SolidPrinciple.IterationSix
{
    public interface IterationSix_IWeapon
    {
        public float WeaponDamage { get; }
        public void Attack();
        public bool CanAttack();
    }
}
