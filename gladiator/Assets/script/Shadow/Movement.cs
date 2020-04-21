using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    int Jumpcount=0;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 Move=new Vector2(1f,0f);
        if(Input.GetKey("d"))
        {
            rb.AddForce(Move*speed);
        }
         else if(Input.GetKey("a"))
        {
            rb.AddForce(Move*-speed);
        }
        else
        {
            rb.AddForce(Move*0f);
        }
        if(Input.GetKey("w"))
        {
            if(Jumpcount=0)
            {
                Vector2 jump=new Vector2(0f,2f);
                rb.AddForce(jump*-10f);

            }
            else
            {
                 Vector2 jump=new Vector2(0f,2f);
                rb.AddForce(jump*0f);
            }
        }
        
    }
}
