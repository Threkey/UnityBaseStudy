using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CsRotate01 : MonoBehaviour
{
    public float speed; //��ũ ���� �ӵ�
    public GameObject Head; //��ũ �ͷ�
    // Start is called before the first frame update
    void Start()
    {
        speed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");
        Vector3 rotOfBody = new Vector3(0f, 0f, 0f);
        Vector3 rotOfHead = new Vector3(0f, 0f, 0f);

        if (v != 0)         //����or���� ��
        {
            this.transform.Translate(Vector3.forward * v * speed * Time.deltaTime);
            if (h > 0)       //��ü ȸ��
            {
                rotOfBody.y += 0.5f;
            }
            else if (h < 0)
            {
                rotOfBody.y += -0.5f;
            }
            this.transform.Rotate(rotOfBody);
        }
        else if (v == 0)     //����or���� ����
        {
                if (h > 0)          // �ͷ� ȸ��
                {
                    rotOfHead.y += 0.5f;
                }
                else if (h < 0)
                {
                    rotOfHead.y += -0.5f;
                }
                Head.transform.Rotate(rotOfHead);
        }
    }
}
