using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SoundElement : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private TextMeshProUGUI value;
    public void Setvalue()
    {
        value.SetText($"{(int)(slider.value * 100)}");
    }
}
