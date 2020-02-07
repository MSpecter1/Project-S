
using UnityEngine;
using UnityEngine.Events;

public class MoveController : MonoBehaviour
{
    [SerializeField] private Collider2D StandingPushBox;
    [SerializeField] private Collider2D m_CrouchDisableCollider;

    [SerializeField] private float m_JumpForce = 400f;  // Amount of force added when the player jumps.
    public float jumpVelocityX = 10f;
    public float jumpVelocityY = 35f;
    

    [Range(0, 1)] [SerializeField] private float m_CrouchSpeed = .36f;          // Amount of maxSpeed applied to crouching movement. 1 = 100%
    [Range(0, .3f)] [SerializeField] private float m_MovementSmoothing = .05f;  // How much to smooth out the movement
    [SerializeField] private bool m_AirControl = true;                         // Whether or not a player can steer while jumping;

    public LayerMask groundLayer;
    public bool m_Grounded;            // Whether or not the player is grounded.
    
    private Rigidbody2D m_Rigidbody2D;
    public bool m_FacingRight = true;  // For determining which way the player is currently facing.
    private Vector3 m_Velocity = Vector3.zero;

    public Animator animator;
    public float RayDistance; //FOR SETTING HEIGHT FOR CHECKING IF GROUNDED

    [Header("Events")]
    [Space]

    public UnityEvent OnLandEvent;

    [System.Serializable]
    public class BoolEvent : UnityEvent<bool> { }

    public BoolEvent OnCrouchEvent;
    private bool m_wasCrouching = false;

    //////////////////////////////////////////////
    private void Awake()
    {
        m_Rigidbody2D = GetComponent<Rigidbody2D>();

        if (OnLandEvent == null)
            OnLandEvent = new UnityEvent();

        if (OnCrouchEvent == null)
            OnCrouchEvent = new BoolEvent();
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
        
        //ANIAMTOR PARAMETER SET
        animator.SetFloat("YVelocity", m_Rigidbody2D.velocity.y);
        animator.SetFloat("WalkXVelocity", Mathf.Abs(m_Rigidbody2D.velocity.x));

    }

    bool IsGrounded()
    {
        Vector2 position = transform.position;
        Vector2 direction = Vector2.down;
        Vector2 drawtest = new Vector2(0, -1*RayDistance);
        Debug.DrawRay(position, drawtest, Color.green);
      
        RaycastHit2D hit = Physics2D.Raycast(position, direction, RayDistance, groundLayer);
        if (hit.collider != null)
        {
            return true;
        }

        return false;
    }
   
    public void Move(float move, bool crouch, bool jump)
    {
        //only control the player if grounded or airControl is turned on
        if (m_Grounded || m_AirControl)
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
            Vector3 targetVelocity = new Vector2(move * 10f, m_Rigidbody2D.velocity.y);
            // And then smoothing it out and applying it to the character
            m_Rigidbody2D.velocity = Vector3.SmoothDamp(m_Rigidbody2D.velocity, targetVelocity, ref m_Velocity, m_MovementSmoothing);
        }
        // If the player should jump...
        if (m_Grounded && jump)
        {
            
            // Add a vertical force to the player.
            m_Grounded = false;
            //m_Rigidbody2D.AddForce(new Vector2(0f, m_JumpForce));
            m_Rigidbody2D.velocity = new Vector2(move*jumpVelocityX, jumpVelocityY);
        }
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