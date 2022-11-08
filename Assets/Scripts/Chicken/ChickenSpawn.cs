using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenSpawn : MonoBehaviour
{
    private Vector3 Min;
    private Vector3 Max;

    private float _xAxis;
    private float _zAxis; 

    private Vector3 _randomPosition;
    public bool _canInstantiate;

    private void Start()
    {
        SetRanges();
    }
    private void Update()
    {
        _xAxis = UnityEngine.Random.Range(Min.x, Max.x);
        _zAxis = UnityEngine.Random.Range(Min.z, Max.z);
        _randomPosition = new Vector3(_xAxis, 0, _zAxis);
    }
    //Here put the ranges where your object will appear, or put it in the inspector.
    private void SetRanges()
    {
        Min = new Vector3(30, 0, 30); // Minimum range for chicken to spawn
        Max = new Vector3(100, 0, 100); //Maxiumum range for chicken to spawn 
    }
    private void InstantiateRandomObjects()
    {
        if (_canInstantiate)
        {
            Instantiate(gameObject, _randomPosition, Quaternion.identity);
        }

    }
}
