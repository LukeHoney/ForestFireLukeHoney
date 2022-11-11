using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenActivation : MonoBehaviour
{
    public FollowingScript followingScript; //refencing the following script
   
    private void OnTriggerEnter(Collider other) //function what in range of the Chicken
    {
        if (other.tag == "Player") //what happens when the Player is in range of the Chicken
        {
            //Debug.Log("The Chicken is in range of the bread"); //logging if the chicken is in range of the bread
            followingScript.enabled = true; //enabling follow scrip for when the chicken is close to the bread it will now follow. 
        }

    }
    
}
