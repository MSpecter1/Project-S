using System.Collections;
using System.Collections.Generic;

using Cinemachine;
using UnityEngine;

//Loads the character into the stage, when Select == True 

public class CharLoaderScript : MonoBehaviour
{
    public CharIndexManager cmanager;
    public Vector3 p1start = new Vector3(-15,-13,32);
    public Vector3 p2start = new Vector3(15, -13, 32);
    public GameObject P1Char;
    public GameObject P2Char;

    // Start is called before the first frame update\
    void Awake()
    {
        if (cmanager.selected)
        {
            P1Char = Instantiate(cmanager.P1CharList[cmanager.P1CIndex], p1start, Quaternion.identity);
            P2Char = Instantiate(cmanager.P2CharList[cmanager.P2Cindex], p2start, Quaternion.identity);
            P1Char.name = "P1Char";
            P1Char.tag = "P1";
            P2Char.name = "P2Char";
            P2Char.tag = "P2";
            SetFollowCam();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetFollowCam()
    {
        CinemachineTargetGroup targetGroup = GameObject.Find("CamTargetGroup").GetComponent<CinemachineTargetGroup>();

        Cinemachine.CinemachineTargetGroup.Target target1;
        target1.target = P1Char.transform;
        target1.weight = 1;
        target1.radius = 0;

        Cinemachine.CinemachineTargetGroup.Target target2;
        target2.target = P2Char.transform;
        target2.weight = 1;
        target2.radius = 0;

        targetGroup.m_Targets.SetValue(target1, 0);
        targetGroup.m_Targets.SetValue(target2, 1);
        return;

     
    }

}
