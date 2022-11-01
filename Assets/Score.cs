using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Score : MonoBehaviour
{
    public GameObject chicken; //refrence to the chicken 
    public ChickenHut chickenHut; //refrence to the chicken huts script

    public int playerScore; //the players score is how many chickens have been saved
    private int valueScore = 1; //how many chickens (usually always 1)

    

    private void Start()
    {
        playerScore = 0; //makes player score zero at the start
    }

 
    void OnCollisionEnter(Collision collisionInfo) //When Chicken and Chicken Hut Collide
    {

        if (collisionInfo.collider.tag == "ChickenHut") //what happens when the chicken hut is colliding of the Chicken
        {
            Debug.Log("The Chicken is in range of the hut"); //logging if the chicken is in range of the hut
            chicken.SetActive(false); //hides the chicken from the player once the chicken goes to the hut
            playerScore = playerScore + valueScore; //player score is increased by one as one more chicken is saves
            Debug.Log("player score is now " + playerScore); //Logs player overall score in console

        }

    }
}
