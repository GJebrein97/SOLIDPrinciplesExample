using UnityEngine;

namespace SoliderPrinciple.IterationFive
{ 
    public interface IWeapon
    {
        public float GunDamage { get; }
        public void Attack();
        public bool CanAttack();
    }
}
