using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenDamage : MonoBehaviour
{
    public ChickenHeath ChickenHeathScript; //reference to chicken health script   

    public int damageValue; //creates a variable to carry the damage value

    // Start is called before the first frame update
    void Start()
    {
        ChickenHeathScript = GameObject.FindGameObjectWithTag("Chicken").GetComponent<ChickenHeath>(); //Gets Chicken Heath Script from Chicken
    }

    // 
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Chicken") //asking if fire and Chicken have collided
        {
            ChickenHeathScript.chickenCurrentHealth = ChickenHeathScript.chickenCurrentHealth - damageValue; //takes away damage value for current chicken health
            Debug.Log("The chickens current health is " + ChickenHeathScript.chickenCurrentHealth); //logs the current cicken health in console
        }
        else
        {
            Debug.Log("this in not the chicken"); //log if fire is colliding with something else
        }
    }

}