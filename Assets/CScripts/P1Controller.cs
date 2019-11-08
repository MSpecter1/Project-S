using UnityEngine;
using System;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;

public class P1Controller : MonoBehaviour
{
    public Animator animator;
    public float speed;

    public float jumpVelocity;
    public float fallMultiplier = 2.5f;
    public float lowJumpMultiplier = 2f;
    private float moveInput;

    private Rigidbody2D rb;

    private bool facingRight=true; //STATE
    private bool isGrounded; //STATE
    private bool jumping;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (isGrounded)
        {
            moveInput = Input.GetAxis("Horizontal");
            rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
            if (facingRight == false && moveInput > 0)
            {
                flip();
            }
            else if (facingRight == true && moveInput < 0)
            {
                flip();
            }
        }
        
    }

    void Update()
    {

        //if (rb.velocity.y==0)
        //{
        //    isGrounded = true;
        //}
        //else
        //{
        //    isGrounded=false;
        //}
        if (rb.velocity.y > 0)
        {
            jumping = true;
        }
        else 
        { 
            jumping = false; 
        }

        animator.SetBool("Jumping", jumping);
        animator.SetBool("Grounded", isGrounded);
        animator.SetFloat("YVelocity", rb.velocity.y);
        if (Input.GetButton("Jump") && isGrounded)
        {
            rb.velocity = Vector2.up * jumpVelocity;
        }

        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }
        else if (rb.velocity.y > 0 && !Input.GetButton("Jump"))
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
        }
    }

    void flip()
    {
        facingRight = !facingRight;
        Vector3 scalar = transform.localScale;
        scalar.x*= -1;
        transform.localScale=scalar;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8 && !isGrounded)
        {
            isGrounded = true;
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8 && isGrounded)
        {
            isGrounded = false;
        }
    }
}