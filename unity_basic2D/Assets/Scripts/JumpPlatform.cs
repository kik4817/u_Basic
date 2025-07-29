using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPlatform : MonoBehaviour
{
    // 1. Animator Component�� Awake �Լ����� ���� �ʱ�ȭ ���ּ���. Setup

    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        // �浹 ������ �÷��̾ ������ ���� �� �ڵ带 �����ϰ� �ʹ�.
        PlayTriggerAnimation("Trigger");
    }

    public void PlayTriggerAnimation(string paramName)
    {
        animator.SetTrigger(paramName);
    }
}
