using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenActivation : MonoBehaviour
{
    public FollowingScript followingScript; //refencing following script
   
    private void OnTriggerEnter(Collider other) //function what in range of the Chicken
    {
        if (other.tag == "Bread") //what happens when the Bread is in range of the Chicken
        {
            Debug.Log("The Chicken can smell the bread"); //logging if the chicken is in range of the bread
            followingScript.enabled = true; //enabling foll0w scrip for when the chicken is close to the bread it will now follow. 
        }

    }
    
}
