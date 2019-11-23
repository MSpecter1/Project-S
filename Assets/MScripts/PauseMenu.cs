using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject options;
    public GameObject displayMenu;
    public GameObject controlsMenu;
    public GameObject audioMenu;
    private bool activePause;

    public enum PauseStates { Display, Controls, Audio };
    public PauseStates currentState;

    //Audio
    public AudioMixer mVolume;

    //Resolution Variables
    private int[] wid = { 720, 1024, 1280, 1366, 1440, 1600, 1920 };
    private int[] leng = { 480, 768, 720, 768, 900, 900, 1080 };
    private bool isFullscreen;

    void Start()
    {
        options.SetActive(false);
        activePause = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (activePause == false && Input.GetKeyDown(KeyCode.Escape))
        {
            options.SetActive(true);
            Time.timeScale = 0;
            activePause = true;
        }
        else if (activePause == true && Input.GetKeyDown(KeyCode.Escape))
        {
            options.SetActive(false);
            Time.timeScale = 1;
            activePause = false;
        }

        //Checks current menu state
        switch (currentState)
        {
            //Display Panel
            case PauseStates.Display:
                displayMenu.SetActive(true);
                controlsMenu.SetActive(false);
                audioMenu.SetActive(false);
                break;

            //Control Panel
            case PauseStates.Controls:
                displayMenu.SetActive(false);
                controlsMenu.SetActive(true);
                audioMenu.SetActive(false);
                break;

            //Audio Panel
            case PauseStates.Audio:
                displayMenu.SetActive(false);
                controlsMenu.SetActive(false);
                audioMenu.SetActive(true);
                break;
        }

    }

    //Option Buttons ======================

    //Display Buttons
    public void DisplayButton()
    {
        currentState = PauseStates.Display;
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
        switch (val)
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
                Screen.SetResolution(1920, 1080, false);
                break;
        }
    }


    //Audio Buttons
    public void AudioButton()
    {
        currentState = PauseStates.Audio;
    }

    public void setVolume(float masterVolume)
    {
        mVolume.SetFloat("masterVolume", masterVolume);
    }

    //Control Buttons
    public void ControlsButton()
    {
        currentState = PauseStates.Controls;
    }

    public void ReturnMain()
    {
        SceneManager.LoadScene(1);
    }

}


