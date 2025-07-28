using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] private Transform target; // ī�޶� ������ ����Դϴ�.

    Vector3 offset; // offset = ī�޶�

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - target.position;
        Debug.Log($"����� ���� ��ġ : {offset}");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position + offset;
    }
}
