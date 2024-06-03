using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CsAnim : MonoBehaviour
{
    Button btnSitIdle, btnJump, btnWalk;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

        btnSitIdle = GameObject.Find("ButtonSitIdle").GetComponent<Button>();
        btnJump = GameObject.Find("ButtonJump").GetComponent <Button>();
        btnWalk = GameObject.Find("ButtonWalk").GetComponent< Button>();

        btnSitIdle.onClick.AddListener(SitIdle);
        btnJump.onClick.AddListener(Jump);
        btnWalk.onClick.AddListener(Walk);
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    void SitIdle()
    {
        anim.SetInteger("aniStep", 1);
    }

    void Jump()
    {
        anim.SetInteger("aniStep", 2);
        //StartCoroutine("JumpReset");            //코루틴을 사용해서 점프 후 Idle로 이동
    }

    void Walk()
    {
        anim.SetInteger("aniStep", 3);
    }

    IEnumerator JumpReset()
    {
        yield return new WaitForSeconds(0.01f);
        anim.SetInteger("aniStep", 0);
    }
}