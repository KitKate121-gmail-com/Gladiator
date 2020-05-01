using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_ai : MonoBehaviour
{
    public Transform player;
    public float speed;
    public float stop;
    public Animator enemy;
    float attack_time;
    public float attack_timer;
    public int num;
    public float dist;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        attack_time=0f;
        rb=gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       
         dist=Vector2.Distance(transform.position,player.position);
        if(dist<5f&&dist>stop)
        {
            transform.position=Vector2.MoveTowards(transform.position,player.position,speed);
            enemy.SetBool("on_move",true);
            rb.constraints=RigidbodyConstraints2D.None;
            rb.constraints=RigidbodyConstraints2D.FreezeRotation;
            
        }else if(dist<=stop)
        {
            rb.constraints=RigidbodyConstraints2D.FreezeAll;
            enemy.SetBool("on_move",false);
            if(attack_time>=Time.deltaTime)
            {
                attack_time-=Time.deltaTime;
            }else{
                attack_time+=attack_timer+Time.deltaTime;
                  num=Random.Range(0,4);
            enemy.SetInteger("attack_num",num);
            }
          
        }else{
             rb.constraints=RigidbodyConstraints2D.None;
            rb.constraints=RigidbodyConstraints2D.FreezeRotation;
              enemy.SetBool("on_move",false);
        }
        
    }
}
