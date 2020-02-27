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

    public Collider2D[] collidersHit;
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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void hitConfirm()
    {
        BoxCollider2D.OverlapCollider(LayerMask.NameToLayer("Hurtbox"), collidersHit);

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.layer == LayerMask.NameToLayer("Hurtbox")) //IF HITTING ENEMY
        {
            GameObject otherChar = other.transform.parent.parent.gameObject;
            CharHPManager otherHP = otherChar.GetComponent<CharHPManager>();
            CharStateManager otherState = otherChar.GetComponent<CharStateManager>();

            if (otherState.isBlocking() != true && otherState.getState() != CharStateManager.CharState.DeadState) //if hitting unguarded enemy
            {
                Debug.Log(gameObject.name + ": landed a hit");
                otherHP.damageHP(attackDamage);
                otherState.StartHitStun(framesOnHit);

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


}
