using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitboxManager : MonoBehaviour
{
    // Used for organization
    public BoxCollider2D[] Hitboxes;

    // Collider on this game object
    public BoxCollider2D currentHitbox;
    public hitBoxes activeHitBox;
    public int playerNum = 0;

    public enum hitBoxes
    {
        standingLight,
        standingMedium,
        standingHeavy,

        crouchingLight,
        crouchingMedium,
        crouchingHeavy,

        airLight,
        airMedium,
        airHeavy,

        SpecialAttack1,
        SpecialAttack2,
        SpecialAttack3,

        clear // special case to remove all boxes
    }
    private void OnEnable()
    {
        
    }
    void Start()
    {
        currentHitbox.isTrigger = true; // Set as a trigger so it doesn't collide with our environment
        //currentHitbox.enabled = false;
        if (transform.parent.parent.CompareTag("P1"))
        {
            playerNum = 1;
        }
        else if (transform.parent.parent.CompareTag("P2"))
        {
            playerNum = 2;
        }
        else
        {
            Debug.Log(transform.parent.parent + "ERROR PLAYER TAG NOT GIVEN TO HITBOXES");
        }
    }

    public int getPlayerNum()
    {
        return playerNum;
    }

    public void setHitBox(hitBoxes val)
    {
        if (val != hitBoxes.clear)
        {
            currentHitbox = Hitboxes[(int)val];
            currentHitbox.enabled = true;
            currentHitbox.transform.GetComponent<CharAttackHitboxScript>().setAttacking(true);
            //Collider2D[] results = new Collider2D[10];
            //ContactFilter2D contactFilter = new ContactFilter2D();
            //contactFilter.NoFilter();
            //Physics2D.OverlapCollider(currentHitbox,contactFilter, results);
            //int timeshit = 0;
            //foreach (Collider2D t in results)
            //{
            //    if (t != null && t.tag != transform.parent.parent.tag)
            //    { 
            //        if (timeshit<1)
            //        {
            //            if (t.name == "HeadHurtbox")
            //            {
            //                timeshit++;
            //            }
            //            else if (t.name == "StandingHurtbox")
            //            {
            //                timeshit++;
            //            }
            //            Debug.Log(transform.parent.parent + "OVERLAPcollider hit: " + t.tag + "'s " + t);
            //        }
            //    }
            //}

            //currentHitbox.gameObject.SetActive(true);
            return;
        }
        currentHitbox.enabled = false;
        currentHitbox.transform.GetComponent<CharAttackHitboxScript>().setAttacking(false);
        //currentHitbox.gameObject.SetActive(false);
    }
}
