using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Special Attacks for MTSebby

public class MTSebbyFunctions : MonoBehaviour
{
    public CharInputEngine CharInputEngine;
    public CharHPManager hpmanager;

    public Animator animator;

    public GameObject FireballStartLoc;
    public GameObject HadoukenFire;

    // Start is called before the first frame update
    void Start()
    {
        //SET UNIQUE HP
        hpmanager.setHP(10000);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Hurtbox")) //IF HITTING ENEMY HURTBOX
        {
            Debug.Log("normal attack landed a hit");
        }
    }

    public void LaunchHadouken() //SPECIAL ATTACK 1
    {
        GameObject b = Instantiate(HadoukenFire) as GameObject;
        b.transform.position = FireballStartLoc.transform.position;
        if (CharInputEngine.faceRight) //CHECK FLIP
        {
            b.GetComponent<Rigidbody2D>().velocity = transform.right * 20;
        }
        else
        {
            Vector3 theScale = b.transform.localScale;
            theScale.x *= -1;
            b.transform.localScale = theScale; //flip sprite

            b.GetComponent<Rigidbody2D>().velocity = -transform.right * 20;
        }

    }
}
