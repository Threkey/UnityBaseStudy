using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsSmoothFollow : MonoBehaviour
{
    //���� ������Ʈ ����
    public Transform target;
    public float distance = 15f;
    public float height = 5f;

    public float heightDamping = 3.0f;
    public float rotationDamping = 3.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (target)
        {
            //ī�޶� ������(ȸ���Ϸ���) ��(ȸ��, ����)
            float wantedRotationAngle = target.rotation.y; //target.eulerAngles.y
            float wantedHeight = target.position.y + height;

            //���� ī�޶� ��
            float currentRotationAngle = transform.rotation.y;
            float currentHeight = transform.position.y;

            //�ε巴�� ����(ȸ��, ����)
            currentRotationAngle = Mathf.LerpAngle(currentRotationAngle, wantedRotationAngle, rotationDamping * Time.deltaTime);

            currentHeight = Mathf.Lerp(currentHeight, wantedHeight, heightDamping * Time.deltaTime);

            //transform.Rotate(0f, currentRotationAngle, 0f);

            //transform.position.y = currentHeight; (�̷��Դ� �ȵ�.)
            //transform.position = new Vector3(transform.position.x, currentHeight, transform.position.z);

            Quaternion currentRotation = Quaternion.Euler(0, currentRotationAngle, 0);

            Vector3 pos = target.position;

            pos = pos - currentRotation * Vector3.forward * distance;
            Debug.Log(currentRotation + " * " + Vector3.forward + " = " + pos/distance);
            pos.y = currentHeight;
            transform.position = pos;

            transform.LookAt(target);

        }
    }
}