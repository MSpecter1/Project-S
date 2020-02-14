using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharAttackHitboxScript : MonoBehaviour
{
    public int attackDamage;
    public AttackType thisAttackType;
    public AttackLaunchType thisAttackLaunchType;
    public float framesOnHit;
    public float framesOnBlock;

    public bool lightCancellable;
    public bool mediumCancellable;
    public bool heavyCancellable;
    public bool abilityCancellable;

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

    void OnTriggerEnter2D(Collider2D other) //Check if ANY hitbox attacks a hurtbox
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Hurtbox") && other.gameObject.GetComponent<CharStateManager>().getState()!=CharStateManager.CharState.BlockState) //IF HITTING ENEMY
        {
            Debug.Log(gameObject.name + ": landed a hit");
            other.GetComponent<CharHPManager>().damageHP(attackDamage);
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
        else if (other.gameObject.layer == LayerMask.NameToLayer("Hurtbox") && other.gameObject.GetComponent<CharStateManager>().getState() == CharStateManager.CharState.BlockState)//hit guarded enemy
        {

        }

    }


}
