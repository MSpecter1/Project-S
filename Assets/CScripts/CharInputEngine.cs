using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.InputSystem;

// Handles inputs from keyboard/controller
// Causes Basic Movement (walking and jumping so far)
// Causes Basic Attacks and implements special attack function (no command normals yet)

public class CharInputEngine: MonoBehaviour
{
    public MoveController mControl;
    public Animator animator;
    public PlayerInput playerInput;
    public CharEXManager exmanager;
    public CharStateManager CharStateManager;
    public CharFunctions CharacterFunctions;
    public CharInputBuffer CharInputBuffer;
    //TEMP
    public CharAudioManager CharAudio;

    public bool faceRight;
    private bool jumpState = false;
    private bool crouchState = false;

    public float MoveSpeed;
    private float horizantalMove=0f;

    public bool isGrounded;

    public Transform target;

    //Input buffer vector, discard actions after a time, 


    void Start()
    {
        faceRight = true;
        //STARTING ORIENTATION - MAY BE REDUNDANT
        if (transform.position.x>0)
        {
            Flip();
        }

        //FIND NAME OF OPPONANT CHAR
        if (transform.name=="P1Char")
        {
            target = GameObject.Find("P2Char").transform;
            
        }
        else
        {
            target = GameObject.Find("P1Char").transform;
        }
        
        //ENABLE CONTROLS

        playerInput.currentActionMap.Disable();
        //ADD COROUTINE for Round Manager
        if (transform.name == "P2Char")
        {
            playerInput.SwitchCurrentActionMap("FGInputsKeyboard2");
        }
        playerInput.currentActionMap.Enable();

    }

    public void EnableControls(bool input) //ENABLES OR DISABLE MOVING/ATTACKING
    {
        if (input)
        {
            playerInput.currentActionMap.Enable();
        }
        else
        {
            playerInput.currentActionMap.Disable();
        }

    }

    void FixedUpdate()
    {

        //MOVE
        GetMoveValue();
        if(CharStateManager.getState()!=CharStateManager.CharState.BlockStunState && CharStateManager.getState() != CharStateManager.CharState.HitStunState)
        {
            if ((faceRight && horizantalMove > 0) || (!faceRight && horizantalMove < 0))
            {
                mControl.Move(horizantalMove * Time.fixedDeltaTime, crouchState, jumpState, true); //move character forwards
            }
            else
            {
                mControl.Move(horizantalMove * Time.fixedDeltaTime, crouchState, jumpState, false); //move character backwards
            }
            //SET STATES
            if (horizantalMove != 0)
            {
                CharStateManager.setState(CharStateManager.CharState.WalkState);
            }
            else
            {
                CharStateManager.setState(CharStateManager.CharState.IdleState);
            }
        }
        else
        {
            mControl.Move(0 * Time.fixedDeltaTime, crouchState, jumpState, true);
        }

        

        //FACE OTHER PLAYER
        if (target.position.x > transform.position.x && !faceRight) //if the target is to the right of enemy and the enemy is not facing right
        { Flip(); }
        if (target.position.x < transform.position.x && faceRight)
        { Flip(); }

        //MAKE JUMP FALSE
        jumpState = false;
    }

    //MOVEMENT
    void GetMoveValue()
    {
        var temp = playerInput.currentActionMap.FindAction("Move", false).ReadValue<Vector2>();
        if (!animator.GetBool("attackState"))
        {
            if ((faceRight && temp.x < 0) || (!faceRight && temp.x > 0))
            {
                CharStateManager.Blocking = true; 
            }
            else
            {
                CharStateManager.Blocking = false;
            }
        }
        if (!crouchState && !animator.GetBool("attackState") && CharStateManager.getState()!=CharStateManager.CharState.BlockStunState)
        {
            var movement = new Vector3();
            movement.x = temp.x;
            movement.z = temp.y;
            movement.Normalize();
            horizantalMove = movement.x * MoveSpeed;
        }
        else
        {
            horizantalMove = 0;
        }
    }

    public void OnMoveRight()
    {
        if(faceRight)
        {
            CharInputBuffer.BufferInput(CharInputBuffer.input.right);
        }
        else
        {
            CharInputBuffer.BufferInput(CharInputBuffer.input.left);
        }
        
    }

    public void OnMoveLeft()
    {
        if (faceRight)
        {
            CharInputBuffer.BufferInput(CharInputBuffer.input.left);
        }
        else
        {
            CharInputBuffer.BufferInput(CharInputBuffer.input.right);
        }
    }

    public void OnDashRight()
    {
        Debug.Log("Dash Right");
    }
    public void OnDashLeft()
    {
        Debug.Log("Dash Left");
    }
    void OnMoveJump()
    {
        if (!animator.GetBool("attackState") && !jumpState)
        {
            jumpState = true;
        }
    }

    void OnMoveCrouch()
    {
        CharInputBuffer.BufferInput(CharInputBuffer.input.down);
        if (!jumpState)
        {
            //Debug.Log("CROUCHSTATE CHANGED");
            crouchState = !crouchState;
            if (crouchState)
            { 
                animator.SetBool("Crouching", true); 
            }
            else
            { 
                animator.SetBool("Crouching", false); 
            }
        }     
    }

    //ATTACKS

    void OnNAttackLight()
    {
        CharInputBuffer.BufferInput(CharInputBuffer.input.light);
        //animator.SetTrigger("lightNormal");
    }

    void OnNAttackMedium()
    {
        CharInputBuffer.BufferInput(CharInputBuffer.input.medium);
        //animator.SetTrigger("mediumNormal");
    }

    void OnNAttackHeavy()
    {
        CharInputBuffer.BufferInput(CharInputBuffer.input.heavy);
        //animator.SetTrigger("heavyNormal");
    }

    void OnSpecialAttack()
    {
        CharInputBuffer.BufferInput(CharInputBuffer.input.special);
        //CharacterFunctions.SpecialAttack1(1);
    }

    //NON-INPUT FUNCTIONS

    private void Flip()
    {
        // Switch the way the player is labelled as facing.
        faceRight = !faceRight;

        // Multiply the player's x local scale by -1.
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    public void PlaySoundClip(string soundname)
    {
        CharAudio.PlaySound(soundname);
    }

}


