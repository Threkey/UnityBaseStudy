using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsJump03 : MonoBehaviour
{
    public float speed;                                 // 점프속도
    private float initSpeed;                         //초기 속도
    private Vector3 initPos, curPos;          //초기 위치, 현재위치
    private bool isJump;                              //점프중인지 상태
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
        if (Input.GetMouseButtonDown(0) && !isJump)             // 점프중이 아닐 때 마우스 좌클릭하면 점프중으로 상태 바꿈
        {
            isJump = true;
        }
        if (isJump)                 //점프중이면
        {
            curPos.y += speed * Time.deltaTime;                             //속도만큼 위로 이동
            //this.transform.Translate(Vector3.up * speed * Time.deltaTime);
            speed = speed - 0.5f;                          //속도 감소
            if (curPos.y < initPos.y)                    // y값이 초기 y값보다 낮다면(착지했으면)
            {
                isJump=false;                                 //점프 상태를 점프중이 아님으로 바꿈
                speed = initSpeed;                         //속도를 초기속도로 바꿈
                curPos.y=initPos.y;                       //현재 위치의 y값을 초기위치로 바꿈(땅보다 아래 박혀있는 상황 방지)
            }
        }
        this.transform.position = curPos;         //현재위치 갱신
    }
}
