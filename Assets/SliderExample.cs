using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderExample : MonoBehaviour
{
    Slider slider;

    void Start()
    {
        // this script must be placed on the slider GameObject
        slider = GetComponent<Slider>();
        slider.onValueChanged.AddListener((value) => ChangeValue(value));
    }
	
    void ChangeValue(float value)
    {
        // You can do what you like with 'value' here.
        // This code will happen every time the value in the slider changes.
        Debug.Log(value);
    }
}
