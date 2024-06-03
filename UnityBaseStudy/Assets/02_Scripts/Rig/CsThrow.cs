using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsThrow : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.Translate(Vector3.right * Time.deltaTime * speed);

        this.GetComponent<Rigidbody>().velocity = Vector3.right * speed;
        
        //this.GetComponent <Rigidbody>().AddForce(Vector3.right * speed);

        //Vector3 vel = this.GetComponent <Rigidbody>().velocity;
        //float a = vel.magnitude;
        //Debug.Log(a);
    }
}
