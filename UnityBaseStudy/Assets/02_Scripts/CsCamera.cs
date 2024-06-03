using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsCamera : MonoBehaviour
{
    public Camera cam;
    public float setDis, camSpeed;
    private float curDis;
    // Start is called before the first frame update
    void Start()
    {
        setDis = 0f;
        camSpeed = 0.5f;
        cam.transform.position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        curDis = Vector3.Distance(transform.position, cam.transform.position);
        if (curDis > setDis)
        {
            cam.transform.position += Vector3.forward * camSpeed;
            cam.transform.position += Vector3.down * camSpeed;
        }
        if (curDis < setDis)
        {
            cam.transform.position -= Vector3.forward * camSpeed;
            cam.transform.position -= Vector3.down * camSpeed;
        }

        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            setDis = 0f;
        }
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            setDis = 5f;
        }
    }
}
