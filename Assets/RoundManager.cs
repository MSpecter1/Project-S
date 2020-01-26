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
    public string round1Winner="NotSet1";
    public string round2Winner="NotSet2";
    public int currentRound = 0;

    public GameObject P1Char;
    public CharHPManager P1HP;
    public GameObject P2Char;
    public CharHPManager P2HP;
    public GameObject fadeanimator;

    public bool P1Dead = false;
    public bool P2Dead = false;
    public bool timerActive = false;



    void Start()
    {
        //SET VARIABLES
        P1Char = GameObject.Find("P1Char");
        P2Char = GameObject.Find("P2Char");
        P1HP = P1Char.GetComponent<CharHPManager>();
        P2HP = P1Char.GetComponent<CharHPManager>();
        fadeanimator = GameObject.Find("FadeTransition");
        //INITIALIZE SETTINGS
        announcerText.gameObject.SetActive(false);
        currentRound = 0;

        newRound();
    }

    void FixedUpdate()
    {
        //UPDATE VARIABLES
        roundTimer.text = "" + timeLeft;
        if (timerActive)
        { 
        timeLeft -= Time.deltaTime;
        }

        if (((P1Dead||P2Dead)||timeLeft<0) && currentRound == 1)
        {
            if (P1Dead)
            {
                round1Winner = "P1";
            }
            else if (P2Dead)
            {
                round1Winner = "P2";
            }
            //ADD DRAW LATER

            //Announce Winner and Linger
            endRound();
            newRound();
        }
    }

    void newRound()
    {
        currentRound++;
        timeLeft = defaultRoundTime;
        //ANNOUNCE NEW ROUND
        
        P1HP.resetChar();
        P2HP.resetChar();

        StartCoroutine(StartRound());
    }

    void endRound()
    {
        StartCoroutine(EndRound());
        timerActive = false;
    }

    public void setDeath(GameObject player)
    {
        if (player.transform.name=="P1Char")
        {
            P1Dead = true;
        }
        else if (player.transform.name == "P2Char")
        {
            P1Dead = true;
        }
    }

    IEnumerator StartRound()
    {
        fadeanimator.GetComponent<FadeTransitionScript>().FadeIn();
        yield return new WaitForSeconds(fadeanimator.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length + fadeanimator.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).normalizedTime);
        Time.timeScale = 0;
        announcerText.text = "ROUND " + currentRound;
        announcerText.gameObject.SetActive(true);
        yield return new WaitForSecondsRealtime(1);
        announcerText.text = "FIGHT";
        yield return new WaitForSecondsRealtime(1);
        announcerText.gameObject.SetActive(false);
        Time.timeScale = 1;
        timerActive = true;
        yield return null;

    }

    IEnumerator EndRound()
    {
        announcerText.text = round1Winner + " Wins";
        announcerText.gameObject.SetActive(true);
        yield return new WaitForSecondsRealtime(2);
        announcerText.gameObject.SetActive(false);
        yield return null;
        fadeanimator.GetComponent<FadeTransitionScript>().FadeOut();
    }

    IEnumerator WaitForTime(float time)
    {
        yield return new WaitForSeconds(time);
    }
}
