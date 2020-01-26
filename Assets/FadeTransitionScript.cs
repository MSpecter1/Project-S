using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeTransitionScript : MonoBehaviour
{
    public Animator fadeanimator;

    // Start is called before the first frame update
    void Start()
    {
        FadeIn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FadeIn()
    {
        fadeanimator.SetTrigger("FadeIn");
    }
    public void FadeOut()
    {
        fadeanimator.SetTrigger("FadeOut");
    }
}
