using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    Weapons weapon;
    private void Start()
    {
        weapon = new Fists();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SetWeapon(new Sword());
            Debug.Log("Weapon Changed: Sword");
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SetWeapon(new Gun());
            Debug.Log("Weapon Changed: Gun");
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            weapon.Attack();
            //
        }
    }
    void SetWeapon(Weapons newWeapon)
    {
        weapon = newWeapon;
        // 콜백함수 
    }
}
