using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsScreenPointMove : MonoBehaviour
{
    private Vector3 cubePos;
    // Start is called before the first frame update
    void Start()
    {
        cubePos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if(hit.collider.name == "Plane")
                {
                    cubePos.x = hit.point.x;
                    cubePos.z = hit.point.z;
                    //transform.position = hit.point;
                }
                transform.position = cubePos;
            }
        }

    }
}
