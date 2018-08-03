using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.UI;

public class sc_load_model_from_server : MonoBehaviour
{
    public Text URL;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void load_model_from_server()
    {
        var client = new WebClient();
        client.DownloadFile(URL.text, "./Assets/Resources/3D_models/iphone.fbx");
    }
}
