using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEntity : MonoBehaviour
{
    [Header("Life")]
    [SerializeField] int currentLife;
    [SerializeField] int maxLife = 10;

    [Header("Coin")]
    [SerializeField] int currentCoin;
    [SerializeField] int maxCoin = 99;

    [SerializeField] RuntimeUI runtimeUI;

    // ������ ������ �� ���� ����� �ִ� ������� �����Ѵ�.
    // �������� �����Ѵ�.

    private void Start()
    {
        currentLife = maxLife/2;
        currentCoin = 0;

        OnLifeUpdated(0);
        OnCoinUpdated(0);
        
    }
    public void OnLifeUpdated(int amount)
    {
        currentLife += amount;

        if(currentLife > maxLife)
        {
            currentLife = maxLife;
        }
        
        // RuntimeUI.LifeUpdate ����
        runtimeUI.OnLifeUpdated(currentLife);
    }

    public void OnCoinUpdated(int amount)
    {
        currentCoin += amount;

        if (currentCoin > maxCoin)
        {
            currentCoin = maxCoin;
        }

        runtimeUI.OnCoinUpdated(currentCoin);
    }

    public bool isPlayerDeath()
    {
        return currentLife <= 0;
    }
}
