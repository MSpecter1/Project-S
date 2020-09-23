﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralFireball : MonoBehaviour
{
    // Start is called before the first frame update
    private int damage;
    private int framesOnBlock;
    private int framesOnHit;
    private GameObject user;
    public float FireballKnockback = 700;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    private void OnDestroy()
    {
        user.GetComponent<CharFunctions>().ProjectileActive = false;
    }

    public void setDmg(int val)
    {
        damage = val;
    }

    public void setUser(GameObject fired)
    {
        user = fired;
    }

    public void setFramesOnBlock(int frames)
    {
        framesOnBlock = frames;
    }
    public void setFramesOnHit(int frames)
    {
        framesOnHit = frames;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Hurtbox")) //IF HITTING ENEMY
        {
            GameObject otherChar = other.transform.parent.parent.gameObject;
            CharHPManager otherHP = otherChar.GetComponent<CharHPManager>();
            CharStateManager otherState = otherChar.GetComponent<CharStateManager>();

            if (!otherState.isBlocking() && otherState.getState() != CharStateManager.CharState.DeadState) //if hitting unguarded enemy
            {
                //Debug.Log(gameObject.name + ": landed a hit");
                otherHP.damageHP(damage);
                otherState.StartHitStun(framesOnHit);

                otherChar.GetComponent<MoveController>().forceMove(false, FireballKnockback);

            }
            else if (otherState.isBlocking() && otherState.getState() != CharStateManager.CharState.DeadState)//hit guarded enemy
            {
                otherState.StartBlockStun(framesOnBlock);
            }
            StartCoroutine(LingerFireball(5));

        }
        else //hits wall etc
        {
            Destroy(gameObject);
        }
    }

    IEnumerator LingerFireball(float frames) //lets fireball stall for a bit before disappearing
    {
        yield return new WaitForSeconds(frames/60);
        Destroy(gameObject);
    }
}
