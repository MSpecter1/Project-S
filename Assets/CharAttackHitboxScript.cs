using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharAttackHitboxScript : MonoBehaviour
{
    public int attackDamage;
    public AttackType thisAttackType;
    public AttackLaunchType thisAttackLaunchType;
    public int framesOnHit;
    public int framesOnBlock;
    public bool low;
    public bool overhead;

    public bool lightCancellable;
    public bool mediumCancellable;
    public bool heavyCancellable;
    public bool abilityCancellable;

    public Collider2D thisHitbox;
    public int playerNumber = 0;

    [SerializeField]
    private int timeshit = 0;
    private bool Attacking = false;

    //public Collider2D[] EnemyHit;
    //public Transform lightAttackPoint;
    //public ContactFilter2D enemyFilter;
    public enum AttackType
    {
        lightNormal,
        mediumNormal,
        heavyNormal,
        commandNormal,
        specialAttack,
    }
    public enum AttackLaunchType
    {
        normalAttack,
        smashAttack,
        sweepUpAttack,
        smashDownAttack,
        specialLaunchAttack,
    }

    public float AttackKnockback = 400;

    // Start is called before the first frame update
    void Start()
    {
        thisHitbox = gameObject.GetComponent<BoxCollider2D>();
        playerNumber = transform.parent.GetComponent<HitboxManager>().getPlayerNum();
    }

    // Update is called once per frame
    void Update()
    {
        if (Attacking)
        {
            hitConfirm();
        }
    }

    public void setAttacking(bool attack)
    {
        switch(attack)
        {
            case true:
                {
                    timeshit = 0;
                    Attacking = true;
                }
                break;
            case false:
                {
                    Attacking = false;
                }
                break;
        }

    }

    public void hitConfirm()
    {
        Collider2D[] results = new Collider2D[10];
        ContactFilter2D contactFilter = new ContactFilter2D();
        contactFilter.NoFilter();
        thisHitbox.OverlapCollider(contactFilter, results);
        foreach (Collider2D t in results)
        {
            if (t != null && t.tag != transform.parent.parent.parent.tag)
            {
                if (timeshit < 1)
                {
                    if (t.name == "HeadHurtbox")
                    {
                        timeshit++;
                    }
                    else if (t.name == "StandingHurtbox")
                    {
                        timeshit++;
                    }
                    //Debug.Log(transform.parent.parent + "OVERLAPcollider hit: " + t.tag + "'s " + t);

                    //ON HIT
                    onHit(t);
                }
            }
        }
    }

    private void onHit(Collider2D other)
    {
        if ((other.gameObject.CompareTag("P1") && playerNumber != 1) || (other.gameObject.CompareTag("P2") && playerNumber != 2))
        {
            GameObject otherChar = other.transform.parent.parent.gameObject; //get other gameobject, which is grandparent of enemy hurtbox
            CharHPManager otherHP = otherChar.GetComponent<CharHPManager>();
            CharStateManager otherState = otherChar.GetComponent<CharStateManager>();

            if (otherState.isBlocking() != true && otherState.getState() != CharStateManager.CharState.DeadState || otherState.isBlocking() && overhead && otherState.getState() == CharStateManager.CharState.CrouchState && otherState.getState() != CharStateManager.CharState.DeadState || otherState.isBlocking() && low && otherState.getState() != CharStateManager.CharState.CrouchState && otherState.getState() != CharStateManager.CharState.DeadState) //if hitting unguarded enemy
            {
                // Debug.Log(gameObject.name + ": landed a hit");
                otherState.StartHitStun(framesOnHit);

                otherChar.GetComponent<MoveController>().forceMove(false, AttackKnockback); //TEMPORARY HITBOX FIX PLEASE REMOVE LATER
                CinemachineShake.Instance.ShakeCamera(5f, 0.1f);
                otherHP.damageHP(attackDamage);

                switch (thisAttackType) //check what can cancel off this attack on hit
                {
                    case AttackType.lightNormal:
                        {

                        }
                        break;
                    case AttackType.mediumNormal:
                        {

                        }
                        break;
                    case AttackType.heavyNormal:
                        {

                        }
                        break;
                }
                switch (thisAttackLaunchType) // check if this attack launches
                {
                    case AttackLaunchType.normalAttack:
                        {

                        }
                        break;
                    case AttackLaunchType.smashAttack:
                        {

                        }
                        break;
                    case AttackLaunchType.smashDownAttack:
                        {

                        }
                        break;
                    case AttackLaunchType.specialLaunchAttack:
                        {

                        }
                        break;
                }
            }
            else if (otherState.isBlocking() && overhead && otherState.getState() == CharStateManager.CharState.CrouchState && otherState.getState() != CharStateManager.CharState.DeadState)//hit crouching enemy
            {
                otherState.StartHitStun(framesOnHit);
            }
            else if (otherState.isBlocking() && low && otherState.getState() != CharStateManager.CharState.CrouchState && otherState.getState() != CharStateManager.CharState.DeadState)//hit not crouching enemy
            {
                otherState.StartHitStun(framesOnHit);
            }
            else if (otherState.isBlocking() && otherState.getState() != CharStateManager.CharState.DeadState)//hit guarded enemy
            {
                otherState.StartBlockStun(framesOnBlock);
            }
        }
    }

    //void OnTriggerEnter2D(Collider2D other)
    //{
    //    if (other.gameObject.layer == LayerMask.NameToLayer("Hurtbox")) //IF HITTING ENEMY
    //    {
    //        if ((other.gameObject.CompareTag("P1") && playerNumber != 1) || (other.gameObject.CompareTag("P2") && playerNumber != 2))
    //        {
    //            GameObject otherChar = other.transform.parent.parent.gameObject; //get other gameobject, which is grandparent of enemy hurtbox
    //            CharHPManager otherHP = otherChar.GetComponent<CharHPManager>();
    //            CharStateManager otherState = otherChar.GetComponent<CharStateManager>();

    //            if (otherState.isBlocking() != true && otherState.getState() != CharStateManager.CharState.DeadState || otherState.isBlocking() && overhead && otherState.getState() == CharStateManager.CharState.CrouchState && otherState.getState() != CharStateManager.CharState.DeadState || otherState.isBlocking() && low && otherState.getState() != CharStateManager.CharState.CrouchState && otherState.getState() != CharStateManager.CharState.DeadState) //if hitting unguarded enemy
    //            {
    //                // Debug.Log(gameObject.name + ": landed a hit");
    //                otherState.StartHitStun(framesOnHit);

    //                otherChar.GetComponent<MoveController>().forceMove(false, AttackKnockback); //TEMPORARY HITBOX FIX PLEASE REMOVE LATER
    //                CinemachineShake.Instance.ShakeCamera(5f, 0.1f);
    //                otherHP.damageHP(attackDamage);

    //                switch (thisAttackType) //check what can cancel off this attack on hit
    //                {
    //                    case AttackType.lightNormal:
    //                        {

    //                        }
    //                        break;
    //                    case AttackType.mediumNormal:
    //                        {

    //                        }
    //                        break;
    //                    case AttackType.heavyNormal:
    //                        {

    //                        }
    //                        break;
    //                }
    //                switch (thisAttackLaunchType) // check if this attack launches
    //                {
    //                    case AttackLaunchType.normalAttack:
    //                        {

    //                        }
    //                        break;
    //                    case AttackLaunchType.smashAttack:
    //                        {

    //                        }
    //                        break;
    //                    case AttackLaunchType.smashDownAttack:
    //                        {

    //                        }
    //                        break;
    //                    case AttackLaunchType.specialLaunchAttack:
    //                        {

    //                        }
    //                        break;
    //                }
    //            }
    //            else if (otherState.isBlocking() && overhead && otherState.getState() == CharStateManager.CharState.CrouchState && otherState.getState() != CharStateManager.CharState.DeadState)//hit crouching enemy
    //            {
    //                otherState.StartHitStun(framesOnHit);
    //            }
    //            else if (otherState.isBlocking() && low && otherState.getState() != CharStateManager.CharState.CrouchState && otherState.getState() != CharStateManager.CharState.DeadState)//hit not crouching enemy
    //            {
    //                otherState.StartHitStun(framesOnHit);
    //            }
    //            else if (otherState.isBlocking() && otherState.getState() != CharStateManager.CharState.DeadState)//hit guarded enemy
    //            {
    //                otherState.StartBlockStun(framesOnBlock);
    //            }
    //        }



    //    }

    //}


}
