using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Sword : Weapons
{
    public Sword()
    {
        durability = 1;
        useCost = 0;
        attackPoint = 10;
        weaponName = "Sword";
        OnWeaponBreak = new UnityEvent();
    }

    public override void Attack()
    {
        base.Attack();
    }
}
