using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenLocation : MonoBehaviour
{
    public GameObject chicken;

    // Start is called before the first frame update
    void Start()
    {
        //int randomIndex = Random.Range(0, chicken.Length);
        Vector3 randomSpawnPosition = new Vector3(Random.Range(30, 120), 0, Random.Range(30, 120));

        //Instantiate(chicken[randomIndex], randomSpawnPosition, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
