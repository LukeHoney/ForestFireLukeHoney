using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChickenHut : MonoBehaviour
{
    public GameObject chickenhut; //refrence to the chicken huts
    public GameObject chicken; //refrence to the chicken

    public GameObject[] chickens; //creating array to list Chickens

    public int playerScore; //creates a variable to carry the players score
    private int valueScore = 1; // how many chickens (usually always 1)

    public TMP_Text scoreText; //refrece to text that displays how many chickens are saved

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = playerScore.ToString(); //Show number of saved chickens at start of the game (0)
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = playerScore.ToString(); //update to keep checking how many chickens have been saved
    }

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
