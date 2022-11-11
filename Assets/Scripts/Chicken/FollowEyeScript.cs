using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowEyeScript : MonoBehaviour
{
    public Transform bread; //refrence to bread location

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(bread.position.x, 0.3f, bread.position.z); //go towards just above the floor level of the bread
    }
}
