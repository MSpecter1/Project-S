using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharAudioManager : MonoBehaviour
{
    public AudioSource Sound;
    public AudioClip test;

    //LIST OUT SOUNDS IN ORDER
    //Normal Attacks
    private AudioClip AttackLight; 
    private AudioClip AttackMedium;
    private AudioClip AttackHeavy;
    //Specials
    private AudioClip SpecialAttack1; //COMMENT THE ACTUAL NAME OF THE ATTACK HERE: 
    private AudioClip SpecialAttack2;
    private AudioClip SpecialAttack3;
    //EX Specials
    private AudioClip EXSpecialAttack1;
    private AudioClip EXSpecialAttack2;
    private AudioClip EXSpecialAttack3;
    //Guard
    private AudioClip BlockAttack;

    //etc


    void Start()
    {
        AudioSource[] Sound = GetComponents<AudioSource>();
        //// SET SOUND CLIP NAMES (THEY ARE IN INDEX ORDER OF THE COMPONANTS):
        ////Normal Attacks
        //AttackLight = Sound[0].clip;
        //AttackMedium = Sound[1].clip;
        //AttackHeavy = Sound[2].clip;
        ////Specials
        //SpecialAttack1 = Sound[3].clip; //COMMENT THE ACTUAL NAME OF THE ATTACK HERE: 
        //SpecialAttack2 = Sound[4].clip;
        //SpecialAttack3 = Sound[5].clip;
        ////EX Specials
        //EXSpecialAttack1 = Sound[6].clip;
        //EXSpecialAttack2 = Sound[7].clip;
        //EXSpecialAttack3 = Sound[8].clip;
        ////Guard
        //BlockAttack = Sound[9].clip;

        SpecialAttack1 = Sound[0].clip; //TEMP CODE ONLY

}

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaySound(string soundname)
    {
       switch(soundname)
        {
            case "SpecialAttack1":
                Sound.PlayOneShot(SpecialAttack1);
                return;
            case null:
                return;
        }
    }
}
