using UnityEngine;
using UnityEngine.Events;

public class MoveController : MonoBehaviour
{
    public CharStateManager CharStateManger;

    [SerializeField] private Collider2D m_CrouchDisableCollider;

    public float jumpVelocityY = 35f;


    [Range(0, 1)] [SerializeField] private float m_CrouchSpeed = .36f;          // Amount of maxSpeed applied to crouching movement. 1 = 100%

    public LayerMask groundLayer;
    public bool m_Grounded;            // Whether or not the player is grounded.

    private Rigidbody2D m_Rigidbody2D;
    public bool m_FacingRight = true;  // For determining which way the player is currently facing.

    public Animator animator;
    public float RayDistance; //FOR SETTING HEIGHT FOR CHECKING IF GROUNDED

    [Header("Events")]
    [Space]

    public UnityEvent OnLandEvent;

    [System.Serializable]
    public class BoolEvent : UnityEvent<bool> { }

    public BoolEvent OnCrouchEvent;
    private bool m_wasCrouching = false;

    public float fallMultiplier = 2.5f;


    private void Awake()
    {
        m_Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        //CHECK IF GROUNDED
        m_Grounded = IsGrounded();
        animator.SetBool("Grounded", m_Grounded);
        if (m_Grounded)
        {
            OnLandEvent.Invoke();
        }

        //BETTER JUMPING
        if (m_Rigidbody2D.velocity.y < 0)
        {
            m_Rigidbody2D.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }

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
        if (m_Grounded)
        {
            // If crouching
            if (crouch)
            {
                if (!m_wasCrouching)
                {
                    m_wasCrouching = true;
                    OnCrouchEvent.Invoke(true);
                }

                // Reduce the speed by the crouchSpeed multiplier
                move *= m_CrouchSpeed;

                // Disable one of the colliders when crouching
                if (m_CrouchDisableCollider != null)
                    m_CrouchDisableCollider.enabled = false;
            }
            else
            {
                // Enable the collider when not crouching
                if (m_CrouchDisableCollider != null)
                    m_CrouchDisableCollider.enabled = true;

                if (m_wasCrouching)
                {
                    m_wasCrouching = false;
                    OnCrouchEvent.Invoke(false);
                }
            }

            // Move the character by finding the target velocity
            var targetVelocity = new Vector2();
            if (forwards)
            {
                targetVelocity = new Vector2(move * 10f, m_Rigidbody2D.velocity.y);
            }
            else
            {
                targetVelocity = new Vector2(move * 0.7f * 10f, m_Rigidbody2D.velocity.y);
            }

            // And then smoothing it out and applying it to the character
            m_Rigidbody2D.velocity = targetVelocity;
        }
        // If the player should jump...
        if (m_Grounded && jump)
        {

            // Add a vertical force to the player.
            m_Grounded = false;
            //m_Rigidbody2D.AddForce(new Vector2(0f, m_JumpForce));
            m_Rigidbody2D.velocity = new Vector2(move , jumpVelocityY);
        }
    }

    public void forceMove(bool forwards, float movespeed)
    {
        float pushdirection = 0 ;

        if (CharStateManger.FacingRight)
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
        else if (!CharStateManger.FacingRight)
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

        Vector2 forcedVector = new Vector2(pushdirection * movespeed, m_Rigidbody2D.velocity.y) ; //m_Rigidbody2D.velocity.y
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