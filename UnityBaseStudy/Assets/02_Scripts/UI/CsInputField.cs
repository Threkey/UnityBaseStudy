using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CsInputField : MonoBehaviour
{
    GameObject btn, text, input;
    // Start is called before the first frame update
    void Start()
    {
        btn = GameObject.Find("Button");
        text = GameObject.Find("Hello World");
        input = GameObject.Find("InputField");

        btn.GetComponent<Button>().onClick.AddListener(ChangeTextOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            ChangeTextOnClick();
            input.GetComponent<InputField>().ActivateInputField();
            //input.GetComponent<InputField>().MoveTextEnd(false);
        }

    }

    void ChangeTextOnClick()
    {
        if(input.GetComponent<InputField>().text != null)
        {
            text.GetComponent<Text>().text = input.GetComponent<InputField>().text;
        }
    }
}
