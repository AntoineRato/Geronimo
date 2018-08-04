using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sc_deactivate_AR_placement : MonoBehaviour
{
    public GameObject hitpoint;

	public void deactivate_hitpoint()
    {
        if (hitpoint.active)
        {
            hitpoint.SetActive(false);
            this.GetComponentInChildren<Text>().text = "Activate AR Move";
        }
        else
        {
            hitpoint.SetActive(true);
            this.GetComponentInChildren<Text>().text = "Deactivate AR Move";
        }
    }
}
