using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsJump02 : MonoBehaviour
{
    public float power;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            this.GetComponent<Rigidbody>().velocity = Vector3.up * power;
        }
    }
}
