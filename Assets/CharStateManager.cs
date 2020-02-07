using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharStateManager : MonoBehaviour
{
    public Animator animator;
    public CharHPManager CharHPManager;
    public CharInputEngine CharInputEngine;

    public bool FacingRight;
    public enum CharState
    {
        //MOVEMENT
        IdleState,
        WalkState,
        DashState,
        AirState,
        CrouchState,
        //ATTACK
        AttackStartupState,
        AttackActiveState,
        AttackRecoveryState,
        //DEFENSE
        BlockState,
        BlockStunState,
        HitStunState,
        //MISC
        PoweredState,
        StunnedState,
        DeadState,
        InvincibleState,
        TauntState
    }
    public CharState ActiveState = CharState.IdleState;
    // Start is called before the first frame update
    void Start()
    {
        ActiveState = CharState.IdleState;
    }

    // Update is called once per frame
    void Update()
    {
        switch (ActiveState)
        {
            //MOVEMENT
            case CharState.IdleState:
                {
                    animator.SetBool("WalkState", false);
                }
                break;

            case CharState.WalkState:
                {
                    animator.SetBool("WalkState", true);
                }
                break;

            case CharState.AirState:
                {

                }
                break;

            case CharState.CrouchState:
                {

                }
                break;

            //ATTACK
            case CharState.AttackStartupState:
                {
                    animator.SetBool("WalkState", false);
                }
                break;

            case CharState.AttackActiveState:
                {
                    animator.SetBool("WalkState", true);
                }
                break;

            case CharState.AttackRecoveryState:
                {

                }
                break;

            //DEFENSE
            case CharState.BlockState:
                {

                }
                break;
            case CharState.BlockStunState:
                {
                    animator.SetBool("WalkState", true);
                }
                break;

            case CharState.HitStunState:
                {

                }
                break;

            //MISC

            default:
                {

                }
                break;
        }
    }

    public void setState(CharState state)
    {
        ActiveState = state;
    }

    public CharState getState()
    {
        return ActiveState;
    }

    public void resetState()
    {
        ActiveState = CharState.IdleState;
    }


}
