using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

//Charaacter script for training mode punching bag

public class PunchingBag : MonoBehaviour
{
    private Rigidbody2D m_Rigidbody2D;
    
    public int CharHP = 10000;
    public TMP_Text HealthText;
    public bool deadState=false;
    public bool invincibleState=false;
    SpriteRenderer SpriteRenderer;

    public Transform target;
    public bool faceRight=true;
    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody2D = GetComponent<Rigidbody2D>();
        if (transform.name == "P1Char")
        {
            HealthText = GameObject.Find("P1HealthBar").GetComponent<TMP_Text>();
        }
        else
        {
            HealthText = GameObject.Find("P2HealthBar").GetComponent<TMP_Text>();
        }

        if (transform.position.x > 0)
        {
            Flip();
        }

        //FIND NAME OF OPPONANT CHAR
        if (transform.name == "P1Char")
        {
            target = GameObject.Find("P2Char").transform;
        }
        else
        {
            target = GameObject.Find("P1Char").transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (target.position.x > transform.position.x && !faceRight) //if the target is to the right of enemy and the enemy is not facing right
        { Flip(); }
        if (target.position.x < transform.position.x && faceRight)
        { Flip(); }

        //SHOW HEATLH ON SCREEN
        HealthText.text = transform.name + ": " + CharHP + "/10000"; //DEBUG/PLACEHOLDER PURPOSES FOR NOW
    }

    void OnTriggerEnter2D(Collider2D col) 
    {
        float LaunchDirection=0; //CALCULATE LAUNCH DIRECTION IF HIT
        if (faceRight)
        {
            LaunchDirection = -1;
        }
        else if (!faceRight)
        {
            LaunchDirection = 1; 
        }
        
        if (col.gameObject.layer == LayerMask.NameToLayer("Hitbox") || col.gameObject.layer == LayerMask.NameToLayer("ProjectileHitbox")  && !invincibleState && !deadState) //IF HIT BY HITBOX FROM ENEMY ATTACK
        {
            Debug.Log("HIT");
            StartCoroutine(FlashDamageTaken());
            CharHP -= 1000;
            if (CharHP<=0)
            {
                deadState = true;
                transform.Rotate(0, 0, 90); //LAY ON SIDE IF DEAD
            }
            m_Rigidbody2D.velocity = new Vector2(LaunchDirection, 1) * 10f;
        }
    }

    void Flip()
    {
        // Switch the way the player is labelled as facing.
        faceRight = !faceRight;

        // Multiply the player's x local scale by -1.
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
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


