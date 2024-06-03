using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsJump03 : MonoBehaviour
{
    public float speed;                                 // �����ӵ�
    private float initSpeed;                         //�ʱ� �ӵ�
    private Vector3 initPos, curPos;          //�ʱ� ��ġ, ������ġ
    private bool isJump;                              //���������� ����
    // Start is called before the first frame update
    void Start()
    {
        initPos = this.transform.position;
        curPos = this.transform.position;
        initSpeed = speed;
        isJump = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isJump)             // �������� �ƴ� �� ���콺 ��Ŭ���ϸ� ���������� ���� �ٲ�
        {
            isJump = true;
        }
        if (isJump)                 //�������̸�
        {
            curPos.y += speed * Time.deltaTime;                             //�ӵ���ŭ ���� �̵�
            //this.transform.Translate(Vector3.up * speed * Time.deltaTime);
            speed = speed - 0.5f;                          //�ӵ� ����
            if (curPos.y < initPos.y)                    // y���� �ʱ� y������ ���ٸ�(����������)
            {
                isJump=false;                                 //���� ���¸� �������� �ƴ����� �ٲ�
                speed = initSpeed;                         //�ӵ��� �ʱ�ӵ��� �ٲ�
                curPos.y=initPos.y;                       //���� ��ġ�� y���� �ʱ���ġ�� �ٲ�(������ �Ʒ� �����ִ� ��Ȳ ����)
            }
        }
        this.transform.position = curPos;         //������ġ ����
    }
}
