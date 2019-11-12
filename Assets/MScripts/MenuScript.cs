using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public enum MenuStates { Main, Options, Gamemode, Display, Controls, Audio};
    public MenuStates currentState;

    //Menu panel objects
    public GameObject mainMenu;
    public GameObject gamemodeMenu;
    public GameObject optionMenu;
    public GameObject displayMenu;
    public GameObject controlsMenu;
    public GameObject audioMenu;

    //Awake is called before anything
    void Awake()
    {
        currentState = MenuStates.Main;
    }

    // Update is called once per frame
    void Update()
    {
        
            //Checks current menu state
            switch (currentState)
            {
                //Sets active gameObject for main menu

                //Main Menu
                case MenuStates.Main:
                    mainMenu.SetActive(true);
                    optionMenu.SetActive(false);
                    gamemodeMenu.SetActive(false);
                    displayMenu.SetActive(false);
                    controlsMenu.SetActive(false);
                    audioMenu.SetActive(false);
                    break;

                //Option Menu
                case MenuStates.Options:
                    optionMenu.SetActive(true);
                    mainMenu.SetActive(false);
                    gamemodeMenu.SetActive(false);  
                    displayMenu.SetActive(true);
                    controlsMenu.SetActive(false);
                    audioMenu.SetActive(false);
                    break; 

                //Gamemode Menu
                case MenuStates.Gamemode:
                    optionMenu.SetActive(false);
                    mainMenu.SetActive(false);
                    gamemodeMenu.SetActive(true);
                    displayMenu.SetActive(false);
                    controlsMenu.SetActive(false);
                    audioMenu.SetActive(false);
                    break;

            //Display Panel
            case MenuStates.Display:
                    optionMenu.SetActive(true);
                    mainMenu.SetActive(false);
                    gamemodeMenu.SetActive(false);
                    displayMenu.SetActive(true);
                    controlsMenu.SetActive(false);
                    audioMenu.SetActive(false);
                    break;

                //Control Panel
                case MenuStates.Controls:
                    optionMenu.SetActive(true);
                    mainMenu.SetActive(false);
                    gamemodeMenu.SetActive(false);
                    displayMenu.SetActive(false);
                    controlsMenu.SetActive(true);
                    audioMenu.SetActive(false);
                    break;

                //Audio Panel
                case MenuStates.Audio:
                    optionMenu.SetActive(true);
                    mainMenu.SetActive(false);
                    gamemodeMenu.SetActive(false);
                    displayMenu.SetActive(false);
                    controlsMenu.SetActive(false);
                    audioMenu.SetActive(true);
                    break;
            }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (currentState == MenuStates.Options || currentState == MenuStates.Display || currentState == MenuStates.Controls || currentState == MenuStates.Audio || currentState == MenuStates.Gamemode)
            {
                currentState = MenuStates.Main;
            }

        }

    }

    //Butons ===============================
    public void QuitGame()
    { 
        Application.Quit();
    }

    //Single Player Button 
    public void PlayGame()
    {
        currentState = MenuStates.Gamemode;
    }

    //Gamemode Buttons =====================

    //Versus Button
    public void VersusButton()
    {
        //Implement Versus Scene
    }

    //Story Button
    public void StoryButton()
    {
        //Implement Story Scene
    }

    //Trainging Button
    public void TrainingModeButton()
    {
        SceneManager.LoadScene(3);
    }

    //Option Buttons ======================
    public void OptionButton()
    {
        currentState = MenuStates.Options;
    }

    //Display Buttons
    public void DisplayButton()
    {
        currentState = MenuStates.Display;
    }


    //Audio Buttons
    public void AudioButton()
    {
        currentState = MenuStates.Audio;
    }

    //Control Buttons
    public void ControlsButton()
    {
        currentState = MenuStates.Controls;
    }


}


