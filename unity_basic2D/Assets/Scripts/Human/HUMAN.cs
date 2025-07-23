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

        // 자기자신으로 부터 자식을 검색해서 가장 먼저 발견한 컴포넌트를 반환한다.
        allBones = GetComponentsInChildren<HumanBone>();

        arm = GetComponentInChildren<Arm>();
        leg = GetComponentInChildren<Leg>();
        body = GetComponentInChildren<Body>();
        head = GetComponentInChildren<Head>();

        //arm = GetComponentsInChildren<Arm>(); // 복수형태 왼쪽, 오른족

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
