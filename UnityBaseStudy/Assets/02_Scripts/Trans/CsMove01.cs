using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsMove01 : MonoBehaviour
{
    public Vector3 pos;
    public float speed;
    //public GameObject goS;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = pos; //´©±¸ÀÇ
        this.transform.Translate(pos);
        // Vector3 trans = this.transform.position + pos;
        //goS.transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.Translate(pos * speed);
        //this.transform.Translate(Vector3.right * Time.deltaTime * speed);
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 rot = new Vector3(0f, 0f, 0f);

        if(h != 0f || v != 0f)
        {
            if(h>0f)
            {
                rot.y += 0.5f;
            }
            else if (h < 0f)
            {
                rot.y += -0.5f;
            }
            this.transform.Rotate(rot);
            //this.transform.Translate(Vector3.right * h *  Time.deltaTime * speed);
            this.transform.Translate(Vector3.forward * v * Time.deltaTime * speed);

        }
    }
}
