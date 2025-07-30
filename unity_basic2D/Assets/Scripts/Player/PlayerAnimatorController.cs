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
        PlayBoolAnimation("IsMove", true);
        PlayBoolAnimation("IsDance", false);
    }
    public void PlayerDanceAnimation()
    {
        PlayBoolAnimation("IsMove", false);
        PlayBoolAnimation("IsDance", true);
    }
    private void PlayBoolAnimation(string paramName, bool enable)
    {
        animator.SetBool(paramName, enable);
    }


}
