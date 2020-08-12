using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharFunctions : MonoBehaviour
{
    public Animator animator;
    public CharInputEngine CharInputEngine;
    public CharHPManager hpmanager;
    public CharEXManager exmanager;
    public bool ProjectileActive = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void NAttackLight()
    {
        animator.SetTrigger("lightNormal");
    }

    public virtual void NAttackMedium()
    {
        animator.SetTrigger("mediumNormal");
    }

    public virtual void NAttackHeavy()
    {
        animator.SetTrigger("heavyNormal");
    }

    public virtual void SpecialAttack1(int variant)
    {
        animator.SetTrigger("specialAttack1");
    }

    public virtual void SpecialAttack2(int variant)
    {
        animator.SetTrigger("specialAttack2");
    }

    public virtual void SpecialAttack3(int variant)
    {
        animator.SetTrigger("specialAttack3");
    }

    public virtual void LaunchProjectile(int val)
    {
        Debug.Log(gameObject.name +" called \"Launch Projectile\" without having a projectile attack");
    }
}
