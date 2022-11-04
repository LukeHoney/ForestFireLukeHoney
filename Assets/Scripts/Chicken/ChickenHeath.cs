using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenHeath : MonoBehaviour
{
    public int chickenMaxHeath = 5; //creates a variable to carry the chickens max health value
    public int chickenCurrentHealth; //creates a variable to carry the chickens current health value

    public GameObject chicken; //Refrence to the chicken as a game object

    //public HealthBarScript healthBarScript; //Refrence to healthbar script

    // Start is called before the first frame update
    void Start()
    {
        chickenCurrentHealth = chickenMaxHeath; // Starts game with current health equal to desired max health
        //healthBarScript.SetMaxHealth(chickenMaxHeath); //Sets the health bar to match max health at start
    }

    // Update is called once per frame
    void Update()
    {
        if (chickenCurrentHealth == 0) //If the chickens health hits 0 
        {
            chicken.SetActive(false); //Deactivate the chicken to hide it from the scene
            //Debug.Log("Chicken is dead");
        }

    }

    //void Healthbar(int damage)
    //{
        //healthBarScript.SetHealth(chickenCurrentHealth); //Sets the health bar to match current health
    //}

}
