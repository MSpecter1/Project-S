using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.Audio;

public class OptScript : MonoBehaviour
{
    public GameObject menuPanel;
    public GameObject controlPanel;
    public GameObject selectorBox;
    public GameObject cSelectorBox;
    public GameObject displaySelector;
    private Vector3 pos;
    private int displayBox = 0, vBarCount = 0, selectorCount = 0, num = 100, volCount = 10, cSelectorCount = 0;
    private bool isLeft = true;

    //VOLUME BARS
    public int volume = 100;
    public TextMeshProUGUI audioPercent;
    public AudioMixer MasterMix;

    public List<GameObject> vBars = new List<GameObject>(10);

    //Controls Menu Instance Variables =========================
    public List<TextMeshPro> inText = new List<TextMeshPro>(8);

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(false);
        controlPanel.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        //OPTIONS MENU =======================================================================================================================

        //EDIT CONTROLS HERE, THERE BEING WEIRD SO IM JUST MAKING IT WORK FOR NOW
        //Selector Box ==========================================================
        if (Input.GetKeyDown("down") && this.gameObject.activeSelf && controlPanel.gameObject.activeSelf == false) //Move selector down
        {
            selectorCount++;
            //Debug.Log(selectorCount);
            if (selectorCount == 4)
            {
                selectorBox.transform.localPosition = new Vector3(25, 100, 0);
                selectorCount = 0;
                num = 100;
            }
            else
            {
                selectorBox.transform.localPosition = new Vector3(25, (num -= 75), 0);
            }
        }

        if (Input.GetKeyDown("up") && this.gameObject.activeSelf && controlPanel.gameObject.activeSelf == false) //Move selector up
        {
            selectorCount--;
            //Debug.Log(selectorCount);
            if (selectorCount == -1)
            {
                selectorBox.transform.localPosition = new Vector3(25, -125, 0);
                selectorCount = 3;
                num = -125;
            }

            else
            {
                selectorBox.transform.localPosition = new Vector3(25, (num += 75), 0);
            }
        }

        //Display Control ============================================================

        if (Input.GetKeyDown(KeyCode.RightArrow) && displayBox == 0 && selectorCount == 0)
        {
            displayBox++;
            displaySelector.transform.localPosition = new Vector3(500, 0, 0);
            Screen.fullScreen = true;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) && displayBox == 1 && selectorCount == 0)
        {
            displayBox--;
            displaySelector.transform.localPosition = new Vector3(250, 0, 0);
            Screen.fullScreen = false;
        }

        //Audio Control ===============================================================
        if (Input.GetKeyDown(KeyCode.RightArrow) && selectorCount == 1) //Move right
        {
            if (volCount < 10)
            {
                if (volCount == 0)
                {
                    vBars[volCount].SetActive(true);
                    volCount++;
                    raiseVol();
                }

                else
                {
                    vBars[volCount].SetActive(true);
                    volCount++;
                    raiseVol();
                }
            }  
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) && selectorCount == 1) //Move left
        {
            if (volCount > 0)
            {
                volCount--;
                vBars[volCount].SetActive(false);
                lowerVol();
            }
        }

        //Go to Control Menu
        if ((Input.GetKeyDown(KeyCode.Return) && selectorCount == 2))
        {
            resetOptionMenu();
            resetControlMenu();
            controlPanel.gameObject.SetActive(true);

        
        }

        //Return To MENU
        if ((Input.GetKeyDown(KeyCode.Return) && selectorCount == 3) || ((Input.GetKeyDown(KeyCode.Escape) && controlPanel.gameObject.activeSelf == false)) && this.gameObject.activeSelf)
        {

            resetOptionMenu();
            this.gameObject.SetActive(false);
            menuPanel.gameObject.SetActive(true);
        }



        //CONTROL MENU ===============================================================================================================================

        //Selector Box ==========================================================
        //Debug.Log(cSelectorCount);
        if (Input.GetKeyDown("down") && controlPanel.gameObject.activeSelf) //Move selector down
        {
            cSelectorCount++;
            if (cSelectorCount == 6) //to the top
            {
                cSelectorBox.gameObject.transform.localPosition = new Vector3(-100, 140, 0);
                cSelectorCount = 0;
            }

            else if (cSelectorCount == 5)
            {
                cSelectorBox.gameObject.transform.localPosition = new Vector3(0, -140, 0);
                cSelectorCount = 5;
            }

            else if (cSelectorCount == 13)
            {
                cSelectorBox.gameObject.transform.localPosition = new Vector3(0, -140, 0);
                cSelectorCount = 5;
            }

            else
            {
                cSelectorBox.gameObject.transform.localPosition = new Vector3(cSelectorBox.gameObject.transform.localPosition.x, (cSelectorBox.gameObject.transform.localPosition.y - 50), 0);
            }
        }

        if (Input.GetKeyDown("up") && controlPanel.gameObject.activeSelf) //Move selector up
        {
            cSelectorCount--;
            if (cSelectorCount == -1) //to the bottom
            {
                cSelectorBox.gameObject.transform.localPosition = new Vector3(0, -140, 0);
                cSelectorCount = 5;
            }

            else if (cSelectorCount == 4)
            {
                cSelectorBox.gameObject.transform.localPosition = new Vector3(-100, -60, 0);
            }

            else if (cSelectorCount == 7)
            {
                cSelectorBox.gameObject.transform.localPosition = new Vector3(0, -140, 0);
                cSelectorCount = 5;
            }

            else
            {
                cSelectorBox.gameObject.transform.localPosition = new Vector3(cSelectorBox.gameObject.transform.localPosition.x, (cSelectorBox.gameObject.transform.localPosition.y + 50), 0);
            }
        }

        if (Input.GetKeyDown("right") && controlPanel.gameObject.activeSelf && cSelectorCount != 5 && isLeft == true) //Move selector right
        {
            isLeft = false;
            cSelectorCount += 8;
            cSelectorBox.gameObject.transform.localPosition = new Vector3(300, cSelectorBox.gameObject.transform.localPosition.y, 0);
        }

        if (Input.GetKeyDown("left") && controlPanel.gameObject.activeSelf && cSelectorCount != 5 && isLeft == false) //Move selector left
        {
            isLeft = true;
            cSelectorCount -= 8;
            cSelectorBox.gameObject.transform.localPosition = new Vector3(-100, cSelectorBox.gameObject.transform.localPosition.y, 0);
        }

        //Catch ALL for input error
        if(cSelectorCount > 13 || cSelectorCount < -1) 
        {
            cSelectorBox.gameObject.transform.localPosition = new Vector3(-100, 140, 0);
            cSelectorCount = 0;
        }

        //Go back to options
        if((Input.GetKeyDown(KeyCode.Return) && (cSelectorCount == 5)) || (Input.GetKeyDown(KeyCode.Escape) && controlPanel.activeSelf)) 
        {

            controlPanel.gameObject.SetActive(false);
            
            resetOptionMenu();
            resetControlMenu();
        }

    }


    //Accessors, mutators, resets
    void raiseVol()
    {
        volume+=10;
        string volumeText = volume.ToString();
        audioPercent.SetText(volumeText);
        MasterMix.SetFloat("volumeMaster", volume - 80);
    }

    void lowerVol()
    {
        volume-=10;
        string volumeText = volume.ToString();
        audioPercent.SetText(volumeText);
        MasterMix.SetFloat("volumeMaster", volume - 80);
    }

    void resetControlMenu()
    {
        cSelectorCount = 0;
        cSelectorBox.gameObject.transform.localPosition = new Vector3(-100, 140, 0);
    }

    void resetOptionMenu()
    {
        selectorBox.transform.localPosition = new Vector3(25, 100, 0);
        selectorCount = 0;
        num = 100;
    }

}
