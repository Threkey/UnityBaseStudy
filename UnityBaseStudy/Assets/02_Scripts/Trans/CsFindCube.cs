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
        timeNow = Time.time;            // 현재시간 업데이트
        if (Input.GetMouseButtonDown(0))            // 마우스가 클릭되면
        {
            //count = 0;                                                   // 카운트 초기화
            timeEnd = timeNow + timeInterval;        // 회전이 끝나는 시간 초기화
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);            // 마우스 위치에 있는 것 선택
            RaycastHit hit;                                           // 선택된 오브젝트 정보
            if (Physics.Raycast(ray, out hit))              // 선택되면
            {
                if (hit.collider.tag == "Cube")                // 선택된 오브젝트의 태그가 "Cube"이면
                {
                    go = hit.collider.gameObject;            // go에 선택된 오브젝트 대입
                }
            }
        }

        //if (go != null && count <= maxCount)     // 시간을 count로 측정
        if(go != null && timeNow <= timeEnd)        // 시간을 Time.time으로 측정
        {
            go.GetComponent<CsTurn>().TurnObject();
            count++;
        }
    }
}
