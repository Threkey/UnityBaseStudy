using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CsToggle : MonoBehaviour
{
    public string str1, str2;
    Toggle tog;
    // Start is called before the first frame update
    void Start()
    {
        str1 = "Hello World";
        str2 = "Goodbye World";
        tog = GameObject.Find("Toggle").GetComponent<Toggle>();
        //tog.onValueChanged.AddListener(delegate { Method(); }) ;
        tog.onValueChanged.AddListener(Method);
    }

    // Update is called once per frame
    void Update()
    {
        //GetComponent<Text>().text = str1;
    }
    
    void Method(bool _bool)         //toggle의 AddListener는 bool(is On)을 인자로 넘겨준다
    {

        Debug.Log(_bool);

        if (_bool)
        {
            GetComponent<Text>().text = str1;
        }
        else
        {
            GetComponent<Text>().text = str2;
        }
    }
    
    void Method()           //bool인자 없이 메소드를 만들려면 delegate를 써야함
    {
        string temp = str1;
        str1 = str2;
        str2 = temp;
    }
    
}