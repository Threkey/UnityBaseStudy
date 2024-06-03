using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
// �ǽ�: ť�갡 Wall�� �浹���� �� ť���� �ӵ��� 1�� ����, Debug.Log�� ǥ��

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
        dir.x = this.transform.position.x - wall.transform.position.x;                    // wall�� �ݴ�������� �з���
        dir.z = this.transform.position.z - wall.transform.position.z;
        dir.y = Vector3.up.y;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject == wall)
        {
            //CsRotate01.speed = 1.0f;          //���� �ܺ� ������ ���� speed�� static�����
            this.GetComponent<CsRotate01>().speed = 1f;         //static�� ����ϸ� �̷������� ������ ����, ������Ʈ�� ���� ��ũ��Ʈ�� ������Ʈ��
            Debug.Log("Wall�� �浹�߽��ϴ�. speed: 1");
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        rb.isKinematic = false;
        rb.AddForce(dir * power);
    }
}
