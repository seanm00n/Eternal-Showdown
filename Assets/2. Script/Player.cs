using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    Weapons weapon;
    CharacterController controller;
    Animator animator;
    float x, z;
    float speed = 6.0f;
    float gravity = -9.81f;
    float jumpHeight = 1.0f;
    float health = 200;
    bool isGround;
    Vector3 velocity;

    private void Start()
    {
        SetFists();
        animator = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        // gravity&jump
        isGround = controller.isGrounded;
        if (isGround && velocity.y < 0)
        {
            velocity.y = -2.0f;
        }

        if (Input.GetButtonDown("Jump") && isGround)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        // movement
        x = Input.GetAxisRaw("Horizontal");
        z = Input.GetAxisRaw("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        // apply
        controller.Move(move * speed * Time.deltaTime);
        controller.Move(velocity * Time.deltaTime);

        // attack
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            weapon.Attack();
            animator.SetTrigger("Attack");
        }
    }

    public void Hit() // 이벤트 추가
    {
        // 캐릭터 흔들림
        // 체력 감소
        // 애니메이션 
    }

    public void SetWeapon(Weapons newWeapon)
    {
        weapon = newWeapon;
        weapon.OnWeaponBreak.AddListener(SetFists);
    }

    void SetFists()
    {
        weapon = new Fists();
    }
}
