using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class AgilityPotion : UsableItem.UsageEffect
{
    public int agilityIncrease;

    public override bool Use(CharacterData user)
    {
        user.Stats.stats.agility += agilityIncrease;
        return true;
    }
}
