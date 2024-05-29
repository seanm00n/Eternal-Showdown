using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapons : MonoBehaviour//, IWeapons
{
    protected int durability;
    protected int useCost;
    protected int attackPoint;
    protected string weaponName;
    public delegate void WeaponBreakAction();
    public event WeaponBreakAction OnWeaponBreak;
    public virtual void Attack()
    {
        durability -= useCost;
        if(durability < 0)
        {
            Debug.Log(weaponName + " Broke");
            OnWeaponBreak?.Invoke();
            return;
        }
        
        Debug.Log(weaponName + " Attack");
    }
}
