using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsRotateAnim : MonoBehaviour
{
    public Material mat1, mat2;
    // Start is called before the first frame update


    public void FrontImage()
    {
        GetComponent<Renderer>().material = mat1;
    }

    public void BackImage()
    {

        GetComponent<Renderer>().material = mat2;
    }
}
