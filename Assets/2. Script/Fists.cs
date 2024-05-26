using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fists : Weapons
{
    public Fists()
    {
        durability = 1;
        useCost = 0;
        attackPoint = 5;
        weaponName = "Fists";
    }

    public override void Attack()
    {
        base.Attack();
    }
}
