using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
// 실습: 큐브가 Wall에 충돌했을 때 큐브의 속도를 1로 수정, Debug.Log로 표시

public class CsCollision : MonoBehaviour
{
    public GameObject wall;
    public float power;
    private Rigidbody rb;
    private Vector3 dir;
    // Start is called before the first frame update
    void Start()
    {
        wall = GameObject.Find("Wall");
        rb = GetComponent<Rigidbody>();
        dir = Vector3.zero;
        power = 500f;
    }

    // Update is called once per frame
    void Update()
    {
        dir.x = this.transform.position.x - wall.transform.position.x;                    // wall의 반대방향으로 밀려남
        dir.z = this.transform.position.z - wall.transform.position.z;
        dir.y = Vector3.up.y;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject == wall)
        {
            //CsRotate01.speed = 1.0f;          //변수 외부 참조를 위해 speed에 static사용함
            this.GetComponent<CsRotate01>().speed = 1f;         //static을 사용하면 이런식으로 접근을 못함, 오브젝트에 넣은 스크립트도 컴포넌트다
            Debug.Log("Wall과 충돌했습니다. speed: 1");
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        rb.isKinematic = false;
        rb.AddForce(dir * power);
    }
}
