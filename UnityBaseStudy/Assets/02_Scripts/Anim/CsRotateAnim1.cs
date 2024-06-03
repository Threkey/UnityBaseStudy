using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsRotateAnim1 : MonoBehaviour
{
    public Material mat1, mat2;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseUp()
    {
        StartCoroutine("coAnim");
    }

    public void FrontImage()
    {
        GetComponent<Renderer>().material = mat1;
    }

    public void BackImage()
    {

        GetComponent<Renderer>().material = mat2;
    }

    IEnumerator coAnim()
    {
        anim.SetInteger("play", 1);
        yield return new WaitForSeconds(1f);
        anim.SetInteger("play", 0);
    }
}
