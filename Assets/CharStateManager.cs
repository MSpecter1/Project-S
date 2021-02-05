using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharStateManager : MonoBehaviour
{
    public Animator animator;
    public CharHPManager CharHPManager;
    public CharInputEngine CharInputEngine;

    public bool FacingRight;
    public bool Blocking = false;
    public int StunFrames = 0;
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
        BlockStunState,
        HitStunState,
        //MISC MAYBE CHANGE TO MODIFIER BOOLS???
        PoweredState,
        StunnedState,
        DeadState,
        TauntState
    }
    public CharState ActiveState = CharState.IdleState;

    // Start is called before the first frame update
    void Start()
    {
        ActiveState = CharState.IdleState;
    }

    // Update is called once per frame
    //void FixedUpdate()}

    private void Update()
    {
        if (ActiveState != CharState.HitStunState && ActiveState != CharState.BlockStunState)
        {
            animator.SetBool("BlockStunState", false);
            animator.SetBool("HitStunState", false);
            animator.SetInteger("ComboCounter", 0);
            StunFrames = 0;
            CharHPManager.SpriteRenderer.color = Color.white;
        }
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
                    animator.SetBool("CrouchState", true);
                }
                break;

            //ATTACK
            case CharState.AttackStartupState:
                {

                }
                break;

            case CharState.AttackActiveState:
                {

                }
                break;

            case CharState.AttackRecoveryState:
                {

                }
                break;

            //DEFENSE
            case CharState.BlockStunState: //technically doesn't let you move, see InputEngine if confused
                {
                    CharHPManager.SpriteRenderer.color = Color.blue;
                    animator.SetBool("BlockStunState", true);
                    if (StunFrames == 0)
                    {
                        setState(CharState.IdleState);
                    }
                    else
                    {
                        StunFrames -= 1;
                    }
                }
                break;

            case CharState.HitStunState:
                {
                    CharHPManager.SpriteRenderer.color = Color.red;
                    animator.SetBool("HitStunState", true);
                    if (StunFrames == 0)
                    {
                        setState(CharState.IdleState);
                        Debug.Log("RECOVERED!!!");
                        Debug.Log("COMBO: " + animator.GetInteger("ComboCounter"));
                    }
                    else
                    {
                        StunFrames -= 1;
                    }
                }
                break;
            case CharState.DeadState:
                {
                    //animator.SetBool("BlockStunState", false);
                    //animator.SetBool("HitStunState", false);
                    //animator.SetInteger("ComboCounter", 0);
                    animator.SetBool("DeadState", true);
                }
                break;

            //MISC

            default:
                {
                    Debug.LogError("NO CHAR STATE ACTIVE");
                }
                break;
        }
    }

    public void setState(CharState state)
    {
        //Debug.Log(gameObject.name + ": "+ state);
        ActiveState = state;
    }

    public CharState getState()
    {
        return ActiveState;
    }

    public void resetState()
    {
        //Debug.Log(gameObject.name + " state reset");
        animator.SetBool("DeadState",false);
        ActiveState = CharState.IdleState;
    }

    public bool isBlocking()
    {
        return Blocking;
    }

    public void StartBlockStun(int frames)
    {
        StunFrames = frames;
        if (ActiveState != CharStateManager.CharState.BlockStunState)
        {
            setState(CharStateManager.CharState.BlockStunState);
        }
        animator.SetTrigger("BlockStunHit");
        //StartCoroutine(BlockStunned(frames));
    }

    public void StartHitStun(int frames)
    {
        animator.SetInteger("ComboCounter", animator.GetInteger("ComboCounter")+1);
        StunFrames = frames;
        if (ActiveState!= CharStateManager.CharState.HitStunState)
        {
            setState(CharStateManager.CharState.HitStunState);
        }
        animator.SetTrigger("HitStunHit");
        //StartCoroutine(HitStunned(frames));
    }

    IEnumerator HitStunned(int frameCount)
    {
        setState(CharStateManager.CharState.HitStunState);
        yield return StartCoroutine(WaitForFrames(frameCount));
        setState(CharStateManager.CharState.IdleState);
        //CharHPManager.SpriteRenderer.color = Color.white;

    }
    IEnumerator BlockStunned(int frameCount)
    {
        setState(CharStateManager.CharState.BlockStunState);
        yield return StartCoroutine(WaitForFrames(frameCount));
        setState(CharStateManager.CharState.IdleState);
        //CharHPManager.SpriteRenderer.color = Color.white;
    }
    IEnumerator WaitForFrames(int frameCount)
    {
        while (frameCount > 0)
        {
            frameCount--;
            yield return null;
        }
    }
}
