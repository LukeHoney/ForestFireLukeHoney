using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class SetTeleportation : MonoBehaviour
{
    public TeleportationProvider teleportation;

    
    public void SetTypeFromIndex(int index)
    {
        if (index == 0)
        {
            teleportation.enabled = false;
            Debug.Log("Teleportaion Off");
        }
        else if (index == 1)
        {
            teleportation.enabled = true;
        }
    }
}
