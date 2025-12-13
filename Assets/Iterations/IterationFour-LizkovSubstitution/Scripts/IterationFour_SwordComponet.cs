using UnityEditor;
using UnityEngine;

namespace SolidPrinciple.IterationFour
{
    public class IterationFour_SwordComponet : IterationFour_BaseWeapon
    {
        [SerializeField] protected Animator AttackAnimator;
        [SerializeField] protected bool _isWeaponAttacking;
        public override void Attack()
        {
            AttackAnimator.SetBool("IsAttackAnimationRunning", true);
            _isWeaponAttacking = true;
        }

        public override bool CanAttack()
        {
            return !_isWeaponAttacking;
        }

        public void OnAttackAnimationEnd()
        {
            _isWeaponAttacking = false;
            AttackAnimator.SetBool("IsAttackAnimationRunning", false);
        }

    }
}