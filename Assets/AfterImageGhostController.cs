using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AfterImageGhostController : MonoBehaviour
{
    public float ghostDelay = 0.1f;
    public float ghostfadetime = 1f;
    private float ghostDelaySeconds;
    public GameObject ghost;
    public bool afterimageEnabled = false;
    private Vector3 flipscale;

    // Start is called before the first frame update
    void Start()
    {
        flipscale = transform.localScale;
        flipscale.x *= -1;
        ghostDelaySeconds = ghostDelay;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (afterimageEnabled)
        {
            if (ghostDelaySeconds > 0)
            {
                ghostDelaySeconds -= Time.deltaTime;
            }
            else
            {
                //generate a afteriamge
                GameObject currentghost = Instantiate(ghost, transform.position, transform.rotation);
                Sprite currentSprite = GetComponent<SpriteRenderer>().sprite;
                if (this.transform.parent.localScale.x<1)
                {
                    currentghost.transform.localScale = flipscale;
                }
                currentghost.GetComponent<SpriteRenderer>().sprite = currentSprite;
                ghostDelaySeconds = ghostDelay;
                Destroy(currentghost, ghostfadetime);
            }
        }
    }

    public void enableAfterimage(bool enable)
    {
        if (enable)
        {
            afterimageEnabled = true;
        }
        else
        {
            afterimageEnabled = false;
        }
    }

}
