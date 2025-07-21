using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �������� : Tag�� �̿��ؼ� ������ ���� ������Ʈ�� ���� �ڵ带 ������ �� �ֵ��� �����غ�����

public class CollisionCheck : MonoBehaviour
{
    // ��Ͽ� ���� ����
    public bool isLava;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Debug.Log(collision.gameObject.name + "�� �浹��");
            Debug.Log("���� ���°� ��Ͽ� ���� �����Դϴ�.");
            isLava = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Debug.Log(collision.gameObject.name + "�� �浹 ���¿��� ���");
            Debug.Log("���� ���°� ��� ���°� �ƴմϴ�.");
            isLava = false;
        }
    }
}
