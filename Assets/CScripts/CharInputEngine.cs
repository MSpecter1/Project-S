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

    public string PlayerName;
    public bool faceRight;
    private bool blockState = false;
    private bool jumpState = false;
    private bool crouchState = false;

    public float MoveSpeed;
    private float horizantalMove=0f;

    public bool isGrounded;
    private bool inHitStun;
    private bool inBlockStun;
    private bool inRecovery;

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
            PlayerName = "P1Char";
            
        }
        else
        {
            target = GameObject.Find("P1Char").transform;
            PlayerName = "P2Char";
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

    void FixedUpdate()
    {
        //MOVE
        GetMoveValue();
        mControl.Move(horizantalMove * Time.fixedDeltaTime, crouchState, jumpState); //move character

        //FACE OTHER PLAYER
        if (target.position.x > transform.position.x && !faceRight) //if the target is to the right of enemy and the enemy is not facing right
        { Flip(); }
        if (target.position.x < transform.position.x && faceRight)
        { Flip(); }

        //MAKE JUMP FALSE
        jumpState = false;
    }

    void OnMenu()
    {

    }

    void OnSelect()
    {

    }

    //MOVEMENT
    void GetMoveValue()
    {
        if (!crouchState && !animator.GetBool("attackState"))
        {
            var temp = playerInput.currentActionMap.FindAction("Move", false).ReadValue<Vector2>();
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
        
    }
    public void OnMoveLeft()
    {
        
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
        if (!jumpState)
        {
            Debug.Log("CROUCHSTATE CHANGED");
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
            animator.SetTrigger("lightNormal");

    }

    void OnNAttackMedium()
    {
            animator.SetTrigger("mediumNormal");
    }

    void OnNAttackHeavy()
    {
            animator.SetTrigger("heavyNormal");
    }

    void OnSpecialAttack()
    {
            animator.SetTrigger("specialAttack1");
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

}
