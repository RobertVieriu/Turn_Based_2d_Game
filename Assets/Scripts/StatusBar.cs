using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StatusBar : MonoBehaviour
{
    [SerializeField] private Slider slider;
    public TMP_Text text;


    public void UpdateStatusBar(float maxValue, float currentValue, float tempValue)
    {
        slider.value = currentValue / maxValue;
    }
}
