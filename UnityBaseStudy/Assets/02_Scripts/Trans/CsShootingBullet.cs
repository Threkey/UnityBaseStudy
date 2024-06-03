using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CsShootingBullet : MonoBehaviour
{
    private float timeNow, timeEnd, timeInterval;
    public GameObject go;
    public float power = 150f;
    // Start is called before the first frame update
    void Start()
    {
        timeInterval = 2;
    }

    // Update is called once per frame
    void Update()
    {
        timeNow = Time.time;
        timeEnd = timeNow + timeInterval;
        if(timeNow > timeEnd)
        {
            Destroy(go);
        }
    }

    public void Shoot()
    {
        go = Instantiate(go);
        go.GetComponent<Rigidbody>().velocity = transform.forward * power;
    }
}
