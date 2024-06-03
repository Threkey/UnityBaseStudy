using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsSwap : MonoBehaviour
{
    public int a, b;
    void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("a: " + a + ", b: " + b);
        Swap(ref a, ref b);
        Debug.Log("a: " + a + ", b: " + b);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
