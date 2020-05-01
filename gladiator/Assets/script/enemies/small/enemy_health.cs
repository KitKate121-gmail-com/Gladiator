using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class enemy_health : MonoBehaviour
{
    public int maxhealth;
    public int  health;
    public int playerdamage=5; 
     enemy_ai enemyattack;
     fighting enemydamge;
     Stats playerstat;
     Movement playerimpulse;
    public AudioClip[] enemyaudio;
    AudioSource enemyaudiosource;
    public particlemanager particle;
    int i;
    public GameObject player;
   Animator playeranimation;
    Animator enemyanimations;
    // Start is called before the first frame update
    void Start()
    {
        health=maxhealth;
        enemyaudiosource=gameObject.GetComponent<AudioSource>();
        enemyanimations=gameObject.GetComponent<Animator>();
        enemyattack=gameObject.GetComponent<enemy_ai>();
        playerimpulse=player.GetComponent<Movement>();
        enemydamge=player.GetComponent<fighting>();
        playerstat=player.GetComponent<Stats>();
        playeranimation=player.GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
     
        enemyanimations.SetInteger("attack_num",enemydamge.enemydefense);
        if(health<=0)
        {
            playerdamage=enemydamge.damage;
            Destroy(gameObject,10f);
             
               enemyattack.enemy.SetBool("on_death",true);
               
               Destroy(GetComponent<CapsuleCollider2D>());
                particle.i=3;
                    particle. paritclecaller();
               
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        
           if(collision.gameObject.name=="shadow")
           {
              if(Input.GetKeyDown("[4]"))
              {

              }else{
                  if(playeranimation.GetCurrentAnimatorStateInfo(0).IsTag("1"))
                  {
                       if(enemyattack.enemy.GetCurrentAnimatorStateInfo(0).IsTag("0"))
                    { particle.paritclecaller();
                         i=0;
                     sound();
                     health-=playerdamage;
                         particle.i=1;
                    }
               
                  }    else if(playeranimation.GetCurrentAnimatorStateInfo(0).IsName("Defence_punch"))
                    { player.GetComponent<particlemanager>().i=2;
                                player.GetComponent<particlemanager>().paritclecaller();
                            i=1;    
                        sound();
                    }else if(enemyattack.dist<=enemyattack.stop)
                        {
                                playerstat.health-=playerdamage;
                                player.GetComponent<particlemanager>().i=1;
                                player.GetComponent<particlemanager>().paritclecaller();
                                   i=2;    
                                sound();
                        }
                         
              }
              
              
                   
               
           }
        
    }
   public void sound()
    {
         
        enemyaudiosource.clip=enemyaudio[i];
        enemyaudiosource.Play();
    }
}
