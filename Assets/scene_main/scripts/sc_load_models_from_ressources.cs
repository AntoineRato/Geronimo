using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sc_load_models_from_ressources : MonoBehaviour
{
    public GameObject panel;
    public GameObject buttonPrefab;
    private GameObject[] list_objects;

	// Use this for initialization
	void Start ()
    {
        list_objects = Resources.LoadAll<GameObject>("3D_models/");
        foreach(GameObject model in list_objects)
        {
            GameObject button = (GameObject)Instantiate(buttonPrefab);
            button.GetComponentInChildren<Text>().text = model.name;
            button.transform.SetParent(panel.transform, false);
        }
	}
}
