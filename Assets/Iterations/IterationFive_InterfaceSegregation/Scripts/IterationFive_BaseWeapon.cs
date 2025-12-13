using UnityEngine;

namespace SolidPrinciple.IterationFive
{
    public abstract class IterationFive_BaseWeapon : MonoBehaviour
    {
        protected float _weaponDamage;
        public abstract void Attack();
        public abstract bool CanAttack();
    }
}
