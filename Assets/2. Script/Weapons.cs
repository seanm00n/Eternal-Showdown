using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class Weapons
{
    protected int durability;
    protected int useCost;
    protected int attackPoint;
    protected string weaponName;
    public string userName;
    public UnityEvent OnWeaponBreak;

    public virtual void Attack()
    {
        Debug.Log(weaponName + " Attack");
        durability -= useCost;
        if(durability <= 0)
        {
            Debug.Log(weaponName + " Broke");
            OnWeaponBreak?.Invoke();
        }
    }
}
