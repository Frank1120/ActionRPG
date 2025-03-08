using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class ColdDamage : Weapon.WeaponAttackEffect
{

        public int coldDamage = 10;
        private int healthToAdd = 0;
    public override void OnAttack(CharacterData target, CharacterData user, ref Weapon.AttackData attackData)
    {
        attackData.AddDamage(StatSystem.DamageType.Cold, coldDamage);
    }
    
    public override void OnPostAttack(CharacterData target, CharacterData user, Weapon.AttackData data)
    {
        
        healthToAdd = coldDamage / 4; 
        user.Stats.ChangeHealth(user.Stats.CurrentHealth + healthToAdd);
    }
}
