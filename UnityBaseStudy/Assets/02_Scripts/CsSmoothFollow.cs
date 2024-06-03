using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsSmoothFollow : MonoBehaviour
{
    //따라갈 오브젝트 지정
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
            //카메라가 가려는(회전하려는) 값(회전, 높이)
            float wantedRotationAngle = target.rotation.y; //target.eulerAngles.y
            float wantedHeight = target.position.y + height;

            //현재 카메라 값
            float currentRotationAngle = transform.rotation.y;
            float currentHeight = transform.position.y;

            //부드럽게 적용(회전, 높이)
            currentRotationAngle = Mathf.LerpAngle(currentRotationAngle, wantedRotationAngle, rotationDamping * Time.deltaTime);

            currentHeight = Mathf.Lerp(currentHeight, wantedHeight, heightDamping * Time.deltaTime);

            //transform.Rotate(0f, currentRotationAngle, 0f);

            //transform.position.y = currentHeight; (이렇게는 안됨.)
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