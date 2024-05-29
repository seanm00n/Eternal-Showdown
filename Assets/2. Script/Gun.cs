using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Gun : Weapons
{
    public Gun()
    {
        durability = 15;
        useCost = 1;
        attackPoint = 15;
        weaponName = "Gun";
        OnWeaponBreak = new UnityEvent();
    }

    public override void Attack()
    {
        // do something
        base.Attack();
    }
}
