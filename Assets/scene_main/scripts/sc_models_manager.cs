using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class sc_models_manager : MonoBehaviour
{
    public GameObject models_menu;

    private GameObject mainObject;
    private GameObject modelToLoad;

    // Use this for initialization
    void Start()
    {
        //var client = new WebClient();
        //client.DownloadFile("http://juicestudio.eu/iphone.fbx", "./Assets/Resources/3D_models/iphone.fbx");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void load_model()
    {
        mainObject = GameObject.Find("MainObject");
        modelToLoad = Resources.Load("3D_models/" + EventSystem.current.currentSelectedGameObject.GetComponentInChildren<Text>().text + "/" + EventSystem.current.currentSelectedGameObject.GetComponentInChildren<Text>().text, typeof(GameObject)) as GameObject;

        if(modelToLoad == null)
        {
            modelToLoad = Resources.Load("3D_models/" + EventSystem.current.currentSelectedGameObject.GetComponentInChildren<Text>().text, typeof(GameObject)) as GameObject;
        }

        foreach (Transform childObject in mainObject.transform)
        {
            Destroy(childObject.gameObject);
        }

        GameObject newModel = Instantiate(modelToLoad);
        newModel.transform.SetParent(mainObject.transform, false);
    }

    public void display_models_menu()
    {
        if (models_menu.activeSelf)
            models_menu.SetActive(false);
        else
            models_menu.SetActive(true);
    }

}
