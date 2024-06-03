using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsIdentity : MonoBehaviour
{
    public float rotSpeed = 120f;
    private Quaternion idleRot;
    // Start is called before the first frame update
    void Start()
    {
        idleRot = this.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        float amtRot = rotSpeed * Time.deltaTime;
        float h = Input.GetAxis("Horizontal");
        this.transform.Rotate(Vector3.up * h * amtRot);

        if (Input.GetMouseButtonDown(0))
        {
            //transform.rotation = idleRot;
            //transfrom.rotation = transform.rotation;

            transform.localRotation = idleRot;
        }
    }
}