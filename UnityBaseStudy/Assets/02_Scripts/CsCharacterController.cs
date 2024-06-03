using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsCharacterController : MonoBehaviour
{
    public float movSpeed, rotSpeed, initJumpSpeed, curJumpSpeed;
    private CharacterController cc;
    private float v, h, gravity;
    private Vector3 dir;
    private bool isJump;
    // Start is called before the first frame update
    void Start()
    {
        movSpeed = 5f;
        rotSpeed = 1f;
        initJumpSpeed = 50f;
        curJumpSpeed = initJumpSpeed;
        gravity = -30f;
        cc = GetComponent<CharacterController>();
        dir = Vector3.zero;
        isJump = false;
    }

    // Update is called once per frame
    void Update()
    {

        v = Input.GetAxis("Vertical");
        h = Input.GetAxis("Horizontal");
        //dir = Vector3.forward * speed + Vector3.right * speed;

        dir.y = h;
        //transform.TransformDirection()

        if(!cc.isGrounded)
        {
            cc.Move(transform.up * gravity * Time.deltaTime);
        }

        if(cc.isGrounded && Input.GetButtonDown("Jump"))
        {
            isJump = true;
        }

        if (isJump)
        {
            cc.Move(transform.up * curJumpSpeed * Time.deltaTime);
            curJumpSpeed -= 0.5f;

            if(cc.isGrounded )
            {
                isJump=false;
                curJumpSpeed = initJumpSpeed;
            }
        }

        if (v != 0f || h != 0f)
        {
            cc.Move(transform.forward * v * movSpeed * Time.deltaTime);
            //cc.Move(transform.right * h);

            transform.Rotate(dir * rotSpeed);
        }
    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.collider.gameObject.tag == "Slope")
        {
            Debug.Log("Ãæµ¹"); 
        }
    }
}