using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class RandomBox : MonoBehaviour
{
    List<Weapons> weaponsList = new List<Weapons> { new Sword(), new Gun() };
    IObjectPool<RandomBox> pool;
    Weapons weapon;
    Vector3 position;

    private void Awake()
    {
        position = transform.position;
        pool = GameMananger.Instance.pool;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Box Obtain");
            other.GetComponent<Player>()?.SetWeapon(WeaponDraw());
            GameMananger.Instance.SpawnBox(position);
            pool.Release(this);
        }
    }

    Weapons WeaponDraw()
    {
        int index = Random.Range(0, weaponsList.Count);
        return weaponsList[index];
    }
}
