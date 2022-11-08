using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowLook : MonoBehaviour
{
    [SerializeField] //Refrence for direction of arrow
    private Transform m_Target;
    public Transform LookAtTarget { get { return m_Target; } }

    [SerializeField] //Refrence for spinning of arrow
    private Transform m_Spinner; 
    public Transform Spinner { get { return m_Spinner; } }

    [SerializeField] //Refrence for size of arrow
    private Transform m_Scaler;
    public Transform Scaler { get { return m_Scaler; } }

    public float speed; //public float for the speed

    public GameObject chicken; //refrence to chickens
    public GameObject chicken2;
    public GameObject chicken3;

    public void SetTarget(Transform target = null)
    {
        m_Target = target;
    }

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(false); //
    }

    // Update is called once per frame
    void Update()
    {
        if (LookAtTarget) //if a target is avalable
            transform.LookAt(LookAtTarget); //arrow to direct at target

        if (Spinner) //if arrow is spinning
            Spinner.transform.Rotate(0, 0, speed * Time.deltaTime); //spin the arrow at desired speed per real life time


        //if (GameObject.activeInHierarchy = true)
        { 
        
        }
            //if chicken is isActiveAndEnabled then set as target
        //else if chicken2 is isActiveAndEnabled then set as target
        //else if chicken3 is isActiveAndEnabled then set as target
    }




}
