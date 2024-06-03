using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsAudioSource : MonoBehaviour
{
    AudioSource audS;
    // Start is called before the first frame update
    void Start()
    {
        audS = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    { 
        audS.Play();
    }
}