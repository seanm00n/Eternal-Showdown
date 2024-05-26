using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapons : MonoBehaviour//, IWeapons
{
    protected int durability;
    protected int useCost;
    protected int attackPoint;
    protected string weaponName;
    public delegate void OnRunOut(); // µ®∏Æ∞‘¿Ã∆Æ
    public virtual void Attack()
    {
        durability -= useCost;
        if(durability < 0)
        {
            //
        }

        Debug.Log(weaponName + " Attack");
    }
}
