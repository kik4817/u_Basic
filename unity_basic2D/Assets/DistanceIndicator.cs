using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceIndicator : MonoBehaviour
{
    [Header("플레이어와 목표 지점을 연결하세요.")]
    [SerializeField] private Transform player;
    [SerializeField] private Transform target;
    [SerializeField] private Slider playerSlider;
    [Header("Enemy Slider")]
    [SerializeField] private Transform enemy;    
    [SerializeField] private Transform enemytarget;
    [SerializeField] private Slider enemySlider;

    private float startX;
    private float startEnemyX;

    private void Start()
    {
        startX = player.transform.position.x * -1;
        startEnemyX = enemy.transform.position.x * -1;
    }

    public void SetPlayerValue(float value)
    {
        playerSlider.value = value;
    }
    public void SetEnemeyValue(float value)
    {
        enemySlider.value = value;
    }
    private void Update()
    {
        float playerX = player.position.x + startX;
        float targetX = target.position.x + startX;

        float enemyX = enemy.position.x + startEnemyX;
        float enemeytargetX = enemytarget.position.x + startEnemyX;

        float sliderValue = playerX / targetX;
        float enemySliderValue = enemyX / enemeytargetX; 

        SetPlayerValue(sliderValue);
        SetEnemeyValue(enemySliderValue);
    }
}
