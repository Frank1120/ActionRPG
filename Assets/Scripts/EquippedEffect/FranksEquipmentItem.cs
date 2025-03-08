using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class FranksEquipmentItem : EquipmentItem.EquippedEffect
{

     private int strengthIncrease = 15;
     private int strengthDecrease = 15;

     public override void Equipped(CharacterData user)
     {
          user.Stats.stats.strength += strengthIncrease;
     }
     
     public override void Removed(CharacterData user)
     {
          user.Stats.stats.strength -= strengthDecrease;
     }
}
