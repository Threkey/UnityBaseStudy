using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Button btn1, btn2, btn3;
    GameObject go;
    CsRotateCube cRs;
    // Start is called before the first frame update
    void Start()
    {
        go = GameObject.Find("Cube");
        cRs = go.GetComponent<CsRotateCube>();
        btn1.onClick.AddListener(MethodCall1);
        btn2.onClick.AddListener(MethodCall2);
        btn3.onClick.AddListener(MethodCall3);
    }

    public void MethodCall1()
    {
        //public 메소드 호출
        //go.GetComponent<CsRotateCube>().Rotate1();
        cRs.Rotate1();
    }
    public void MethodCall2()
    {
        //private 메소드 호출
        go.SendMessage("Rotate2", SendMessageOptions.DontRequireReceiver);
    }
    public void MethodCall3()
    {
        //static 메소드 호출
        CsRotateCube.AddTwoNum(3, 5);
        CsRotateCube.numX = 3;
        Debug.Log(CsRotateCube.numX);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
