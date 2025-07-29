using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class PlayerHandler : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigidbody2D;
    [SerializeField] private float moveSpeed = 5.0f;

    [SerializeField] private KeyCode JumpKey = KeyCode.Space;
    [SerializeField] private float JumpPower = 5f;
    [SerializeField] private float groundDistance = 1.2f;
    [SerializeField] private LayerMask groundLayer;
    
    private PlayerAnimatorController playerAnimatorController;

    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        playerAnimatorController = GetComponent<PlayerAnimatorController>();
    }

    private void Start()
    {
        Setup();
    }

    private void Setup()
    {
        rigidbody2D.freezeRotation = true;
    }

    private void Update()
    {
        // 코드를 작성한 후에 함수로 추출, 테스트를 하고 싶을 때
        // 코드가 완성이 되면 함수로 추출한다.
        Move();
        Jump();
    }

    private void Jump()
    {
        // 점프 조건
        // 점프 구현

        if (CanJump())
        {
            // 숫자 5를 멤버 변수의 점프 크기(jumpPower)
            rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, JumpPower);
        }

        Debug.DrawRay(transform.position, Vector3.down * groundDistance, Color.red);
    }

    private bool CanJump()
    {
        return Input.GetKeyDown(JumpKey) && GroundCheck();
    }

    private bool GroundCheck()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, groundDistance, groundLayer);
        return hit.collider != null;
    }

    private void Move()
    {
        // 1. 플레이어의 입력을 받아야 합니다. A, D // 화살표 <-, -> x의 좌표를 변경해야합니다.
        // 2. rigidbody.velocity 변경해서 이동을 구현한다.


        float horizontal = Input.GetAxisRaw("Horizontal");

        if (horizontal == 0)
        {
            playerAnimatorController.PlayBoolAnimation();
               }
        else
        {
            playerAnimatorController.PlayBoolAnimation("IsDance", true);
            playerAnimatorController.PlayBoolAnimation("IsMove", true);
        }
        //Debug.Log($"horizontal의 값 : {horizontal}");

        // 위에 있는 horizontal을 이용해서 vector2의 x값을 변경하는 코드를 만들어보세요
        // 멤버 변수로 이동 속도 변수를 하나 추가해서 vector의 현제 크기에 속도를 곱한 값으로 이동하도록 코들르 작성
        // moveSpeed
        rigidbody2D.velocity = new Vector2(horizontal * moveSpeed, rigidbody2D.velocity.y);
    }
}
