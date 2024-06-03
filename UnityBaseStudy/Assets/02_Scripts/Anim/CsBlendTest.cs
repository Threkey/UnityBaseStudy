using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsBlendTest : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        anim.SetFloat("dir", h);
        anim.SetFloat("speed", v);
        Vector3 dir = new Vector3(h, 0, v);
        //transform.Translate(Vector3.forward * v * Time.deltaTime);
        transform.Translate(dir * Time.deltaTime);
    }
}
