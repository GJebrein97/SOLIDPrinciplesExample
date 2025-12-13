using UnityEngine;

namespace SolidPrinciple.IterationFour
{
    public class IterationFour_SwordComponet : IterationFour_BaseWeapon
    {
        [SerializeField] protected Animator AttackAnimator;
        [SerializeField] protected bool _isWeaponAttacking;
        public override void Attack()
        {
            _isWeaponAttacking = true;
            AttackAnimator.SetBool("IsAttackAnimationRunning", _isWeaponAttacking);
        }

        public override bool CanAttack()
        {
            return !_isWeaponAttacking;
        }

        public void OnAttackAnimationEnd()
        {
            _isWeaponAttacking = false;
            AttackAnimator.SetBool("IsAttackAnimationRunning", _isWeaponAttacking);
        }

    }
}