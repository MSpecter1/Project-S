using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pausePanel;
    private bool activePause;

    void Start()
    {
        pausePanel.SetActive(false);
        activePause = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (activePause == false && Input.GetKeyDown(KeyCode.Escape))
        {
            pausePanel.SetActive(true);
            Time.timeScale = 0;
            activePause = true;
        }
        else if (activePause == true && Input.GetKeyDown(KeyCode.Escape))
        {
            pausePanel.SetActive(false);
            Time.timeScale = 1;
            activePause = false;
        }
    }

    public void ReturnMain()
    {
        SceneManager.LoadScene(1);
    }

}
