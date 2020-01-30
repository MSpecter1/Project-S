using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharEXManager : MonoBehaviour
{
    private Rigidbody2D m_Rigidbody2D;
    public CharInputEngine CharInputEngine;

    //HP MANAGERMENT VARIABLES
    public int CharEX = 0;
    public int CharMaxEX = 500;

    public bool PoweredState = false;
    public HealthBar EXbar;
    SpriteRenderer SpriteRenderer;

    public float floatEX;

    void Start()
    {
        //LOAD COMPONANTS ONTO VARIABLES
        m_Rigidbody2D = GetComponent<Rigidbody2D>();
        if (transform.name == "P1Char")
        {
            EXbar = GameObject.Find("P1EXBar").GetComponent<HealthBar>();
        }
        else if (transform.name == "P2Char")
        {
            EXbar = GameObject.Find("P2EXBar").GetComponent<HealthBar>();
        }
        //EXbar.setSize(CharEX/CharMaxEX);
        CharEX = CharMaxEX;
        EXbar.setSize(CharMaxEX/CharMaxEX);

    }

    void Update()
    {
        
    }

    public bool UseEX(int EXAmount)
    {
        if (EXAmount>=CharEX && CharEX!=0) //if there is enough EX and it is not 0
        {
            CharEX -= EXAmount;
            return true;
        }
        return false;
    }

    public void GainEX(int EXAmount) //if not already at max ex
    { 
        if (CharEX!=CharMaxEX)
        {
            CharEX += EXAmount;
        }
    }

    //IEnumerator EXChange(int ChangeAmount)
    //{
    //    floatEX = 
    //    while (EXbar.getSize()!=)
    //    {
            
    //        yield return null;
    //    }
    //}
}
