using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenActivation : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) 
    {
        Debug.Log("Collition detected"); //logging if detection occuered 
    }
}
