using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

//ADD IS HIT BOOLEAN AND CALCULATE LAUNCH DISTANCE BASED ON ATTACK


public class CharHPManager : MonoBehaviour
{
    private Rigidbody2D m_Rigidbody2D;
    public CharInputEngine CharInputEngine;
    
    //HP MANAGERMENT VARIABLES
    public int CharHP = 10000;
    public TMP_Text HealthText;
    public bool deadState = false;
    public bool invincibleState = false;
    SpriteRenderer SpriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody2D = GetComponent<Rigidbody2D>();
        if (transform.name=="P1Char")
        {
            HealthText = GameObject.Find("P1HealthBar").GetComponent<TMP_Text>();
        }
        else
        {
            HealthText = GameObject.Find("P2HealthBar").GetComponent<TMP_Text>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        HealthText.text = transform.name+": " + CharHP +"/10000"; //DEBUG/PLACEHOLDER PURPOSES FOR NOW
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
        if (col.gameObject.layer == LayerMask.NameToLayer("Hitbox") || col.gameObject.layer == LayerMask.NameToLayer("ProjectileHitbox") && !invincibleState && !deadState) //IF HIT BY HITBOX FROM ENEMY ATTACK
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
