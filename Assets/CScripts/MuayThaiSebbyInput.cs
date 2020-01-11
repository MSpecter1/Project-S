using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//OUTDATED, REPLACED BY UNITY INPUT SYSTEM

public class MuayThaiSebbyInput : MonoBehaviour
{
    public MuayThaiSebbyController controller;
    public Animator animator;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("LightNormalAttack"))
        {
            controller.punch();
        }

        if (Input.GetButtonDown("MediumNormalAttack"))
        {
            controller.kick();
        }
        if (Input.GetButtonDown("HeavyNormalAttack"))
        {
            controller.hadouken();
        }

    }

    void FixedUpdate()
    {
        
    }
}
