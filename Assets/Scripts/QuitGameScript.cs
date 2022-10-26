using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class QuitGameScript : MonoBehaviour
{
    void QuitGame() //Create a quit function
    {
        Application.Quit(); // Quiting Script
        Debug.Log("Game is exiting"); //Shows quitting action in console
        
    }
}
