using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class movement3D : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 5.0f;

    private Vector3 moveDirection;

    private CharacterController characterController;

    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        characterController.Move(moveDirection * moveSpeed * Time.deltaTime);
    }

    public void MoveTO(Vector3 direction)
    {
        moveDirection = direction;
    }
}
