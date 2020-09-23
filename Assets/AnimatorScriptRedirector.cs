using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorScriptRedirector : MonoBehaviour
{
    public CharFunctions characterFunctions;
    public CharStateManager charStateManager;
    public HitboxManager hitboxmanager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void callCharStateManager(CharStateManager.CharState newState)
    {
        charStateManager.setState(newState);
    }

    public void callHitBoxManager(HitboxManager.hitBoxes val)
    {
        hitboxmanager.setHitBox(val);
    }

    public void CallLaunchProjectile(int val)
    {
        characterFunctions.LaunchProjectile(val);
    }

    public void CallSpecialAttack1()
    {
        characterFunctions.SpecialAttack1(1);
    }
    public void CallSpecialAttack2()
    {
        characterFunctions.SpecialAttack2(1);
    }
    public void CallSpecialAttack3()
    {
        characterFunctions.SpecialAttack3(1);
    }
}
