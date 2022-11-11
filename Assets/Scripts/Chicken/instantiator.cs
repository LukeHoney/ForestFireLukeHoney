using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiator : MonoBehaviour
{
    public GameObject[] spawnPoints; //Array of world postions for spawn point

    public GameObject Chicken; //Refrence to Chicken 
    public GameObject Chicken1; //Refrence to Second Chicken
    public GameObject Chicken2; //Refrence to Third Chicken 

    public int spawnNumberChicken; //refrence to random number generated for first chicken
    public int spawnNumberChicken1; //refrence to random number generated for second chicken
    public int spawnNumberChicken2; //refrence to random number generated for third chicken

    // Start is called before the first frame update
    void Start()
    {
        
        spawnPoints = GameObject.FindGameObjectsWithTag("Spawn"); // Finds all game objects with the tag 'spawn' to add to array

        spawnNumberChicken = UnityEngine.Random.Range (0, spawnPoints.Length); //Using a random number generator chooses an array number from list for first chicken
        spawnNumberChicken1 = UnityEngine.Random.Range(0, spawnPoints.Length); //Using a random number generator chooses an array number from list for second chicken
        spawnNumberChicken2 = UnityEngine.Random.Range(0, spawnPoints.Length); //Using a random number generator chooses an array number from list for third chicken

        Instantiate(Chicken,spawnPoints[spawnNumberChicken].transform.position, Quaternion.identity); //moves chicken to location of randomly chosen array
        Instantiate(Chicken1,spawnPoints[spawnNumberChicken1].transform.position, Quaternion.identity); //moves chicken1 to location of randomly chosen array
        Instantiate(Chicken2, spawnPoints[spawnNumberChicken2].transform.position, Quaternion.identity); //moves chicken2 to location of randomly chosen array

    }

}
