using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideMenu : MonoBehaviour
{
    public GameObject menu;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space")) //if spacebar is pressed
        {
            menu.SetActive(false); // Activate the Menu to be disapper
        }
    }
}
