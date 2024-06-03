using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsLookAt : MonoBehaviour
{
    private GameObject obj;
    private int lookAtCycle;
    // Start is called before the first frame update
    void Start()
    {
        obj = GameObject.Find("Cube (1)");
        lookAtCycle = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //회전의 중심 위치, 축, 회전 속도
        transform.RotateAround(obj.transform.position, Vector3.up, 2f);



        lookAtCycle++;
        if( lookAtCycle >= 360 )
        {
            transform.LookAt(obj.transform);
            lookAtCycle = 0;
        }

    }
}
