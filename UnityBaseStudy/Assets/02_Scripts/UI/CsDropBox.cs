using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CsDropBox : MonoBehaviour
{
    Dropdown dropdown;
    Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = GameObject.Find("Hello World").GetComponent<Text>();

        dropdown = GameObject.Find("Dropdown").GetComponent<Dropdown>();
        dropdown.onValueChanged.AddListener(ChangeText);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ChangeText(Dropdown select)
    {
        text.text = dropdown.options[select.value].text;
    }
    void ChangeText(int value)
    {
        Debug.Log(value);
        text.text = dropdown.options[value].text;
    }
}
