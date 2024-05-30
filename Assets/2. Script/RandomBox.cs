using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBox : MonoBehaviour
{
    List<Weapons> weaponsList = new List<Weapons> { new Gun() };
    Weapons weapon;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Player player = other.GetComponent<Player>();
            if (player != null)
            {
                WeaponDraw(player);
            }
        }
    }

    void WeaponDraw(Player player)
    {
        int index = Random.Range(0, weaponsList.Count);
        weapon = weaponsList[index];
        player.SetWeapon(weapon);
        gameObject.SetActive(false);
    }
}
