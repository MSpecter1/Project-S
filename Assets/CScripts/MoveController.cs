using UnityEngine;
using System.Collections;
using UnityEngine.Events;
using System;

public class MoveController : MonoBehaviour
{
    public CharStateManager charStateManager;

    public LayerMask groundLayer;
    public bool m_Grounded;            // Whether or not the player is grounded.

    private Rigidbody2D m_Rigidbody2D;
    public bool m_FacingRight = true;  // For determining which way the player is currently facing.

    public Animator animator;
    public float RayDistance; //FOR SETTING HEIGHT FOR CHECKING IF GROUNDED

    public float fallMultiplier = 2.5f;

    public bool gravity = true;
    public float gravitySpeed = 50f;
    public float jumpVelocityY = 60f;
    public float jumpMaxHeight = 10f;

    public bool isDashing = false;
    public float dashSpeed = 5000;
    public float dashTimeFrames = 10f;
    public float dashDistance;

    public AfterImageGhostController ghostcontroller;


    private void Awake()
    {
        m_Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        //CHECK IF GROUNDED
        m_Grounded = IsGrounded();
        animator.SetBool("Grounded", m_Grounded);

        //IF GROUNDED IS FALSE
        Vector2 currentV = m_Rigidbody2D.velocity;
        if (!m_Grounded && gravity)
        {
            // m_Rigidbody2D.velocity = new Vector2(currentV.x, -gravitySpeed);
            m_Rigidbody2D.velocity += Vector2.up * -gravitySpeed * Time.deltaTime;
        }

        //BETTER JUMPING
        //if (m_Rigidbody2D.velocity.y < 0)
        //{
        //    m_Rigidbody2D.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        //}

        //ANIMATOR PARAMETER SET
        animator.SetFloat("YVelocity", m_Rigidbody2D.velocity.y);
        animator.SetFloat("WalkXVelocity", Mathf.Abs(m_Rigidbody2D.velocity.x));

    }

    bool IsGrounded()
    {
        Vector2 position = transform.position;
        Vector2 direction = Vector2.down;
        Vector2 drawtest = new Vector2(0, -1 * RayDistance);
        Debug.DrawRay(position, drawtest, Color.green);

        RaycastHit2D hit = Physics2D.Raycast(position, direction, RayDistance, groundLayer);
        if (hit.collider != null)
        {
            return true;
        }
        return false;
    }

    public void Move(float move, bool crouch, bool jump, bool forwards)
    {

        //only control the player if grounded or airControl is turned on
        if (m_Grounded && !isDashing)
        {
            var targetVelocity = new Vector2();
            switch (forwards)
            {
                case true when jump == false:
                    targetVelocity = new Vector2(move, m_Rigidbody2D.velocity.y);
                    m_Rigidbody2D.velocity = targetVelocity;
                    //Debug.Log("SWITCH FORWARD" + move); 
                    break;

                case true when jump == true: //forward jump
                    m_Grounded = false;
                    StartCoroutine(JumpAirTime());
                    targetVelocity = new Vector2(move, jumpVelocityY);
                    m_Rigidbody2D.velocity = targetVelocity;
                    //Debug.Log("SWITCH FORWARD JUMP" + move); 
                    break;

                case false when jump == false:
                    targetVelocity = new Vector2(move * 0.7f, m_Rigidbody2D.velocity.y); //reduced movement for going backwards
                    m_Rigidbody2D.velocity = targetVelocity;
                    //Debug.Log("SWITCH BACKWARDS" + move); 
                    break;

                case false when jump == true:
                    m_Grounded = false;
                    StartCoroutine(JumpAirTime());
                    targetVelocity = new Vector2(move, jumpVelocityY);
                    m_Rigidbody2D.velocity = targetVelocity;
                    //Debug.Log("SWITCH BACKWARDS JUMP" + move); 
                    break;

                default:
                    Debug.Log("SWITCH DEFAULT ERROR PLEASE CHECK MOVE CONTROLLER"); break;
            }
        }
    }

    IEnumerator JumpAirTime() //Entire jump sequence = 40 frames = 40/60 seconds
    {
        //gravity = false;
        for (float i = 0f; i <= 40f / 60f; i += 1 / 60f)
        {

        }
        yield return new WaitForSeconds(0.4f);
        //gravity = true;
    }

    public void Dash(float pushdirection, float dashspeed)
    {
       if (m_Grounded)
        {
            isDashing = true;
            ghostcontroller.enableAfterimage(true);
            StartCoroutine(DashTimer(pushdirection, dashTimeFrames, dashSpeed));
        }
    }

    IEnumerator DashTimer(float pushdirection, float frames, float speed)
    {
        m_Rigidbody2D.velocity = new Vector2(pushdirection * speed, 0);
        yield return new WaitForSeconds(frames/60);
        isDashing = false;
        ghostcontroller.enableAfterimage(false);
    }

    public void forceMove(bool forwards, float movespeed) // add enum for different directions north souwest etc
    {
        float pushdirection = 0;

        if (charStateManager.FacingRight)
        {
            if (forwards)
            {
                pushdirection = 1;
            }
            else
            {
                pushdirection = -1;
            }
        }
        else if (!charStateManager.FacingRight)
        {
            if (forwards)
            {
                pushdirection = -1;
            }
            else
            {
                pushdirection = 1;
            }
        }

        //m_Rigidbody2D.velocity = new Vector2(pushdirection * movespeed, m_Rigidbody2D.velocity.y);
        Vector2 forcedVector = new Vector2(pushdirection * movespeed * Time.deltaTime, m_Rigidbody2D.velocity.y); //m_Rigidbody2D.velocity.y
        m_Rigidbody2D.velocity = forcedVector;
    }


    private void Flip()
    {
        // Switch the way the player is labelled as facing.
        m_FacingRight = !m_FacingRight;

        // Multiply the player's x local scale by -1.
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}



//    private void Awake()
//    {
//        m_Rigidbody2D = GetComponent<Rigidbody2D>();
//    }

//    private void FixedUpdate()
//    {
//        //CHECK IF GROUNDED
//        m_Grounded = IsGrounded();
//        animator.SetBool("Grounded", m_Grounded);
//        if (m_Grounded)
//        {
//            OnLandEvent.Invoke();
//        }

//        //BETTER JUMPING
//        if (m_Rigidbody2D.velocity.y < 0)
//        {
//            m_Rigidbody2D.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
//        }

//        //ANIMATOR PARAMETER SET
//        animator.SetFloat("YVelocity", m_Rigidbody2D.velocity.y);
//        animator.SetFloat("WalkXVelocity", Mathf.Abs(m_Rigidbody2D.velocity.x));

//    }

//    bool IsGrounded()
//    {
//        Vector2 position = transform.position;
//        Vector2 direction = Vector2.down;
//        Vector2 drawtest = new Vector2(0, -1 * RayDistance);
//        Debug.DrawRay(position, drawtest, Color.green);

//        RaycastHit2D hit = Physics2D.Raycast(position, direction, RayDistance, groundLayer);
//        if (hit.collider != null)
//        {
//            return true;
//        }
//        return false;
//    }

//    public void Move(float move, bool crouch, bool jump, bool forwards)
//    {
//        //only control the player if grounded or airControl is turned on
//        if (m_Grounded)
//        {
//            // If crouching
//            if (crouch)
//            {
//                if (!m_wasCrouching)
//                {
//                    m_wasCrouching = true;
//                    OnCrouchEvent.Invoke(true);
//                }

//                // Reduce the speed by the crouchSpeed multiplier
//                move *= m_CrouchSpeed;

//                // Disable one of the colliders when crouching
//                if (m_CrouchDisableCollider != null)
//                    m_CrouchDisableCollider.enabled = false;
//            }
//            else
//            {
//                // Enable the collider when not crouching
//                if (m_CrouchDisableCollider != null)
//                    m_CrouchDisableCollider.enabled = true;

//                if (m_wasCrouching)
//                {
//                    m_wasCrouching = false;
//                    OnCrouchEvent.Invoke(false);
//                }
//            }

//            // Move the character by finding the target velocity
//            var targetVelocity = new Vector2();
//            if (forwards)
//            {
//                targetVelocity = new Vector2(move * 10f, m_Rigidbody2D.velocity.y);
//            }
//            else
//            {
//                targetVelocity = new Vector2(move * 0.7f * 10f, m_Rigidbody2D.velocity.y);
//            }

//            // And then smoothing it out and applying it to the character
//            m_Rigidbody2D.velocity = targetVelocity;
//        }
//        // If the player should jump...
//        if (m_Grounded && jump)
//        {

//            // Add a vertical force to the player.
//            m_Grounded = false;
//            //m_Rigidbody2D.AddForce(new Vector2(0f, m_JumpForce));
//            m_Rigidbody2D.velocity = new Vector2(move , jumpVelocityY);
//        }
//    }

//    public void forceMove(bool forwards, float movespeed)
//    {
//        float pushdirection = 0 ;

//        if (CharStateManger.FacingRight)
//        {
//            if (forwards)
//            {
//                pushdirection = 1;
//            }
//            else
//            {
//                pushdirection = -1;
//            }
//        }
//        else if (!CharStateManger.FacingRight)
//        {
//            if (forwards)
//            {
//                pushdirection = -1;
//            }
//            else
//            {
//                pushdirection = 1;
//            }
//        }

//        Vector2 forcedVector = new Vector2(pushdirection * movespeed, m_Rigidbody2D.velocity.y) ; //m_Rigidbody2D.velocity.y
//        m_Rigidbody2D.velocity = forcedVector;
//    }


//    private void Flip()
//    {
//        // Switch the way the player is labelled as facing.
//        m_FacingRight = !m_FacingRight;

//        // Multiply the player's x local scale by -1.
//        Vector3 theScale = transform.localScale;
//        theScale.x *= -1;
//        transform.localScale = theScale;
//    }
//}