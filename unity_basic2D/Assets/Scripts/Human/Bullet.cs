using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            // �浹�� ����� ���� ������Ʈ���� ������ ������ �� �ִ� ������Ʈ(Sprite Renderer)�� ������ �� ������ ���������� �����ϼ���.

            SpriteRenderer _sr = collision.GetComponent<SpriteRenderer>();

            if(_sr != null )
            {
                _sr.color = Color.red;
                Invoke(nameof(ResetColor), 0.5f);
            }

            //if(collision.TryGetComponent(out SpriteRenderer sr))
            //{
            //    sr.color = Color.red;
            //}

        }
    }

    private void ResetColor(SpriteRenderer sr)
    {
        sr.color = Color.white;
    }
}
