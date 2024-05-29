using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Fists : Weapons
{
    public Fists()
    {
        durability = 1;
        useCost = 0;
        attackPoint = 5;
        weaponName = "Fists";
        OnWeaponBreak = new UnityEvent();
    }

    public override void Attack()
    {
        base.Attack();
    }
}
