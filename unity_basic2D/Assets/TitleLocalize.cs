using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class TitleLocalize : MonoBehaviour
{
    TextMeshProUGUI titleText;

    [SerializeField] private string engTitle;
    [SerializeField] private string korTitle;
    public bool isKorean = true;
    //public bool isEnglish;
    //public bool isJanan;

    private void Awake()
    {
        titleText = GetComponent<TextMeshProUGUI>();
    }

    private void Start()
    {
        //titleText.text = "ÇÃ·§Æû °ÔÀÓ";
        //titleText.SetText("ÇÃ·§Æû °ÔÀÓ2");
        if(isKorean)
            titleText.SetText(korTitle);
        else
            titleText.SetText(engTitle);

    }
}
