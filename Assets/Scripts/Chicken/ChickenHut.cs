using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenHut : MonoBehaviour
{
    public GameObject chickenhut; //refrence to the chicken huts
    public GameObject chicken; //refrence to the chicken


    public GameObject[] chickens; //creating array to list Chickens

    public int playerScore; //creates a variable to carry the players score
    private int valueScore = 1; // how many chickens (usually always 1)


    private void OnTriggerEnter(Collider other) 
    {
        // Debug.LogWarning("trigger detected"); //logging if any collisions are detected
        if(other.tag == "Chicken") //looking for game object with Chicken tag
        {
            // Debug.LogError("chicken trigger detected"); //logging if any collisions with Chicken tag object
            GameObject chickenInHut = other.gameObject; //if the chicken collides with the chicken hut
            playerScore = playerScore + valueScore; //Player score is increased by one as one more chicken is saved
            chickenInHut.SetActive(false); // Deactivate the chicken to hide it from the scene
        }
    }

}
