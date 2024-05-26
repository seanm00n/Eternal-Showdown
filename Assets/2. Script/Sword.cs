using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : Weapons
{
    public Sword()
    {
        durability = 1;
        useCost = 0;
        attackPoint = 10;
        weaponName = "Sword";
    }

    public override void Attack()
    {
        base.Attack();
    }
}
