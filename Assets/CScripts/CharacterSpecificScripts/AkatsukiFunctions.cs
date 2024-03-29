﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Special Attacks for MTSebby

public class AkatsukiFunctions : CharFunctions
{
    //public CharInputEngine CharInputEngine;
    //public CharHPManager hpmanager;
    //public CharEXManager exmanager;

    //public Animator animator;

    public GameObject FireballStartLoc;
    public GameObject ultFireballStartLoc;
    
    public GameObject HadoukenFire;
    public int FireballDamage;

    // Start is called before the first frame update
    void Start()
    {
        //SET UNIQUE HP
        hpmanager.setHP(10000);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void SpecialAttack1(int variant)
    {
        if (!ProjectileActive)
        {
            animator.SetTrigger("specialAttack1");
            ProjectileActive = true;
        }
    }
    void OnTriggerEnter2D(Collider2D other) //Check if ANY hitbox attacks a hurtbox
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Hurtbox")) //IF HITTING ENEMY HURTBOX
        {
            Debug.Log(gameObject.name + "'s attack landed a hit");
        }
    }

    public override void LaunchProjectile(int val)
    {
        switch(val)
        {
            case 0:
                LaunchHadouken(FireballDamage);
                break;
            default:
                Debug.Log(gameObject.name + " called \"Launch Projectile\" but its value was incorrect/missing");
                break;
        }
    }

    public void LaunchHadouken(int damage) //SPECIAL ATTACK 1
    {
        GameObject b = Instantiate(HadoukenFire) as GameObject;
        GeneralFireball Fireball = b.GetComponent<GeneralFireball>();
        Fireball.setDmg(damage);
        Fireball.setUser(gameObject);
        Fireball.setFramesOnBlock(26);
        Fireball.setFramesOnHit(26);
        
        b.transform.position = FireballStartLoc.transform.position;
        if (CharInputEngine.faceRight) //CHECK FLIP
        {
            b.GetComponent<Rigidbody2D>().velocity = transform.right * 60;
        }
        else
        {
            Vector3 theScale = b.transform.localScale;
            theScale.x *= -1;
            b.transform.localScale = theScale; //flip sprite

            b.GetComponent<Rigidbody2D>().velocity = -transform.right * 60;
        }
    }

    public void LaunchUltHadouken() //SPECIAL ATTACK 1
    {
        GameObject b = Instantiate(HadoukenFire) as GameObject;
        b.transform.position = ultFireballStartLoc.transform.position;
        //START Ult CHARGEUP
        
        SpriteRenderer sprite = b.GetComponent<SpriteRenderer>();
        sprite.color = Color.red;

        Time.timeScale = 0;
        StartCoroutine(ChargeUlt(b));

        //FINISH Ult CHARGEUP

        if (CharInputEngine.faceRight) //CHECK FLIP
        {
            b.GetComponent<Rigidbody2D>().velocity = transform.right * 70;
        }
        else
        {
            Vector3 theScale = b.transform.localScale;
            theScale.x *= -1;
            b.transform.localScale = theScale; //flip sprite

            b.GetComponent<Rigidbody2D>().velocity = -transform.right * 70;
        }

    }

    IEnumerator ChargeUlt(GameObject b)
    {
        SpriteRenderer sprite = b.GetComponent<SpriteRenderer>();
        Vector3 sizechange = new Vector3(1, 1, 1);
        float vectorx = 1, vectory = 1;
        for (int i = 0; i < 50; i++)
        {
            
            Time.timeScale = 0;
            sizechange.x = (float)vectorx*i / 10;
            sizechange.y = (float)vectory*i / 10;
            b.transform.localScale = sizechange;
            //SpriteRenderer.color = Color.red;
            //yield return new WaitForSeconds(.1f);
            //SpriteRenderer.color = Color.white;
            //yield return new WaitForSeconds(.1f);
            yield return null;
        }
        Time.timeScale = 1;
        
    }
}

