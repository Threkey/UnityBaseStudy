using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsRaycast : MonoBehaviour
{
    float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float amtMove = speed * Time.deltaTime;
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * hor *  amtMove);
        transform.Translate(Vector3.forward * ver * amtMove);


        //DrawRay, ����ĳ��Ʈ�� ���̰� ����(Gizmo)
        Debug.DrawRay(transform.position, transform.forward * 8, Color.red);
        /*
        //����ĳ��Ʈ ������� ������ ������ ����
        RaycastHit hit;
        //������ ���� �浹�� ���� ������Ʈ�� �ռ� ������ ���� hit�� ����
        if(Physics.Raycast(transform.position, transform.forward, out hit, 8) )         // ���� ����� ��ü Ž��
        {
            Debug.Log(hit.collider.gameObject.name);
        }
        */

        //�浹�� ��� ��ü ����
        //����ĳ��Ʈ ������� ������ ������ ����(�迭)
        RaycastHit[] hits;
        hits = Physics.RaycastAll(transform.position, transform.forward, 8);
        /*
        foreach (RaycastHit hit in hits)
        {
            Debug.Log(hit.collider.gameObject.name);
        }
        */

        for(int i = 0; i < hits.Length; i++)
        {
            //Debug.Log(hits[i].collider.gameObject.name);
        }
    }
}