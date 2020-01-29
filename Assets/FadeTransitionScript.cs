using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeTransitionScript : MonoBehaviour
{
    public Animator fadeanimator;
    public GameObject fade;

    // Start is called before the first frame update
    void Start()
    {
        fade.SetActive(true);
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
