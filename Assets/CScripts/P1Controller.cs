using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;

public class P1Controller : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    private float moveInput;
    private Rigidbody2D rb;
    private bool facingRight=false;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
        if (facingRight==false&&moveInput>0)
        {
            flip();
        }
        else if (facingRight==true&&moveInput>0)
        {
            flip();
        }

        
        if (Input.GetKeyDown("space"))
        {
            rb.velocity = new Vector2(jumpForce, rb.velocity.x);
        }
        


    }

    void flip()
    {
        facingRight = !facingRight;
        Vector3 scalar = transform.localScale;
        scalar.x*= -1;
        transform.localScale=scalar;
    }


}