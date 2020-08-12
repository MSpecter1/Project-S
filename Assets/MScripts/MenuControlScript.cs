using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControlScript : MonoBehaviour
{
    public GameObject optionMenu;
    public GameObject mainMenu;
    public GameObject sBox;

    public List<SpriteRenderer> Scroll = new List<SpriteRenderer>(4);
    //private List<Color> vis = new List<Color>(4);

    private float[] visState = { 1f, .5f, 0 };
    private float speed = 10;
    private int selCount = 0;

    private Vector3 targetPos;

    // Start is called before the first frame update
    void Start()
    {
        resetMenu();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 downTar, upTar; 
        downTar = new Vector3 ((sBox.gameObject.transform.localPosition.x + 25), (sBox.gameObject.transform.localPosition.y - 200), 0);
        upTar = new Vector3 ((sBox.gameObject.transform.localPosition.x - 25), (sBox.gameObject.transform.localPosition.y + 50), 0);
        Vector3 curr = (sBox.gameObject.transform.localPosition);

        //TOP = -300, 0;
        //Bottom = -225, -150;
        if (mainMenu.activeSelf)
        {
            if (Input.GetKeyDown("down")) //Move selector down
            {
                if (sBox.gameObject.transform.localPosition.y == -150)
                {
                    sBox.gameObject.transform.localPosition = new Vector3(-300, 0, 0);
                    selCount = 0;
                }

                else
                {
                    sBox.gameObject.transform.localPosition = new Vector3(-300, (sBox.gameObject.transform.localPosition.y - 50), 0);
                    selCount++;
                }
            }

            if (Input.GetKeyDown("up")) //Move selector up
            {

                if (sBox.gameObject.transform.localPosition.y == 0)
                {
                    sBox.gameObject.transform.localPosition = new Vector3(-300, -150, 0);
                    selCount = 3;
                }

                else
                {
                    sBox.gameObject.transform.localPosition = new Vector3(-300, (sBox.gameObject.transform.localPosition.y + 50), 0);
                    selCount--;
                }
            }

            if (Input.GetKeyDown(KeyCode.Return))
            {
                if (selCount == 0) //Versus
                {
                    versusButton();
                }

                else if (selCount == 1) //Arcade
                {
                    arcadeButton();
                }

                else if (selCount == 2) //Options
                {
                    optionButton();
                }

                else if (selCount == 3) //Quit
                {
                    quitButton();
                }
            }
        }

        if(!mainMenu.activeSelf)
        {
            resetMenu();
        }
    }

    public void versusButton()
    {
        SceneManager.LoadScene("TheGridTestCharLoader");
    }

    public void arcadeButton()
    {
        //ADD THIS LATER
        //SceneManager.LoadScene("TheGridTestCharLoader");
    }

    public void optionButton()
    {
        mainMenu.SetActive(false);
        optionMenu.SetActive(true);
        
        
    }

    public void quitButton()
    {
        Application.Quit();
    }

    public void resetMenu()
    {
        selCount = 0;
        sBox.gameObject.transform.localPosition = new Vector3(-300, 0, 0);
    }
}



/*
       //Button selector ==========================================

       //DOWN
       if (Input.GetKeyDown("down")) //Move selector down
       {
           Debug.Log("Test");
           for (int i = 0; i < Scroll.Count; i++)
           {

               Vector3 currPos = Scroll[i].gameObject.transform.localPosition;
               targetPos = new Vector3 (-300, (Scroll[i].gameObject.transform.localPosition.y - 75), 0);

               if (Scroll[i].gameObject.transform.localPosition.y == -200) //Out of frame down
               {
                   Scroll[i].gameObject.transform.localPosition = new Vector3(-300, 100, 0);
                   Scroll[i].gameObject.transform.localPosition = Vector3.MoveTowards(currPos, targetPos, Time.deltaTime * speed);
                   Scroll[i].color = new Color(1f, 1f, 1f, .5f);
               }

               else if (Scroll[i].gameObject.transform.localPosition.y == 25) //1 before or after middle
               {
                   Scroll[i].gameObject.transform.localPosition = Vector3.MoveTowards(currPos, targetPos, Time.deltaTime * speed);
                   Scroll[i].color = new Color(1f, 1f, 1f, 1f);
               }

               else if(Scroll[i].gameObject.transform.localPosition.y == -125) //1 before or after middle
               {
                   Scroll[i].gameObject.transform.localPosition = Vector3.MoveTowards(currPos, targetPos, Time.deltaTime * speed);
                   Scroll[i].color = new Color(1f, 1f, 1f, 0f);
               }

               else if(Scroll[i].gameObject.transform.localPosition.y == -50) //Middle
               {
                   Scroll[i].gameObject.transform.localPosition = Vector3.MoveTowards(currPos, targetPos, Time.deltaTime * speed);
                   Scroll[i].color = new Color(1f, 1f, 1f, .5f);
               }

               else if (Scroll[i].gameObject.transform.localPosition.y == 100) //Out of frame up
               {
                   Scroll[i].gameObject.transform.localPosition = Vector3.MoveTowards(currPos, targetPos, Time.deltaTime * speed);
                   Scroll[i].color = new Color(1f, 1f, 1f, .5f);
               }
               //Vector3.MoveTowards(transform.position, target.position, step);
           }
       }

       //UP
       if (Input.GetKeyDown("up")) //Move selector up
       {
           Debug.Log("Test");
           for (int i = 0; i < Scroll.Count; i++)
           {

               Vector3 currPos = Scroll[i].gameObject.transform.localPosition;
               targetPos = new Vector3(-300, (Scroll[i].gameObject.transform.localPosition.y + 75), 0);

               if (Scroll[i].gameObject.transform.localPosition.y == 100) //Out of frame up
               {
                   Scroll[i].gameObject.transform.localPosition = new Vector3(-300, -200, 0);
                   Scroll[i].gameObject.transform.localPosition = Vector3.MoveTowards(currPos, targetPos, Time.deltaTime * speed);
                   Scroll[i].color = new Color(1f, 1f, 1f, .5f);
               }

               else if (Scroll[i].gameObject.transform.localPosition.y == 25) //1 before or after middle
               {
                   Scroll[i].gameObject.transform.localPosition = Vector3.MoveTowards(currPos, targetPos, Time.deltaTime * speed);
                   Scroll[i].color = new Color(1f, 1f, 1f, 0f);
               }

               else if(Scroll[i].gameObject.transform.localPosition.y == -125) //1 before or after middle
               {
                   Scroll[i].gameObject.transform.localPosition = Vector3.MoveTowards(currPos, targetPos, Time.deltaTime * speed);
                   Scroll[i].color = new Color(1f, 1f, 1f, 1f);
               }

               else if (Scroll[i].gameObject.transform.localPosition.y == -50)//Middle
               {
                   Scroll[i].gameObject.transform.localPosition = Vector3.MoveTowards(currPos, targetPos, Time.deltaTime * speed);
                   Scroll[i].color = new Color(1f, 1f, 1f, .5f);
               }

               else if (Scroll[i].gameObject.transform.localPosition.y == -200) //Middle
               {
                   Scroll[i].gameObject.transform.localPosition = Vector3.MoveTowards(currPos, targetPos, Time.deltaTime * speed);
                   Scroll[i].color = new Color(1f, 1f, 1f, .5f);
               }
           }
       }*/
