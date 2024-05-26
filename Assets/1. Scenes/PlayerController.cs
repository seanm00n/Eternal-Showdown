using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private movement3D movement3D;

    private void Awake()
    {
        movement3D = GetComponent<movement3D>();
    }

    private void Update()
    {
        // x,z 방향 이동
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        movement3D.MoveTO(new Vector3(x, 0, z));
    }

}
