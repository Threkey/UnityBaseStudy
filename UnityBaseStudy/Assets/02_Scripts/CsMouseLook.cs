using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsMouseLook : MonoBehaviour
{
    public float sensitivity = 500f;
    public float maxX = 45f;
    public float maxY = 45f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float mouseMoveValueX = Input.GetAxis("Mouse X");
        float mouseMoveValueY = Input.GetAxis("Mouse Y");

        Vector3 rotate = new Vector3(-mouseMoveValueY, mouseMoveValueX, 0f);
        rotate = rotate * sensitivity * Time.deltaTime;



        transform.Rotate(rotate);

    }
}
