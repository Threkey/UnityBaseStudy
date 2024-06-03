using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsFindCube : MonoBehaviour
{
    private int count;
    public int maxCount = 180;
    private float timeNow = 0f;
    private float timeEnd = 0f;
    public float timeInterval = 1f;
    private GameObject go;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        maxCount = 360;
    }

    // Update is called once per frame
    void Update()
    {
        timeNow = Time.time;            // ����ð� ������Ʈ
        if (Input.GetMouseButtonDown(0))            // ���콺�� Ŭ���Ǹ�
        {
            //count = 0;                                                   // ī��Ʈ �ʱ�ȭ
            timeEnd = timeNow + timeInterval;        // ȸ���� ������ �ð� �ʱ�ȭ
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);            // ���콺 ��ġ�� �ִ� �� ����
            RaycastHit hit;                                           // ���õ� ������Ʈ ����
            if (Physics.Raycast(ray, out hit))              // ���õǸ�
            {
                if (hit.collider.tag == "Cube")                // ���õ� ������Ʈ�� �±װ� "Cube"�̸�
                {
                    go = hit.collider.gameObject;            // go�� ���õ� ������Ʈ ����
                }
            }
        }

        //if (go != null && count <= maxCount)     // �ð��� count�� ����
        if(go != null && timeNow <= timeEnd)        // �ð��� Time.time���� ����
        {
            go.GetComponent<CsTurn>().TurnObject();
            count++;
        }
    }
}
