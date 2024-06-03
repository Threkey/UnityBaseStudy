using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CsEnemyDetect : MonoBehaviour
{
    private bool isDetected;
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        isDetected = false;
        speed = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward * 6, Color.red);
        RaycastHit hit = new RaycastHit();

        if (!isDetected)
        {
            transform.Rotate(Vector3.up * speed);
            if(Physics.Raycast(transform.position, transform.forward, out hit, 6))
            {
                isDetected=true;
            }
        }

        if(isDetected)
        {
            if (Physics.Raycast(transform.position, transform.forward, out hit, 6))
            {
                transform.LookAt(hit.transform);
                Debug.Log("Detected!");
                GameObject go = GameObject.Find("FirePosition");
                go.GetComponent<CsShootingBullet>().Shoot();
            }
            else
            {
                isDetected = false;
            }
        }
    }
}
