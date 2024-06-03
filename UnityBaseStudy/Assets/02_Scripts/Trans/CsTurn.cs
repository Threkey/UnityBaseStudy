using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsTurn : MonoBehaviour
{
    float timeNow, timeInterval;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        //TurnObject();
    }

    public void TurnObject()
    {
        transform.Rotate(Vector3.up * speed);
    }
}
