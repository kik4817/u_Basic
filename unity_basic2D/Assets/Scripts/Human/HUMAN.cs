using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class HUMAN : MonoBehaviour
{
    [SerializeField] private HumanBone[] allBones;

    private Arm arm;
    private Leg leg;
    private Body body;
    private Head head;

    [SerializeField] private Color legColor;
    [SerializeField] private int legSortingOrder = 10;
    [SerializeField] private Color armColor;
    [SerializeField] private int armSortingOrder = 10;
    [SerializeField] private Color bodyColor;
    [SerializeField] private int bodySortingOrder = -10;
    [SerializeField] private Color headColor;
    [SerializeField] private int headSortingOrder = 10;

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

        arm.SetRenderProperty(armColor, legSortingOrder);
        leg.SetRenderProperty(legColor, legSortingOrder);
        body.SetRenderProperty(bodyColor, legSortingOrder);
        head.SetRenderProperty(headColor, legSortingOrder);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
