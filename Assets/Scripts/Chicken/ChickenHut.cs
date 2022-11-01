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
        // Debug.LogWarning("trigger detected"); //
        if(other.tag == "Chicken")
        {
            Debug.LogError("chicken trigger detected");
            GameObject chickenInHut = other.gameObject;
            playerScore = playerScore + valueScore; //Player score is increased by one as one more chicken is saves
            chickenInHut.SetActive(false); // Deactivate 
        }
    }

}
