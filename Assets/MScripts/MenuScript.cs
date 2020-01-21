using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

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

    //Audio

    public AudioMixer mVolume;

    //Resolution Variables
    private int[] wid = { 720, 1024, 1280, 1366, 1440, 1600, 1920 };
    private int[] leng = { 480, 768, 720, 768, 900, 900, 1080 };
    private bool isFullscreen;

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

    //Menu Butons ==========================
    public void QuitGame()
    { 
        Application.Quit();
    }

    public void ToDevStage()
    {
        //MAKE SURE SCENE NAME IS CORRECT
        SceneManager.LoadScene("TestDevStage");
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

    //Set Resolution Dropdown
    public void setResolution(int val)
    {
        

        switch (val)
        {
            case 0:
                Screen.SetResolution(wid[0], leng[0], isFullscreen);
                break;
            case 1:
                Screen.SetResolution(wid[1], leng[1], isFullscreen);
                break;
            case 2:
                Screen.SetResolution(wid[2], leng[2], isFullscreen);
                break;
            case 3:
                Screen.SetResolution(wid[3], leng[3], isFullscreen);
                break;
            case 4:
                Screen.SetResolution(wid[4], leng[4], isFullscreen);
                break;
            case 5:
                Screen.SetResolution(wid[5], leng[5], isFullscreen);
                break;
            case 6:
                Screen.SetResolution(wid[6], leng[6], isFullscreen);
                break;
        }
    }

    //Set Display Mode Dropdown
    public void setDisplay(int val)
    {
        switch(val)
        {
            case 0:
                Screen.fullScreen = false;
                isFullscreen = false;
                break;
            case 1:
                Screen.fullScreen = true;
                isFullscreen = true;
                break;
            case 2:
                Screen.SetResolution(1920,1080, false);
                break;
        }
    }


    //Audio Buttons
    public void AudioButton()
    {
        currentState = MenuStates.Audio;
    }

    public void setVolume(float masterVolume)
    {
        mVolume.SetFloat("masterVolume", masterVolume);
    }

    //Control Buttons
    public void ControlsButton()
    {
        currentState = MenuStates.Controls;
    }
}


