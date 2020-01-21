using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class GoToMainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("to main menu started");
        Screen.SetResolution(1280,720, false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {
            Debug.Log("Any key is pressed");
            SceneManager.LoadScene("MainMenu");
        }
    }
}

