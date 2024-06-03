using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CsSilder : MonoBehaviour
{
    Slider slider1, slider2;
    int maxFontSize = 200;
    Color textColor;
    // Start is called before the first frame update
    void Start()
    {
        slider1 = GameObject.Find("Slider1").GetComponent<Slider>();
        slider2 = GameObject.Find("Slider2").GetComponent<Slider>();
        slider1.onValueChanged.AddListener(ChangeSize);
        slider2.onValueChanged.AddListener(ChangeColor);
        textColor = GetComponent<Text>().color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ChangeSize(float value)
    {
        GetComponent<Text>().fontSize = (int)(value * maxFontSize);
    }

    void ChangeColor(float vlaue)
    {
        GetComponent<Text>().color = textColor * vlaue;
    }
}
