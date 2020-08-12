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

    // We say box, but we're still using polygons.
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

    void Start()
    {
        currentHitbox.isTrigger = true; // Set as a trigger so it doesn't collide with our environment
        //currentHitbox.enabled = false;
    }

    public void setHitBox(hitBoxes val)
    {
        if (val != hitBoxes.clear)
        {
            currentHitbox = Hitboxes[(int)val];
            currentHitbox.enabled = true;
            //currentHitbox.gameObject.SetActive(true);
            return;
        }
        currentHitbox.enabled = false;
        //currentHitbox.gameObject.SetActive(false);
    }
}
