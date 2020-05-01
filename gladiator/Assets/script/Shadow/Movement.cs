using System.Collections;
 using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    int Jumpcount=0;
    float normalspeed;
    public Animator player;
    public Audio_Player plclip;
    public GameObject moving_sound;
    GameObject cam;
    Vector3 offset;
    Transform campos;
    Stats stat;
    particlemanager particlescript;
    
  // Start is called before the first frame update
    void Start()
    {
       plclip=gameObject.GetComponent<Audio_Player>();
       cam=GameObject.Find("Camera");
        campos=cam.GetComponent<Transform>();
       offset=campos.position-transform.position;
       stat=gameObject.GetComponent<Stats>();
       
       particlescript=gameObject.GetComponent<particlemanager>();
    }

    // Update is called once per frame
    void Update()
    {
        campos.position=transform.position+offset;

       float horizontalmove=Input.GetAxis("Horizontal");

        player.SetFloat("speed",horizontalmove);
    Vector2 Move=new Vector2(horizontalmove,0f);
        rb.AddForce(Move*speed);
        Vector2 jump=new Vector2(0f,2f);
       if(horizontalmove>0f)
       {
           transform.rotation=Quaternion.Euler(0f,180f,0f);
           moving_sound.SetActive(true);
           rb.constraints=RigidbodyConstraints2D.None;
           rb.constraints=RigidbodyConstraints2D.FreezeRotation;
       }else if(horizontalmove<0f)
       {
           transform.rotation=Quaternion.Euler(0f,0f,0f);
           moving_sound.SetActive(true);
           rb.constraints=RigidbodyConstraints2D.None;
           rb.constraints=RigidbodyConstraints2D.FreezeRotation;
       }
       else if(Input.GetKeyUp("w"))
        {
            plclip.plsource.clip=plclip.placlips[1];
           plclip.plsource.Play();
              player.SetBool("On_ground",true);  
            
          
        }
       else
       {
           rb.constraints=RigidbodyConstraints2D.FreezeAll;
            moving_sound.SetActive(false);
            player.SetBool("On_ground",false);  
             rb.AddForce(jump*0f);  
       }
    
         
        
        if(stat.health!=0&&stat.health<1)
        {
            Destroy(gameObject);
        }
        
        
        
    }
    
}
