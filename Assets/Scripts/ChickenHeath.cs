using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenHeath : MonoBehaviour
{
    public float chickenMaxHeath; //creates a variable to carry the chickens max health value
    public float chickenCurrentHealth; //creates a variable to carry the chickens current health value

    
    // Start is called before the first frame update
    void Start()
    {
        chickenCurrentHealth = chickenMaxHeath; // Starts game with current health equal to desired max health


    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
