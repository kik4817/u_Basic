using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTrigger : MonoBehaviour
{
    [SerializeField] GameObject GameOverPanel;

    //[SerializeField] int damageAmount = 5; �������� �ٶ�
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            // ���� ����� 0�� ������ ��
            // ���� ����� ��� ����������? -> �÷��̾��� ���ӿ�����Ʈ �ȿ� �÷��̾��� ����� �����ϴ� ��ũ��Ʈ�� ���� ������?
            // ���࿡ ����� �����ϴ� ��ũ��Ʈ�� �ִٸ� �� ��Ʈ��Ʈ���� ����� ���ּ���.
           
            //var Life = collision.GetComponent<PlayerEntity>(); // var = PlayerEntity
            //Life.OnLifeUpdated(-1);
            
            // SavePoint�� ���ư����մϴ�.


            // GameOver ������Ʈ�� Ȱ��ȭ�ϼ���
           GameOverPanel.SetActive(true);
        }
    }
}
