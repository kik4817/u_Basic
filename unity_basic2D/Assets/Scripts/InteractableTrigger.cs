using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableTrigger : MonoBehaviour
{
    [SerializeField] JumpPlatform jumpPlatform;

    // �̺�Ʈ �浹 �Լ��� �����غ�����. OnTriggerEnter2D, Tag �̸� Player
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player")) // �÷��̾�� �浹���� �� �۵��Ѵ�.
        {
            // JumpPlatform�� �ִ� PlayTriggerAnimation �Լ��� �����Ѵ�.
            jumpPlatform.PlayTriggerAnimation("Trigger");
        }
    }
}
