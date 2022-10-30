using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingScript : MonoBehaviour
{
    [SerializeField] private GameObject bread; //refecnce to bread for chicken to follow
    [SerializeField] private float speed = 1; //how fast the chicken moves

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position,bread.transform.position,speed * Time.deltaTime); // Telling the Chicken to follow the bread
        Debug.Log("Chicken is now following the Bread"); //Shows in log when Chicken is following the bread
    }

}
