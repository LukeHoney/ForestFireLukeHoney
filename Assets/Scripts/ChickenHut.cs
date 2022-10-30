using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenHut : MonoBehaviour
{
    
    void OnCollisionEnter (Collision collisionInfo) //When Chicken and Chicken Hut Collide
    {
        
        if (collisionInfo.collider.tag == "ChickenHut") //what happens when the chicken hut is in range of the Chicken
        {
            Debug.Log("The Chicken is in range of the hut"); //logging if the chicken is in range of the hut
        }
            
        

    }
}
