using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_flip : MonoBehaviour
{
    public Transform playerpos;
     Vector3 flipdist;
     public float dir;
  public void fliping()
  {
      playerpos=GameObject.Find("shadow").GetComponent<Transform>();
      
      flipdist=transform.position-playerpos.position;

      dir=flipdist.x;
      if(dir<=0f)
      {
        transform.rotation=Quaternion.Euler(0f,180f,0f);
      }
      if(dir>0f)
      {
        transform.rotation=Quaternion.Euler(0f,0f,0f);
      }

  }

    
}
