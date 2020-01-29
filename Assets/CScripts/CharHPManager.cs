using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

//Manages getting hit and launches etc
//ADD IS HIT BOOLEAN AND CALCULATE LAUNCH DISTANCE BASED ON ATTACK


public class CharHPManager : MonoBehaviour
{
    private Rigidbody2D m_Rigidbody2D;
    public CharInputEngine CharInputEngine;
    
    //HP MANAGERMENT VARIABLES
    public int CharHP;
    public int CharMaxHP;
    
    public bool deadState = false;
    public bool invincibleState = false;
    public HealthBar healthbar;
    SpriteRenderer SpriteRenderer;

    public float floathp;

    void Start()
    {
        //LOAD COMPONANTS ONTO VARIABLES
        m_Rigidbody2D = GetComponent<Rigidbody2D>();
        if (transform.name=="P1Char")
        {
            healthbar = GameObject.Find("P1HealthBar").GetComponent<HealthBar>();
        }
        else if (transform.name == "P2Char")
        {
            healthbar = GameObject.Find("P2HealthBar").GetComponent<HealthBar>();
        }
      
    }

    void Update()
    {
        //UPDATE HEALTH BAR DISPLAY
        floathp = (float)CharHP / CharMaxHP;
        healthbar.setSize(floathp);
        
        if (!deadState && CharHP <= 0)
        {
            PlayerDied();
        }
    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown("m"))
        {
            resetChar();
        }
    }

    public void setHP(int hp)
    {
        CharMaxHP = hp;
        CharHP = CharMaxHP;
    }

    public void resetChar()
    {
        PlayerRevive(CharMaxHP);
        Debug.Log("CHAR RESET");
        if (transform.name=="P1Char")
        { 
            transform.position = GameObject.Find("CSSScriptsObject").GetComponent<CharLoaderScript>().p1start; 
        }
        else if (transform.name == "P2Char")
        { 
            transform.position = GameObject.Find("CSSScriptsObject").GetComponent<CharLoaderScript>().p2start; 
        }
}

    public void PlayerDied()
    {
        //SET ROUNDMANAGER BOOL
        GameObject.Find("RoundManager").GetComponent<RoundManager>().setDeath(gameObject);
        //SET OTHER BOOLS
        deadState = true;
        invincibleState = true;
        CharInputEngine.animator.SetBool("deadState", true);
    }

    public void PlayerRevive(int revivehp)
    {
        GameObject.Find("RoundManager").GetComponent<RoundManager>().setAlive(gameObject);
        CharHP = revivehp;
        deadState = false;
        invincibleState = false;
        CharInputEngine.animator.SetBool("deadState", false);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        float LaunchDirection = 0; //CALCULATE LAUNCH DIRECTION IF HIT
        if (CharInputEngine.faceRight)
        {
            LaunchDirection = -1;
        }
        else if (!CharInputEngine.faceRight)
        {
            LaunchDirection = 1;
        }

        // TEMPORARY REMOVE LATER
        if ((col.gameObject.layer == LayerMask.NameToLayer("Hitbox") || col.gameObject.layer == LayerMask.NameToLayer("ProjectileHitbox")) && !invincibleState) //IF HIT BY HITBOX FROM ENEMY ATTACK
        {
            Debug.Log("HIT");
            StartCoroutine(FlashDamageTaken());
            if (CharHP>0)
            {
                CharHP -= 1000;
            }

            //TEMPORARY CODE, EACH UNIQUE HIT SHOULD HAVE DIFFERENT LAUNCH FORCE
            //HITTER SHOULD BE THE ONE THAT CAUSES "OTHER" TO GO FLYING
            m_Rigidbody2D.velocity = new Vector2(LaunchDirection, 1) * 10f;
        }

    }

    IEnumerator FlashDamageTaken()
    {
        //invincibleState = !invincibleState;
        for (int i = 0; i < 4; i++)
        {
            SpriteRenderer = GetComponent<SpriteRenderer>();
            SpriteRenderer.color = Color.red;
            yield return new WaitForSeconds(.1f);
            SpriteRenderer.color = Color.white;
            yield return new WaitForSeconds(.1f);
        }
        //invincibleState = !invincibleState;
    }
}
