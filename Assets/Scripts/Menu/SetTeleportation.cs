using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class SetTeleportation : MonoBehaviour
{
    public TeleportationProvider teleportation; //refrence to teleportaion provider

    public void SetTypeFromIndex(int index) //method for turning teleportaion on or off
    {
        if (index == 0) //if yes is selected
        {
            teleportation.enabled = true; //turn on the teleportaion provider
            //Debug.Log("Teleportaion on");
        }
        else if (index == 1) //if no is selected
        {
            teleportation.enabled = false; //turn off the teleportaion provider
            //Debug.Log("Teleportaion Off");
        }
    }
}
