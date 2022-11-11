using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBoard : MonoBehaviour
{
    public static int playerScore;

    private void OnGUI()
    {
        GUI.Box(new Rect(100, 100, 200, 100), "Chickens Saved: " + playerScore.ToString()); //Creates a retangler display for the user to see how many chickens they have saved
    }
}
