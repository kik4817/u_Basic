using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTrigger : MonoBehaviour
{
    [SerializeField] GameObject GameOverPanel;

    //[SerializeField] int damageAmount = 5; 데미지를 줄때
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            // 남은 목숨이 0개 이하일 때
            // 남은 목숨은 어떻게 가져오나요? -> 플레이어의 게임오브젝트 안에 플레이어의 목숨을 제어하는 스크립트가 있지 않을까?
            // 만약에 목숨을 제어하는 스크립트가 있다면 그 쓰트립트에서 목숨을 빼주세요.
           
            //var Life = collision.GetComponent<PlayerEntity>(); // var = PlayerEntity
            //Life.OnLifeUpdated(-1);
            
            // SavePoint로 돌아가야합니다.


            // GameOver 오브젝트를 활성화하세요
           GameOverPanel.SetActive(true);
        }
    }
}
