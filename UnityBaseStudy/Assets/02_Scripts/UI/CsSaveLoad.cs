using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CsSaveLoad : MonoBehaviour
{
    GameObject btnSave, btnLoad, inputID, inputPassword;
    // Start is called before the first frame update
    void Start()
    {
        btnSave = GameObject.Find("Save");
        btnLoad = GameObject.Find("Load");
        inputID = GameObject.Find("ID");
        inputPassword = GameObject.Find("Password");

        btnSave.GetComponent<Button>().onClick.AddListener(Save);
        btnLoad.GetComponent<Button>().onClick.AddListener(Load);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Save()
    {
        PlayerPrefs.SetString("ID", inputID.GetComponent<InputField>().text);
        PlayerPrefs.SetString("Password", inputPassword.GetComponent<InputField>().text);
    }

    void Load()
    {
        if(PlayerPrefs.HasKey("ID"))
        {
            string loadID = PlayerPrefs.GetString("ID");
            inputID.GetComponent<InputField>().text = loadID;
        }
        if (PlayerPrefs.HasKey("Password"))
        {
            string loadPassword = PlayerPrefs.GetString("Password");
            inputPassword.GetComponent<InputField>().text = loadPassword;
        }
    }
}
