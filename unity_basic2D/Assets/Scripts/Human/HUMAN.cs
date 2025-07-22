using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class HUMAN : MonoBehaviour
{
    [SerializeField] private HumanBone[] allBones;

    [SerializeField] private Arm arm;
    [SerializeField] private Leg leg;
    [SerializeField] private Body body;
    [SerializeField] private Head head;

    [SerializeField] private Color legColor;
    [SerializeField] private int legSortingOrder = 10;

    // Start is called before the first frame update
    void Start()
    {

        // �ڱ��ڽ����� ���� �ڽ��� �˻��ؼ� ���� ���� �߰��� ������Ʈ�� ��ȯ�Ѵ�.
        allBones = GetComponentsInChildren<HumanBone>();

        arm = GetComponentInChildren<Arm>();
        leg = GetComponentInChildren<Leg>();
        body = GetComponentInChildren<Body>();
        head = GetComponentInChildren<Head>();

        //arm = GetComponentsInChildren<Arm>(); // �������� ����, ������

        //leg.SetRenderProperty(legColor, legSortingOrder);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
