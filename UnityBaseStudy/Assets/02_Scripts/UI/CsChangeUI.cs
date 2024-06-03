using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.UI;

public class CsChangeUI : MonoBehaviour
{
    public string str1, str2;
    public Button btn;
    private bool isChanged, isCalled;
    // Start is called before the first frame update
    void Start()
    {
        str1 = "Hello World";
        str2 = "Bye World";
        isChanged = true;
        //GetComponent<Text>().text = "Bye World";
        btn.onClick.AddListener(Method);
    }

    // Update is called once per frame
    void Update()
    {
        if (!isChanged)
        {
            StartCoroutine(ChangeText());
        }
    }

    public void Method()
    {
        isChanged = false;
    }

    IEnumerator ChangeText()
    {
        char[] temp = str1.ToCharArray();
        for(int i = 0;  i < str1.Length; i++)
        {
            if (i < str2.Length)
                temp[i] = str2[i];
            else temp[i] = '\0';
            str1 = new string(temp);
            GetComponent<Text>().text = str1;
            yield return new WaitForSeconds(1f);
        }
        isChanged = true;
    }
}