using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{

    public Transform bar;
    public Vector3 testvector;
    public bool lowHP=false;
    public bool flashing;
    void Start()
    {
        bar = transform.Find("Bar");
        if (transform.name=="P1HealthBar")
        {
            Vector3 newScale = transform.localScale;
            newScale.x *= -1;
            transform.localScale= newScale;
        }
    }

    void Update()
    {

    }

    public void setSize(float sizeNormalized) //float = {0 -> 1} for % of how much the health bar is filled
    {
        if (sizeNormalized<=0.2)
        {
            lowHP = true;
            startFlashing();
        }
        else
        {
            lowHP = false;
        }
        testvector = new Vector3(sizeNormalized, 1f, 1f);
        bar.localScale = testvector;
    }

    public float getSize()
    {
        return bar.localScale.x;
    }

    public void setColor(Color color)
    {
        bar.Find("BarSprite").GetComponent<SpriteRenderer>().color = color;
    }

    public void setHPBarBool(bool state)
    {
        lowHP = state;
    }
    public void startFlashing()
    {
        if (!flashing)
        {
            flashing = true;
            StartCoroutine(FlashHealthBar());
        }
    }

    IEnumerator FlashHealthBar()
    {
        while (lowHP)
        {
            setColor(Color.red);
            yield return new WaitForSeconds(.2f);
            setColor(Color.white);
            yield return new WaitForSeconds(.2f);
        }
        flashing = false;
    }
}
