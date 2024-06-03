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
    
    void Method(bool _bool)         //toggle�� AddListener�� bool(is On)�� ���ڷ� �Ѱ��ش�
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
    
    void Method()           //bool���� ���� �޼ҵ带 ������� delegate�� �����
    {
        string temp = str1;
        str1 = str2;
        str2 = temp;
    }
    
}