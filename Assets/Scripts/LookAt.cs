using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    [SerializeField] private Transform bread; //refernce to what chicken has to look at (Bread)


    // Update is called once per frame
    void Update()
    {
        transform.LookAt(bread); //code to make chicken look at the target (Bread)
        Debug.Log("Chicken is now looking at the Bread"); //Shows in log when Chicken is looking at the bread
    }
}

