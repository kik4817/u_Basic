using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnetict_Filed : MonoBehaviour
{
    public bool isSafe;

    public GameObject player;

    public float currentsize = 50;
    public float Speed = 1f;

    private void Update()
    {
        currentsize -= Time.deltaTime * Speed;
        if (currentsize <= 1)
        {
            currentsize = 1;
        }
        transform.localScale = Vector3.one * currentsize;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            isSafe = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            isSafe = false;
            Destroy(player);
        }
    }
}
