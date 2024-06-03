using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CsSlider2 : MonoBehaviour
{
    Slider slider3, slider4;
    Color textColor;
    GameObject text;
    Text percentText;
    string str1;
    // Start is called before the first frame update
    void Start()
    {
        slider3 = GetComponent<Slider>();
        slider4 = GameObject.Find("Slider4").GetComponent<Slider>();
        slider3.onValueChanged.AddListener(SynchronizedValue);
        slider4.onValueChanged.AddListener(ChangeColor);
        text = GameObject.Find("Hello World");
        textColor = text.GetComponent<Text>().color ;
        percentText = GameObject.Find("Percent").GetComponent <Text>();
        str1 = slider3.value.ToString() ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SynchronizedValue(float value)
    {
        str1 = ((int)(value * 100)).ToString() ;
        slider4.value = value;
        textColor.r = value;
        text.GetComponent<Text>().color = textColor;
        percentText.text = str1 + "%";
    }

    void ChangeColor(float value)
    {
        textColor.b = value;
        text.GetComponent<Text>().color = textColor;
    }
}