using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RoundManager : MonoBehaviour
{
    public TextMeshProUGUI roundTimer;
    public TextMeshProUGUI announcerText;

    public float defaultRoundTime = 99;
    public float timeLeft = 99;
    public string roundWinner="NotSet1";
    public int P1WonRounds = 0;
    public int P2WonRounds = 0;
    public int currentRound = 0;
    public int maxRound = 2; //ROUNDS NEEDED TO WIN

    public CharHPManager P1HP;
    public CharHPManager P2HP;
    public CharStateManager P1StateManager;
    public CharStateManager P2StateManager;

    public GameObject fadeanimator;
    public GameObject canvas;
    public GameObject P1CounterGroup;
    public GameObject P2CounterGroup;
    public GameObject WinCounter;

    public bool P1Dead = false;
    public bool P2Dead = false;
    public bool timerActive = false;

    public bool debugMode = false;


    void Start()
    {
        //SET VARIABLES
        P1HP = GameObject.Find("P1Char").GetComponent<CharHPManager>();
        P2HP = GameObject.Find("P2Char").GetComponent<CharHPManager>();
        P1StateManager = GameObject.Find("P1Char").GetComponent<CharStateManager>();
        P2StateManager = GameObject.Find("P2Char").GetComponent<CharStateManager>();
        fadeanimator = GameObject.Find("FadeTransition");
        //INITIALIZE SETTINGS
        announcerText.gameObject.SetActive(false);
        currentRound = 0; //set to first round

        if (!debugMode) //DEBUG PURPOSES ONLY, DISABLES TIMER/FADEIN/ROUNDSTART
        {
            newRound();
        }
        //newRound();
    }

    void FixedUpdate()
    {
        //UPDATE VARIABLES
        roundTimer.text = "" + (int)timeLeft;
        if (timerActive)
        { 
            timeLeft -= Time.deltaTime;
        }
        if (timeLeft <= 0 && timerActive) //if timer runs out
        {
            if (P1HP.CharHP == P2HP.CharHP)
            {
                P1WonRounds++;
                P2WonRounds++;
                AddWinCounter("draw");
                roundWinner = "DRAW";
            }
            else if (P1HP.CharHP < P2HP.CharHP)
            {
                roundWinner = "P2";
                P2WonRounds++;
                AddWinCounter("P2");
                //IMPLEMENT ROUND WIN INDICATOR
            }
            else if (P1HP.CharHP > P2HP.CharHP)
            {
                roundWinner = "P1";
                P1WonRounds++;
                AddWinCounter("P1");
            }
            endRound();
        }
        else if ((P1Dead||P2Dead) && timerActive) //if someone loses , will calculate if match is won at endround()
        {
            if (P1Dead && P2Dead)
            {
                P1WonRounds++;
                P2WonRounds++;
                AddWinCounter("draw");
                roundWinner = "DRAW";
            }
            else if (P1Dead)
            {
                roundWinner = "P2";
                P2WonRounds++;
                AddWinCounter("P2");
                //IMPLEMENT ROUND WIN INDICATOR
            }
            else if (P2Dead)
            {
                roundWinner = "P1";
                P1WonRounds++;
                AddWinCounter("P1");
            }
            endRound();
        }
        
    }

    void newRound()
    {
        timeLeft = defaultRoundTime;
        currentRound++;
        StartCoroutine(StartRound());
    }

    void endRound()
    {
        timerActive = false;
        //CHECK IF MATCH HAS BEEN WON
        if (P1WonRounds == maxRound && P1WonRounds==P2WonRounds)
        {
            StartCoroutine(MatchWon("DRAW"));
        }
        else if (P1WonRounds==maxRound)
        {
            Debug.Log(P1WonRounds);
            StartCoroutine(MatchWon("P1"));
        }
        else if (P2WonRounds == maxRound)
        {
            StartCoroutine(MatchWon("P2"));
        }
        else
        {
            StartCoroutine(EndRound());
        }
    }

    public void AddWinCounter(string winner) //ONLY WORKS AFTER ADDING TO WONROUNDS VARIABLE - NOT BEFORE
    {
        if (winner == "P1")
        {
            GameObject P1WCounter = Instantiate(WinCounter) as GameObject;
            P1WCounter.transform.SetParent(P1CounterGroup.transform, false);
            setWCounterPos(P1WCounter, P1WonRounds, "P1");
          
        }
        else if (winner == "P2")
        {
            GameObject P2WCounter = Instantiate(WinCounter) as GameObject;
            P2WCounter.transform.SetParent(P2CounterGroup.transform, false);
            setWCounterPos(P2WCounter, P2WonRounds, "P2");
        }
        else if (winner == "draw")
        {
            GameObject P1WCounter = Instantiate(WinCounter) as GameObject;
            P1WCounter.transform.SetParent(P1CounterGroup.transform, false);
            GameObject P2WCounter = Instantiate(WinCounter) as GameObject;
            P2WCounter.transform.SetParent(P2CounterGroup.transform, false);

            setWCounterPos(P1WCounter, P1WonRounds, "P1");
            setWCounterPos(P2WCounter, P2WonRounds, "P2");
        }
    }

    private void setWCounterPos(GameObject counter ,int roundswon, string player)
    {
        if (P1WonRounds > 1 && player=="P1")
        {
            Vector3 newPostion = new Vector3(counter.transform.localPosition.x - (P1WonRounds - 1) * 50, counter.transform.localPosition.y, counter.transform.localPosition.z);
            counter.transform.localPosition = newPostion;
        }
        else if (P1WonRounds > 1 && player == "P2")
        {
            Vector3 newPostion = new Vector3(counter.transform.localPosition.x + (P1WonRounds - 1) * 50, counter.transform.localPosition.y, counter.transform.localPosition.z);
            counter.transform.localPosition = newPostion;
        }
    }

    public void setDeath(GameObject player)
    {
        if (player.transform.name=="P1Char")
        {   
                P1Dead = true;
        }
        else if (player.transform.name == "P2Char")
        {
                P2Dead = true;
        }
    }

   public void setAlive(GameObject player)
    {
        if (player.transform.name == "P1Char")
        {
                P1Dead = false;
        }
        else if (player.transform.name == "P2Char")
        {

                P2Dead = false;
        }
    }

    public void setMaxRound(int numRounds)
    {
        maxRound = numRounds;
    }

    IEnumerator StartRound()
    {
        P1HP.resetChar();
        P2HP.resetChar();

        GameObject.Find("P1Char").GetComponent<CharInputEngine>().EnableControls(false);
        GameObject.Find("P2Char").GetComponent<CharInputEngine>().EnableControls(false);

        fadeanimator.GetComponent<FadeTransitionScript>().FadeIn();
        yield return new WaitForSeconds(fadeanimator.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length);
        //Time.timeScale = 0;
        announcerText.text = "ROUND " + currentRound;
        announcerText.gameObject.SetActive(true);
        yield return new WaitForSecondsRealtime(1);
        announcerText.text = "FIGHT";
        GameObject.Find("P1Char").GetComponent<CharInputEngine>().EnableControls(true);
        GameObject.Find("P2Char").GetComponent<CharInputEngine>().EnableControls(true);
        yield return new WaitForSecondsRealtime(1);
        announcerText.gameObject.SetActive(false);
        //Time.timeScale = 1;
        timerActive = true; //activate timer

    }

    IEnumerator EndRound()
    {
        if (roundWinner!="DRAW")
        {
            announcerText.text = roundWinner + " Wins";
        }
        else
        {
            announcerText.text = "DRAW";
        }
        announcerText.gameObject.SetActive(true);
        yield return new WaitForSecondsRealtime(2);
        fadeanimator.GetComponent<FadeTransitionScript>().FadeOut();
        announcerText.gameObject.SetActive(false);
        
        yield return new WaitForSecondsRealtime(2);
        newRound();
    }

    IEnumerator MatchWon(string winner)
    {
        if (winner != "DRAW")
        {
            announcerText.text = winner + " is Victorious";
        }
        else
        {
            announcerText.text = "THE MATCH IS A DRAW";
        }
        announcerText.gameObject.SetActive(true);
        yield return new WaitForSecondsRealtime(2);
        fadeanimator.GetComponent<FadeTransitionScript>().FadeOut();
        //announcerText.gameObject.SetActive(false);
        
        //ADD VICTORY GRAPHIC HERE
        
    }

    IEnumerator WaitForTime(float time)
    {
        yield return new WaitForSeconds(time);
    }
}
