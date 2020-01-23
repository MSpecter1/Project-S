using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{

    public Transform bar;
    public Vector3 testvector;
    public bool lowHP=false;
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
        testvector = new Vector3(sizeNormalized, 1f, 1f);
        bar.localScale = testvector;
    }

    public void setColor(Color color)
    {
        bar.Find("BarSprite").GetComponent<SpriteRenderer>().color = color;
    }

    public void startFlashing()
    {
        lowHP = true;
        StartCoroutine(FlashHealthBar());
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
    }
}
