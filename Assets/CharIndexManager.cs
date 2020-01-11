using UnityEngine;
using System;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;

// Initializes the list of P1/P2 character prefabs

public class CharIndexManager : MonoBehaviour
{
    public int P1CIndex;
    public int P2Cindex;
    public bool selected;

    public List<GameObject> P1CharList = new List<GameObject>();
    public List<GameObject> P2CharList = new List<GameObject>();

    void Awake()
    {
        P2CharList = P1CharList;
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
