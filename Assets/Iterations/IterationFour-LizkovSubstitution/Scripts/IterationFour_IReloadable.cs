namespace SoliderPrinciple.IterationFour
{
    public interface IterationFour_IReloadable
    {
        public bool IsReloading { get; }
        public float ReloadTime { get; }
        public int AmmoCount { get; }
        public int RuntimeAmmoCount { get; }
        public void Reload();
        public void FillAmmo();
        public bool IsOutOfBullets();
    }
}
