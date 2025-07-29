using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimatorController : MonoBehaviour
{
    // Animator ������Ʈ�� �����ͼ� �����ϴ� �Լ��� ����� ������
    // PlayerHandler�� PlayerAnimatorController Ŭ������ ������ �� �ֵ��� �����غ�����. PlayBoolAnimator
    // PlayerHandler���� PlayerAnimatorController�� public���� ������� �ִϸ����� ���� �Լ��� ȣ���ϼ���
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void PlayerMoveAnimation()
    {
        playerAnimatorController.PlayBoolAnimation("IsMove", true);
        playerAnimatorController.PlayBoolAnimation("IsDance", false);
    }
    private void PlayBoolAnimation(string paramName, bool enable)
    {
        animator.SetBool(paramName, enable);
    }


}
