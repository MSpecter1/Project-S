using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralFireball : MonoBehaviour
{
    // Start is called before the first frame update

    private bool isUlt;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    public bool getUlt()
    {
        return isUlt;
    }

    public void setUlt(bool bl)
    {
        isUlt = bl;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (isUlt)
        {
            StartCoroutine(MeatyFireball());
        }
        else
        {
            Destroy(gameObject);
        }
    }
    IEnumerator MeatyFireball()
    {
        SpriteRenderer SpriteRenderer;
        for (int i = 0; i <100; i++)
        {
            yield return null;
        }
        Destroy(gameObject);
    }
}
