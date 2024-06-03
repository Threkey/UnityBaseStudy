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


        //DrawRay, 레이캐스트가 보이게 설정(Gizmo)
        Debug.DrawRay(transform.position, transform.forward * 8, Color.red);
        /*
        //레이캐스트 결과값을 저장할 변수를 선언
        RaycastHit hit;
        //광선을 쏴서 충돌한 게임 오브젝트를 앞서 선언한 변수 hit에 저장
        if(Physics.Raycast(transform.position, transform.forward, out hit, 8) )         // 가장 가까운 물체 탐색
        {
            Debug.Log(hit.collider.gameObject.name);
        }
        */

        //충돌한 모든 물체 저장
        //레이캐스트 결과값을 저장할 변수를 선언(배열)
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