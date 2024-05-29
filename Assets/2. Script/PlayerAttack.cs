using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerAttack : MonoBehaviour
{
    Weapons weapon;

    private void Start()
    {
        SetWeapon(new Fists());
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
        }
    }

    void SetWeapon(Weapons newWeapon)
    {
        weapon = newWeapon;
        weapon.OnWeaponBreak.AddListener(SetFists); // 이벤트 추가
    }

    void SetFists()
    {
        weapon = new Fists();
    }

}
