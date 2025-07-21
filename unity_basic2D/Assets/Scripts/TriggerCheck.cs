using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCheck : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy")) // Tag �̸��� Enemy�� ���� �Ʒ� �ڵ带 �����ϼ���
        {
            // 1. �浹�� ����� �ı����Ѻ�����
            Destroy(collision.gameObject);
            // 2. �浹�� �ڱ� �ڽ��� �ı����Ѻ�����
            //Destroy(gameObject); 
        }

        // ���ǹ��� �ϳ� �����غ�����
        // Tag�� Player�� �� �����ϴ� �ڵ��Դϴ�.
        // Debug.Log("�浹�� ������Ʈ�� �̸� : " + collision.gameObject.name);
        if (collision.CompareTag("Player"))
        {
            Debug.Log("�浹�� ������Ʈ�� �̸� : " + collision.gameObject.name);
        }
    }
}
