using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cellDisplay : MonoBehaviour
{
    public characterCell characterCell;

    public SpriteRenderer artwork;
    public SpriteRenderer background;
    
    void Start()
    {
        artwork.sprite = characterCell.artwork;
        background.sprite = characterCell.background;
    }

}
