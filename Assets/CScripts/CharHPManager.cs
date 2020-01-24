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
        //IF HP IS BELOW 20% START FLASHING RED
        if (!healthbar.lowHP && floathp < 0.2f)
        {
            healthbar.startFlashing();
        }
    }

    public void setHP(int hp)
    {
        CharHP = hp;
        CharMaxHP = CharHP;
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
        if ((col.gameObject.layer == LayerMask.NameToLayer("Hitbox") || col.gameObject.layer == LayerMask.NameToLayer("ProjectileHitbox")) && !invincibleState && !deadState) //IF HIT BY HITBOX FROM ENEMY ATTACK
        {
            Debug.Log("HIT");
            StartCoroutine(FlashDamageTaken());
            CharHP -= 1000;
            if (CharHP <= 0)
            {
                deadState = true;
                CharInputEngine.animator.SetBool("deadState", true);
                //transform.Rotate(0, 0, 90); //LAY ON SIDE IF DEAD
            }
            m_Rigidbody2D.velocity = new Vector2(LaunchDirection, 1) * 30f; //TEMPORARY CODE, EACH UNIQUE HIT SHOULD HAVE DIFFERENT LAUNCH FORCE
            //HITTER SHOULD BE THE ONE THAT CAUSES "OTHER" TO GO FLYING
        }
    }

    IEnumerator FlashDamageTaken()
    {
        invincibleState = !invincibleState;
        for (int i = 0; i < 4; i++)
        {

            SpriteRenderer = GetComponent<SpriteRenderer>();
            SpriteRenderer.color = Color.red;
            yield return new WaitForSeconds(.1f);
            SpriteRenderer.color = Color.white;
            yield return new WaitForSeconds(.1f);
        }
        invincibleState = !invincibleState;
    }
}
