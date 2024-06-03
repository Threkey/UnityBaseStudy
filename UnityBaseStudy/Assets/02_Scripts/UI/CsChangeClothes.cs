using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CsChangeClothes : MonoBehaviour
{
    GameObject[] go;
    Button btn1, btn2;
    int count;
    // Start is called before the first frame update
    void Start()
    {
        go = new GameObject[transform.childCount];
        for(int i = 0;  i < go.Length; i++)
        {
            go[i] = transform.GetChild(i).gameObject;
        }

        btn1 = GameObject.Find("Button1").GetComponent<Button>();
        btn2 = GameObject.Find("Button2").GetComponent<Button>();

        btn1.onClick.AddListener(delegate { ChangeShirts(go); });
        btn2.onClick.AddListener(delegate { ChangeColor(go); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ChangeShirts(GameObject[] go)
    {

        for(int i = 1; i <= 4; i++)
        {
            if (go[go.Length - i].activeSelf)
            {
                go[go.Length - i].SetActive(false);
                if(go.Length - i >= go.Length - 1)
                    go[go.Length - 4].SetActive(true);
                else
                    go[go.Length - i + 1].SetActive(true);
            }

        }

    }

    void ChangeColor(GameObject[] go)
    {

    }
}
