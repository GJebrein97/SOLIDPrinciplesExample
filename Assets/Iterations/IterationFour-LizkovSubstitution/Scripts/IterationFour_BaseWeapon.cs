using UnityEngine;

namespace SolidPrinciple.IterationFour
{ 
    public abstract class IterationFour_BaseWeapon : MonoBehaviour
    {
        [SerializeField] protected float WeaponDamage;
       
        public abstract void Attack();
        public abstract bool CanAttack();
    }
}
