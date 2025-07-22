using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanBone : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    void Awake()
    {
       spriteRenderer = GetComponent<SpriteRenderer>();
       
    }
    private void SetRenderProperty(Color _color, int _orderCount)
    {
        spriteRenderer.color = _color;
        spriteRenderer.sortingOrder = _orderCount;
    }    

}
