using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsFire : MonoBehaviour
{
    public GameObject bullet, head;
    public float speed;
    Rigidbody rbOfBullet;
    // Start is called before the first frame update
    void Start()
    {
        rbOfBullet = bullet.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(bullet, head.transform);
            bullet.GetComponent<Rigidbody>().AddForce(head.transform.forward * speed + head.transform.up * speed);
            }
    }
}
