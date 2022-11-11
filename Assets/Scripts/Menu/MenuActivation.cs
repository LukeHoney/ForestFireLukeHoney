using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MenuActivation : MonoBehaviour
{
    public InputActionReference pauseMenuAction; //Refrence to button mapping on the oculus controller

    public GameObject pauseMenu; //refrence to the game object

    public bool isPaused; //refrence to if the game is paused or not

    // Start is called before the first frame update
    private void Start()
    {
        pauseMenu.SetActive(true); //at the start of the game the pause menu is up
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space")) //if spacebar is pressed
        {
            pauseMenu.SetActive(false); // Activate the Menu to be disapper

            //Debug.Log("Space bar was pressed");
        }

        if (pauseMenuAction.action.IsPressed()) //if selected buttons are pressed
        {
            //Debug.Log("menu button is pressed"); //debug to see if menu button is pressed
            
            if (isPaused) //if the game is currently paused
            {
                ResumeGame(); //Do Resumegame method
                //Debug.Log("Game was Resumed");
            }
            else //if the game is currently playing
            {
             PauseGame(); //Do Pause Method
                //Debug.Log("Game was Paused");
            }

        }
      
    }
    
    public void PauseGame() //Method of pauseing game
    {
        pauseMenu.SetActive(true); //when the pause menu is up
        Time.timeScale = 0f; //pauses the game in background
        isPaused = true; //change state of bool to pause mode
        AudioListener.pause = true; //Pauses audio of game
    }

    public void ResumeGame() //Method of resuming game
    {
        pauseMenu.SetActive(false); //when the pause menu is not open
        Time.timeScale = 1f; //the game will play
        isPaused = false; //change state of bool to play mode
        AudioListener.pause = false; //Resumes audio of game
    }
}