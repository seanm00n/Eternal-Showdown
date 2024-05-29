using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    Weapons weapon;

    private void Start()
    {
        weapon = new Fists();
        weapon.OnWeaponBreak += SetFists;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            weapon = new Sword();
            Debug.Log("Weapon Changed: Sword");
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            weapon = new Gun();
            Debug.Log("Weapon Changed: Gun");
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            weapon.Attack();
        }
    }

    void SetFists()
    {
        weapon = new Fists();
        Debug.Log("Weapon Changed: Fists");
    }

}
