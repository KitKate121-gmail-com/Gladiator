using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blade_attacks : MonoBehaviour
{
    public Transform playerpos;
    public GameObject player;
    public float attacksindex;
    Animator bladeanimation;
     float timer;
     public float timebtw;
     public GameObject SteelBalls;
     Rigidbody2D rb;
     Vector3 playerdir;
     public float speeddash;
     int attacknumber;
    // Start is called before the first frame update
    void Start()
    {
        bladeanimation=gameObject.GetComponent<Animator>();
        timer=timebtw;
        rb=gameObject.GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Blade_anime();
    }
    public void Blade_anime()
    {
        float  dist=Vector3.Distance(transform.position,playerpos.position);
        if(dist>=attacksindex)
        {
           attacknumber=Random.Range(4,7);
           bladeanimation.SetInteger("attacks",attacknumber);
               if(bladeanimation.GetCurrentAnimatorStateInfo(0).IsName("steel_ball"))
        {
               bladeanimation.SetInteger("attacks",4);
               if(timer>=Time.deltaTime)
               {
                   timer-=Time.deltaTime;
               }else{
                   Vector3 spawnpos=new Vector3(Random.Range(4f,-15f),15f,0f);
                   Instantiate(SteelBalls,spawnpos,Quaternion.identity);

               }
               
         }
           
           if(attacknumber==5)
           {
               bladeanimation.SetInteger("attacks",5);
               playerdir=transform.position-playerpos.position;
               float dir=playerdir.x/playerdir.x*-1f;
               Vector3 dash=new Vector3(dir,0f,0f);
               rb.AddForce(dash*speeddash);
           }
        }else if(dist<attacksindex){
             attacknumber=Random.Range(1,4);
        }
    }
}
