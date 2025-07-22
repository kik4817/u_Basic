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

        // 자기자신으로 부터 자식을 검색해서 가장 먼저 발견한 컴포넌트를 반환한다.
        allBones = GetComponentsInChildren<HumanBone>();

        arm = GetComponentInChildren<Arm>();
        leg = GetComponentInChildren<Leg>();
        body = GetComponentInChildren<Body>();
        head = GetComponentInChildren<Head>();

        //arm = GetComponentsInChildren<Arm>(); // 복수형태 왼쪽, 오른족

        //leg.SetRenderProperty(legColor, legSortingOrder);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
