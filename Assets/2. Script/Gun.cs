using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : Weapons
{
    public Gun()
    {
        durability = 15;
        useCost = 1;
        attackPoint = 15;
        weaponName = "Gun";
    }

    public override void Attack()
    {
        // do something
        base.Attack();
    }
}
