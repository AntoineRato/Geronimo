using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class sc_material_manager : MonoBehaviour
{
    static public Material selected_material;
    public GameObject materials_menu;
    public GameObject mainObject;

    private Renderer[] childrensMainObject;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void change_selected_material()
    {
        selected_material = Resources.Load("materials/" + EventSystem.current.currentSelectedGameObject.name, typeof(Material)) as Material;
        Debug.Log("selected material : " + selected_material);
        childrensMainObject = mainObject.GetComponentsInChildren<Renderer>();

        foreach(Renderer child in childrensMainObject)
        {
            var mats = new Material[child.materials.Length];
            for (var j = 0; j < child.materials.Length; j++)
            {
                mats[j] = selected_material;
            }
            child.materials = mats;
        }
    }

    public void display_materials_menu()
    {
        if (materials_menu.activeSelf)
            materials_menu.SetActive(false);
        else
            materials_menu.SetActive(true);
    }
}
