using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuayThaiSebbyController : MonoBehaviour
{
    public Animator animator;
    public GameObject bstart;
    public GameObject HadoukenFire;
    public Character character;
  
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void punch()
    {
        animator.SetTrigger("punch");
    }

    public void kick()
    {
        animator.SetTrigger("kick");
    }

    public void hadouken()
    {
        animator.SetTrigger("hadouken");
    }
    public void launchHadouken()
    {
        GameObject b = Instantiate(HadoukenFire) as GameObject;
        b.transform.position = bstart.transform.position;
        if (character.controller.m_FacingRight) //CHECK FLIP
        {
            b.GetComponent<Rigidbody2D>().velocity = transform.right * 20;
        }
        else
        {
            Vector3 theScale = b.transform.localScale;
            theScale.x *= -1;
            b.transform.localScale = theScale; //flip sprite

            b.GetComponent<Rigidbody2D>().velocity = -transform.right * 20;
        }
        
    }

}
