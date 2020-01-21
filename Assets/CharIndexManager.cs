using UnityEngine;
using System;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;

// Start is called before the first frame update
// Insert charloader (its own class)
// dont touch char loader or char index manager

public class CharIndexManager : MonoBehaviour
{
    public int P1CIndex;
    public int P2Cindex;

    public List<GameObject> CharList = new List<GameObject>();

    void Awake()
    {
        DontDestroyOnLoad(this);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
