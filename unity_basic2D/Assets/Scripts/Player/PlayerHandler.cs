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
        // �ڵ带 �ۼ��� �Ŀ� �Լ��� ����, �׽�Ʈ�� �ϰ� ���� ��
        // �ڵ尡 �ϼ��� �Ǹ� �Լ��� �����Ѵ�.
        Move();
        Jump();
    }

    private void Jump()
    {
        // ���� ����
        // ���� ����

        if (CanJump())
        {
            // ���� 5�� ��� ������ ���� ũ��(jumpPower)
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
        // 1. �÷��̾��� �Է��� �޾ƾ� �մϴ�. A, D // ȭ��ǥ <-, -> x�� ��ǥ�� �����ؾ��մϴ�.
        // 2. rigidbody.velocity �����ؼ� �̵��� �����Ѵ�.


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
        //Debug.Log($"horizontal�� �� : {horizontal}");

        // ���� �ִ� horizontal�� �̿��ؼ� vector2�� x���� �����ϴ� �ڵ带 ��������
        // ��� ������ �̵� �ӵ� ������ �ϳ� �߰��ؼ� vector�� ���� ũ�⿡ �ӵ��� ���� ������ �̵��ϵ��� �ڵ鸣 �ۼ�
        // moveSpeed
        rigidbody2D.velocity = new Vector2(horizontal * moveSpeed, rigidbody2D.velocity.y);
    }
}
