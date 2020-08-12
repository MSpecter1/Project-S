using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMoveScript : MonoBehaviour
{
    public float speed;

    Random rdm = new Random();

    // Start is called before the first frame update
    void Start()
    {
        transform.localPosition = new Vector3(Random.Range(-1500, -700), Random.Range(-120f, 250f), 0);
        speed = Random.Range(.5f, 1.25f);

        Vector3 charScale = transform.localScale;
        charScale.x = -1;
        transform.localScale = charScale;
    }
        // Update is called once per frame
        void Update()
    {
        transform.Translate(speed, 0, 0);
        float x = transform.position.x;

        if(x > 1500)
        {
            transform.localPosition = new Vector3(-700, Random.Range(-120f, 250f), 0);
            speed = Random.Range(.5f, 1.25f);
        }
    }
}
