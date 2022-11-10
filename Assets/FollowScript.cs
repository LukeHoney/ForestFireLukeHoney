using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowScript : MonoBehaviour
{
    public Transform bread; //refrence to bread location

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(bread.position.x, 0, bread.position.z); //go towards floor level of breads location
    }
}
